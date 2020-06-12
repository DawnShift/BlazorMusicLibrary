using System;
using System.IO;

namespace ShearedModel.Sheared_Classes
{
    public static class ImageHandler
    {
        public static string CreateBase64Images(string filePath)
            => Convert.ToBase64String(File.ReadAllBytes(filePath)); 
    }
}
