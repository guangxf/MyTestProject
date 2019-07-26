using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.HelpService
{
    public class DateClass
    {
        public bool DateDiff(DateTime dateTime1, DateTime dateTime2, out int days)
        {
            TimeSpan ts = dateTime1 - dateTime2;
            days = ts.Days;
            if (days < 0)
            {
                return false;
            }
            return true;
        }
    }
}
