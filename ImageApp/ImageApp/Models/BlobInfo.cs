﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageApp.Models
{
    public class BlobInfo
    {
        public string ImageUri { get; set; }
        public string ThumbnailUri { get; set; }
        public string Caption { get; set; }
    }
}