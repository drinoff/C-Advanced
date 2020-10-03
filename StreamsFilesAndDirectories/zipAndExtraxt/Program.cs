using System;
using System.IO.Compression;

namespace zipAndExtraxt
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("../../../New Folder","copyMe.zip");
            ZipFile.ExtractToDirectory("copyMe.zip", "../");
        }
    }
}
