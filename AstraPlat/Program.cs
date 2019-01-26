using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    class Program
    {
        static int choice;
        static bool check;
        static void Main(string[] args)
        {
            Random rnd = new Random();
            const int CITY_ROUTE_COUNT = 50;
            const int EXPRESS_ROUTE_COUNT = 10;
            const int BEGIN_NUMB_EXPRESS_ROUTE = 100;

            Bus[] cityBus = new Bus[CITY_ROUTE_COUNT];
            Bus[] expressBus = new Bus[EXPRESS_ROUTE_COUNT];

            for (int i = 0; i < cityBus.Length; i++)
            {
                cityBus[i] = new Bus(i+1, "Городской");
            }
            for (int i = BEGIN_NUMB_EXPRESS_ROUTE; i < expressBus.Length; i++)
            {
                expressBus[i] = new Bus(i+1, "Экспресс");
            }
            
            Trip(GoToCass(), cityBus, expressBus);
        }

        #region Пойти в кассу
        static Card GoToCass()
        {
            check = false;
            Random rnd = new Random();
            Card card = new Card();
            while (!check)
            {
                Console.Clear();
                Console.Write("\t\t\tAstra Plat" +
                "\n1) Приобрести карточку" +
                "\n2) Выйти" +
                "\n\nВыбор: ");

                check = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1: PurchaseCard(card); break;
                    case 2: Environment.Exit(0); break;
                    default: check = false; Console.Write("Ошибочный ввод. Нажмите ENTER чтобы ввести заново...");
                        Console.ReadKey(); break;
                }
            }
            return card;
        }
        #endregion

        #region Приобрести карточку
        static void PurchaseCard(Card card)
        {
            check = false;
            while (!check)
            {
                Console.Clear();
                Console.Write("\t\t\tAstra Plat" +
                "\n1) Детский" +
                "\n2) Взрослый" +
                "\n3) Экспресс-Детский" +
                "\n4) Экспресс-Взрослый" +
                "\n\nВыбор: ");

                check = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1: card.Type = "Детский"; MakeDeposit(card); break;
                    case 2: card.Type = "Взрослый"; MakeDeposit(card); break;
                    case 3: card.Type = "Экспресс-Детский"; MakeDeposit(card); break;
                    case 4: card.Type = "Экспресс-Взрослый"; MakeDeposit(card); break;
                    default: check = false; Console.Write("Ошибочный ввод. Нажмите ENTER чтобы ввести заново...");
                        Console.ReadKey(); break;
                }
            }
        }
        #endregion

        #region Пополнить карточку
        static void MakeDeposit(Card card)
        {
            int money = 0; const int MIN_SUM = 100;
            check = false;
            while (!check)
            {
                Console.Clear();
                Console.Write("Сумма пополнения: ");
                check = int.TryParse(Console.ReadLine(), out money);
                if(money < MIN_SUM)
                {
                    Console.Write("Минимальная сумма пополнения составляет {0} тенге, нажмите ENTER чтобы ввести заново...", MIN_SUM);
                    Console.ReadKey();
                    check = false;
                }
            }
            card.Balance = money;
            try
            {
                card.CardHistory(DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        #endregion

        #region Проверка баланса
        static int RemainingBalance()
        {

            return 0;
        }
        #endregion

        #region Поездка
        static void Trip(Card card, Bus[] cityBus, Bus[] expressBus)
        {
            check = false;
            while (!check)
            {
                Console.Write("Сесть в:" +
                    "\n- Городской маршрут (1-50)" +
                    "\n- Экспресс маршрут (101-110)" +
                    "\n\nВыбор: ");
                check = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1: break;
                    case 2: break;
                    default:
                        check = false; Console.Write("Ошибочный ввод. Нажмите ENTER чтобы ввести заново...");
                        Console.ReadKey(); break;
                }
            }
        }
        #endregion
    }
}
