using Moq;
using NUnit.Framework;
using OrderProcessor;
using OrderProcessor.EventModels;
using System;

namespace OrderProcessorTests
{
    public class OrderProcessorSimpleTest
    {
        [SetUp]
        public void Setup()
        {
            //We dont have that much oc a complex logic here
        }

        [Test]
        public void OrderProcessorSimpleTest_WhenCalled_RaiseAnEvent()
        {
            var mid = new Mock<MidProcessor<PaymentEventArgs, ActionEventArgs>>();
            var orderProcesssSimple = new OrderProcessorSimple(mid.Object);

            var key= EventArgs.Empty;
            orderProcesssSimple.Process += (sender, args) => { key = args; };
            orderProcesssSimple.run();

            Assert.That(key, Is.Not.EqualTo(EventArgs.Empty));
        }
    }
}