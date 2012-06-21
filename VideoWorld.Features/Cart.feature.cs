﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace VideoWorld.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Shopping cart")]
    public partial class ShoppingCartFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Cart.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Shopping cart", "In order to rent movies\nAs a customer\nI want to see the movies I have chosen", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("View my Cart")]
        [NUnit.Framework.CategoryAttribute("web")]
        public virtual void ViewMyCart()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("View my Cart", new string[] {
                        "web"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have added the movie \"Avatar\"");
#line 9
 testRunner.When("I view my Cart");
#line 10
 testRunner.Then("I should see the movie \"Avatar\" with a 1 day rental");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check out")]
        [NUnit.Framework.CategoryAttribute("web")]
        public virtual void CheckOut()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check out", new string[] {
                        "web"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given("I have added the movie \"Avatar\"");
#line 15
 testRunner.When("I navigate to my Cart");
#line 16
 testRunner.And("I check out");
#line 17
 testRunner.Then("I should see my statement");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("View History")]
        [NUnit.Framework.CategoryAttribute("web")]
        public virtual void ViewHistory()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("View History", new string[] {
                        "web"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("I have rented the movie \"Avatar\"");
#line 22
 testRunner.When("I navigate to my History");
#line 23
 testRunner.Then("I should see 1 history item");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
