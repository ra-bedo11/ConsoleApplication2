using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        struct person
        {
            public int id;
            public string name;
        }
        enum gender
        {
            male, female
        }
        static void Main(string[] args)
        {
            //   bool res;
            // int myvar1 = 6, myvar2 = 9;
            //res = myvar1 == myvar2;
            //Console.WriteLine("the result {0}",res);

            //double sal = 10500.5, total = 0.0;
            //int myvar = 0;
            //do
            //{
            //    total += sal;
            //    ++myvar;
            //} while (myvar < 5);
            //Console.WriteLine("the total sal {0}", total);

            //for (int x = 0;x <=3;x++) {
            //    Console.WriteLine("Hello Mr.Abdallah");
            //    for (int y =0 ; y <=2 ; y++) {
            //        Console.WriteLine("\t sasa and yoyo");
            //    }
            //    Console.WriteLine("\n");
            //}

            //for (int x=1;x<=6;x++) {
            //    //Console.WriteLine("{0}", x);
            //    for (int y=1;y<=6;y++) {
            //        Console.WriteLine("\t" + "  " + x + " * " + y + " = " +  x * y );
            //    }
            //    Console.WriteLine("\n");
            //}

            //gender f = gender.male;
            //Console.WriteLine(f.ToString()) ;
            //}

            person p = new person();
            Console.WriteLine("Enter Name");
            p.name = Console.ReadLine();
            Console.WriteLine("Enter ID");
            p.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Are u male ? ");
            string genders = Console.ReadLine();
            switch (genders) {
                case "yes":
                    //Console.WriteLine(gender.male);
                    genders = Convert.ToString(gender.male);
                    break;
                case "no":
                    //Console.WriteLine(gender.female);
                    genders = gender.female.ToString();
                    break;
            }
            Console.WriteLine("my name is : {0} and id is : {1}  and ur is : {2}", p.name, p.id, genders);

        }
    }
}
