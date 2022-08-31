Book Instance = new Book();
Instance.defBook();
while(true)
{ 
Console.WriteLine("for the book review enter 1\nTo change the description of the book enter 2");
switch (Console.ReadLine())
{
    case "1":
        {
            Instance.Show();
            break;
        }
    case "2":
        {
            Console.WriteLine("Chose what do you wnat to add:\n1. Book name\n2. Author\n3.Content");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.WriteLine("current book name:"+Instance.name+ "\nenter the new one:\n");
                        Instance.name = Console.ReadLine();
                        Instance.defBook();
                            Instance.Show();
                            break;
                    }
                case "2":
                    {
                        Console.WriteLine("current FIO:" + Instance.FIO + "\nenter the new one:\n");
                        Instance.FIO = Console.ReadLine();
                        Instance.defBook();
                            Instance.Show();
                            break;
                    }
                case "3": 
                    {
                        Console.WriteLine(@"current content:" + Instance.content + "\nenter the new one:\n");
                        Instance.content = Console.ReadLine();
                        Instance.defBook();
                            Instance.Show();
                            break;
                    }
                default:
                    {
                        Console.WriteLine("You enter something wrong");
                        break;
                    }
            }
            break;
        }
    default:
    {
    Console.WriteLine("You enter something wrong");
    break;
    }
}
Console.WriteLine("if u want to end the session press <enter>");
if (Console.ReadKey().Key == ConsoleKey.Enter)
    break;
    Console.Clear();
}
class Book {
    public Book()
    {

        name = "Fall of the house of usher";
        FIO = "edgar allan poe";
        content = "The Fall of the House of Usher is a short story by American writer Edgar Allan Poe, first published in 1839 in Burton's Gentleman's Magazine, then included in the collection Tales of the Grotesque and Arabesque in 1840.[1] The short story, a work of Gothic fiction, includes themes of madness, family, isolation, and metaphysical identities";
    }
    public Title na = new Title();
    public Author au = new Author();
    public Content desc = new Content();
    public string name { get; set; }
    public string content { get; set; }
    public string FIO { get; set; }
    public void defBook()
    {

        na.name = name;
        au.FIO = FIO;
        desc.content = content;
    }
    public void Show()
    {
        na.Show();
        au.Show();
        desc.Show();
    }
}
class Title { 
    public string name { get; set; }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(name);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
class Author {
    public string FIO{ get; set; }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(FIO);
        Console.ForegroundColor = ConsoleColor.White;
    }
} 
class Content
{
    public string content { get; set; }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(content);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

