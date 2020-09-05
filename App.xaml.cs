using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Text;
namespace WpfApp1
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        //定义全局变量
        static public int FirstSELECT1 = -1, SecondSELECT1 = -1, LastSELECT1 = -1, FirstSELECT2 = -1, SecondSELECT2 = -1, LastSELECT2 = -1,
            FirstKey1 = -1, SecondKey1 = -1, LastKey1 = -1, FirstKey2 = -1, SecondKey2 = -1, LastKey2 = -1;
        static public int amount, time1, time2;
        static public string method;
        static public string fi = @".\method.txt";
        static public FileStream FS = new FileStream(fi, FileMode.OpenOrCreate);
        //StreamReader rd = new StreamReader(FS);
        //Game_method game_Method = new Game_method();
        //game_Method.TextBox.Text = rd.ReadLine();
    }
}
