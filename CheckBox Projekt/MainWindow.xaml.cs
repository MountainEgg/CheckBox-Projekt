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

namespace CheckBox_Projekt
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

        private void cbox_agb_Checked(object sender, RoutedEventArgs e)
        {
                btn_register.IsEnabled = true;
        }

        private void cbox_agb_Unchecked(object sender, RoutedEventArgs e)
        {
            btn_register.IsEnabled = false;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {   
                lbl_reports.Content = "Du hast dich mit dem Benutzername " + txtb_username.Text + " registriert!";       
        }
    }
}
