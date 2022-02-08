using CESI_POO_Ex6.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex6.Model.VideoRessource
{
    public class EncodedVideo : IEncoded
    {
        private Dictionary<string, string> values;

        public IDictionary<string, string> GetValues()
        {
            return values;
        }

        public void SetValues(Video video)
        {
            values = new Dictionary<string, string>(
                new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string,string>("Title", video.Title),
                    new KeyValuePair<string,string>("View", video.Views.ToString()),
                    new KeyValuePair<string,string>("Uri", video.Uri)
                });
        }
    }
}
