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


namespace DZ_4
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //-------------------------------------------------------------//
            // 1 //
            int Count;
            int n;
            bool success = Int32.TryParse(tbUser.Text, out n);
            if (success)
            {
            }
            else
            {
                MessageBox.Show("Неправильный ввод размера!");
                return;
            }


            if (int.Parse(tbUser.Text) == 0)
            {
                MessageBox.Show("Введите размер массива!");
                return;
            }
            Count = int.Parse(tbUser.Text);
            Random Random = new Random();
            double[] a = new double[Count];
            tb1.Text = "";
            for (int i = 0; i < Count; i++)
            {
                a[i] = Math.Round((double)Random.Next(-100, 100) / 10f, 1);
                tb1.Text = tb1.Text + a[i] + "  ";
            }
            double min;
            int Index;
            Index = 0;
            min = a[0];
            for (int i = 0; i < Count; i++)
            {

                if (a[i] < min)
                {
                    min = a[i];
                    Index = i;
                }

            }
            tb1MINVALUE.Text = "" + Index;
            tb1MIN.Text = "" + min;


            List<int> Inx = new List<int>();
            for (int i = 0; i < Count; i++)
            {
                if (a[i] < 0)
                {
                    Inx.Add(i);
                }
            }

            int[] InxArr;
            InxArr = Inx.ToArray();

            double S = 0;
            if (InxArr.Length >= 2)
            {
                for (int i = InxArr[0]; i <= InxArr[1]; i++)
                {
                    S = S + Math.Abs(a[i]);
                }
                tb1SUMMA.Text = "" + Math.Round(S, 1);
            }
            else
            {
                tb1SUMMA.Text = "Отрицательных элементов либо нет,либо их меньше двух";
            }
            double[] b = new double[Count];
            b = a.OrderBy(x => Math.Abs(x) >= 1).ToArray();

            tb1Sort.Text = "";
            for (int i = 0; i < Count; i++)
            {
                tb1Sort.Text = tb1Sort.Text + b[i] + "  ";
            }
            //-------------------------------------------------------------//








        }

    }


}

