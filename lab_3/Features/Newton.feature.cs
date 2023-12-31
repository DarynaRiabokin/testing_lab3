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
namespace lab_3.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Newton API Calculations")]
    public partial class NewtonAPICalculationsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Newton.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Newton API Calculations", "    In order to verify the Newton API across various endpoints\r\n    As a math ent" +
                    "husiast\r\n    I want to perform different mathematical operations and validate th" +
                    "e results", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("Perform mathematical operations via Newton API")]
        [NUnit.Framework.TestCaseAttribute("x+x", "x%2Bx", "2 x", "simplify", null)]
        [NUnit.Framework.TestCaseAttribute("x^2+2x", "x%5E2%2B2x", "x (x + 2)", "factor", null)]
        [NUnit.Framework.TestCaseAttribute("x^2+2x", "x%5E2%2B2x", "2 x + 2", "derive", null)]
        [NUnit.Framework.TestCaseAttribute("x^2+2x", "x%5E2%2B2x", "1/3 x^3 + x^2", "integrate", null)]
        [NUnit.Framework.TestCaseAttribute("2/x^3", "2%7Cx%5E3", "12 x + -16", "tangent", null)]
        [NUnit.Framework.TestCaseAttribute("2:4/x^3", "2:4%7Cx%5E3", "60", "area", null)]
        [NUnit.Framework.TestCaseAttribute("2/8", "2%7C8", "3", "log", null)]
        public void PerformMathematicalOperationsViaNewtonAPI(string expression, string codedExpression, string result, string operation, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("expression", expression);
            argumentsOfScenario.Add("coded expression", codedExpression);
            argumentsOfScenario.Add("result", result);
            argumentsOfScenario.Add("operation", operation);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Perform mathematical operations via Newton API", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
    testRunner.Given("I have access to the Newton API", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
    testRunner.When(string.Format("I call the \'{0}/{1}\' endpoint", operation, codedExpression), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
    testRunner.Then(string.Format("the responce should contain operation:\'{0}\',expression:\'{1}\',result:\'{2}\'", operation, expression, result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
