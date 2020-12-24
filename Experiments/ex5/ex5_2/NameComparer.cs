using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_2 {
    class NameComparer :IComparer<PhoneBook>{
        public int Compare(PhoneBook x,PhoneBook y) {
            return (x.Name.CompareTo(y.Name));
        }
    }
}
