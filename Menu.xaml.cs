using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ex01_Login
{
    /// <summary>
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Adicao adicaop = new Adicao();
            adicaop.ShowDialog();
        }

        private void Bt_multiplicacao1_Click(object sender, RoutedEventArgs e)
        {
            Multiplicacao multiplicacaop = new Multiplicacao();
            multiplicacaop.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Subtracao subtracaop = new Subtracao();
            subtracaop.ShowDialog();
        }

        private void Bt_divisao_Click(object sender, RoutedEventArgs e)
        {
            Divisao divisaop = new Divisao();
            divisaop.ShowDialog();
        }

        private void Bt_Tela3_Click(object sender, RoutedEventArgs e)
        {
            Tela3 tela3p = new Tela3();
            tela3p.ShowDialog();
        }
    }
}
