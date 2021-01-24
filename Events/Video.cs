using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class Video
    {
        public string Title { get; private set; }

        public Video(string title)
        {
            Title = title;
        }
    }
}
