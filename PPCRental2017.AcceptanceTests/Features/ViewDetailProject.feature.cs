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
namespace PPCRental2017.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ViewDetailProjectFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ViewDetailProject.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ViewDetailProject", "As a potential customer\r\nI want to view the details of a properety\r\nSo that I cou" +
                    "ld choose the most suitable property", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "ViewDetailProject")))
            {
                PPCRental2017.AcceptanceTests.Features.ViewDetailProjectFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "Price",
                        "PropertyType",
                        "District",
                        "Ward",
                        "Street",
                        "PackingPlace",
                        "Bedroom",
                        "Bathroom",
                        "Content",
                        "UnitPrice",
                        "PropertyType_ID",
                        "Area"});
            table1.AddRow(new string[] {
                        "PIS Serviced Apartment – Style 3",
                        "30000",
                        "Office",
                        "Chương Mỹ",
                        "TT Chúc Sơn",
                        "Đường Nội Bộ",
                        "1",
                        "2",
                        "4",
                        "The well equipped kitchen is opened on a cozy living room and a dining area with " +
                            "table and chairs.. Behind the industrial glass wall you will find the bedroom ar" +
                            "ea with a double bed and a large closet.",
                        "USD",
                        "3",
                        "130m2"});
#line 7
testRunner.Given("the following projects", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The details of selected property should show")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ViewDetailProject")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void TheDetailsOfSelectedPropertyShouldShow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The details of selected property should show", new string[] {
                        "automated"});
#line 12
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 13
 testRunner.When("I open the details of \'PIS Serviced Apartment – Style 3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName"});
            table2.AddRow(new string[] {
                        "PIS Serviced Apartment – Style 3"});
#line 14
 testRunner.Then("I should see the following information", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
