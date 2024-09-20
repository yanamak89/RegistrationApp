using System.Text.RegularExpressions;
using RegistrationApp;  

namespace RegistrationApp;

public class LoginValidator
{
    // Метод для перевірки логіну (тільки латинські літери)
    public bool IsValidLogin(string login)
    {
        // Логін повинен містити тільки латинські літери
        return Regex.IsMatch(login, "^[a-zA-Z]+$");
    }

    // Метод для перевірки пароля (цифри або символи)
    public bool IsValidPassword(string password)
    {
        // Перевірка пароля: повинен містити літери і хоча б одну цифру або спеціальний символ
        bool containsLetter = Regex.IsMatch(password, "[a-zA-Z]"); // Латинські літери
        bool containsDigitOrSymbol = Regex.IsMatch(password, "[0-9!@#$%^&*()_+{}:;,.<>?\\[\\]]"); // Цифри або спеціальні символи

        return containsLetter && containsDigitOrSymbol;
    }
}