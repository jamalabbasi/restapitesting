﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace RestApiTest
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly List<int> _numbers = new List<int>();
        private int _total;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            _numbers.Add(p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _total = _numbers.Sum();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(p0, _total);
        }
    }
}
