using lesson7;

ACoder a1 = new ACoder();
Console.WriteLine(a1.Encode("Эта программа работает"));
Console.WriteLine(a1.Decode("Юуб рспдсбннб сбвпубжу"));

public interface ICoder
{
    string Encode(string shifr);
    string Decode(string shifr);
}