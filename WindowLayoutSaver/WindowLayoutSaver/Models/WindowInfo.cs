using System;
using System.Collections.Generic;
using System.Text;

namespace WindowLayoutSaver.Models
{
    public class WindowInfo
    {
        public IntPtr Handle { get; set; }

        public string Title { get; set; } = string.Empty;

        public string ProcessName { get; set; } = string.Empty;
    }
}