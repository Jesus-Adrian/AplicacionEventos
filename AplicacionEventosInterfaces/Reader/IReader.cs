using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventosInterfaces
{
    interface IReader
    {
        List<string>ReadFile(string _cFilePath);
    }
}
