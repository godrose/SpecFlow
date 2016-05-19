﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Calling Steps from StepDefinitions")]
    public partial class CallingStepsFromStepDefinitionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CallingStepsFromStepDefinition.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Calling Steps from StepDefinitions", "In order to create steps of a higher abstraction\r\nAs a developer\r\nI want reuse ot" +
                    "her steps in my step definitions", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void OtherStepDefinitionCanBeCalledWhenDeriveFromStepsBaseClass(string stepType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Other step definition can be called when derive from Steps base class", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 7
 testRunner.Given("the following binding class", string.Format(@"[Binding]
public class CallingStepsFromStepDefinitionSteps : Steps
{{
[{0}(@""I have entered (\d+) into the calculator"")]
public void GivenIHaveEntered(int number)
{{
//...
}}

[{0}(@""I have entered (\d+) and (\d+) into the calculator"")]
public void GivenIHaveEntered(int n1, int n2)
{{
{0}(string.Format(""I have entered {{0}} into the calculator"", n1));
{0}(string.Format(""I have entered {{0}} into the calculator"", n2));
}}
}}	", stepType), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.And("a scenario \'Simple Scenario\' as", string.Format("{0} I have entered 2 and 3 into the calculator", stepType), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table1.AddRow(new string[] {
                        "1"});
#line 31
 testRunner.Then("the execution summary should contain", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Other step definition can be called when derive from Steps base class")]
        public virtual void OtherStepDefinitionCanBeCalledWhenDeriveFromStepsBaseClass_Given()
        {
            this.OtherStepDefinitionCanBeCalledWhenDeriveFromStepsBaseClass("Given", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Other step definition can be called when derive from Steps base class")]
        public virtual void OtherStepDefinitionCanBeCalledWhenDeriveFromStepsBaseClass_When()
        {
            this.OtherStepDefinitionCanBeCalledWhenDeriveFromStepsBaseClass("When", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Other step definition can be called when derive from Steps base class")]
        public virtual void OtherStepDefinitionCanBeCalledWhenDeriveFromStepsBaseClass_Then()
        {
            this.OtherStepDefinitionCanBeCalledWhenDeriveFromStepsBaseClass("Then", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When I call other steps of a different type it shouldn\'t change the type of the n" +
            "ext and step in my feature")]
        public virtual void WhenICallOtherStepsOfADifferentTypeItShouldnTChangeTheTypeOfTheNextAndStepInMyFeature()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I call other steps of a different type it shouldn\'t change the type of the n" +
                    "ext and step in my feature", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 42
 testRunner.Given("the following binding class", @"[Binding]
public class CallingStepsFromStepDefinitionSteps : Steps
{
[Given(@""I have a given step"")]
public void GivenIHaveEntered()
{
//...
}

[When(@""I call a step of a different type"")]
public void WhenICallAStepOfADifferentType()
{
//...
}

[Given(@""I want to call another given step"")]
public void GivenIWantToCallAnotherGivenStep()
{
//...
}

[Given(@""I called some steps of different types"")]
public void GivenIHaveCalledStepsOfDifferentTypes()
{
Given(""I have a given step"");
When(""I call a step of a different type"");
}
}	", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 73
 testRunner.And("a scenario \'Simple Scenario\' as", "Given I called some steps of different types\r\nAnd I want to call another given st" +
                    "ep", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table2.AddRow(new string[] {
                        "1"});
#line 79
 testRunner.Then("the execution summary should contain", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When I call other steps of a different types in a hierarchy it shouldn\'t change t" +
            "he type of the next and step in my feature")]
        public virtual void WhenICallOtherStepsOfADifferentTypesInAHierarchyItShouldnTChangeTheTypeOfTheNextAndStepInMyFeature()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I call other steps of a different types in a hierarchy it shouldn\'t change t" +
                    "he type of the next and step in my feature", ((string[])(null)));
#line 84
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 85
 testRunner.Given("the following binding class", @"[Binding]
public class CallingStepsFromStepDefinitionSteps : Steps
{
[Given(@""I have a given step"")]
public void GivenIHaveEntered()
{
//...
}

[Given(@""I called a starting step"")]
public void GenericStepName7()
{
//...
}

[When(@""I call a step of a different type"")]
public void WhenICallAStepOfADifferentType()
{
//...
}

[Given(@""I want to call another given step"")]
public void GivenIWantToCallAnotherGivenStep()
{
//...
}

[Given(@""I called some steps of different types"")]
public void GenericStepName6()
{
Given(""I have a given step"");
When(""I call a step of a different type"");
}

[When(@""I have a when step"")]
public void GenericStepName8()
{
//...
}

[When(@""this step is called"")]
public void GenericStepName2()
{
Then(""this calls anotherStep"");
}

[Then(@""this calls anotherStep"")]
public void GenericStepName1()
{
//..
}

[Given(@""then this step is called"")]
public void GenericStepName3()
{
//..
}

[When(@""it calls a step which calls other steps"")]
public void GenericStepName4()
{
When(""this step is called"");
Given(""then this step is called"");
}

[Then(@""it should still find this step"")]
public void GenericStepName5()
{
//..
}
}	", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 159
 testRunner.And("a scenario \'Simple Scenario\' as", "Given I called a starting step\r\nAnd I called some steps of different types\r\nAnd I" +
                    " want to call another given step\r\nWhen I have a when step\r\nAnd it calls a step w" +
                    "hich calls other steps\r\nThen it should still find this step", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 168
 testRunner.When("I execute the tests", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table3.AddRow(new string[] {
                        "1"});
#line 169
 testRunner.Then("the execution summary should contain", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
