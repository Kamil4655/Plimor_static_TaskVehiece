using Static.Models;

namespace Static;
internal class Program
{
    static void Main(string[] args)
    {
       Student std =new Student("Kamil","Qehremanov",20);

        std.GetImfo();

        Student.PocketExpensePlus(100); 
        
    }
}
