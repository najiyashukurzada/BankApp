using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        loginbp:
            Console.Write("username: ");
            string username = Console.ReadLine();
            Console.Write("password: ");
            string password = Console.ReadLine();
            int mebleg = 0;
            int ay = 0;
            int faiz = 0;
            int odenilecekMebleg = 0;
            int ayliqOdenis = 0;
            int qalanAy = 0;
            if (username == "admin" && password == "admin")
            {
            menu:
                Console.WriteLine($"Welcome {username}");
                Console.WriteLine("1.Kredit goturmek \n2.Kredit odemek \n3.Hesabat");
                Console.Write("Emeliyyat: ");
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                    caseta:
                        Console.WriteLine("goturmek");
                        Console.Write("Ay daxil edin :");
                        ay = Int32.Parse(Console.ReadLine());
                        Console.Write("Meblegi daxil edin: ");
                        mebleg = Int32.Parse(Console.ReadLine());
                        if (ay > 0 && ay <= 12)
                        {
                            qalanAy = ay;
                            faiz = 12;
                            odenilecekMebleg = mebleg + (mebleg * faiz) / 100;
                            ayliqOdenis = odenilecekMebleg / ay;
                            Console.WriteLine($"Umumi odenilecek mebleg: {odenilecekMebleg}\nAyliq Odenis: {ayliqOdenis}");
                            Console.WriteLine("Razisinizmi? \n1.Beli \n2.Xeyr");
                            string secim = Console.ReadLine();
                            if (secim == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("Emeliyyat ugurlu oldu !");

                                goto menu;
                            }
                            else if (secim == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("Emeliyyat ugursuz oldu !");
                                faiz = 0;
                                odenilecekMebleg = 0;
                                ayliqOdenis = 0;
                            }
                            else
                            {
                                Console.WriteLine("Daxil etdiyiniz emeliyyat movcud deyil");
                            }

                        }
                        else if (ay > 12)
                        {
                            qalanAy = ay;
                            faiz = 18;
                            odenilecekMebleg = mebleg + (mebleg * faiz) / 100;
                            ayliqOdenis = odenilecekMebleg / ay;
                            Console.WriteLine($"Umumi odenilecek mebleg: {odenilecekMebleg}\nAyliq Odenis: {ayliqOdenis}");
                            Console.WriteLine("Razisinizmi? \n1.Beli \n2.Xeyr");
                            string secim = Console.ReadLine();
                            if (secim == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("Emeliyyat ugurlu oldu !");

                                goto menu;
                            }
                            else if (secim == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("Emeliyyat ugursuz oldu !");
                                faiz = 0;
                                odenilecekMebleg = 0;
                                ayliqOdenis = 0;
                            }
                            else
                            {
                                Console.WriteLine("Daxil etdiyiniz emeliyyat movcud deyil");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Daxil etdiyiniz muddet duzgun deyil !");
                            Console.WriteLine("Yeniden cehd edin !");
                            goto caseta;
                        }
                        break;
                    case "2":
                        Console.WriteLine("odemek");
                        Console.WriteLine($"Odenilecek mebleg : {odenilecekMebleg} \nAyliq Odenis : {ayliqOdenis}");
                        if (ayliqOdenis > odenilecekMebleg)
                        {
                            Console.WriteLine($"Odenilecek mebleg : {odenilecekMebleg} \nAyliq Odenis : {ayliqOdenis} \nQalan ay : {qalanAy}");
                            Console.WriteLine("Odenis click 1");
                            if (Console.ReadLine() == "1")
                            {
                                odenilecekMebleg = 0;
                                Console.WriteLine("Sizin borcunuz yoxdur !");
                                ayliqOdenis = 0;
                                qalanAy = 0;
                                goto menu;
                            }
                            else
                            {
                                Console.WriteLine("Bele emeliyyat yoxdur !");
                            }

                        }
                        else
                        {
                            Console.Write("Odemek ucun 1 click edin : ");

                            if (Console.ReadLine() == "1")
                            {
                                odenilecekMebleg = odenilecekMebleg - ayliqOdenis;
                                qalanAy = qalanAy - 1;
                                Console.WriteLine("Odenis ugurlu oldu !");
                                Console.WriteLine($"Odenilecek mebleg : {odenilecekMebleg} \nAyliq Odenis : {ayliqOdenis} \nQalan ay : {qalanAy}");
                                goto menu;

                            }
                            else
                            {
                                Console.WriteLine("Odenis ugursuz oldu !");
                                goto menu;
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("hesabat");
                        Console.WriteLine($"Odenilecek mebleg : {odenilecekMebleg} \nAyliq Odenis : {ayliqOdenis}");
                        goto menu;
                    default:
                        Console.WriteLine("Bele emeliyyat yoxdur duzgun daxil edin !");
                        goto menu;
                }


            }
            else
            {
                Console.WriteLine("invalid username or password");
                Console.Clear();
                goto loginbp;
            }

        }
    }
}
