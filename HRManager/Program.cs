namespace HRManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            employees.Input();
            employees.DisplayDetail();
        }
    }
}