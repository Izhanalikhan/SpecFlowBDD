﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace testing.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("mix")]
    public partial class MixFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "mix.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "mix", "A short summary of the feature", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Testing Postman Echo Get")]
        [NUnit.Framework.CategoryAttribute("DataSource:testData/postEcho.xlsx")]
        [NUnit.Framework.TestCaseAttribute("GET", "https://postman-echo.com", "get", "muh", "Aman", "xyz", "abc", "200", "", "", "", "", "", "", ".", null)]
        public void TestingPostmanEchoGet(
                    string requestMethod, 
                    string baseUrl, 
                    string endPoint, 
                    string h_Param_1_Key, 
                    string h_Param_1_Value, 
                    string r_Param_1_Key, 
                    string r_Param_2_Value, 
                    string respCode, 
                    string column8, 
                    string column9, 
                    string column10, 
                    string column11, 
                    string column12, 
                    string column13, 
                    string _, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "DataSource:testData/postEcho.xlsx"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("requestMethod", requestMethod);
            argumentsOfScenario.Add("baseUrl", baseUrl);
            argumentsOfScenario.Add("endPoint", endPoint);
            argumentsOfScenario.Add("h_param_1_key", h_Param_1_Key);
            argumentsOfScenario.Add("h_param_1_value", h_Param_1_Value);
            argumentsOfScenario.Add("r_param_1_key", r_Param_1_Key);
            argumentsOfScenario.Add("r_param_2_value", r_Param_2_Value);
            argumentsOfScenario.Add("respCode", respCode);
            argumentsOfScenario.Add("Column8", column8);
            argumentsOfScenario.Add("Column9", column9);
            argumentsOfScenario.Add("Column10", column10);
            argumentsOfScenario.Add("Column11", column11);
            argumentsOfScenario.Add("Column12", column12);
            argumentsOfScenario.Add("Column13", column13);
            argumentsOfScenario.Add(".", _);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Testing Postman Echo Get", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.When(string.Format("I set url to \'{0}\'", baseUrl), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.And(string.Format("I set endpoint to \'{0}\'", endPoint), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And(string.Format("Add \'{0}\' to \'{1}\' in request header", h_Param_1_Key, h_Param_1_Value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And(string.Format("Add parameter \'{0}\' with value \'{1}\' to request", r_Param_1_Key, r_Param_2_Value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("I execute a \'GET\' request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.Then(string.Format("I get a \'{0}\' response code", respCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1. Logging in without password (Negative Test Case 1)")]
        [NUnit.Framework.CategoryAttribute("DataSource:testData/sauceDemo.xlsx")]
        [NUnit.Framework.TestCaseAttribute("sauceDemo", "https://www.saucedemo.com/", "standard_user", "secret_sauce", "Aman", "Alam", "12345", "", "", "", "", "", ".", null)]
        public void _1_LoggingInWithoutPasswordNegativeTestCase1(string websiteName, string url, string username, string password, string firstName, string lastName, string postalCode, string column7, string column8, string column9, string column10, string column11, string _, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "DataSource:testData/sauceDemo.xlsx"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("websiteName", websiteName);
            argumentsOfScenario.Add("url", url);
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("firstName", firstName);
            argumentsOfScenario.Add("lastName", lastName);
            argumentsOfScenario.Add("postalCode", postalCode);
            argumentsOfScenario.Add("Column7", column7);
            argumentsOfScenario.Add("Column8", column8);
            argumentsOfScenario.Add("Column9", column9);
            argumentsOfScenario.Add("Column10", column10);
            argumentsOfScenario.Add("Column11", column11);
            argumentsOfScenario.Add(".", _);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1. Logging in without password (Negative Test Case 1)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 16
 testRunner.Given(string.Format("User Navigates to {0}", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 17
 testRunner.When(string.Format("User Enters {0} in \'sauceDemo_usernname\'", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.And("User Clicks on \'sauceDemo_loginBtn\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.Then("\'sauceDemo_loginError\' should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.Then("User Clicks on \'sauceDemo_loginErrorBtn\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2. Logging into Sauce Demo Website")]
        [NUnit.Framework.CategoryAttribute("DataSource:testData/sauceDemo.xlsx")]
        [NUnit.Framework.TestCaseAttribute("sauceDemo", "https://www.saucedemo.com/", "standard_user", "secret_sauce", "Aman", "Alam", "12345", "", "", "", "", "", ".", null)]
        public void _2_LoggingIntoSauceDemoWebsite(string websiteName, string url, string username, string password, string firstName, string lastName, string postalCode, string column7, string column8, string column9, string column10, string column11, string _, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "DataSource:testData/sauceDemo.xlsx"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("websiteName", websiteName);
            argumentsOfScenario.Add("url", url);
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("firstName", firstName);
            argumentsOfScenario.Add("lastName", lastName);
            argumentsOfScenario.Add("postalCode", postalCode);
            argumentsOfScenario.Add("Column7", column7);
            argumentsOfScenario.Add("Column8", column8);
            argumentsOfScenario.Add("Column9", column9);
            argumentsOfScenario.Add("Column10", column10);
            argumentsOfScenario.Add("Column11", column11);
            argumentsOfScenario.Add(".", _);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2. Logging into Sauce Demo Website", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
 testRunner.When(string.Format("User Enters {0} in \'sauceDemo_usernname\'", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then(string.Format("User Enters {0} in \'sauceDemo_password\'", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.And("User Clicks on \'sauceDemo_loginBtn\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.Then("\'sauceDemo_appLogo\' should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
