

using Exseption.Exseption;

namespace Exseption
{
    internal class Department
    {
        private string Name;
        private int EmployeLimit;
        private Employee[] employees;

        public Department(string name, int employeLimit)
        {
            Name = name;
            EmployeLimit = employeLimit;
        }

        public void AddEmploye(Employee employee)
        {
            this.employees.Append(employee);    
        }

        public void Exceptionmethod()
        {
            if (EmployeLimit < 5)
            {

            }
            else
            {
                throw new CapacityLimitException("CapacityLimitException");
            }
        }
        public void UpdateDepartment(string newName,int employeeLimit)
        {
            Name = newName; 
            EmployeLimit = employeeLimit;    
        }

        private Employee[] employee=new Employee[5]; 

        public Employee this[int index]
        {
            get
            {
                return employee[index]; 
            }
            set
            {
                employee[index] = value;    
            }
        }
    }
}
