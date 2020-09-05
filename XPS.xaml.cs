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
using System.Windows.Xps.Packaging;
using System.IO;
namespace WpfApp1
{
    /// <summary>
    /// XPS.xaml 的交互逻辑
    /// </summary>
    public partial class XPS : Window
    {
        public XPS()
        {
            InitializeComponent();
            LoadXPSFile("./Recouse/使用说明v3.0.xps");
        }

        private void LoadXPSFile(string _xpsfile)

        {

            using (XpsDocument xpsDoc = new XpsDocument(_xpsfile, FileAccess.Read))

            {

                var fs = xpsDoc.GetFixedDocumentSequence();

                this.xpsDoc.Document = fs;

            }
        }
    }
}
