using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Text.RegularExpressions;

namespace Wpf_App
{  

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            filmler.Items.Add("Truman Show");
            filmler.Items.Add("Back to Future");
            filmler.Items.Add("Matrix");
            filmler.Items.Add("İnterstellar");
            filmler.Items.Add("Çığlık 4");
            filmler.Items.Add("İT");
            filmler.Items.Add("Kingsman: Gizli Servis");
            filmler.Items.Add("Ölümcül Labirent");

          
        }

        private async void a1_Click_1(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("A1");
            a1.Background = Brushes.Red;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("A2");
            a2.Background = Brushes.Red;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("A3");
            a3.Background = Brushes.Red;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("A4");
            a4.Background = Brushes.Red;
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("B1");
            b1.Background = Brushes.Red;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("B2");
            b2.Background = Brushes.Red;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("B3");
            b3.Background = Brushes.Red;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("B4");
            b4.Background = Brushes.Red;
        }

        private void c1_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("C1");
            c1.Background = Brushes.Red;
        }

        private void c2_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("C2");
            c2.Background = Brushes.Red;
        }

        private void c3_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("C3");
            c3.Background = Brushes.Red;
        }

        private void c4_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("C4");
            c4.Background = Brushes.Red;
        }

        private void d1_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("D1");
            d1.Background = Brushes.Red;
        }

        private void d2_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("D2");
            d2.Background = Brushes.Red;
        }

        private void d3_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("D3");
            d3.Background = Brushes.Red;
        }

        private void d4_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Add("D4");
            d4.Background = Brushes.Red;
        }

        private void htemizle_Click(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Clear();
            a1.Background = Brushes.LimeGreen;
            a2.Background = Brushes.LimeGreen;
            a3.Background = Brushes.LimeGreen;
            a4.Background = Brushes.LimeGreen;
            b1.Background = Brushes.LimeGreen;
            b2.Background = Brushes.LimeGreen;
            b3.Background = Brushes.LimeGreen;
            b4.Background = Brushes.LimeGreen;
            c1.Background = Brushes.LimeGreen;
            c2.Background = Brushes.LimeGreen;
            c3.Background = Brushes.LimeGreen;
            c4.Background = Brushes.LimeGreen;
            d1.Background = Brushes.LimeGreen;
            d2.Background = Brushes.LimeGreen;
            d3.Background = Brushes.LimeGreen;
            d4.Background = Brushes.LimeGreen;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            secilen_koltuklar.Items.Remove(secilen_koltuklar.SelectedItem);

        }

        private void satin_al_Click(object sender, RoutedEventArgs e)
        {


            if (filmler.Text == "")
            {
                MessageBox.Show("Lütfen Film Seçiniz");
            }

            else if (filmler.Text == "Truman Show")
            {
                satispaneli kt = new satispaneli();
                kt.Show();
            }
            else if (filmler.Text == "Back to Future")
            {
                satispaneli kt = new satispaneli();
                kt.Show();
            }
            else if (filmler.Text == "Matrix")
            {
                satispaneli kt = new satispaneli();
                kt.Show();
            }
            else if (filmler.Text == "İnterstellar")
            {
                satispaneli kt = new satispaneli();
                kt.Show();
            }
            else if (filmler.Text == "Çığlık 4")
            {
                satispaneli kt = new satispaneli();
                kt.Show();
            }
            else if (filmler.Text == "İT")
            {
                satispaneli kt = new satispaneli();
                kt.Show();
            }
            else if (filmler.Text == "Kingsman: Gizli Servis")
            {
                satispaneli kt = new satispaneli();
                kt.Show();
            }
            else if (filmler.Text == "Ölümcül Labirent")
            {
                satispaneli kt = new satispaneli();
                kt.Show();
            }


        }

       
    }

    
}
