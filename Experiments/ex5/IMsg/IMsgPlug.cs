using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMsg {
    public interface IMsgPlug {
        void OnShowDlg();
        string OnShowInfo();
    }
}
