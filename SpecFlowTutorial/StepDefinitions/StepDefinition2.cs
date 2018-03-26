using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecFlowTutorial.StepDefinitions
{
    [Binding]
    public sealed class StepDefinition2
    {
        //List<Employee> employeDetails;

        //public StepDefinition2(List<Employee> employeDetails)
        //{
        //    employeDetails = this.employeDetails;
        //}


        [Given(@"I get the values from different binding class")]
        public void GivenIGetTheValuesFromDifferentBindingClass()
        {
            Console.WriteLine("*** Retrieving Values From ScenarioContext StepDefinition 2 **");

            //Retrieving Simple Data Type
            Console.WriteLine("My name is " + ScenarioContext.Current.Get<string>("name"));

            //Retrieving Complex Data Type 
            List<Employee> employeDetails = ScenarioContext.Current.Get<List<Employee>>("employeeInfo");
           
            foreach (Employee emp in employeDetails)
            {
                Console.WriteLine("*************************");
                Console.WriteLine("Employe name: " + emp.name);
                Console.WriteLine("Employe age: " + emp.age);
                Console.WriteLine("Employe phone: " + emp.phone);
            }
        }

    }
}
