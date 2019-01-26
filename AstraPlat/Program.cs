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
            Card childCard = new Card("Детский", 2500);
            Card adultCard = new Card("Взрослый", 1200);
            Card expressChildCard = new Card("Экспресс-Детский", 3600);
            Card expressAdultCard = new Card("Экспресс-Взрослый", 4800);
            Card[] card = new Card[] { childCard, adultCard, expressChildCard, expressAdultCard };
            UseTerminal(card);
        }
        static void UseTerminal(Card[] card)
        {
            check = false;
            Random rnd = new Random();
            while (!check)
            {
                Console.Clear();
                Console.Write("\t\t\tAstra Plat" +
                "\n1) Приобрести карточку" +
                "\n2) Пополнить карточку" +
                "\n3) Узнать остаток баланса" +
                "\n4) Выйти" +
                "\n\nВыбор: ");

                check = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1: PurchaseCard(); break;
                    case 2: MakeDeposit(card[rnd.Next(card.Length)]); break;
                    case 3: RemainingBalance(); break;
                    case 4: Environment.Exit(0); break;
                    default: check = false; Console.Write("Ошибочный ввод. Нажмите ENTER чтобы ввести заново...");
                        Console.ReadKey(); break;
                }
            }
        }
        static void PurchaseCard()
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
                    case 1: Card childCard = new Card("Детский");
                        MakeDeposit(childCard); break;
                    case 2: Card adultCard = new Card("Взрослый");
                        MakeDeposit(adultCard); break;
                    case 3: Card expressChildCard = new Card("Экспресс-Детский");
                        MakeDeposit(expressChildCard); break;
                    case 4: Card expressAdultCard = new Card("Экспресс-Взрослый");
                        MakeDeposit(expressAdultCard); break;
                    default: check = false; Console.WriteLine("Ошибочный ввод"); break;

                }
            }
        }
        static void MakeDeposit(Card card)
        {
            int money = 0; const int MIN_SUM = 1000;
            check = false;
            while (!check)
            {
                Console.Clear();
                Console.Write("Сумма пополнения: ");
                check = int.TryParse(Console.ReadLine(), out money);
                if(money < MIN_SUM)
                {
                    Console.Write("Минимальная сумма пополнения составляет 1000 тенге, нажмите Backspace чтобы ввести заново...");
                    Console.ReadKey();
                    //ConsoleKey key = Console.ReadKey().Key;
                    check = false;
                }
            }
            card.Balance = money;
        }
        static int RemainingBalance()
        {
            return 0;
        }
    }
}
