using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    public struct CardHistory
    {
        public int TripsNumber;           // количество поездок
        public int TransfersCount;
        public DateTime LastReplenishment; // дата последнего пополнения
        public DateTime ValidatonTime;

        #region Констукторы
        //public CardHistory(int tripsNumber)
        //{
        //    TripsNumber = tripsNumber;
        //}
        //public CardHistory(DateTime dateTime)
        //{
        //    LastReplenishment = dateTime;
        //}
        //public CardHistory(int tripsNumber, int freeTripsNumber) : this(tripsNumber)
        //{
        //    FreeTripsNumber = freeTripsNumber;
        //}
        //public CardHistory(int tripsNumber, int freeTripsNumber, DateTime lastReplenishment) : this(tripsNumber, freeTripsNumber)
        //{
        //    LastReplenishment = lastReplenishment;
        //}
        #endregion
    }
}
