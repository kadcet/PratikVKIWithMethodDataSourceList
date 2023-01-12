using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikVKIApplication.Business
{
    public class VKI
    {
        public double boy;
        public double kilo;

        public double VKIHesaplama()
        {
            return kilo / (boy * boy);
        }
    }
}
