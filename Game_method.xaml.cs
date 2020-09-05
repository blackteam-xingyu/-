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
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
using System.Text;
namespace WpfApp1
{
    /// <summary>
    /// Game_method.xaml 的交互逻辑
    /// </summary>
    public partial class Game_method : Window
    {
        public Game_method()
        {

            InitializeComponent();
            StreamReader rd = null;
            if (App.FS != null)
            {
                rd = new StreamReader(App.FS);
                TextBox.Text = rd.ReadLine();
            }
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (App.FS != null)
            {
                App.FS.Close();
            }
            FileStream FS = new FileStream(App.fi, FileMode.Create);
            StreamWriter wr = null;
            wr = new StreamWriter(FS);
            string Method = TextBox.Text;
            wr.WriteLine(Method);
            wr.Flush();
            App.method = TextBox.Text;
            wr.Close();
            App.FS = null;
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "请选择您的游戏根目录";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBox.Text = fbd.SelectedPath;
            }

        }

    }
}
