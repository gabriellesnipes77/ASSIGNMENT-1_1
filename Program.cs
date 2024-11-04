namespace CCAD16_DEMO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            double age = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Enter address:");
            string address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I am " + age);  
            Console.WriteLine("I live in " + address);
        }
     }
}
