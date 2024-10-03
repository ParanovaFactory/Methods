using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //void list(string[] cities)
            //{
            //    foreach (string c in cities)
            //    {
            //        Console.WriteLine(c);
            //    }
            //}

            //string[] city = { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkâri", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kilis", "Kırıkkale", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Şanlıurfa", "Siirt", "Sinop", "Sivas", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };
            //list(city);


            //void sum(int s1, int s2)
            //{
            //    Console.WriteLine(s1 + s2);
            //}

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //sum(num1, num2);


            //void personInfo(string name, string surname, string city)
            //{
            //    Console.WriteLine(name + " " + surname + " " + city);
            //}
            //string Name = Console.ReadLine();
            //string Surname = Console.ReadLine();
            //string City = Console.ReadLine();

            //personInfo(Name, Surname, City);


            //void personInfo(string name, string surname, double exam1, double exam2, double exam3)
            //{
            //    double avg = (exam1 + exam2 + exam3) / 3;
            //    Console.WriteLine(name + " " + surname + " " + exam1 + " " + exam2 + " " + exam3 + " " + avg);
            //}
            //string Name = Console.ReadLine();
            //string Surname = Console.ReadLine();
            //double Exam1 = double.Parse(Console.ReadLine());
            //double Exam2 = double.Parse(Console.ReadLine());
            //double Exam3 = double.Parse(Console.ReadLine());

            //personInfo(Name, Surname, Exam1, Exam2, Exam3);


            int sum(int[] nums)
            {
                int result = 0;
                foreach (int x in nums)
                {
                    result += x;
                }
                return result;
            }

            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(sum(ints));
        }
    }
}
