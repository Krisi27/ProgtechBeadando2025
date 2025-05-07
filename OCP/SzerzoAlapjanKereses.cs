using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Rendszer_Kezeles.OCP
{
    public class SzerzoAlapjanKereses : IKeresesiStrategia
    {
        public List<IKonyv> Kereses(List<IKonyv> konyvek, string keresesiKriterium)
        {
            return konyvek.Where(k => k.Szerzo.Contains(keresesiKriterium, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
