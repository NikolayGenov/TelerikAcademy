﻿using System;

namespace CohesionAndCoupling
{
    class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("Filename is null");
            }
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("Filename is null");
            }
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }
            string fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            return fileNameWithoutExtension;
        }
    }
}