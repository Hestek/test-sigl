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

namespace test_sigl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        nakladak nakladak1;
        public MainWindow()
        {
            
            InitializeComponent();
            nakladak1 = new nakladak();
            Shownakladak(nakladak1, txt1);
            

        }


        public void Shownakladak(nakladak vehicle, TextBox textbox)
        {
            textbox.Text = $"MaxNosnost: {vehicle.nosnost}\n";
            textbox.Text += $"Naklad: {vehicle.naklad}\n";
            textbox.Text += $"Velikost nadrze: {vehicle.velikost_nadrz}\n";
            textbox.Text += $"Stav nadrze: {vehicle.stav_nadrz}\n";
            textbox.Text += $"Tachometr: {vehicle.tachometr}\n";
            textbox.Text += $"spotreba: {vehicle.spotreba}\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nakladak1.Nalozitnaklad();
            Shownakladak(nakladak1 , txt1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            nakladak1.Vylozitnaklad();
            Shownakladak(nakladak1, txt1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            nakladak1.pohyb();
            nakladak1.Spotreba();
            Shownakladak(nakladak1, txt1);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            nakladak1.Natankovat();
            Shownakladak(nakladak1, txt1);
        }
    }
}
