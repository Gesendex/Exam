using System;

namespace ExamTest2
{
  public class Program
    { // BEGIN of 'Program' class
        public class TimeInDay
        {// BEGIN of 'TimeInDay' class TTTTTTTTTTTTTTT
            private int _time_value = 0; // hh mm ss
            private string _time_name = "Unknown";
            public TimeInDay(int time_value, string time_name)
            { _time_value = time_value; _time_name = time_name; }
            public string Name { get { return _time_name; } }
            public int Hours
            { // BEGIN of 'Hours' property HHHHHHHHHHHHHHHH
                get
                {
                    return (_time_value & 0x00FF0000) >> 16;
                }
                set
                {
                    if (value < 0 || (value > 23)) value = 0;
                    _time_value = (_time_value & 0x7F00FFFF) | ((value << 16) & 0x00FF0000);
                }
            } // END of 'Hours' property HHHHHHHHHHHHHHHHHH
            public int Minutes
            { // BEGIN of 'Minutes' property MMMMMMMMMMMMMM
                get
                {
                    return (_time_value & 0x0000FF00) >> 8;
                }
                set
                {
                    if (value < 0 || value > 59) value = 0;
                    _time_value = (_time_value & 0x7FFF00FF) | ((value << 8) & 0x0000FF00);
                }
            } // END of 'Minutes' property MMMMMMMMMMMMMMMM
            public int Seconds
            { // BEGIN of 'Seconds' property SSSSSSSSSSSSSS
                get
                {
                    return _time_value & 0x000000FF;
                }
                set
                {
                    if (value < 0 || value > 59) value = 0;
                    _time_value = (_time_value & 0x7FFFFF00) | (value & 0x000000FF);
                }
            } // END of 'Seconds' property SSSSSSSSSSSSSSSS
        } // END of 'TimeInDay' class TTTTTTTTTTTTTTT

        static public bool SwapHours<T>(ref T a, ref T b)
        { // BEGIN of 'SwapHours'
            if (a.GetType() == typeof(TimeInDay) && b.GetType() == typeof(TimeInDay))
            {
                int hours_temp = (a as TimeInDay).Hours;
                (a as TimeInDay).Hours = (b as TimeInDay).Hours;
                (b as TimeInDay).Hours = hours_temp;
                return true;
            }
            else
            {
                T temp = a; a = b; b = temp;
                return false;
            }
        } // END of 'SwapHours'
        static public bool SwapMinutes<T>(ref T a, ref T b)
        {// BEGIN of 'SwapMinutes'
            if (a.GetType() == typeof(TimeInDay) && b.GetType() == typeof(TimeInDay))
            {
                int minutes_temp = (a as TimeInDay).Minutes;
                (a as TimeInDay).Minutes = (b as TimeInDay).Minutes;
                (b as TimeInDay).Minutes = minutes_temp;
                return true;
            }
            else
            {
                T temp = a; a = b; b = temp;
                return false;
            }
        } // END of 'SwapMinutes'
        static public bool SwapSeconds<T>(ref T a, ref T b)
        {// BEGIN of 'SwapMinutes'
            if (a.GetType() == typeof(TimeInDay) && b.GetType() == typeof(TimeInDay))
            {
                int seconds_temp = (a as TimeInDay).Seconds;
                (a as TimeInDay).Seconds = (b as TimeInDay).Seconds;
                (b as TimeInDay).Seconds = seconds_temp;
                return true;
            }
            else
            {
                T temp = a; a = b; b = temp;
                return false;
            }
        } // END of 'SwapSeconds'
        public static void Main(string[] args)
        {
            TimeInDay td_1 = new TimeInDay(0x59008, "td_1");
            TimeInDay td_2 = new TimeInDay(0x08590, "td_2");
            Console.WriteLine("{0}: Hours: {1}, Minutes {2}, Seconds {3}",
              td_1.Name, td_1.Hours, td_1.Minutes, td_1.Seconds);
            Console.WriteLine("{0}: Hours: {1}, Minutes {2}, Seconds {3}",
              td_2.Name, td_2.Hours, td_2.Minutes, td_2.Seconds);
            SwapHours<TimeInDay>(ref td_1, ref td_2);
            SwapMinutes<TimeInDay>(ref td_1, ref td_2);
            SwapSeconds<TimeInDay>(ref td_1, ref td_2);
            Console.WriteLine("{0}: Hours: {1}, Minutes {2}, Seconds {3}",
              td_1.Name, td_1.Hours, td_1.Minutes, td_1.Seconds);
            Console.WriteLine("{0}: Hours: {1}, Minutes {2}, Seconds {3}",
              td_2.Name, td_2.Hours, td_2.Minutes, td_2.Seconds);
            //Console.ReadKey();
        }
    } // END of 'Program' class 
} // END of user namespace

