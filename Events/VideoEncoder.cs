using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object sender, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video _vid)
        {
            Thread.Sleep(1500);
                        
            OnVideoEncoded(_vid.Title);
        }

        protected virtual void OnVideoEncoded(string title)
        {
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}
