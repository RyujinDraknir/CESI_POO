using CESI_POO_Ex6.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CESI_POO_Ex6.Model.VideoRessource
{
    public class VideoEncoder : IEncoder<Video, EncodedVideo>
    {
        public EncodedVideo Encode(Video video)
        {
            EncodedVideo encodedVideo = new();

            encodedVideo.SetValues(video);

            return encodedVideo;
        }
    }
}
