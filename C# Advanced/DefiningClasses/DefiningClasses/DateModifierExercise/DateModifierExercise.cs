using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifierExercise
{
    public class DateModifierExercise
    {
        public int GetDaysDifference(string startDateAsString, string endDateAsString)
        {
            DateTime startDate = DateTime.Parse(startDateAsString);
            DateTime endDate = DateTime.Parse(endDateAsString);

            int result = (int)(startDate - endDate).TotalDays;

            return result;
        }
    }
}
