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
        nakladak nakladak2;
        public MainWindow()
        {
            
            InitializeComponent();
            nakladak1 = new nakladak();
            Shownakladak(nakladak1, txt1);
            nakladak2 = new nakladak();
            Shownakladak(nakladak2, txt2);
            

        }


        public void Shownakladak(nakladak vehicle, TextBox textbox)
        {
            textbox.Text = $"MaxNosnost: {vehicle.nosnost} kg\n";
            textbox.Text += $"Naklad: {vehicle.naklad} kg\n";
            textbox.Text += $"Velikost nadrze: {vehicle.velikost_nadrz} L\n";
            textbox.Text += $"Stav nadrze: {vehicle.stav_nadrz} L\n";
            textbox.Text += $"Tachometr: {vehicle.tachometr} km\n";
            textbox.Text += $"spotreba: {vehicle.spotreba} L/100km\n";
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            nakladak1.Jet50();
            Shownakladak(nakladak1, txt1);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            nakladak1.Jet10();
            Shownakladak(nakladak1, txt1);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            nakladak2.Nalozitnaklad();
            Shownakladak(nakladak2, txt2);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            nakladak2.Vylozitnaklad();
            Shownakladak(nakladak2, txt2);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            nakladak2.Natankovat();
            Shownakladak(nakladak2, txt2);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            nakladak2.pohyb();
            nakladak2.Spotreba();
            Shownakladak(nakladak2, txt2);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            nakladak2.Jet50();
            Shownakladak(nakladak2, txt2);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            nakladak2.Jet10();
            Shownakladak(nakladak2, txt2);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            nakladak1.vylozitvse();
            Shownakladak(nakladak1, txt1);
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            nakladak2.vylozitvse();
            Shownakladak(nakladak2, txt2);
        }
    }
}
