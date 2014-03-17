using MsTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsTestWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var game = new FizzBuzz();

            int number = int.Parse(this.textBox.Text);

            var result = game.PlayRange(number);

            using (StreamWriter stream = new StreamWriter(@"D:\IO\MsTest\test.txt"))
            {
                foreach (var item in result)
                {
                    this.listBox.Items.Add(item);
                    stream.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}
