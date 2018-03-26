using System;

namespace SpecFlowTutorial.StepDefinitions
{
    public class Employee
    { 

        public Employee(string name, int age, Int64 phone)
        {
            this.name = name;
            this.age = age;
            this.phone = phone;
        }

        public string name { get; set; }
        public int age { get; set; }
        public Int64 phone { get; set; }
         
    }
}