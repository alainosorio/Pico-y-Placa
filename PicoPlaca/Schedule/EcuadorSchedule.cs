using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public class EcuadorSchedule : Schedule
    {
        public EcuadorSchedule()
            : base()
        { }

        protected override bool Validator(Registration.Registration registration, DateTime datetime) 
        {
            bool drive = true;
            
            int position = registration.Number.Length -1;

            String digit = registration.Number.Substring(position,1);

            string weekday = datetime.DayOfWeek.ToString();

            if (weekday == WeekDay.week_day.Monday.ToString() && (digit == "1" || digit == "2"))
            {
                drive = false;    
            }
            else if (weekday == WeekDay.week_day.Tuesday.ToString() && (digit == "3" || digit == "4"))
            {
                drive = false;
            }
            else if (weekday == WeekDay.week_day.Wednesday.ToString() && (digit == "5" || digit == "6"))
            {
                drive = false;
            }
            else if (weekday == WeekDay.week_day.Thursday.ToString() && (digit == "7" || digit == "8"))
            {
                drive = false;
            }
            else if (weekday == WeekDay.week_day.Friday.ToString() && (digit == "9" || digit == "0"))
            {
                drive = false;
            }

            return drive;
        }

        public bool EcuadorValidator(Registration.Registration registration, DateTime datetime)
        {
            return this.Validator(registration, datetime);
        }
    }
}
