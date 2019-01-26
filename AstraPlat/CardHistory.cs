using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    public class CardHistory
    {
        public int TripsNumber { get; set; }            // количество поездок
        public int FreeTripsNumber { get; set; }        // количество бесплатных поездок
        public DateTime LastReplenishment { get; set; } // дата последнего пополнения

        #region Констукторы
        public CardHistory(int tripsNumber)
        {
            TripsNumber = tripsNumber;
        }
        public CardHistory(DateTime dateTime)
        {
            LastReplenishment = dateTime;
        }
        public CardHistory(int tripsNumber, int freeTripsNumber) : this(tripsNumber)
        {
            FreeTripsNumber = freeTripsNumber;
        }
        public CardHistory(int tripsNumber, int freeTripsNumber, DateTime lastReplenishment) : this(tripsNumber, freeTripsNumber)
        {
            LastReplenishment = lastReplenishment;
        }
        #endregion
    }
}
