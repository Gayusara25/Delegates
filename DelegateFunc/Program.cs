public class Program
{ 
    static void Main()
    {
        Func<double,double,string> DisplayEmp = new Func<double,double,string>(Speed);
        Console.WriteLine(DisplayEmp(88.45,15));
        Console.ReadKey();
    }
    private static string Speed(double dist,double time)
    {
        double velocity = dist / time;
        velocity=Math.Round(velocity,3);
        return string.Format("Speed is {0}m/s",velocity);
    }
}