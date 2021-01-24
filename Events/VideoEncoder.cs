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
            Thread.Sleep(2000);
                        
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}
