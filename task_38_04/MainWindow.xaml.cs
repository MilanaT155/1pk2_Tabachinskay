using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace task_38_04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Создайте окно для ввода информации о студенте (отдельно фамилия, имя , отчество, группа, пол – перечисление,
    //    дата рождения(календарь))
    //При нажатии на кнопку «сохранить» данные о студенте сохраняются во внутренний список связанный с ListBox
    //При закрытии приложения данные сериализируются в файл
    public partial class MainWindow : Window
    {
        private string Surname;
        private string Name;
        private string Patronomic;
        private string Gender;
        private string Birthday;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = TextBirthday.SelectedDate;

            MessageBox.Show(selectedDate.Value.Date.ToShortDateString());
        }
       

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ListBox listBox = new ListBox();
             Surname = TextSurnname.Text;
             Name = TextName.Text;
             Patronomic = TextPatronomic.Text;
            Gender = TextGender.Text;
            DateTime? selectedDate = TextBirthday.SelectedDate;
            string Info = $"{Surname} {Name} {Patronomic} {Gender} {selectedDate}";
            listBox.Items.Add(Info);
            MessageBox.Show("Информация сохранена");
     
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            string newfile = "fale.json";
            Surname = TextSurnname.Text;
            Name = TextName.Text;
            Patronomic = TextPatronomic.Text;
            Gender = TextGender.Text;
            DateTime? selectedDate = TextBirthday.SelectedDate;
            string Info = $"{Surname} {Name} {Patronomic} {Gender} {selectedDate}";
            string JsonSerializeFile = JsonSerializer.Serialize(Info);
            File.WriteAllText(newfile, JsonSerializeFile);
            MessageBox.Show("Данные сериализованы в файл");
      
        }

    }
}