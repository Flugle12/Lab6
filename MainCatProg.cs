using Lab6;

class MainCatProg
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Cat Barsik = new Cat("Барсик");
        Barsik.Meow();
        BIGCat BigBarsik = new BIGCat("Большой барсик");

        int count = 0;
        Barsik.Meow(3);
        Console.WriteLine(Barsik);
     
        MeowClass Meow = new MeowClass();

        IMeow[] cats = new IMeow[] { Barsik, BigBarsik};
        MeowClass.GetAMeow(cats);
        Console.WriteLine(count);
    }
}

