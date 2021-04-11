using System;
using System.IO;
using System.Threading.Tasks;

namespace FileCopy
{
    public static class FileCopy
    {
        public static void CopyDirectory(string source, string target, bool recursive = true)
        {
            DirectoryInfo directory = new DirectoryInfo(source);

            if (!directory.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory not found: " + source
                );
            }

            //Get all subdirectories
            DirectoryInfo[] directories = directory.GetDirectories();

            //If the target doesn't exist, create it
            Directory.CreateDirectory(target);


            //Get all the source files and copy them to the target
            FileInfo[] files = directory.GetFiles();
            foreach (var file in files)
            {
                string temp = Path.Combine(target, file.Name);
                CopyFileAsync(file.FullName, temp);
            }

            //if recursive, copy all subdirectories and their files also
            if (recursive)
            {
                foreach (var subdirectory in directories)
                {
                    string temp = Path.Combine(target, subdirectory.Name);
                    CopyDirectory(subdirectory.FullName, temp);
                }
            }
        }

        public static async Task<bool> CopyDirectoryAsync(string source, string target, IProgress<int> progressbar = null, IProgress<string> currentFile = null, bool recursive = true)
        {
            try { 
                DirectoryInfo directory = new DirectoryInfo(source);

                if (!directory.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Source directory not found: " + source
                    );
                }

                //Get all subdirectories
                DirectoryInfo[] directories = directory.GetDirectories();

                //If the target doesn't exist, create it
                Directory.CreateDirectory(target);


                //Get all the source files and copy them to the target
                FileInfo[] files = directory.GetFiles();
                int totalCount = files.Length;

                //Handle /0 case
                if (totalCount == 0) totalCount = 1;

                int processedCount = await Task.Run<int>(() =>
                {
                    int tCount = 0;
                    foreach (var file in files)
                    {
                        string temp = Path.Combine(target, file.Name);

                        CopyFileAsync(file.FullName, temp);
                        if (progressbar != null) progressbar.Report(tCount * 100 / totalCount);
                        if (currentFile != null) currentFile.Report(file.FullName);
                        tCount++;
                    }

                    //if recursive, copy all subdirectories and their files also
                    if (recursive)
                    {
                        foreach (var subdirectory in directories)
                        {
                            string temp = Path.Combine(target, subdirectory.Name);
                            bool t = CopyDirectoryAsync(subdirectory.FullName, temp, progressbar, currentFile).Result;
                        }
                    }
                    return tCount;
                });



                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }


        public static async Task CopyFileAsync(string source, string target)
        {
            using (Stream sourceStream = File.OpenRead(source))
            {
                using (Stream targetStream = File.Create(target))
                {
                    await sourceStream.CopyToAsync(targetStream);
                }
            }
        }
    }
}
