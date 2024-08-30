using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Evolutionary_Algorithm_TSP {
    /// <summary>
    /// Class <c>Timer</c> Simple c# class, i'am not going into detail here since its just for measuring time and not really importent for the programm itsself.
    /// </summary>
    internal class Timer {

        private DateTime startTime;
        private DateTime endTime;
        public void StartTimer() {
            startTime = DateTime.Now;
        }
        public void StopTimer() {
            endTime = DateTime.Now;
        }
        public void CalculateDifference() {
            TimeSpan value = endTime.Subtract(startTime);
            Console.WriteLine("TimeSpan between start and end is {0} seconds, {1} microseconds.\n", value.TotalSeconds, value.TotalMicroseconds);
        }
    }
}
