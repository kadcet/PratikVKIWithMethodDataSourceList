using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikVKIApplication.Business
{
    public class VKIService
    {
        
            private static List<VKI> liste = new List<VKI>();

            public static void SaveVKI(VKI vki)
            {
                liste.Add(vki);
            }

            public static IReadOnlyCollection<VKI> GetVKIList()
            {
                return liste.AsReadOnly();
            }
        
    }
}
