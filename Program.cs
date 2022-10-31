using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
string? word;
const string banWord = "линукс";
do {
    word = Console.ReadLine();
    Console.WriteLine(word?.Replace("л", "р"));
} while(word != banWord);
