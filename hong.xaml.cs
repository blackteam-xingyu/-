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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// hong.xaml 的交互逻辑
    /// </summary>
    public partial class hong : Window
    {
        public hong()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //快捷键赋值
            if (App.LastSELECT1 == 0 && App.FirstSELECT1 > 0)
            {
                MessageBox.Show("普通按键不可为空哦~小可爱", "ERROR");

            }
            else if (App.LastSELECT2 == 0 && App.FirstSELECT2 > 0)
            {
                MessageBox.Show("普通按键不可为空哦~小可爱", "ERROR");
            }
            else
            {
                if (App.FirstSELECT1 == 0 && App.SecondSELECT1 > 0)
                {
                    MessageBox.Show("宏1的功能按键1不为空时可不能让功能按键2不为空呢~", "ERROR");
                }
                else if (App.FirstSELECT2 == 0 && App.SecondSELECT2 > 0)
                {
                    MessageBox.Show("宏2的功能按键1不为空时可不能让功能按键2不为空呢~", "ERROR");
                }
                else
                {
                    volution();
                    this.Close();
                }

            }
            //Debug
            System.Diagnostics.Trace.WriteLine("FirstKey1:" + App.FirstKey1);
            System.Diagnostics.Trace.WriteLine("SecondKey1:" + App.SecondKey1);
            System.Diagnostics.Trace.WriteLine("LastKey1:" + App.LastKey1);
            System.Diagnostics.Trace.WriteLine("FirstKey2:" + App.FirstKey2);
            System.Diagnostics.Trace.WriteLine("SecondKey2:" + App.SecondKey2);
            System.Diagnostics.Trace.WriteLine("LastKey2:" + App.LastKey2);

            //声明Key赋值函数
            void volution()
            {
                switch (App.FirstSELECT1)
                {
                    case 0:
                        App.FirstKey1 = -1;
                        break;
                    case 1:
                        App.FirstKey1 = 162;
                        break;
                    case 2:
                        App.FirstKey1 = 160;
                        break;
                    case 3:
                        App.FirstKey1 = 164;
                        break;
                }
                switch (App.SecondSELECT1)
                {
                    case 0:
                        App.SecondKey1 = -1;
                        break;
                    case 1:
                        App.SecondKey1 = 162;
                        break;
                    case 2:
                        App.SecondKey1 = 160;
                        break;
                    case 3:
                        App.SecondKey1 = 164;
                        break;
                }
                switch (App.LastSELECT1)
                {
                    case 0:
                        App.LastKey1 = -1;
                        break;
                    case 1:
                        App.LastKey1 = 49;
                        break;
                    case 2:
                        App.LastKey1 = 50;
                        break;
                    case 3:
                        App.LastKey1 = 51;
                        break;
                    case 4:
                        App.LastKey1 = 52;
                        break;
                    case 5:
                        App.LastKey1 = 53;
                        break;
                    case 6:
                        App.LastKey1 = 54;
                        break;
                    case 7:
                        App.LastKey1 = 55;
                        break;
                    case 8:
                        App.LastKey1 = 56;
                        break;
                    case 9:
                        App.LastKey1 = 57;
                        break;
                    case 10:
                        App.LastKey1 = 48;
                        break;
                    case 11:
                        App.LastKey1 = 65;
                        break;
                    case 12:
                        App.LastKey1 = 66;
                        break;
                    case 13:
                        App.LastKey1 = 67;
                        break;
                    case 14:
                        App.LastKey1 = 68;
                        break;
                    case 15:
                        App.LastKey1 = 69;
                        break;
                    case 16:
                        App.LastKey1 = 70;
                        break;
                    case 17:
                        App.LastKey1 = 71;
                        break;
                    case 18:
                        App.LastKey1 = 72;
                        break;
                    case 19:
                        App.LastKey1 = 73;
                        break;
                    case 20:
                        App.LastKey1 = 74;
                        break;
                    case 21:
                        App.LastKey1 = 75;
                        break;
                    case 22:
                        App.LastKey1 = 76;
                        break;
                    case 23:
                        App.LastKey1 = 77;
                        break;
                    case 24:
                        App.LastKey1 = 78;
                        break;
                    case 25:
                        App.LastKey1 = 79;
                        break;
                    case 26:
                        App.LastKey1 = 80;
                        break;
                    case 27:
                        App.LastKey1 = 81;
                        break;
                    case 28:
                        App.LastKey1 = 82;
                        break;
                    case 29:
                        App.LastKey1 = 83;
                        break;
                    case 30:
                        App.LastKey1 = 84;
                        break;
                    case 31:
                        App.LastKey1 = 85;
                        break;
                    case 32:
                        App.LastKey1 = 86;
                        break;
                    case 33:
                        App.LastKey1 = 87;
                        break;
                    case 34:
                        App.LastKey1 = 88;
                        break;
                    case 35:
                        App.LastKey1 = 89;
                        break;
                    case 36:
                        App.LastKey1 = 90;
                        break;
                    case 37:
                        App.LastKey1 = 189;
                        break;
                    case 38:
                        App.LastKey1 = 187;
                        break;
                    case 40:
                        App.LastKey1 = 188;
                        break;
                    case 41:
                        App.LastKey1 = 190;
                        break;
                    case 42:
                        App.LastKey1 = 191;
                        break;
                    case 43:
                        App.LastKey1 = 186;
                        break;
                    case 44:
                        App.LastKey1 = 222;
                        break;
                    case 45:
                        App.LastKey1 = 220;
                        break;
                    case 46:
                        App.LastKey1 = 219;
                        break;
                    case 47:
                        App.LastKey1 = 221;
                        break;
                }
                switch (App.FirstSELECT2)
                {
                    case 0:
                        App.FirstKey2 = -1;
                        break;
                    case 1:
                        App.FirstKey2 = 162;
                        break;
                    case 2:
                        App.FirstKey2 = 160;
                        break;
                    case 3:
                        App.FirstKey2 = 164;
                        break;
                }
                switch (App.SecondSELECT2)
                {
                    case 0:
                        App.SecondKey2 = -1;
                        break;
                    case 1:
                        App.SecondKey2 = 162;
                        break;
                    case 2:
                        App.SecondKey2 = 160;
                        break;
                    case 3:
                        App.SecondKey2 = 164;
                        break;
                }
                switch (App.LastSELECT2)
                {
                    case 0:
                        App.LastKey2 = -1;
                        break;
                    case 1:
                        App.LastKey2 = 49;
                        break;
                    case 2:
                        App.LastKey2 = 50;
                        break;
                    case 3:
                        App.LastKey2 = 51;
                        break;
                    case 4:
                        App.LastKey2 = 52;
                        break;
                    case 5:
                        App.LastKey2 = 53;
                        break;
                    case 6:
                        App.LastKey2 = 54;
                        break;
                    case 7:
                        App.LastKey2 = 55;
                        break;
                    case 8:
                        App.LastKey2 = 56;
                        break;
                    case 9:
                        App.LastKey2 = 57;
                        break;
                    case 10:
                        App.LastKey2 = 48;
                        break;
                    case 11:
                        App.LastKey2 = 65;
                        break;
                    case 12:
                        App.LastKey2 = 66;
                        break;
                    case 13:
                        App.LastKey2 = 67;
                        break;
                    case 14:
                        App.LastKey2 = 68;
                        break;
                    case 15:
                        App.LastKey2 = 69;
                        break;
                    case 16:
                        App.LastKey2 = 70;
                        break;
                    case 17:
                        App.LastKey2 = 71;
                        break;
                    case 18:
                        App.LastKey2 = 72;
                        break;
                    case 19:
                        App.LastKey2 = 73;
                        break;
                    case 20:
                        App.LastKey2 = 74;
                        break;
                    case 21:
                        App.LastKey2 = 75;
                        break;
                    case 22:
                        App.LastKey2 = 76;
                        break;
                    case 23:
                        App.LastKey2 = 77;
                        break;
                    case 24:
                        App.LastKey2 = 78;
                        break;
                    case 25:
                        App.LastKey2 = 79;
                        break;
                    case 26:
                        App.LastKey2 = 80;
                        break;
                    case 27:
                        App.LastKey2 = 81;
                        break;
                    case 28:
                        App.LastKey2 = 82;
                        break;
                    case 29:
                        App.LastKey2 = 83;
                        break;
                    case 30:
                        App.LastKey2 = 84;
                        break;
                    case 31:
                        App.LastKey2 = 85;
                        break;
                    case 32:
                        App.LastKey2 = 86;
                        break;
                    case 33:
                        App.LastKey2 = 87;
                        break;
                    case 34:
                        App.LastKey2 = 88;
                        break;
                    case 35:
                        App.LastKey2 = 89;
                        break;
                    case 36:
                        App.LastKey2 = 90;
                        break;
                    case 37:
                        App.LastKey2 = 189;
                        break;
                    case 38:
                        App.LastKey2 = 187;
                        break;
                    case 40:
                        App.LastKey2 = 188;
                        break;
                    case 41:
                        App.LastKey2 = 190;
                        break;
                    case 42:
                        App.LastKey2 = 191;
                        break;
                    case 43:
                        App.LastKey2 = 186;
                        break;
                    case 44:
                        App.LastKey2 = 222;
                        break;
                    case 45:
                        App.LastKey2 = 220;
                        break;
                    case 46:
                        App.LastKey2 = 219;
                        break;
                    case 47:
                        App.LastKey2 = 221;
                        break;
                }

            }
        }

        private void Combox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Tag1 = (this.Combox1.SelectedItem as ComboBoxItem).Tag.ToString();
            App.FirstSELECT1 = Convert.ToInt32(Tag1);
        }

        private void Combox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Tag2 = (this.Combox2.SelectedItem as ComboBoxItem).Tag.ToString();
            App.SecondSELECT1 = Convert.ToInt32(Tag2);
        }

        private void Combox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Tag3 = (this.Combox3.SelectedItem as ComboBoxItem).Tag.ToString();
            App.LastSELECT1 = Convert.ToInt32(Tag3);
        }

        private void Combox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Tag4 = (this.Combox4.SelectedItem as ComboBoxItem).Tag.ToString();
            App.FirstSELECT2 = Convert.ToInt32(Tag4);
        }

        private void Combox5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Tag5 = (this.Combox5.SelectedItem as ComboBoxItem).Tag.ToString();
            App.SecondSELECT2 = Convert.ToInt32(Tag5);
        }

        private void Combox6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string Tag6 = (this.Combox6.SelectedItem as ComboBoxItem).Tag.ToString();
            App.LastSELECT2 = Convert.ToInt32(Tag6);
        }
    }
}
