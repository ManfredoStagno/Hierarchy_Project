using UnityEngine;

namespace HP.Timers
{
    public class TimeDate
    {
        int mins, hours, days, months, years;

        public TimeDate()
        {
            mins = 0;
            hours = 0;
            days = 1;
            months = 1;
            years = 1;
        }

        public string GetTime()
        {
            string timeString = "";
            //mins
            if(mins < 10) timeString += 0;
            timeString += mins;
            timeString += ":";
            //hours
            if (hours < 10) timeString += 0;
            timeString += hours;

            return timeString;
        }

        public string GetDate()
        {
            string dateString = "";
            //days
            if (days < 10) dateString += 0;
            dateString += days;
            dateString += "/";
            //months
            if (months < 10) dateString += 0;
            dateString += months;
            dateString += "/";
            //years
            if (years < 10) dateString += 0;
            dateString += years;
            
            return dateString;
        }

        public void IncreaseMins()
        {
            mins += 1;
            if(mins > 59)
            {
                mins = 0;
                IncreaseHours();
            }
        }

        private void IncreaseHours()
        {
            hours += 1;
            if (hours > 23)
            {
                hours = 0;
                IncreaseDays();
            }
        }

        private void IncreaseDays()
        {
            days += 1;
            if (days > 30)
            {
                days = 1;
                IncreaseMonths();
            }
        }

        private void IncreaseMonths()
        {
            months += 1;
            if (months > 12)
            {
                months = 1;
                IncreaseYears();
            }
        }

        private void IncreaseYears()
        {
            years += 1;
        }
    }
}