using FizzBuzz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzzForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddItems();
        }

        private void AddItems()
        {
            var game = new FizzBuzzGame();
            var result = game.Range(10);
        }
    }
}
