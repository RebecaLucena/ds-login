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

namespace Ex01_Login
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

        private void bt_logar_Click(object sender, RoutedEventArgs e)
        {
                string use = txt_email.Text;
                string senha = txt_senha.Password.ToString();

                if (use == "mat@gmail.com" && senha == "123")
                {
                    Menu ppmenu = new Menu();
                    ppmenu.ShowDialog();
                }

                else MessageBox.Show("SEU E-MAIL OU SENHA ESTA INCORRETO", "Mat.com", MessageBoxButton.OK);
                txt_senha.Clear();
                txt_email.Clear();
           
        }
    }
}
