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

namespace learn_wpf
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var drive in Directory.GetLogicalDrives())
            {
                TreeViewItem item = new TreeViewItem()
                {
                    Header = drive,
                    Tag = drive
                };

                item.Items.Add(null);

                item.Expanded += Folder_Expanded;
                tvFolder.Items.Add(item);
            }
        }

        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {
            var item = (TreeViewItem)sender;

            if (item.Items.Count != 1 || item.Items[0] != null)
                return;

            item.Items.Clear();

            string fullPath = item.Tag.ToString();

            List<String> subFolder = new List<string>();

            try
            {
                var dir = Directory.GetDirectories(fullPath);
                if (dir.Length > 0)
                    subFolder.AddRange(dir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            subFolder.ForEach(folder =>
            {
                TreeViewItem subItem = new TreeViewItem()
                {
                    Header = getFolderNameFromPath(folder),
                    Tag = folder
                };

                subItem.Expanded += Folder_Expanded;

                subItem.Items.Add(null);
                item.Items.Add(subItem);

            });

        }

        private string getFolderNameFromPath(string path)
        {

            if(string.IsNullOrEmpty(path))
                return string.Empty;
            path = path.Replace('/', '\\');
            int index = path.LastIndexOf("\\");
            if (index < 0)
                return path;
            return path.Substring(index+1);

        }
    }
}
