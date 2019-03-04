using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class LoupGarouSortByIndiceCruaute : IComparer<LoupGarou>
    {
        public int Compare(LoupGarou elt1, LoupGarou elt2)
        {
            if (elt1.ObtenirIndiceCruaute() < elt2.ObtenirIndiceCruaute())
            {
                return -1;
            }
            if (elt1.ObtenirIndiceCruaute() > elt2.ObtenirIndiceCruaute())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
