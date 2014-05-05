using NDP.Abstract;

namespace NDP.Models
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Person(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }

        public void AddPerson()
        {
            throw new System.NotImplementedException();
        }

        public void RemovePerson()
        {
            throw new System.NotImplementedException();
        }

        public void ShowPerson()
        {
            throw new System.NotImplementedException();
        }

        public double CalculateSalary()
        {
            throw new System.NotImplementedException();
        }
    }
}
