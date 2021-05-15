using System;
using System.Collections.Generic;
using System.Text;
using Money;

namespace Forms
{
    public class UserCache
    {
        public static Balance Account = new Balance();
        public static decimal MyDebt;
        public static decimal MySave;
        public static string Currency;
    }
}
