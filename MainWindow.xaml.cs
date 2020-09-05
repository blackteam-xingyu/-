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
using System.IO;
using System.Text;
using System.Diagnostics;
using Dm;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        static public Dm.dmsoft dm = new Dm.dmsoft();
        static public int hwnd = dm.FindWindow("", "最终幻想XIV");
        static public int dm_ret = dm.BindWindow(hwnd, "dx2", "windows", "windows", 0);
        static private string TBX1;
        static private string TBX2;
        static private string TBX3;
        //****************************************界面按钮****************************************

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //dm = null;
            MessageBox.Show("程序关闭,插件已卸载");
            Environment.Exit(0);
        }

        //打开设置界面
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            hong Hong = new hong();
            Hong.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            //开始制作
            int.TryParse(TBX1, out App.amount);
            int.TryParse(TBX2, out App.time1);
            int.TryParse(TBX3, out App.time2);
            System.Diagnostics.Trace.WriteLine("准备制作，数据如下：");
            System.Diagnostics.Trace.WriteLine("hwnd:" + hwnd);
            System.Diagnostics.Trace.WriteLine("dm_ret:" + dm_ret);
            System.Diagnostics.Trace.WriteLine("amount:" + App.amount);
            System.Diagnostics.Trace.WriteLine("time1:" + App.time1);
            System.Diagnostics.Trace.WriteLine("time2:" + App.time2);
            System.Diagnostics.Trace.WriteLine("FirstKey1:" + App.FirstKey1);
            System.Diagnostics.Trace.WriteLine("SecondKey1:" + App.SecondKey1);
            System.Diagnostics.Trace.WriteLine("LastKey1:" + App.LastKey1);
            System.Diagnostics.Trace.WriteLine("FirstKey2:" + App.FirstKey2);
            System.Diagnostics.Trace.WriteLine("SecondKey2:" + App.SecondKey2);
            System.Diagnostics.Trace.WriteLine("LastKey2:" + App.LastKey2);

            if (App.amount == 0 && App.time1 == 0 && App.time2 == 0)
            {
                MessageBox.Show("制造次数与宏运行时间都没填呢！！你是笨蛋嘛?");

            }
            else if (App.time1 > 0 || App.time2 > 0)
            {
                if (App.amount == 0)
                {
                    MessageBox.Show("还没有输入制造次数呢~");
                }
                else
                {
                    MessageBox.Show("点击确定脚本将在5秒后开始运行，请完成说明上的准备工作");
                    dm.delay(5000);
                    Autoprocess(App.amount, App.time1, App.time2);
                }
            }

        }
        //****************************************界面按钮****************************************
        //****************************************菜单按钮****************************************
        //打开设置
        private void setting_Click(object sender, RoutedEventArgs e)
        {
            hong Hong = new hong();
            Hong.Show();
        }
        //关闭脚本
        private void stop_Click(object sender, RoutedEventArgs e)
        {
            dm = null;
            MessageBox.Show("程序关闭,插件已卸载");
            Environment.Exit(0);
        }
        //打开游戏
        private void start_game_Click(object sender, RoutedEventArgs e)
        {

            System.Diagnostics.Process.Start(App.method + @"\FFXIVBoot.exe");
        }
        //游戏路径
        private void game_method_Click(object sender, RoutedEventArgs e)
        {
            Game_method game_Method = new Game_method();
            game_Method.Show();
        }
        //开发者手册
        private void developer_message_Click(object sender, RoutedEventArgs e)
        {

            System.Diagnostics.Process.Start(@".\Recouse\开发者声明.png");
            System.Diagnostics.Process.Start(@".\Recouse\开发者日志.txt");
        }
        //使用手册
        private void user_intraction_Click(object sender, RoutedEventArgs e)
        {
            XPS xps = new XPS();
            xps.Show();
        }
        //检测运行环境
        public void check_environment_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.hwnd == 0)
            {
                MessageBox.Show("error：没有获得窗口句柄，点击确定为您修复","ERROR");
            }
            MainWindow.hwnd = dm.FindWindow("", "最终幻想XIV");
            if (MainWindow.hwnd == 0)
            {
                MessageBox.Show("error:游戏窗口句柄获取失败,请检查游戏是否打开，开启后再次点击测试", "ERROR");
            }
            else
            {
                MessageBox.Show("游戏已运行，窗口句柄为:" + hwnd);
            }
            if (dm_ret == 0)
            {
                MessageBox.Show("error：绑定窗口失败，点击确定为您修复", "ERROR");
            }
            MainWindow.dm_ret = dm.BindWindow(hwnd, "dx2", "windows", "windows", 0);
            if (MainWindow.dm_ret == 0)
            {
                int dd = dm.GetLastError();
                MessageBox.Show(dm_ret.ToString());
                if (dm_ret == 0)
                {
                    MessageBox.Show(dd.ToString());
                }
                MessageBox.Show("或许是插件未注册", "ERROR");
            }
            else
            {
                MessageBox.Show("窗口绑定成功");
            }
        }
        //插件注册
        private void register_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@".\Recouse\注册插件.bat");
        }
        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("版本：v3.0.1\n更新时间：2020-09-05\n开发者：晨曦王座—小奶糖呀\nQQ:1169906528");
        }
        //****************************************菜单按钮****************************************
        //****************************************文本赋值****************************************
        public void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TBX1 = this.TestBox1.Text.ToString();
        }

        public void TestBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            TBX2 = this.TestBox2.Text.ToString();
        }

        public void TestBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            TBX3 = this.TestBox3.Text.ToString();
        }
        //****************************************文本赋值****************************************
        //****************************************自动生产****************************************
        private void Autoprocess(int amount, int time1, int time2)
        {
            time1 *= 1000;
            time2 *= 1000;
            for (int i = 0; i < amount; i++)
            {
                dm.KeyPress(96);
                dm.delay(1500);
                dm.KeyPress(96);
                dm.delay(1500);
                if (time1 > 0)
                {
                    hong1();
                    dm.delay(time1 + 1500);
                }
                if (time2 > 0)
                {
                    hong2();
                    dm.delay(time2 + 1500);
                }
                dm.KeyPress(96);
                dm.delay(2200);
            }
            void hong1()
            {
                dm.KeyDown(App.FirstKey1);
                dm.delay(100);
                if (App.SecondSELECT1 > 0)
                {
                    dm.KeyDown(App.SecondKey1);
                    dm.delay(100);
                }
                dm.KeyPress(App.LastKey1);
                dm.delay(100);
                if (App.SecondSELECT1 > 0)
                {
                    dm.KeyUp(App.SecondKey1);
                    dm.delay(100);
                }
                dm.KeyUp(App.FirstKey1);
            }
            void hong2()
            {
                dm.KeyDown(App.FirstKey2);
                dm.delay(100);
                if (App.SecondSELECT2 > 0)
                {
                    dm.KeyDown(App.SecondKey2);
                    dm.delay(100);
                }
                dm.KeyPress(App.LastKey2);
                dm.delay(100);
                if (App.SecondSELECT2 > 0)
                {
                    dm.KeyUp(App.SecondKey2);
                    dm.delay(100);
                }
                dm.KeyUp(App.FirstKey2);
            }
        }
    }
}
