using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static tubesAKHIR_Kelompok5.Regis;

namespace tubesAKHIR_Kelompok5
{
    public class RegistrationRule
    {
        public RegistrationRuleType RuleType { get; set; }
        public Func<Users, bool> Validation { get; set; }
        public Action<Users> Process { get; set; }
    }
}
