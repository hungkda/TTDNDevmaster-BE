using Ex03;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();

        try {
            student.Nhap();
            if(student.labMark < 0 || student.labMark > 10 || student.TheoryMark <0 || student.TheoryMark >10) 
            {
                throw new InvalidMarkException();
            }
        }
        catch (InvalidMarkException ex) 
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (student.labMark > 0 && student.labMark < 10 && student.TheoryMark > 0 && student.TheoryMark < 10)
            {
                student.Display();
            }
            
        }
        
    }
}