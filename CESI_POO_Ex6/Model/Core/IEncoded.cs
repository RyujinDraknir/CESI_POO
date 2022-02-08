using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex6.Model.Core
{
    public interface IEncoded
    {
        IDictionary<string, string> GetValues();
    }
}
