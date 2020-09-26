using System;
using System.Collections.Generic;
using System.Text;

namespace dateModifier
{
    public class DateModifier
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public int DayDifference()
        {
            var difference = this.EndDate - this.StartDate;
            return difference.Days;
        }
    }
}
