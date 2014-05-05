using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class A
    {
        private int _a;
        private string _b;

        public A(int a, string b="")
        {
            _a = a;
            _b = b;
        }

        public void ShowMore()
        {
            MessageBox.Show(_b);
        }
    }
}
