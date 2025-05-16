using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace task_39_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
 //    Создайте приложение – список покупок. Использовать ListBox. В качестве источника данных использовать не List а 
 //   ObservableCollection
 //    Функции:
 //• Ввод продуктов
 //• Сохранение списка продуктов в текстовый файл
 //• Использовать стандартные диалоговые окна

    public partial class MainWindow : Window
    {
        private ObservableCollection<string> products = new ObservableCollection<string>();
      

        public MainWindow()
        {
            InitializeComponent();
            ProductList.ItemsSource = products;
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            string product = ProductName.Text.Trim();
            if (!string.IsNullOrEmpty(product))
            {
                products.Add(product);
                ProductName.Clear();
            }
            

        }
        private void List_Click (object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                DefaultExt = ".txt",
                Title = "Сохранить в файл",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            };
          
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllLines(saveFileDialog.FileName, products);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Ошибка",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }
        }
    }
}