namespace Static.Models
{
    internal class Student
    {

        string _name;
        string _surname;
        int _age;

        static double _pockedExpense;


        public Student(string name,string surname ,int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
            
        }

        static Student()
        {

            _pockedExpense = 300;
        }


        public void GetImfo()
        {
            Console.WriteLine($"adi: {_name}\nsoy adi: {_surname}\nyasi: {_age}\ncibxercliyi: {_pockedExpense}");
        }

        public static void PocketExpensePlus(int bonus)
        {
            Console.WriteLine($"Cib xercliyiniz artdi {_pockedExpense + bonus}");
        }

        public static void SayHi(string _name )
        {
            Console.WriteLine("salam "+_name);
        }
    }
}
