﻿using System;

namespace ABCRetail_Part1.Models
{
    public class FileModel
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public DateTimeOffset? LastModified { get; set; }

        //get display size of file in a readable format 
        public string DisplaySize
        {
            get
            {
                if (Size >= 1024 * 1024)
                    return $"{Size / 1024 / 1024} MB";
                if (Size >= 1024)
                    return $"{Size / 1024} KB";
                return $"{Size} Bytes";
            }
        }
    }
}
