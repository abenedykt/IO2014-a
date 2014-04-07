using KwadratProstokatLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KwadratProstokat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //IFigure ifihu = new Kwadrat(Int32.Parse(tbA.Text));

            IFigure ifihu = new Prostokat(Int32.Parse(tbA.Text), Int32.Parse(tbB.Text));

            tbOutput.Text = ifihu.perimeter().ToString();

        }
    }
}
