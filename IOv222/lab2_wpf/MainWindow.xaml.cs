using System;
using System.Windows;
using System.Windows.Controls;

namespace lab2_wpf
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var game = new FizzBazz();
            //var textBoxTextProperty = sender as TextBox;
            //int zmienna = Convert.ToInt32(textBoxTextProperty.Text);
            ////int podanaLiczba =int.Parse(TextBox.TextProperty.ToString());
            //var wynik = game.Next(zmienna);
            ////game.Next(TextBox.TextProperty);
            //if (wynik != null) Label.ContentProperty(wynik);
        }
    }
}
