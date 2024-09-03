using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_reload
{
    public class Employee
    {
        private string name;
        private int salary;
        DateTime birthDate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public Employee(string name, int salary, DateTime birthDate)
        {
            this.name = name;
            this.salary = salary;
            this.birthDate = birthDate;
        }
        
        public static Employee operator +(Employee employee, int amount)
        {
            employee.Salary += amount;
            return employee;
        }
        
        public static Employee operator -(Employee employee, int amount)
        {
            employee.Salary -= amount;
            return employee;
        }
       
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Salary == employee2.Salary;
        }
        
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Salary != employee2.Salary;
        }
       
        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }
        
        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }
        
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Employee))            
                return false;            

            Employee other = (Employee)obj;
            return this.Name == other.Name && this.Salary == other.Salary && this.BirthDate == other.BirthDate;
        }
        
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Salary.GetHashCode() ^ this.BirthDate.GetHashCode();
        }
    }
}
