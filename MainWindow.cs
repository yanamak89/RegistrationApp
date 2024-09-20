using Avalonia.Controls;
using Avalonia.Media;
using RegistrationApp;  


namespace RegistrationApp;

public partial class MainWindow : Window
{
    private LoginValidator loginValidator = new LoginValidator();
    private void OnRegisterClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        string login = LoginTextBox.Text;
        string password = PasswordTextBox.Text;
        
        // Перевірка логіну
        if (!loginValidator.IsValidLogin(login))
        {
            ResultTextBlock.Text = "Невірний формат логіну. Логін повинен містити тільки латинські літери.";
            ResultTextBlock.Foreground = new SolidColorBrush(Colors.Red);
            return;
        }

        // Перевірка пароля
        if (!loginValidator.IsValidPassword(password))
        {
            ResultTextBlock.Text = "Невірний формат пароля. Пароль повинен містити хоча б одну цифру або спеціальний символ.";
            ResultTextBlock.Foreground = new SolidColorBrush(Colors.Red);
            return;
        }
        // Якщо логін і пароль валідні, реєстрація успішна
        ResultTextBlock.Text = "Реєстрація успішна!";
        ResultTextBlock.Foreground = new SolidColorBrush(Colors.Green);
    }

}