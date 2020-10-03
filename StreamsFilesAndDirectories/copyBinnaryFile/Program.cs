using System;
using System.IO;

namespace copyBinnaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = "../../../copyMe.png";
            var outputFile = "../../../copiedFile.png";
            CopyFile(inputFile, outputFile);
            
        }
        public static void CopyFile(string inputpath, string outputPath)
        {
            int bufferSize = 1024*1024;
            using (FileStream stm = new FileStream(outputPath,FileMode.OpenOrCreate,FileAccess.Write))
            {
                FileStream stm2 = new FileStream(inputpath, FileMode.Open);
                stm.SetLength(stm2.Length);
                int bytesRead = -1;
                byte[] bytes = new byte[bufferSize];
                bytesRead = stm2.Read(bytes, 0, bufferSize);

                while (bytesRead>0)
                {
                    stm.Write(bytes, 0, bytesRead);
                    break;
                }
            }
            
        }
    }
}
