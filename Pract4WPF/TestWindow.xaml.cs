using System.Windows;

namespace Pract4WPF
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Change_test_button_OnClick(object sender, RoutedEventArgs e)
        {
            this.test_frame.Content = new ChangeTestPage();
        }

        private void Start_test_button_OnClick(object sender, RoutedEventArgs e)
        {
            if (SerDeser.Deserialization<TestClass>().Count != 0)
            {
                this.test_frame.Content = new StartTestPage();
            }
        }
    }
}
