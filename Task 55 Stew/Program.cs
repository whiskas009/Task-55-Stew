using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_55_Stew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CanStew> cansStew = new List<CanStew>(){
            new CanStew("Высший сорт", 2001, 2011),
            new CanStew("Высший сорт", 2002, 2012),
            new CanStew("Высший сорт", 2003, 2013),
            new CanStew("Белорусская", 2005, 2025),
            new CanStew("Белорусская", 2005, 2025),
            new CanStew("Белорусская", 2005, 2025),
            new CanStew("Гродфуд", 2006, 2015),
            new CanStew("Гродфуд", 2006, 2015),
            new CanStew("Гродфуд", 2007, 2016),
            new CanStew("Гродфуд", 2008, 2017)};

            int currentYear = 2020;

            var overdueStew = cansStew.Where(canStew => canStew.ExpirationDate < currentYear);

            Console.WriteLine($"Текущий год: {currentYear}\n");
            Console.WriteLine("Просроченная тушенка: \n");

            foreach (var canStew in overdueStew)
            {
                canStew.ShowInfo();
            }
        }
    }

    class CanStew
    {
        public string Name { get; private set; }
        public int YearProduction { get; private set; }
        public int ExpirationDate { get; private set; }

        public CanStew(string name, int yearProduction, int expirationDate)
        {
            Name = name;
            YearProduction = yearProduction;
            ExpirationDate = expirationDate;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Тушенка: {Name}. Год выпуска: {YearProduction}. Срок годности: {ExpirationDate}.");
        }
    }
}
