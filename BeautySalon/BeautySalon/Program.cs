using System;

namespace BeautySalon
{
    class Program
    {
        static int sum;

        static void CutHair()
        {
            Console.WriteLine("Стрижка. Наши мастера помогут вам сменить длину волос и сделать модную стрижку ");
            Console.WriteLine("Если мы вас заинтересовали и вам интересно узнать о стоимости нажмите 1, если нет то что-то другое ");
            int cut = Convert.ToInt32(Console.ReadLine());
            if (cut == 1)
            {
                Console.WriteLine("Стоимость: $30");
            }
            Console.WriteLine("Так же можем предложить другие услуги: 1-помыть голову за $7 + Подстричь за $30, либо сет 2 - помыть голову+укладка+стрижка за $57, 3 - только стрижка - $30");
            Console.WriteLine("Если хотите что-то добавить из перечисленного, нажмите нужную цифру, если нет нажмите 0");
            int set = Convert.ToInt32(Console.ReadLine());
            if (set == 1)
            {
                sum += 37;
            }
            else if (set == 2)
            {
                sum += 57;
            }
            else if (set == 3)
            {
                sum += 30;
            }
            else if (set == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Вы не вверно ввели число");
            }
        }

        static void StyleHair()
        {
            Console.WriteLine("Укладка. Наши мастера помогут вам сделать ваши волосы отлично уложить или сделать прическу  ");
            Console.WriteLine("Если мы вас заинтересовали и вам интересно узнать о стоимости нажмите 22");
            int desing = Convert.ToInt32(Console.ReadLine());
            if (desing == 22)
            {
                Console.WriteLine("Стоимость: $30");
            }
            Console.WriteLine("Так же можем предложить другие услуги: 1-помыть голову за $7 и уложить $30,  2 - только укладка - $30");
            Console.WriteLine("Если хотите что-то добавить из перечисленного, нажмите нужную цифру, если нет нажмите 0");
            int set = Convert.ToInt32(Console.ReadLine());
            if (set == 1)
            {
                sum += 37;
            }
            else if (set == 2)
            {
                sum += 30;
            }
            else if (set == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Вы не вверно ввели число");
            }
        }

        static void LashDesing()
        {
            Console.WriteLine("Ламинирование ресниц. Наши мастера помогут вам улучшить внешний вид ресниц и так же увеличить густоту ");
            Console.WriteLine("Если мы вас заинтересовали и вам интересно узнать о стоимости нажмите 41");
            int lash = Convert.ToInt32(Console.ReadLine());
            if (lash == 41)
            {
                Console.WriteLine("Стоимость: $45");
            }
            Console.Write("Хотите воспользоваться этой услугой? 1 - ДА, 2 - НЕТ");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                sum += 45;
            }
            else
            {
                Console.WriteLine("Вы не вверно ввели число");
            }

        }

        static void ColorHair()
        {
            Console.WriteLine("Окрашевание волос. Наши мастера помогут вам сменить ваш образ и стильно воплотить ваши задумки  ");
            Console.WriteLine("Если мы вас заинтересовали и вам интересно узнать о стоимости нажмите 31");
            String color = Console.ReadLine();
            if (color == "31")
            {
                Console.WriteLine("Стоимость: $50");
            }
            Console.WriteLine("Так же можем предложить другие услуги: сет 1 - помыть голову+укладка+стрижка за $100, 2 - только окрашивание - $50, 3 - укладка+окрашевание - $70");
            Console.WriteLine("Если хотите что-то добавить из перечисленного, нажмите нужную цифру, если нет нажмите 0");
            int set = Convert.ToInt32(Console.ReadLine());
            if (set == 1)
            {
                sum += 100;
            }
            else if (set == 2)
            {
                sum += 50;
            }
            else if (set == 3)
            {
                sum += 70;
            }
            else if (set == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("Вы не вверно ввели число");
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Добрый день! Мы рады преветствовать в нашем салоне");
            Console.WriteLine("Мы предлагаем ращные услуги, ознакомится с которыми вы можете ниже");
            Console.WriteLine("Услуги: 1) Стрижка, 2) Укладка, 3) Окрашивание волос, 4) Ламинирование ресниц; 0) если хотите выйти ");
            Console.WriteLine("Если хотите узнать подробно об услугах, введите номер это услуги в консоле");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                if (number <= 4 && number > 0)
                {
                    switch (number)
                    {
                        case 1:
                            CutHair();
                            break;
                        case 2:
                            StyleHair();
                            break;
                        case 3:
                            ColorHair();
                            break;
                        case 4:
                            LashDesing();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы неправильно ввели номер услуги");
                }
                Console.WriteLine("Если есть желание посмотреть описание других услуг, нажмите цифру, той услуги, которая вам интересна ");
                Console.WriteLine("Услуги: 1) Стрижка, 2) Укладка, 3) Окрашивание волос, 4) Ламинирование ресниц; 0) если хотите выйти ");
                number = Convert.ToInt32(Console.ReadLine());

            }
            if (sum > 0)
            {
                Console.WriteLine("Ваш счет составляет: $" + sum);
            }
            Console.WriteLine("Спасибо, что были с нами");
        }
    }
}
