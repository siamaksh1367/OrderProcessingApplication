using Moq;
using NUnit.Framework;
using OrderProcessor;
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
            var videoPaching = new Mock<VideoPacking>();
            var paidVideo = new VideoPayment(new System.Collections.Generic.List<IObserver<PaymentDto>> { videoPaching.Object });

            var payment = new PaymentDto();
            paidVideo.ProcessPayment(payment);

            videoPaching.Verify(s=>s.OnNext(payment));
        }
    }
}