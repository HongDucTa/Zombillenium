using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class FantomeSortByCagnotte : IComparer<Fantome>
    {
        public int Compare(Fantome elt1, Fantome elt2)
        {
            if (elt1.ObtenirCagnotte() < elt2.ObtenirCagnotte())
            {
                return -1;
            }
            if (elt1.ObtenirCagnotte() > elt2.ObtenirCagnotte())
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
