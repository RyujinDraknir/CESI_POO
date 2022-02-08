using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex6.Model.Core
{
    public interface IEncoder<in T, out U> where U : IEncoded
    {
        public U Encode(T toEncode);
    }
}
