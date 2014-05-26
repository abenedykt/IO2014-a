using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFissBass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static object Play(int p)
        {
            switch (p % 15)
            {
                case 0:
                    return "Fiss Bass";
                case 3:
                    return "Fiss";
                case 6:
                    return "Fiss";
                case 5:
                    return "Bass";
                case 10:
                    return "Bass";
                case 9:
                    return "Fiss";
                case 12:
                    return "Fiss";

                default:
                    return p;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                lista.Add(Play(i).ToString());
            }
            listBox1.DataSource = lista;

        }
    }
}
