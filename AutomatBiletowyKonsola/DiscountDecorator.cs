using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public enum Discounts
    {
        normal,
        student,
        teacher,
        pensioner,
        veteran
    }

    public class DiscountDecorator : TicketDecorator
    {
        private double DiscountValue;

        private static Dictionary<Discounts, double> DiscountValues = new Dictionary<Discounts, double>
        {
            { Discounts.student, 50 },
            { Discounts.teacher, 37 },
            { Discounts.pensioner, 67 },
            { Discounts.veteran, 80 }
        };

        public override double Price
        {
            get
            {
                return base.Price * (100 - DiscountValue) / 100;
            }
            protected set
            {
                base.Price = value;
            }

        }

        public DiscountDecorator(Ticket ticket, Discounts discount) : base(ticket)
        {
            DiscountValue = DiscountValues[discount];
            LoggingMessage = string.Concat(base.LoggingMessage, $"Bought with discount: {DiscountValue} for {Price}");
        }
    }
}
