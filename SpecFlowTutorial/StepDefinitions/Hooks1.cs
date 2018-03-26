using TechTalk.SpecFlow;

namespace SpecFlowTutorial.StepDefinitions
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            System.Console.WriteLine("Implementing BeforeTestRun");
        }
         
        [BeforeFeature]
        public static void BeforeFeature()
        {
            System.Console.WriteLine("Implementing BeforeFeature");
        }
         

        [BeforeScenario]
        public void BeforeScenario()
        {
            System.Console.WriteLine("Implementing BeforeScenario");
        }
         
        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {
            System.Console.WriteLine("Implementing BeforeScenarioBlock");
        }

        [AfterScenarioBlock]
        public void AfterScenarioBlock()
        {
            System.Console.WriteLine("Implementing AfterScenarioBlock");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            System.Console.WriteLine("Implementing AfterScenario");
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            System.Console.WriteLine("Implementing BeforeFeature");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            System.Console.WriteLine("Implementing AfterTestRun");
        }


    }
}
