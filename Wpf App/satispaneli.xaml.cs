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
using System.Windows.Shapes;
using System.Text.RegularExpressions;


namespace Wpf_App
{
    /// <summary>
    /// satispaneli.xaml etkileşim mantığı
    /// </summary>
    public partial class satispaneli : Window
    {
        public satispaneli()
        {
            InitializeComponent();

            ogrenci.Items.Add("Sivil");
            ogrenci.Items.Add("Öğrenci");

            ay.Items.Add("1");
            ay.Items.Add("2");
            ay.Items.Add("3");
            ay.Items.Add("4");
            ay.Items.Add("5");
            ay.Items.Add("6");
            ay.Items.Add("7");
            ay.Items.Add("8");
            ay.Items.Add("9");
            ay.Items.Add("10");
            ay.Items.Add("11");
            ay.Items.Add("12");

            yıl.Items.Add("19");
            yıl.Items.Add("20");
            yıl.Items.Add("21");
            yıl.Items.Add("22");
            yıl.Items.Add("23");
            yıl.Items.Add("24");
            yıl.Items.Add("25");
            yıl.Items.Add("26");
            yıl.Items.Add("27");
            yıl.Items.Add("28");
            yıl.Items.Add("29");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            if (kredikart.Text == "")
            {
                MessageBox.Show("Kredi Kartı Bilgilerinizi Giriniz");
            }

            if (cvv.Text == "")
            {
                MessageBox.Show("CVV Bilgilerinizi Giriniz");
            }
            if (ogrenci.Text == "")
            {
                MessageBox.Show("Öğrenci/Sivil Olduğunuzu Belirtin");
            }
            if (ay.Text == "")
            {
                MessageBox.Show("Son Kullanma Tarihi Bilgisi Eksiktir");
            }
            if (yıl.Text == "")
            {
                MessageBox.Show("Son Kullanma Tarihi Bilgisi Eksiktir");
            }
            if (ogrenci.Text == "Öğrenci")
            {
                MessageBox.Show("işleminiz Başarılı");
                this.Hide();
            }
            if (ogrenci.Text == "Sivil")
            {
                MessageBox.Show("işleminiz Başarılı");
                this.Hide();
            }

        }

        private void RakamGirisi(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}


  

