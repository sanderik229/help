using System.Windows;
using System.Windows.Media;

namespace Pract4WPF
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

        private void change_test_Click(object sender, RoutedEventArgs e)
        {
            TestWindow test_window = new TestWindow();
            
            if (admin_key_textbox.Text == "123")
            {
                
                test_window.test_frame.Content = new NonTestPage();
                test_window.Show();
            }
            else
            {
                MessageBox.Show("Нельзя");
            }
        }

        private void start_test_Click(object sender, RoutedEventArgs e) 
        {
            TestWindow test_window = new TestWindow();
            test_window.change_test_button.IsEnabled = false;
            test_window.test_frame.Content = new NonTestPage();
            test_window.Owner = this;
            this.Visibility = Visibility.Collapsed;
            test_window.Show();
           
        }

      
    }
}