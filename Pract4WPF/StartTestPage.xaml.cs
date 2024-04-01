using System.Windows;
using System.Windows.Controls;

namespace Pract4WPF;

public partial class StartTestPage : Page
{
    private int count = 0;
    private int count_of_right = 0;
    private List<TestClass> Tests = SerDeser.Deserialization<TestClass>();
    public StartTestPage()
    {
        InitializeComponent();
        change_elemets(0);
    }
    
    private void Answer1_of_test_button_OnClick(object sender, RoutedEventArgs e)
    {
        check(AnswerEnum.First, count);
        change_elemets(count);
    }

    private void Answer2_of_test_button_OnClick(object sender, RoutedEventArgs e)
    {
        check(AnswerEnum.Second, count);
        change_elemets(count);
    }

    private void Answer3_of_test_button_OnClick(object sender, RoutedEventArgs e)
    {
        check(AnswerEnum.Third, count);
        change_elemets(count);
    }

    private void check(AnswerEnum answer_of_user, int index)
    {
        if (answer_of_user == Tests[index].user_answer)
        {
            count_of_right += 1;
        }
        if (count+1 <= Tests.Count)
        {
            count += 1;
            change_elemets(count);
        }
    }

    private void change_elemets(int index)
    {
        if (count+1 <= Tests.Count)
        {
            name_of_test_textblock.Text = Tests[index].name;
            description_of_test_textblock.Text = Tests[index].description;
            answer1_of_test_button.Content = Tests[index].question1;
            answer2_of_test_button.Content = Tests[index].question2;
            answer3_of_test_button.Content = Tests[index].question3;
        }
        else
        {
            name_of_test_textblock.Text = "Количество правильных ответов - " + count_of_right.ToString();
            description_of_test_textblock.Text = "";
            answer1_of_test_button.Content = "";
            answer2_of_test_button.Content = "";
            answer3_of_test_button.Content = "";
            answer1_of_test_button.IsEnabled = false;
            answer2_of_test_button.IsEnabled = false;
            answer3_of_test_button.IsEnabled = false;
        }
    }
}