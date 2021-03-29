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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Viewmodel viewmodel;
        
        public MainWindow()
        {
            InitializeComponent();
            viewmodel = new Viewmodel(new Model(), this);
            
            
        }

        internal void ChangeButtonconten(string buttonname, string newviewvalue)
        {
            Button currentbutton = (Button)this.FindName(buttonname);
            currentbutton.Content = newviewvalue;
            currentbutton.FontSize = 34;
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //this.button11.Content = "X";
            //this.button11.FontSize = 34;
            viewmodel.Cor(((Button)sender).Name);
        }
    }   
}
