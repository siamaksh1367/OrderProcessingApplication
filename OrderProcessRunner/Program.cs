using OrderProcessor;
using System;

namespace OrderProcessRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var physicalPacking = new PhysicalProductPacking();
            var bookpacking = new BookPacking();
            var MembershipPaid = new MembershipPaid();
            var UpgradeMembershipPaid = new UpgradeMembershipPaid();
            var MailSender = new MailSender();
            var videoPaching = new VideoPacking();
            var agentComission = new AgentComission();

            var paidPhysical = new PhysiclaPayment(new System.Collections.Generic.List<IObserver<PaymentDto>>{physicalPacking, agentComission});
            var paidBook = new BookPayment(new System.Collections.Generic.List<IObserver<PaymentDto>> { bookpacking, agentComission });
            var paidMembership = new MembershipPayment(new System.Collections.Generic.List<IObserver<PaymentDto>> { MembershipPaid, MailSender});
            var paidUpgrade = new UpgradeMembershipPayment(new System.Collections.Generic.List<IObserver<PaymentDto>> { UpgradeMembershipPaid, MailSender });
            var paidVideo = new VideoPayment(new System.Collections.Generic.List<IObserver<PaymentDto>> { videoPaching});

            paidPhysical.ProcessPayment(new PaymentDto());
            paidBook.ProcessPayment(new PaymentDto());
            paidMembership.ProcessPayment(new PaymentDto());
            paidUpgrade.ProcessPayment(new PaymentDto());
            paidVideo.ProcessPayment(new PaymentDto());


        }
    }
}
