using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowTutorial.StepDefinitions
{
    [Binding]
    public sealed class StepDefinition1
    {
        //List<Employee> employeDetails { get; set; }

        //public StepDefinition1(List<Employee> employeDetails)
        //{
        //    employeDetails = this.employeDetails;
        //}

        int result = 0;
        ArrayList a = new ArrayList();
        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
            a.Add(number);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            foreach (int num in a)
            {
                result = result + num;
            }
        }

        [Then("the result should be (.*) on the screen with my name (.*)")]
        public void ThenTheResultShouldBe(int result, string name)
        {
            Console.WriteLine(String.Format("My name is {0} and result is {1}", name, result));
            Assert.That(result == this.result, Is.EqualTo(true), "Incorrect result.");
        }

        [Given(@"I enter values in a form for following and save them  with my name (.*)")]
        public void GivenIEnterValuesInAFormFor(string name, Table table)
        {
            //Saving Simple Data Type in Scenario Context
            Console.WriteLine("***Printing values and saving in ScenarioContext in StepDefinition 1***");
            ScenarioContext.Current["name"] = name;

            //Saving Complex Data Type in Scenario Context using table.CreateSet<Employee>
            var empDetails = table.CreateSet<Employee>();
            List<Employee> empList = new List<Employee>();
            foreach (Employee item in empDetails)
            {
                Employee e = new Employee(item.name, item.age, item.phone);
                empList.Add(e);
            }
            ScenarioContext.Current.Add("employeeInfo",empList);

            //Retrieving values using table.CreateDynamicSet and printing values 
            var allEmployees = table.CreateDynamicSet();
            foreach (var emp in allEmployees)
            {
                Console.WriteLine("*************************");
                Console.WriteLine("Employe name: " + emp.name);    // Column names (name, age and phone) needs to exactly as specified in feature files
                Console.WriteLine("Employe age: " + emp.age);
                Console.WriteLine("Employe phone: " + emp.phone);
            }
             
        }
    }
}
