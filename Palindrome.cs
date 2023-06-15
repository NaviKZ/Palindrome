using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите фразу для проверки:");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine($"Введенная строка является палиндромом: {isPalindrome}");
    }

    static bool IsPalindrome(string input)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (!Char.IsLetter(input[left]))
            {
                left++;
                continue;
            }

            if (!Char.IsLetter(input[right]))
            {
                right--;
                continue;
            }

            if (Char.ToLower(input[left]) != Char.ToLower(input[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
