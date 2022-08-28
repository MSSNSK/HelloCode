// Вид 1 (ничего не возвращает и ничего не принимает)
void Method1()
{
    Console.WriteLine("Author - Markov Sergei");
}
Method1();


// Вид 2 (ничего не возвращает, но может принимать какие-либо аргументы)
void Method2(string msg)
{
    Console.WriteLine(msg); 
}
Method2("Текст сообщения");


// Вид 3 (что-то возвращают, но ничего не принимают)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 (что-то принимает и что-то возвращает)
// string Method4(int count, string text) - через while
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string result = Method4(3, "qwerty");
// Console.WriteLine(result);


string Method4(int count, string text) //- через for
{
    string result = String.Empty;

    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string result = Method4(3, "qwerty");
Console.WriteLine(result);