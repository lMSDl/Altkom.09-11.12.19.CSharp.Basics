using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Altkom._09_11._12._2019.CSharp.Basics.WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var openDialog = new OpenFileDialog
            {
                Filter = "Json files|*.json",
            };
            var result = openDialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                using (var file = new FileStream(openDialog.FileName, FileMode.Open))
                {
                    using (var streamReader = new StreamReader(file))
                        JsonTextBlock.Text = streamReader.ReadToEnd();
                }
            }
        }
    }
}
