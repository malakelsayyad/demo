using System.Security.AccessControl;

namespace demo
{
    internal class Program
    {
        #region Exception Handling and Protective Code
        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        X = int.Parse(Console.ReadLine());//FormatException
        //        Y = int.Parse(Console.ReadLine());//FormatException
        //        Z = X / Y; //DivideByZeroException

        //        int[] Arr = { 1, 2, 3 };
        //        // Arr[99] = 100;// IndexOutOfRangeException
        //    }
        //    catch (Exception E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }
        //    finally
        //    {
        //        //Console.WriteLine("Finally");
        //        // Disconnect | Dispose UnManaged Resource (File,DB)
        //    }
        //}

        //static void DoSomeProtectiveCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        bool Flag;

        //        do
        //        {
        //            Console.Write("Enter First Number:");
        //            Flag = int.TryParse(Console.ReadLine(), out X);
        //        } while (Flag == false);
        //        do
        //        {
        //            Console.Write("Enter Second Number:");
        //            Flag = int.TryParse(Console.ReadLine(), out Y);
        //        } while (Flag == false || Y == 0);


        //        int index;
        //        Z = X / Y; //Divide by zero exception



        //        int[] arr = { 1, 2, 3 };

        //        //arr[99] = 100;
        //    }catch(Exception E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            // Boxing and Unboxing
            // Boxing : casting from datatype [value type] to datatype [Reference type]
            // Unboxing : casting from datatype [Reference type] to datatype [value type] 

            // Boxing
            // object O1;
            // O1 : Can refer to instance from 'object' or any instance from any datatype
            // O1 =/*(object)*/1; // casting from int [value] to object [Reference]
            // O1 =/*(object)*/1.5; // casting from double [value] to object [Reference]
            // O1 = 'A';
            // O1 =true;
            // O1 = new DateTime();

            // int X = 12;
            // object O1 =/*(object)*/X;
            // Implicit casting 
            // Safe casting
            // Parent => child
            // Animal => dog : dog is an animal

            // Unboxing
            // object O1 = 1;
            // O1 = "Ahmed";

            // int X =(int)O1;
            // Explicit casting
            // Unsafe casting : may throw exception
            // Child => parent
            // Dog => (dog) Animal : animal is dog 

            // Console.WriteLine(X);

            #endregion

            #region Nullable Types
            #region Nullable Value Types

            // Nullable types

            // Value type 
            // Reference type

            // Value type 
            //int X = 12;
            //Console.WriteLine(X);

            // int Age = 30;
            // Age = null; // Invalid int dont allow null as valid value
            // Console.WriteLine(Age);

            // Nullable value type : Allows null as valid value

            // Nullabele<int> : Age :-> Allow ints value + null as valid value (Stack)
            // int? Age = 30;
            // Age = null;
            //Console.WriteLine(X);

            // Nullabele<double> : Salary :-> Allow ints value + null as valid value 
            // double? Salary = 20000;
            // Salary = null;
            // Console.WriteLine(Salary);

            // int X = 12;
            // Y :Nullabele<int> : Allow ints value + null as valid value 
            // int? Y = (int?)X;
            // Console.WriteLine(Y);

            //int? X = 12;
            //X = null;
            // Y : int : allows only ints value
            //int Y =(int) X;
            //Console.WriteLine(Y);

            // Protective code

            // int? X = 12;
            // X = null;
            // int Y;

            // if (X != null)
            // {
            //    Y = (int)X;
            // }
            // else
            // { 
            //  Y= 0;
            // }

            // if (X is not null)
            // {
            //    Y = (int)X;
            // }
            // else
            // {
            //    Y = 0;
            // }

            // if (X.HasValue)
            // {
            //    Y = X.Value;
            // }
            // else
            // {
            //    Y = 0;
            // }

            // Y=X.HasValue ? X.Value : 0;
            // Null coalescing operating
            // ??

            // Y = X ?? 0; //  Y=X.HasValue ? X.Value : 0;

            // Console.WriteLine(Y);

            #endregion

            #region Nullable Reference Types

            // Nullable reference types (C# 10.0 Dotnet 6.0)
            // Reference type : allow null as valid

            // string Message01 = null; // Required
            // string? Message02 = null; // Optional

            // Console.WriteLine(Message01);
            // Console.WriteLine(Message02);

            #endregion

            #endregion

            #region Null Propagation Operator 
            // Null Propagation Operator 
            // ?

            // DateTime X = default; 
            // Console.WriteLine(X);

            // int[] Arr = default; // null
            // int[] Arr = {1,2,3}; // null

            // Console.WriteLine(Arr);

            //NullReferenceException
            // for (int i = 0;(Arr is not null) && i < Arr.Length; i++)
            //  {
            // Console.WriteLine(Arr[i]);
            //  }

            // for (int i = 0; i < Arr?.Length; i++)
            //  {
            // Console.WriteLine(Arr[i]);
            //  }

            // if (Arr is not null)
            // {
            //    for (int i = 0; i < Arr.Length; i++)
            //  {
            // Console.WriteLine(Arr[i]);
            //  }
            // }

            // int Len = Arr is not null ? Arr.Length : 0;
            // int? Len = Arr?.Length;
            // int Len = Arr?.Length is not null ? Arr.Length : 0;
            // int Len = Arr?.Length ?? 0;  
            #endregion

            #region Exception Handling and Protective code

            // Exception Handling and Protective code
            // Exception : Runtime Errors

            // Console.WriteLine("Hello before exception");

            // throw new Exception();

            // Console.WriteLine("Hello after exception");

            // DoSomeCode();
            //DoSomeProtectiveCode();

            // Console.WriteLine("Hello after exception");

            // Exception :
            // 1.System Exception
            // 1.1 NullReferenceException
            // 1.2 FormatException
            // 1.3 IndexOutOfRangeException
            // 1.4 ArithmeticException
            // 1.4.1 DivideByZeroException
            // 1.4.2 OverflowException

            // 2.Application Exception

            #endregion

            // Class Library

            // Common.TypeA typeA = new TypeA(); // Invalid TypeA is internal
            // Common.TypeB typeB = new TypeB(); // valid TypeB is public

            // typeB.X = 12; // invalid Private
            // typeB.Y = 12; // invalid Internal
            // typeB.Z = 12; // valid
        }

    }
}
