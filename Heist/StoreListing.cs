﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Heist
{
    class StoreListing
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public BitmapImage Image { get; set; }
        public string Id { get; set; }
    }
}
