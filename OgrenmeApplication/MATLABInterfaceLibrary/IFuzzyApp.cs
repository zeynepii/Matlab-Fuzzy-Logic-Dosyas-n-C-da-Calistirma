using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATLABInterfaceLibrary
{
    interface IFuzzyApp
    {
        public float FindFuzzySucces(float ilgi, float seviye, float sonuc);
    }
}
