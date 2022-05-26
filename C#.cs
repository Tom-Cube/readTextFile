class ReadFromFile
{
    static void Main()
    {
        string text = System.IO.File.ReadAllText(@"txt.txt");
        System.Console.WriteLine(text);
    }
}
