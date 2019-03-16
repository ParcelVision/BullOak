﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BullOak.Repositories.EntityFramework.Test.Integration.Specifications
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class InNewSessionSpecsFeature : Xunit.IClassFixture<InNewSessionSpecsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "IsNewSessionSpecs.feature"
#line hidden
        
        public InNewSessionSpecsFeature(InNewSessionSpecsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "InNewSessionSpecs", @"	In order to guard against illegal transitions for pre-existing entities (for example to raise an error when trying to do any action on a non-initialized entity)
	As a developer using this library
	I want the current session to have a flag informing me if this is a new entity or pre-existing", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="When I start a session for a new entity, the session should hold the fact that th" +
            "e entity is new (not stored)")]
        [Xunit.TraitAttribute("FeatureTitle", "InNewSessionSpecs")]
        [Xunit.TraitAttribute("Description", "When I start a session for a new entity, the session should hold the fact that th" +
            "e entity is new (not stored)")]
        public virtual void WhenIStartASessionForANewEntityTheSessionShouldHoldTheFactThatTheEntityIsNewNotStored()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I start a session for a new entity, the session should hold the fact that th" +
                    "e entity is new (not stored)", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("no existing entity", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When("I load the session", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("the IsNewState should be true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="When I start a session for an existing entity, the session should hold the fact t" +
            "hat the entity already existed in db")]
        [Xunit.TraitAttribute("FeatureTitle", "InNewSessionSpecs")]
        [Xunit.TraitAttribute("Description", "When I start a session for an existing entity, the session should hold the fact t" +
            "hat the entity already existed in db")]
        public virtual void WhenIStartASessionForAnExistingEntityTheSessionShouldHoldTheFactThatTheEntityAlreadyExistedInDb()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I start a session for an existing entity, the session should hold the fact t" +
                    "hat the entity already existed in db", null, ((string[])(null)));
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
 testRunner.Given("an existing entity with HigherOrder 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.When("I load the session", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("the IsNewState should be false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                InNewSessionSpecsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                InNewSessionSpecsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
