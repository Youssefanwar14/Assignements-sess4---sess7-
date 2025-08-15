using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignements
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        // constructor
        public Duration(int hours,int minutes,int seconds) 
        {
            Hours = hours; 
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds)
       
        {
            Hours = totalSeconds / 3600;
            
            int remainingSeconds = totalSeconds % 3600;
            
            Minutes = remainingSeconds / 60;

            Seconds = remainingSeconds % 60;
        }
        
        public int totalSeconds() 
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
        public override string ToString()
        {
            if (Hours != 0)
                 return $"Hours : {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            else
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
        }

        public static Duration operator +(Duration left, Duration right) 
        {
            int totalSeconds = left.totalSeconds() + right.totalSeconds();
            return new Duration(totalSeconds);
        
        }
        public static Duration operator +(Duration left, int seconds) 
        {
            return new Duration(left.totalSeconds() + seconds);
        
        }
        public static Duration operator +(int seconds , Duration right) 
        {
            return new Duration( seconds + right.totalSeconds());
        
        }

        public static Duration operator ++(Duration d) 
        {
            int total = d.totalSeconds();
            return new Duration(total + 60); 
        }
        public static Duration operator --(Duration d) 
        {
            int total = d.totalSeconds();
            return new Duration(total - 60); 
        }

        public static Duration operator -(Duration left, Duration right) 
        {
         int total = left.totalSeconds() - right.totalSeconds();
         if (total < 0)
                total = 0;
         return new Duration(total);
        }

        public static bool operator >(Duration left, Duration right) 
        {
            if(left.totalSeconds() > right.totalSeconds())
                return true;
            else 
                return false;
            
        }
        public static bool operator <(Duration left, Duration right) 
        {
            if(left.totalSeconds() < right.totalSeconds())
                return true;
            else 
                return false;
            
        }

    }
}
