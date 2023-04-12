namespace _01_Basic_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to C# Basic Programs");
            Console.WriteLine("Program # 01");

            Console.WriteLine("Enter your testing number");
            int num = int.Parse(Console.ReadLine());
            if(num %2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The Number is Odd");
            }
        }
    }
}