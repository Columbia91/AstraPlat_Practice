using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    class Bus
    {
        private static int Count { get; set; }
        public int RouteNumber { get; set; }    // номер маршрута
        public string RouteType { get; set; }   // тип маршрута
        public int ValidatorNumber { get; set; } // номер терминала

        #region Конструкторы
        public Bus(int routeNumber, string routeType)
        {
            Count++;
            ValidatorNumber = Count;
            RouteNumber = routeNumber;
            RouteType = routeType;
        }
        #endregion
    }
}
