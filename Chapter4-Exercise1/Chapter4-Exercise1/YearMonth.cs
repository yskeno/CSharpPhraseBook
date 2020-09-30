using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Chapter4_Exercise1
{
    class YearMonth
    {
        public int Year { get; private set; }
        public int Month { get; private set; }
        public bool Is21Century
        {
            get
            {
                return 2001 <= Year && Year <= 2100;
            }
        }

        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        public YearMonth AddOneMonth()
        {
            if (Month == 12)
                return new YearMonth(this.Year + 1, 1);
            return new YearMonth(this.Year, this.Month + 1);
        }

        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }
    }
}
