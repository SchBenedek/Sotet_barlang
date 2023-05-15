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

namespace Sotet_barlang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Nber anya = new Nber("Anya", 20);
        Nber apa = new Nber("Apa", 25);
        Nber beni = new Nber("Beni", 5);
        Nber anna = new Nber("Anna", 10);

        public MainWindow()
        {
            InitializeComponent();
            balListbox.SelectionMode = SelectionMode.Multiple;
        }
        private void Kezdes_Click(object sender, RoutedEventArgs e)
        {

            balListbox.Items.Clear();
            balListbox.Items.Add(apa);
            balListbox.Items.Add(anya);
            balListbox.Items.Add(beni);
            balListbox.Items.Add(anna);
            
            Timer.Content = 0;
        }

        private void Jobbra_Click(object sender, RoutedEventArgs e)
        {
            if(jobbListbox.Items.Count <=2)
            {
                return null;
            }
            
            List<Nber> n = new List<Nber>();
            n.Add(balListbox.SelectedItems[0] as Nber);
            n.Add(balListbox.SelectedItems[1] as Nber);
            foreach(var item in n)
            {
                balListbox.Items.Remove(item);
            }
            foreach(var item in n)
            {
                jobbListbox.Items.Add(item);
            }
            Timer.Content = n[0].Time + n[1].Time + Convert.ToInt32(Timer.Content);
        }

        private void Balra_Click(object sender, RoutedEventArgs e)
        {
            Nber s = jobbListbox.SelectedItem as Nber;
            jobbListbox.Items.Remove(s);
            balListbox.Items.Add(s);
            Timer.Content = s.Time + Convert.ToInt32(Timer.Content);
        }

        private void Lampa_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
