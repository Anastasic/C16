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

namespace _9._06._2021
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            string h = t1.Text;
            string o = "";
            string nov = "";
            if (p1.IsChecked == true)
            {
                po.Text = Slovo.stpow(h);
            }
            else if (p2.IsChecked == true)
            {
                po.Text = Slovo.kol(h, o);
            }
            else if (p3.IsChecked == true)
            {
                po.Text = Slovo.zan(h);
            }
            else if (p4.IsChecked == true)
            {
                po.Text = Slovo.por(h, nov);
            }
            else if (p5.IsChecked == true)
            {
                po.Text = Slovo.sog(h, nov);
            }
        }
    }
    public class Slovo
    {
        public static string stpow(string h)
        {
            foreach (char c in h)
            {
                if (Char.IsWhiteSpace(c) == true)
                {
                    h = h.Trim().Replace("  ", " ");                
                }
            }
            foreach (char c in h)
            {
                if (Char.IsWhiteSpace(c) == true)
                {
                    h  = h.Replace(" ", "");
                }
            }           
            return h ;
        }
        public static string kol(string h, string o)
        {
            int y  = 0;
            foreach (char c in h)
            {
                if (Char.IsWhiteSpace(c) == true)
                {
                    y++;
                }
            }
            o = Convert.ToString(y);
            return o;
        }
        public static string zan(string h)
        {
            h = h.Replace('а', 'о');
            h = h.Replace('a', 'o');
            return h;
        }
        public static string por(string h, string nov)
        {
            string[] gl = { "а", "е", "и", "о", "ё", "у", "я", "э", "ы", "ю", "e", "y", "u", "i", "o", "a" };
            string[] sog = { "б", "в", "г", "д", "ж", "з", "й", "к", "л", "м", "н", "п", "р", "с", "т", "ф", "х", "ц", "ч", "ш", "щ", "q", "w", "r", "t", "p", "s", "d", "f", "g", "h", "j", "l", "z", "c", "v", "b", "n", "m" };
            foreach (char c in h)
            {
                if (Char.IsWhiteSpace(c) == true)
                {
                    h = h.Trim().Replace("  ", " ");
                }
            }
            foreach (char c in h)
            {
                if (Char.IsWhiteSpace(c) == true)
                {
                    h = h.Replace(" ", "");
                }
            }
            for (int ac = 0; ac < h.Length; ac++)
            {
                for (int ad = 0; ad < gl.Length; ad++)
                {
                    if (string.Compare(h[ac].ToString(), gl[ad], true) == 0)
                        nov = nov + h[ac];
                }
            }
            for (int ac = 0; ac < h.Length; ac++)
            {
                for (int af = 0; af < sog.Length; af++)
                {
                    if (string.Compare(h[ac].ToString(), sog[af], true) == 0)
                        nov = nov + h[ac];
                }
            }
            return nov;
        }
        public static string sog(string h, string nov)
        {            
            string[] sog = { "б", "в", "г", "д", "ж", "з", "й", "к", "л", "м", "н", "п", "р", "с", "т", "ф", "х", "ц", "ч", "ш", "щ", "q", "w", "r", "t", "p", "s", "d", "f", "g", "h", "j", "l", "z", "c", "v", "b", "n", "m" };
          
            for (int ac = 0; ac < h.Length; ac++)
            {
                for (int af = 0; af < sog.Length; af++)
                {
                    if (string.Compare(h[ac].ToString(), sog[af], true) == 0)
                        nov = nov + h[ac];
                }
            }
            return nov;
        }
    }
}
