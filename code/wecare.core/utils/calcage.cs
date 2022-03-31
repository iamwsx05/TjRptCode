using System;

namespace weCare.Core.Utils
{
    /// <summary>
    /// 计算年龄
    /// </summary>
    public class CalcAge
    {
        /// <summary>
        /// 获取病人年龄(以当前时间计算).整岁
        /// </summary>
        /// <param name="Birthday"></param>
        /// <returns></returns>
        public static int GetAgeInt(DateTime Birthday)
        {
            return CalcAge.GetAgeInt(Birthday, DateTime.Now);
        }
        /// <summary>
        /// 获取病人年龄(以传入时间计算).整岁
        /// </summary>
        /// <param name="Birthday"></param>
        /// <param name="CurrentTime"></param>
        /// <returns></returns>
        public static int GetAgeInt(DateTime Birthday, DateTime CurrentTime)
        {
            CalcAge calc = new CalcAge();
            int intAge = calc.CalcAgeInt(Birthday, CurrentTime);
            calc = null;
            return intAge;
        }
        /// <summary>
        /// 按整岁计算
        /// </summary>
        /// <param name="Birthday"></param>
        /// <param name="CurrentTime"></param>
        /// <returns></returns>
        private int CalcAgeInt(DateTime Birthday, DateTime CurrentTime)
        {
            int intAgeY = 0;
            int intDiffYear = CurrentTime.Year - Birthday.Year;
            int intDiffMonth = CurrentTime.Month - Birthday.Month;
            int intDiffDay = CurrentTime.Day - Birthday.Day;
            int intDiffHour = CurrentTime.Hour - Birthday.Hour;
            int intDiffMinute = CurrentTime.Minute - Birthday.Minute;
            TimeSpan tspan = CurrentTime.Date - Birthday.Date;

            if (intDiffMinute < 0)
            {
                intDiffHour--;
                intDiffMinute += 60;
            }

            if (intDiffHour < 0)
            {
                intDiffDay--;
                intDiffHour += 24;
            }

            if (intDiffDay < 0)
            {
                intDiffMonth--;
                intDiffDay += 30;
            }

            if (intDiffMonth < 0)
            {
                intDiffYear--;
                intDiffMonth += 12;
            }

            if (intDiffYear >= 1)
            {
                intAgeY = intDiffYear;
            }
            else
            {
                intAgeY = 0;
            }

            return intAgeY;
        }

        /// <summary>
        /// 获取病人年龄(以当前时间计算)
        /// </summary>
        /// <param name="birthday"></param>
        /// <returns></returns>
        public static string GetAge(DateTime birthday)
        {
            return CalcAge.Age(birthday, DateTime.Now);
        }
        /// <summary>
        /// 获取病人年龄(以传入时间计算)
        /// </summary>
        /// <param name="birthday"></param>
        /// <param name="currentTime"></param>
        /// <returns></returns>
        public static string GetAge(DateTime birthday, DateTime currentTime)
        {
            return CalcAge.Age(birthday, currentTime);
        }

        /// <summary>
        /// 计算年龄
        /// </summary>
        /// <param name="birthday"></param>
        /// <param name="currentTime"></param>
        /// <returns></returns>
        private static string Age(DateTime birthday, DateTime currentTime)
        {
            string strAge = string.Empty;
            int intDiffYear = currentTime.Year - birthday.Year;
            int intDiffMonth = currentTime.Month - birthday.Month;
            int intDiffDay = currentTime.Day - birthday.Day;
            int intDiffHour = currentTime.Hour - birthday.Hour;
            int intDiffMinute = currentTime.Minute - birthday.Minute;
            TimeSpan tspan = currentTime.Date - birthday.Date;

            if (intDiffMinute < 0)
            {
                intDiffHour--;
                intDiffMinute += 60;
            }

            if (intDiffHour < 0)
            {
                intDiffDay--;
                intDiffHour += 24;
            }

            if (intDiffDay < 0)
            {
                intDiffMonth--;
                //intDiffDay += DateTime.DaysInMonth(p_dtmCurrentTime.Year, p_dtmCurrentTime.Month); //30;
                //intDiffDay = (p_dtmCurrentTime - p_dtmBirthday).Days;
                intDiffDay = (DateTime.DaysInMonth(birthday.Year, birthday.Month) - birthday.Day) + currentTime.Day;
            }

            if (intDiffMonth < 0)
            {
                intDiffYear--;
                intDiffMonth += 12;
            }

            if (intDiffYear >= 15)
            {
                strAge = intDiffYear.ToString() + "岁";
                if (intDiffYear > 110)
                {
                    return "不详";
                }
            }
            else if (intDiffYear >= 1)
            {
                //if (clsGlobalHospitalCode.Code == "0013")
                //{
                //    if (intDiffYear >= 2 || intDiffMonth == 0)
                //    {
                //        strAge = intDiffYear.ToString() + "岁";
                //    }
                //    else
                //    {
                //        intDiffMonth++;
                //        if (intDiffMonth == 12)
                //        {
                //            strAge = intDiffYear.ToString() + "岁";
                //        }
                //        else
                //        {
                //            strAge = intDiffYear.ToString() + "岁" + intDiffMonth.ToString() + "月";
                //        }
                //    }
                //}
                //else
                //{
                strAge = intDiffYear.ToString() + "岁" + intDiffMonth.ToString() + "月";
                //}
            }
            else if (intDiffMonth >= 1)
            {
                strAge = intDiffMonth.ToString() + "月" + intDiffDay.ToString() + "天";
            }
            else if (intDiffDay >= 1)
            {
                strAge = tspan.Days.ToString() + "天";
                //strAge = tspan.Days.ToString() + "天" + intDiffHour.ToString() + "小时";
            }
            else if (intDiffHour >= 1)
            {
                strAge = intDiffHour.ToString() + "小时";
                //strAge = intDiffHour.ToString() + "小时" + intDiffMinute.ToString() + "分钟";               
            }
            else
            {
                //if (clsGlobalHospitalCode.Code == "0002")
                //    strAge = intDiffMinute.ToString() + "分钟";
                //else
                //    strAge = "1小时";

                if (intDiffMinute == 0)
                {
                    strAge = "新生儿";
                }
                else
                {
                    strAge = intDiffMinute.ToString() + "分钟";
                }
            }

            if (strAge == Convert.ToString(DateTime.Now.Year - 1) + "岁") return string.Empty;
            return strAge;
        }
    }
}
