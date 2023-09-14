class Program
{
    static void Main()
    {
        Predicate <int> Obj=new Predicate<int>(IsEqual);
        Console.WriteLine(Obj(5));
        Console.ReadKey();
    }
    private static bool IsEqual(int a) 
    {
        
        return (a==10)?true:false;
    }
}