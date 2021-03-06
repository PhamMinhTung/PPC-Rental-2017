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
    public partial class PostProjectFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PostProject.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PostProject", "I input value and save successfull", ProgrammingLanguage.CSharp, new string[] {
                        "automated"});
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "PostProject")))
            {
                PPCRental2017.AcceptanceTests.Features.PostProjectFeature.FeatureSetup(null);
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
#line 5
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "FullName",
                        "Phone",
                        "Address",
                        "Role"});
            table1.AddRow(new string[] {
                        "pet@gmail.com",
                        "1",
                        "Pet",
                        "0919413913",
                        "123456 Nguyễn Trãi",
                        "1"});
#line 6
 testRunner.Given("the following account", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "CodeType",
                        "Avatar",
                        "District",
                        "Street",
                        "Ward",
                        "Status"});
            table2.AddRow(new string[] {
                        "Coconut\'s Project",
                        "1",
                        "",
                        "Ba Vì",
                        "Điền Viên Thôn",
                        "TT Tây Đằng",
                        "Chưa duyệt"});
#line 9
 testRunner.Given("the following properties", ((string)(null)), table2, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Post Project Successfully")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "PostProject")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void PostProjectSuccessfully()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Project Successfully", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 13
 testRunner.When("I am at Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.And("I have navigate to Login Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("I entered \'pet@gmail.com\' and \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("I have navigate to Post Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table3.AddRow(new string[] {
                        "PropertyName",
                        "Banana\'s Project"});
            table3.AddRow(new string[] {
                        "Property Type",
                        "1"});
            table3.AddRow(new string[] {
                        "Content",
                        "You will feel comfortable when you come here"});
            table3.AddRow(new string[] {
                        "Street",
                        "Điền Viên Thôn"});
            table3.AddRow(new string[] {
                        "Ward",
                        "TT Tây Đằng"});
            table3.AddRow(new string[] {
                        "Ditrict",
                        "Ba Vì"});
            table3.AddRow(new string[] {
                        "Price",
                        "1000"});
            table3.AddRow(new string[] {
                        "Area",
                        "1000"});
            table3.AddRow(new string[] {
                        "Bedroom",
                        "2"});
            table3.AddRow(new string[] {
                        "Bathroom",
                        "2"});
            table3.AddRow(new string[] {
                        "Packing Place",
                        "1"});
#line 17
 testRunner.And("I entered the following information", ((string)(null)), table3, "And ");
#line 30
 testRunner.And("I have navigate to View List of Agency Project", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "CodeType",
                        "Avatar",
                        "District",
                        "Street",
                        "Ward",
                        "Status"});
            table4.AddRow(new string[] {
                        "Coconut\'s Project",
                        "1",
                        "",
                        "Ba Vì",
                        "Điền Viên Thôn",
                        "TT Tây Đằng",
                        "Chưa duyệt"});
            table4.AddRow(new string[] {
                        "Banana\'s Project",
                        "1",
                        "",
                        "Ba Vì",
                        "Điền Viên Thôn",
                        "TT Tây Đằng",
                        "Chưa duyệt"});
#line 31
 testRunner.Then("The list of properties shoul have my new property", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
