using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mcMath {
    public class mcMathComp {
        public long Add(int val1, int val2, int val3) {
            return val1 + val2 + val3;
        }
        private long bTest;
        public long tra {
            get => bTest;
            set {
                if (value >= 0)bTest = value;
                else bTest = -1;
            }
        }
    }
}