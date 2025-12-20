using System;

class HelloWorld
{
    public static void Main(string[] arg)
    {

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //                                                #                                                             //
        //                                              # #                                                             //
        //                                                #                                                             //
        //                                                #                                                             //
        //                                              #####                                                           //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // //---------------DAY1---1-NORMAL-PROGRAM--------------------
        // Console.WriteLine("\n");

        // Console.WriteLine("Hello World");
        // String name = Console.ReadLine();
        // Console.WriteLine(name);



        // //---------------DAY1----2-DATA-TYPES----------------------
        // Console.WriteLine("\n");

        // Data_Types dtObj = new Data_Types();
        // dtObj.PrintAll();

        // dtObj.Take_Input();
        // dtObj.PrintAll();



        // //---------------DAY1----3-QUESTION--------------------------
        // Console.WriteLine("\n");

        // Questions q = new Questions();
        // q.Ques();



        // //---------------DAY1----4-Employee--------------------------
        // Console.WriteLine("\n");

        // Employee emp1 = new Employee();
        // // emp1.AcceptDetails(1,"Sandeep","CSE",2000.45f,'M');
        // Console.WriteLine("\n\n");
        // emp1.AcceptDetails();

        // Console.WriteLine("\n");
        // emp1.DisplayDetails();
        // Console.WriteLine("\n");



        // //---------------DAY1----5-CALCULATOR APP--------------------
        // Console.WriteLine("\n");

        // Calculator cal = new Calculator();
        // cal.Add();
        // cal.Subtract();
        // cal.Multiply();
        // cal.Divide();
        // cal.Remainder();



        // //---------------DAY1----6-Check_Vowel-----------------------
        // Console.WriteLine("\n");

        // Vowel vowObj = new Vowel();
        // vowObj.Check();



        // //---------------DAY1----7-Convert-to-uppercase-and-find-length-and-print---------------
        // Console.WriteLine("\n");

        // ConvUpPrint cupObj = new ConvUpPrint();
        // cupObj.ConvertUpperPrint(); 



        // //---------------DAY1----8-Swap-two-number-without-using-third-variable----------------
        // Console.WriteLine("\n");

        // SwapTwoNumber swapObj = new SwapTwoNumber();
        // swapObj.swap();





        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //                                               # #                                                            //
        //                                              #   #                                                           //
        //                                                 #                                                            //
        //                                                #                                                             //
        //                                               #####                                                          //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // // --------------DAY2----9-Sum-of-5-number-------------------
        // Console.WriteLine("\n");

        // SumOfNumberWhile sumWhileObj = new SumOfNumberWhile();
        // sumWhileObj.sum();



        // // --------------DAY2---10-Do-while-Example------------------
        // Console.WriteLine("\n");

        // DoWhileExample doWhileObj = new DoWhileExample();
        // doWhileObj.Example1();



        // //---------------DAY2---11-Table-Using-For-Loop-----------------
        // Console.WriteLine("\n");

        // TableUsingForLoop tableObj = new TableUsingForLoop();
        // tableObj.table();



        // //---------------DAY2---12-Break-Continue-Example-----------------
        // Console.WriteLine("\n");

        // BreakContinueExample breakContObj = new BreakContinueExample();
        // breakContObj.BreakExample();
        // breakContObj.ContinueExample();



        // //--------------DAY2---13-BANK-Question---------------------------
        // Console.WriteLine("\n");

        // BankApp bankObj = new BankApp();
        // bankObj.runProgram();



        // //--------------DAY2---14-FINANCE-APP-----------------------------
        // Console.WriteLine("\n");


        // FinanceApp financeAppObj = new FinanceApp();
        // financeAppObj.runProgram();




        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //                                               ####                                                           //
        //                                                    #                                                         //
        //                                                ####                                                          //
        //                                                    #                                                         //
        //                                               #####                                                          //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // //--------------DAY3---15-CLASS-and-OBJECT-------------------------
        // Console.WriteLine("\n");

        // _15_BankAccount bankAccObj = new _15_BankAccount();
        // bankAccObj.AccNum = 101;
        // bankAccObj.Balance = 10000;
        // Console.WriteLine($"Account number is {bankAccObj.AccNum} and salary present is {bankAccObj.Balance}");
        // bankAccObj.Deposit(1234);
        // Console.WriteLine($"salary after deposite amount is {bankAccObj.Balance}");


        // _15_Employee empObj = new _15_Employee();
        // empObj.Name = "Sandeep";
        // empObj.Salary = 100000;
        // empObj.DisplayDetails();




        // //---------------DAY3---16-WALLET-PROGRAM--------------------------
        // Console.WriteLine("\n");

        // _16_Wallet walletObj = new _16_Wallet(1000);
        // double money = walletObj.GetMoney();
        // Console.WriteLine($"Money in your wallet is {money}");

        // walletObj.AddMoney(234);
        // money = walletObj.GetMoney();
        // Console.WriteLine($"Money in your wallet is {money}");




        // //--------------DAY3---17-FUNCTION-OVERLOADING------------------------
        // Console.WriteLine("\n");

        // Console.WriteLine("Sum is "+_17_FunctionOverloading.Add(1,2));

        // _17_FunctionOverloading funcOverObj = new _17_FunctionOverloading();
        
        // int intAns = funcOverObj.Add(1, 3);
        // Console.WriteLine("Sum is " + intAns);

        // double doubleAns = funcOverObj.Add(1.1, 3);
        // Console.WriteLine("Sum is " + doubleAns);

        // int threeIntAns = funcOverObj.Add(1, 2, 3);
        // Console.WriteLine("Sum is " + threeIntAns);

        // string strAns = funcOverObj.Add("Hello ", "CSharp");
        // Console.WriteLine("Result is " + strAns);

        // int paramsAns = funcOverObj.Add(1, 2, 3, 4, 5);
        // Console.WriteLine("Sum is " + paramsAns);




        // //--------------DAY3---18-PARAMETERS-and-ITs-TYPES--------------------
        // Console.WriteLine("\n");

        // _18_Parameters paraObj = new _18_Parameters();
        // paraObj.person("Sandeep","Ballia",21,12211815,"Lovely Professional University");
        // Console.WriteLine("");
        // paraObj.person("Sandeep","Ballia",21,12211815);
        // Console.WriteLine("");
        // paraObj.person(name:"Sandeep",city:"Ballia",age:21,rollNo:12211815,"IIT");
        // Console.WriteLine("");
        // paraObj.person(city:"Ballia",name:"Sandeep",rollNo:12211815,age:21,college:"IIT");
        // Console.WriteLine("");
        // //this will now show error becuse if position of the parameter are chaged then the default agrument names showuld br given
        // // paraObj.person(city:"Ballia",name:"Sandeep",rollNo:12211815,age:21,"IIT");

        // Console.WriteLine("");
        // paraObj.Params(1,2,3);
        // paraObj.Params3(1,"A","B","C"); //here will be become the name bydefualt even you dont want
        // paraObj.Params3(1,str: new string[]{"A","B","C"}); // so use this if default value to be used

        //this will also not work
        //paraObj.Params4(1,3,4,5,6); //compiler will treat 3 as the name input but error as string can not be converted to int
        // paraObj.Params4(1,arr: new int[]{3,4,5,6});

        // _18_Parameters p1Obj = new _18_Parameters();
        // p1Obj.Params(1,2,3,4,5);
        // p1Obj.Params(1,2,3,4,5,6,7);




        // //--------------DAY3---19-REF-OUT-EXAMPLE------------------------------
        // Console.WriteLine("");

        // _19_Refrencse refObj = new _19_Refrencse();
        // refObj.runProgram();




        // //-------------DAY3---20-CALCULATOR------------------------------------
        

    }
}
