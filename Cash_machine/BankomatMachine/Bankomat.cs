using System;

namespace BankomatMachine
{
    public static class Bankomat
    {
        //свойства класса
        public static string Address { get; set; }//адрес банкомата
        public static string SupportFIO { get; set; }//ФИО поддержки
        public static double Roubles { get; set; }//всего доступно рублей
        public static double Dollars { get; set; }//всего доступно долларов
        public static double DollarsCours { get; set; }//курс доллара

        //конструктор класса
        static Bankomat()
        {
            Address = "Лубянка 1";
            SupportFIO = "Феликсов Феликс Феликсович";
            Roubles = 800000;
            Dollars = 400000;
            DollarsCours = 60.35;
        }

        //метод снять деньги
        public static double WithdrawMoney(int accountNumber, double amount)
        {
            Console.WriteLine("... снимаем деньги со счета {0}...", accountNumber);
            if (Roubles >= amount)
            {
                Console.WriteLine("Операция прошла успешно. Заберите ваши деньги и карту\n");
                Roubles = Roubles - amount;
                return amount;
            }
            Console.WriteLine("Ошибка. В банкомате недостаточно стредств\n");
            return 0;
        }

        //метод зачислить деньги
        public static void PutMoney(int accountNumber, double amount)
        {
            Console.WriteLine("... кладем деньги на счет {0}...", accountNumber);
            Console.WriteLine("Операция прошла успешно. Заберите вашу карту\n");
            Roubles = Roubles + amount;
        }

        //метод обменять рубли на доллары
        public static double ChangeRouble(double amount)
        {
            double result = amount / DollarsCours;
            Console.WriteLine("...обмениваем рубли на доллары...");
            if (Dollars >= amount)
            {
                Console.WriteLine("Операция прошла успешно. Заберите ваши деньги и карту\n");
                Dollars = Dollars - result;
                return result;
            }
            Console.WriteLine("Ошибка. В банкомате недостаточно стредств\n");
            return 0;
        }

        //метод обменять доллары на рубли
        public static double ChangeDollar(double amount)
        {
            double result = amount * DollarsCours;
            Console.WriteLine("...обмениваем доллары на рубли...");
            if (Roubles >= amount)
            {
                Console.WriteLine("Операция прошла успешно. Заберите ваши деньги и карту\n");
                Roubles = Roubles - result;
                return result;
            }
            Console.WriteLine("Ошибка. В банкомате недостаточно стредств\n");
            return 0;
        }
    }
}