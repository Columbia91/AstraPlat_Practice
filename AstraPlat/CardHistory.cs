using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    class CardHistory
    {
        public int CardID { get; set; }                 // номер карточки
        public int TripsNumber { get; set; }            // количество поездок
        public int FreeTripsNumber { get; set; }        // количество бесплатных поездок
        public DateTime LastReplenishment { get; set; } // дата последнего пополнения

        #region Констукторы
        public CardHistory(int cardID, int tripsNumber, int freeTripsNumber, DateTime lastReplenishment)
        {
            CardID = cardID;
            TripsNumber = tripsNumber;
            FreeTripsNumber = freeTripsNumber;
            LastReplenishment = lastReplenishment;
        }
        #endregion
    }
}
