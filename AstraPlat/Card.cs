using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    class Card
    {
        private static int Count { get; set; }
        public int CardID { get; set; }         // номер карточки
        public string Type { get; set; }        // тип карточки
        public int Balance { get; set; }        // баланс карточки

        #region Конструкторы
        public Card(string type)
        {
            Count++;
            CardID = Count;
            Type = type;
        }
        public Card(string type, int balance) : this(type)
        {
            Count++;
            CardID = Count;
            Balance = balance;
        }
        #endregion
    }
}
