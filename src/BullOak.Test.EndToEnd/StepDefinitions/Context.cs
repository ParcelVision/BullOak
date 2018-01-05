﻿namespace BullOak.Test.EndToEnd.StepDefinitions
{
    using System.Reflection;
    using BoDi;
    using BullOak.Repositories;
    using TechTalk.SpecFlow;

    [Binding]
    public class ConfigurationSetup
    {
        private readonly IHoldAllConfiguration configuration;
        private readonly IObjectContainer objectContainer;

        public ConfigurationSetup(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
            configuration = Configuration.Begin()
                .WithDefaultCollection()
                .WithDefaultStateFactory()
                .NeverUseThreadSafe()
                .WithNoEventPublisher()
                .WithAnyAppliersFrom(Assembly.GetExecutingAssembly())
                .Build();

        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            objectContainer.RegisterInstanceAs<IHoldAllConfiguration>(configuration);
        }
    }
}
