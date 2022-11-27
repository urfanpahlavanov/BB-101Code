

namespace Exseption
{
    class Employee : IPerson
    {
        public string Name;
        public int Age;

        public int Salary;
        private int Id;
        private static int _id;

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
            _id++;
            Id= _id;    
        }

        public int IdProp { get { return _id; } }
       

        string IPerson.Name => Name;
        int IPerson.Age => Age;


        public string ShowInfo()
        {
            return $"Name={Name} Age={Age} ";
        }
        public override string ToString()
        {
            return ShowInfo(); 
        }
    }
}
