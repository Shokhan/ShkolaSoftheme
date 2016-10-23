using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Age_Zodiac
{
    public class AgeZodiacInfo
    {
        ZodiacInfo[] mZodiacs;
        private DateTime mDate;

        int[] nOfMounthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private void validateDate(string date, int d = 0, int m = 0, int y = 0)
        {
            if(d == 0)
            {
                d = int.Parse(getPartOfString(date, 0, 1));
                validateDate(date, d);
            }
            else if(m == 0)
            {
                m = int.Parse(getPartOfString(date, 3, 4));
                validateDate(date, d, m);
            }
            else if(y == 0)
            {
                y = int.Parse(getPartOfString(date, 6, 9));
                //Учет высокосного года
                if (d == 29 && m == 2)
                {
                    int diff = (2016 - y) % 4;
                    if (diff != 0)
                        throw new FormatException();
                }
                validateDate(date, d, m, y);
            }
            else
            {
                if (d > nOfMounthDays[m - 1] && (m != 2 && d != 29))
                    throw new FormatException();
                mDate = new DateTime(y, m, d);
            }
        }

        string getPartOfString(string str, int firstind, int lastind)
        {
            string temp = "";
            for (int i = firstind; i <= lastind; ++i)
                temp += str[i];
            return temp;
        }
        public int GetAge()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - mDate.Year;

            if (now.Month < mDate.Month)
                --age;
            return age;            
        }

        public string determineZodiac()
        {
                int size = mZodiacs.Count();
                for (int i = 0; i < size - 1; ++i)
                {
                    if (mDate.Month == mZodiacs[i].From.Month)
                    {
                        if (mDate.Day >= mZodiacs[i].From.Day)
                            return mZodiacs[i].Name;
                           
                    }
                    else if(mDate.Month == mZodiacs[i].To.Month)
                    {
                         if(mDate.Day <= mZodiacs[i].To.Day)
                                return mZodiacs[i].Name;
                    }
                }

            return mZodiacs[size - 1].Name;
        }

        public struct ZodiacInfo
        {
            public string Name { get; set; }
            public DateTime From { get; set; }
            public DateTime To { get; set; }
        }
        public AgeZodiacInfo(string date)
        {
            if (date[2] != '/' || date[5] != '/' || date.Length > 10 || date.Length < 9)
                throw new FormatException();

            validateDate(date);

            mZodiacs = new ZodiacInfo[] {
                 new ZodiacInfo()
                 {
                     Name = "Стрелец",
                     From = new DateTime(1444, 11, 22),
                     To = new DateTime(1444, 12, 21)
                 },

                 new ZodiacInfo()
                 {
                     Name = "Скорпион",
                     From = new DateTime(1444, 10, 23),
                     To = new DateTime(1444, 11, 21)
                 },

                 new ZodiacInfo()
                 {
                     Name = "Весы",
                     From = new DateTime(1444, 9, 23),
                     To = new DateTime(1444, 10, 22)
                 },

                 new ZodiacInfo()
                 {
                     Name = "Дева",
                     From = new DateTime(1444, 8, 23),
                     To = new DateTime(1444, 9, 22)
                 },

                 new ZodiacInfo()
                 {
                     Name = "Лев",
                     From = new DateTime(1444, 7, 23),
                     To = new DateTime(1444, 8, 22)
                 },

                 new ZodiacInfo()
                 {
                     Name = "Рак",
                     From = new DateTime(1444, 6, 21),
                     To = new DateTime(1444, 7, 22)
                 },

                 new ZodiacInfo()
                 {
                     Name = "Близнецы",
                     From = new DateTime(1444, 5, 21),
                     To = new DateTime(1444, 6, 20)
                 },

                 new ZodiacInfo()
                 {
                     Name = "Телец",
                     From = new DateTime(1444, 4, 20),
                     To = new DateTime(1444, 5, 20)
                 },

                 new ZodiacInfo()
                 {
                     Name = "Овен",
                     From = new DateTime(1444, 3, 21),
                     To = new DateTime(1444, 4, 19)
                 },

                 new ZodiacInfo()
                 {
                     Name = "Рыбы",
                     From = new DateTime(1444, 2, 19),
                     To = new DateTime(1444, 3, 20)
                 },

                 new ZodiacInfo()
                 {
                     Name = "Водолей",
                     From = new DateTime(1444, 1, 20),
                     To = new DateTime(1444, 2, 18)
                 },
                 new ZodiacInfo()
                 {
                     Name = "Козерог",
                     From = new DateTime(1444, 12, 22),
                     To = new DateTime(1444, 1, 19)
                 }
             };
        }
    }
}
