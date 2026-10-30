
////25 вариант базовый уровень

Console.WriteLine("Введите строку:");
string text = Console.ReadLine()!;
text = text.Replace(".", ". ");
Console.WriteLine(text);

//Вариант 25 средний уровень

Console.WriteLine("Введите размер строк:");
int n = int .Parse(Console.ReadLine());
Random random = new Random();

char[] text1 = new char[n];
for (int i = 0; i < text1.GetLength(0); i++)
{
    text1[i] = (char)random.Next(36, 100);
}
Console.WriteLine();

char[] text2 = new char[n];
for (int i = 0; i < text2.GetLength(0); i++)
{
    text2[i] = (char)random.Next(36, 100);
}
Console.WriteLine();

string str1 = new string(text1);
Console.WriteLine(str1);
string str2 = new string(text2);
Console.WriteLine(str2);
Console.WriteLine();

char[] text3 = new char[n*2];
for (int i = 0;i < text1.Length; i++)
{
    text3[i*2] = text1[i];
    text3[i*2 +1] = text2[i];
}
Console.WriteLine();

string str3 = string.Join(" ", text3);
Console.WriteLine(str3);





