using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03InterfaceApp.InsiteInternational
{
    internal interface ICrudable
    {
        void Create();
        void Read();
        void Update();
        void Delete();

    }
}
