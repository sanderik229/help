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

namespace Pract4WPF
{
    /// <summary>
    /// Логика взаимодействия для ChangeTestPage.xaml
    /// </summary>
    public partial class ChangeTestPage : Page
    {
        private List<TestClass> Tests = SerDeser.Deserialization<TestClass>();
        public ChangeTestPage()
        {
            InitializeComponent();
            change_test_datagrid.ItemsSource = Tests;
        }
        
        private void Add_string_to_table_button_OnClick(object sender, RoutedEventArgs e)
        {
            TestClass new_test_class = new TestClass("", "", "", "", "", AnswerEnum.First);
            Tests.Add(new_test_class);
            change_test_datagrid.ItemsSource = null;
            change_test_datagrid.ItemsSource = Tests;
        }

        private void Delete_string_to_table_button_OnClick(object sender, RoutedEventArgs e)
        {
            if (Tests.Count != 0)
            {
                Tests.RemoveAt(Tests.Count-1);
                change_test_datagrid.ItemsSource = null;
                change_test_datagrid.ItemsSource = Tests;
            }
        }

        private void Save_strings_to_table_button_OnClick(object sender, RoutedEventArgs e)
        {
            SerDeser.Serialization(Tests);
            change_test_datagrid.ItemsSource = null;
            change_test_datagrid.ItemsSource = Tests;
        }
    }
}
