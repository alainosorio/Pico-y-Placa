using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public abstract class Schedule
    {
        public Schedule()
        { }
        protected abstract Boolean Validator(Registration.Registration registration, DateTime datetime);
    }
}
