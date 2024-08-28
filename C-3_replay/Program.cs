namespace C_3_replay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting
            ////1. Implicet Casting (Safe Casting) -Automatic- SmoleDataType => LargerDataType
            //int X = 10;
            //long Y = 9999999999; // => this is implicet Casting

            ////2. Explicit Casting (UnSafe Casting) -Maniwal- LargerDataType => SmoleDataType => DataLose 
            //try
            //{

            //    checked // return Exception if thir is Error
            //    {
            //        X = (int)Y; // OverFlowing
            //    }

            //    Console.WriteLine(X);
            //}
            //catch (Exception Ex)
            //{
            //    Console.WriteLine(Ex.Message);
            //    Console.WriteLine("Console Have Proplem in Casting -OverFlowing-");
            //}

            //Parse Method
            // will throe Excption if Input Was Not Wrong
            //int age;
            //    Console.WriteLine("enter the Name");
            //string name =Console.ReadLine(); 
            //    Console.WriteLine("enter the Number");
            //age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Hello  "+ name +"  Your Age     "+ age );

            //TryParse
            //more safe
            //int age;
            //Console.WriteLine("enter the Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("enter the Age");
            //bool result= int.TryParse(Console.ReadLine(),out age);

            //Console.WriteLine("Hello  " + name + "  Your Age     " + age);





            #endregion

            #region Operators

            #endregion

            #region String Formating
            //Equation : 4 + 2 = 6
            //int X = 4, Y = 2;
            //int Z = X + Y;
            //string Concatenation
            //string equation = "Equation :" + X + "  +   " + Y + "   =   " + Z;
            // Console.WriteLine(equation);

            //Composit formating
            // Console.WriteLine("Equation : {0} + {1} = {2}",X,Y,Z);

            //string Interpolation
            //string Equation = $"Equation : {X} +{Y}  = {Z}";
            //Console.WriteLine( Equation );


            #endregion

            #region Conditional Statment
            // If - switch
            //int MonthNumber = int.Parse(Console.ReadLine());
            //if (MonthNumber == 1) { Console.WriteLine("Jan"); }
            //else if (MonthNumber == 2) { Console.WriteLine("Feb"); }
            //else if (MonthNumber == 3) { Console.WriteLine("Mar"); }
            //else if (MonthNumber == 4) { Console.WriteLine("INvaled"); }

            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    case 4:
            //        Console.WriteLine("Invaled");
            //        break;

            //int Value = 3000;
            //switch (Value)
            //{
            //        case 3000:
            //        Console.WriteLine("option 03");
            //        //Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        goto case 2000;
            //    case 2000:
            //        //Console.WriteLine("option 01");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;
            //}
            //result: Console.WriteLine("1");

            #endregion

            #region Loops Statements
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);
            // For Loop

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i+",");
            }

            #endregion

        }
    }
}

