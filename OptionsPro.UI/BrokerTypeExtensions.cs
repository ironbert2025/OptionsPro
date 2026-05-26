using Options.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsPro.UI
{
    public static class BrokerTypeExtensions
    {
        public static string ToDisplayName(this BrokerType broker)
        {
            switch (broker)
            {
                //case BrokerType.CharlesSchwab:
                //    return "Charles Schwab";

                //case BrokerType.InteractiveBroker:
                //    return "Interactive Broker";

                case BrokerType.ETrade:
                    return "E-Trade";

                default:
                    return broker.ToString();
            }
        }
    }
}
