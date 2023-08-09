using System;
namespace ConAppDisposableEx 
{
    public class FileHandler : IDisposable
    {
        File fileObj = null;
        static int totalFiles = 0;
        bool disposedValues;

        public FileHandler(string fileName) 
        {
            if (fileObj == null)
            {
                fileObj = new File(fileName);
                totalFiles++;
            }
            Console.WriteLine("File Created!!");
            Console.WriteLine("Number of Files are: "+totalFiles);
        }

        public void GetDetails()
        {
            Console.WriteLine(fileObj.Name + "File Created !!!");
        }

        public virtual void Dispose (bool disposing)
        {
            if (!disposedValues)
            {
                if (disposing)
                {
                    totalFiles = 0;
                }
                Console.WriteLine($"The {fileObj.Name} files has been disposed.");
                fileObj = null;
                disposedValues = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
