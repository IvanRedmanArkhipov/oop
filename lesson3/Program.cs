string Reverse(string first)
{
    char[] second = first.ToCharArray();
    char[] third = new char[second.Length];
    string fourth = "";
    for ( var i = 0; i < second.Length ; i++)
    {
        third[i] = second[second.Length - i - 1];
        fourth += third[i];
    }
    return fourth;
}
string first = "Привет, мир";
Console.WriteLine(first);
Console.WriteLine(Reverse(first));