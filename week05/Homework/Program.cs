using System; 

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the Homework Project.");
            Assignment a = new Assignment("Samuel Bennett","Multiplication");
            MathAssignment b = new MathAssignment("Roberto Rodriquez","Fractions","Section 7.3","Problems 8-19");
            WritingAssignment c = new WritingAssignment("Mary Waters","European History","The Causes of World War II by Mary Waters");
        
            Console.WriteLine();        
            Console.WriteLine(a.GetSummary());
            Console.WriteLine();        
            Console.WriteLine(b.GetSummary());
            Console.WriteLine(b.GetHomeworkList());
            Console.WriteLine();        
            Console.WriteLine(c.GetSummary());
            Console.WriteLine(c.GetWritingInformation());
            Console.WriteLine();        
            
        }
    }
}