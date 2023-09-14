using System.Runtime.CompilerServices;

class Program
{
    public static void  Main()
    {
        Action<string, string, double> Display = new Action<string, string, double>(Employee);
        Display("Gayathri", "Saravanan", 45000);
    }
    static void Employee(string Fname,string Lname,double salary)
    {
        Console.WriteLine("Employee Name:{0} {1}\nSalary:{2}",Fname, Lname, salary);
    }
    
}