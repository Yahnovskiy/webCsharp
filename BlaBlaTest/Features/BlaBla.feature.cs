﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BlaBlaTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("BlaBla")]
    public partial class BlaBlaFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BlaBla.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BlaBla", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Serarch (unauthorized)")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void SerarchUnauthorized()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Serarch (unauthorized)", new string[] {
                        "mytag"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "From",
                        "Destinatiom",
                        "DaysFromNow"});
            table1.AddRow(new string[] {
                        "Kiev",
                        "Fastov",
                        "0"});
#line 8
 testRunner.Given("I fill search field", ((string)(null)), table1, "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Authorization")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void Authorization()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Authorization", new string[] {
                        "mytag"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
testRunner.Given("User profile is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Logout")]
        [NUnit.Framework.CategoryAttribute("tag")]
        public virtual void Logout()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Logout", new string[] {
                        "tag"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
