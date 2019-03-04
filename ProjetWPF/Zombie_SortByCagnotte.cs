using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWPF
{
    public class Zombie_SortByCagnotte : IComparer<Zombie>
    {
        public int Compare(Zombie elt1, Zombie elt2)
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
