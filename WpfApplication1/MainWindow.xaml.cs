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

namespace WpfApplication1
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

        private void btnAnd_Click(object sender, RoutedEventArgs e)
        {

            bool var1bool = Convert.ToBoolean(txtVar1.Text);
            bool var2bool = Convert.ToBoolean(txtVar2.Text);

            //testa o And conforme foi digitado nas vars
            bool varResult = var1bool && var2bool;

            txbResult.Text = varResult.ToString();
        }

        private void btnNot_Click(object sender, RoutedEventArgs e)
        {

            bool var1bool = Convert.ToBoolean(txtVar1.Text);
            bool var2bool = Convert.ToBoolean(txtVar2.Text);

            //testa o Not conforme foi digitado nas vars
            bool varResult = var1bool || var2bool;

            txbResult.Text = varResult.ToString();
        }

        private void btnOr_Click(object sender, RoutedEventArgs e)
        {

            bool var1bool = Convert.ToBoolean(txtVar1.Text);
            bool var2bool = Convert.ToBoolean(txtVar2.Text);

            //testa o Or conforme foi digitado nas vars
            bool varResult = var1bool || var2bool;

            txbResult.Text = varResult.ToString();
        }

        private void btnXor_Click(object sender, RoutedEventArgs e)
        {

            bool var1bool = Convert.ToBoolean(txtVar1.Text);
            bool var2bool = Convert.ToBoolean(txtVar2.Text);

            //testa o Xor conforme foi digitado nas vars
            bool varResult = var1bool ^ var2bool;

            txbResult.Text = varResult.ToString();
        }
    }
}