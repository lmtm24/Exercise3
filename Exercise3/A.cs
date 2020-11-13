using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
	public class A
	{
        List<String> values = new List<String>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " "};
        public String word1, word2;
        List<int> intvalues = new List<int>() { 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };

        public void stringComparison(String text1, String text2)
        {
             word1= text1;
             word2 = text2;
            int l1, l2;
            l1 = word1.Length;
            l2 = word2.Length;
            if (l1 == l2)
            {
                Console.WriteLine("Equals");
            }
            else
                Console.WriteLine("Different");

        }

        public void listcomparion()
        {
            List<int> x = new List<int>() { 3, 5, 3, 2, 7 };
            List<int> y = new List<int>() { 3, 5, 3, 7 };
            int listx, listy;
            listx = x.Count;
            listy = y.Count;
            bool isEqual = listx.Equals(listy);
            if (isEqual)
            {
                Console.WriteLine("Lists Lenght are Equal");
            }
            else
            {
                Console.WriteLine("Lists Lenght are not Equal");
            }
        }
        public void orderValues(String orderby)
        {
            if (orderby == "asc")
            {
                var desc = from treeName in values
                           orderby treeName descending
                           select treeName;

                foreach (string value in desc)
                {
                    Console.WriteLine(value);
                }
            }
            else if (orderby == "desc")
            {
                var asc = from treeName in values
                          orderby treeName ascending
                          select treeName;
                foreach (string value in asc)
                {
                    Console.WriteLine(value);
                }
            }         

        }

        public void filter()
        {
            String space = " ";
            foreach (string value in values)
            {
                int pos=value.IndexOf(" ");
                if (value.Contains(space))
                {
                    value.Remove(pos);
                }
                else {
                    Console.WriteLine(value);
                }
                
                
            }
        }

        public void removeduplicates()
        {

            List<int> distinct = intvalues.Distinct().ToList();
            foreach (var values in distinct)
            {
                Console.WriteLine(values);

            }
            
        }

        public static void Main(string[] args)
        {
            A parent = new A();
            B child = new B();
            Console.WriteLine("-------Lenght-----");
            parent.stringComparison("Hola","Hola");
            Console.WriteLine("-------List-----");
            parent.listcomparion();
            Console.WriteLine("-------Inherits -----");
            Console.WriteLine(child.changingText());
            child.stringComparison(child.word1, child.word2);
            Console.WriteLine("-------Interface-----");
            child.print();
            Console.WriteLine("-------Ordering Values-----");
            parent.orderValues("desc");
            Console.WriteLine("-------Filter-----");
            parent.filter();
            Console.WriteLine("-------removeduplicates-----");
            parent.removeduplicates();

        }
    }
}
