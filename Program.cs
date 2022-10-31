using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
string? word;
const string banWord = "линуск";
do {
    word = Console.ReadLine();
    Console.WriteLine(word?.Replace("л", "р"));
} while(word != banWord);
