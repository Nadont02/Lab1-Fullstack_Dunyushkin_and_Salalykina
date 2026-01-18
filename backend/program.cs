// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

// ввод имени
Console.WriteLine("Введите своё прекрастное имя 😍:");
string name = Console.ReadLine();
Console.WriteLine($"Ну здравствуй {name}.🤩");

// день недели
Console.WriteLine($"Какой же сегодня чудестный день недели 😎: {DateTime.Now.ToString("dddd", new CultureInfo("ru-RU"))}");

// логика продолжения
Console.WriteLine($"{name} хотите ли вы продолжить(y/n):");
string otvet = Console.ReadLine();
if (otvet?.ToLower() == "y")
{
    Console.WriteLine("Хорошо, продолжаем");
}
else if (otvet?.ToLower() == "n")
{
    Console.WriteLine("До свидания");
}
else
{
    Console.WriteLine("Ошибка! Неизвестное значение.");
}