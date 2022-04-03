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
    /// Lógica interna para Adicao.xaml
    /// </summary>
    public partial class Adicao : Window
    {
        public Adicao()
        {
            InitializeComponent();
        }

        private void Bt_somar_Click(object sender, RoutedEventArgs e)
        {
            float numero1 = 0;
            float numero2 = 0;
            float resultado = 0;

            numero1 = float.Parse(txt_n1.Text);
            numero2 = float.Parse(txt_n2.Text);

            resultado = numero1 + numero2;
            txt_resul.Text = resultado.ToString();
        }
    }
}
