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
            // 2 //
            int n;
            Random Random = new Random();
            int Rows, Columns;
            bool success1 = Int32.TryParse(tbRows.Text, out n);
            bool success2 = Int32.TryParse(tbColumns.Text, out n);


            if (success1 && success2)
            {

            }
            else
            {
                MessageBox.Show("Неправильный ввод и строк и столбцов!");
                return;
            }

            if (success1)
            {
            }
            else
            {
                MessageBox.Show("Неправильный ввод строк!");
                return;
            }

            if (success2)
            {
            }
            else
            {
                MessageBox.Show("Неправильный ввод столбцов!");
                return;
            }



            Rows = int.Parse(tbRows.Text);
            Columns = int.Parse(tbColumns.Text);

            if (Rows == 0 || Columns == 0)
            {
                MessageBox.Show("Строки или столбцы равны 0!");
                return;
            }
            int[,] x = new int[Rows, Columns];
            tb2.Text = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    x[i, j] = Random.Next(-100, 100);
                    tb2.Text = tb2.Text + x[i, j] + "   ";
                }
                tb2.Text = tb2.Text + "\n";

            }


            int[] SumOfAbs = new int[Columns];
            for (int j = 0; j < Columns; j++)
            {
                SumOfAbs[j] = 0;
                for (int i = 0; i < Rows; i++)
                {
                    if (x[i, j] < 0 && (x[i, j] % 2 != 0))
                    {
                        SumOfAbs[j] = SumOfAbs[j] + Math.Abs(x[i, j]);
                    }
                }

            }
            tb2Test.Text = "";
            for (int j = 0; j < SumOfAbs.Length; j++)
            {
                tb2Test.Text = tb2Test.Text + SumOfAbs[j] + " ";
            }
            int[] index = new int[Columns];
            for (int j = 0; j < index.Length; j++)
                index[j] = j;


            Array.Sort(SumOfAbs, index);
            tb2Sort.Text = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {

                    tb2Sort.Text = tb2Sort.Text + x[i, index[j]] + "   ";
                }
                tb2Sort.Text = tb2Sort.Text + "\n";

            }




            int SumColumnsIfNegative;
            object[] Sumi = new object[Columns];
            tb2SUM.Text = "";
            for (int j = 0; j < Columns; j++)
            {
                SumColumnsIfNegative = 0;
                for (int i = 0; i < Rows; i++)
                {
                    if (x[i, j] < 0)
                    {
                        for (int k = 0; k < Rows; k++)
                        {
                            SumColumnsIfNegative += Math.Abs(x[k, j]);
                            Sumi[j] = SumColumnsIfNegative;
                        }
                        break;
                    }
                    else
                    {
                        string str = "Отрицательного элемента нет";
                        Sumi[j] = str;
                    }
                }

            }
            for (int j = 0; j < Columns; j++)
            {
                tb2SUM.Text = tb2SUM.Text + Sumi[j] + " ";
            }




        }









        //-------------------------------------------------------------//

    }


}

