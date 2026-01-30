using System;
using System.Text.RegularExpressions;
using static System.Math;

using SmartHomeSecurity;
using HelloWorldApp.Day3;
using EcommerceAssessment;

class HelloWorld
{
        public static void Main(string[] arg)
        {

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //                                                                                                               //
                //                                                    #                                                          //
                //                                                  # #                                                          //
                //                                                    #                                                          //
                //                                                    #                                                          //
                //                                                    #                                                          //
                //                                                  #####                                                        //
                //                                                                                                               //
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                // //---------------DAY1---1-NORMAL-PROGRAM--------------------
                // Console.WriteLine("\n");

                // Console.WriteLine("Hello World");
                // String name = Console.ReadLine();
                // Console.WriteLine(name);



                // //---------------DAY1----2-DATA-TYPES----------------------
                // Console.WriteLine("\n");

                // _2_Program _2_dataTypesObj = new _2_Program();
                // _2_dataTypesObj.Main();



                // //---------------DAY1----3-QUESTION--------------------------
                // Console.WriteLine("\n");

                // _3_Questions_Program _3_questionsObj = new _3_Questions_Program();
                // _3_questionsObj.Main();




                // //---------------DAY1----4-Employee--------------------------
                // Console.WriteLine("\n");

                // _4_Program _4_employeeObj = new _4_Program();
                // _4_employeeObj.Main();



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





                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //                                                                                                               //
                //                                                 ###                                                           //
                //                                                #   #                                                          //
                //                                                    #                                                          //
                //                                                   #                                                           //
                //                                                 #                                                             //
                //                                                #####                                                          //
                //                                                                                                               //
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                // //---------------DAY2----9-Sum-of-5-number-------------------
                // Console.WriteLine("\n");

                // SumOfNumberWhile sumWhileObj = new SumOfNumberWhile();
                // sumWhileObj.sum();



                // //---------------DAY2---10-Do-while-Example------------------
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



                // //---------------DAY2---13-BANK-Question---------------------------
                // Console.WriteLine("\n");

                // BankApp bankObj = new BankApp();
                // bankObj.runProgram();



                // //---------------DAY2---14-FINANCE-APP-----------------------------
                // ---------Project Finance APP--------------
                // Located in PROJECT folder




                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //                                                                                                               //
                //                                                #####                                                          //
                //                                                    #                                                          //
                //                                                #####                                                          //
                //                                                    #                                                          //
                //                                                #####                                                          //
                //                                                                                                               //
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                // //---------------DAY3---15-CLASS-and-OBJECT-------------------------
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




                // //---------------DAY3---17-FUNCTION-OVERLOADING------------------------
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




                // //---------------DAY3---18-PARAMETERS-and-ITs-TYPES--------------------
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




                // //---------------DAY3---19-REF-OUT-EXAMPLE------------------------------
                // Console.WriteLine("");

                // _19_Refrencse refObj = new _19_Refrencse();
                // refObj.runProgram();




                // //---------------DAY3---20-CALCULATOR--FUNCTION-INSIDE-FUNCTION--------------------------------
                // Console.WriteLine("");

                // _20_Calculator calObj = new _20_Calculator();
                // calObj.calculate(10,23);




                // //---------------DAY4---21-LAMDA-FUNCTION-EXAMPLE------------------------------------------------
                // Console.WriteLine("");

                // _21_Lamda_Static lamdaStaticObj = new _21_Lamda_Static();

                // Console.WriteLine("---------------Lamda Example------------------");
                // lamdaStaticObj.ExampleLamda();

                // Console.WriteLine("\n---------------Static Example-----------------");
                // lamdaStaticObj.ExampleStatic(); // non static function can use static variables
                // _21_Lamda_Static.ExampleStatic2();  // static function can not use non static variables




                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //                                                                                                               //
                //                                                #   #                                                          //
                //                                                #   #                                                          //
                //                                                #####                                                          //
                //                                                    #                                                          //
                //                                                    #                                                          //
                //                                                                                                               //
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                // //---------------DAY4---22---CONSTRUCTER---------------------------------------
                // Console.WriteLine("");

                // _22_Constructor obj1 = new _22_Constructor();
                // obj1.DisplayDetails();

                // _22_Constructor obj2 = new _22_Constructor("Rahul", 12);
                // obj2.DisplayDetails();

                // obj1.Constructor();
                // obj1.DisplayDetails();



                // //-----------------DAY4---23--INHERITANCE--------------------------------------
                // Console.WriteLine("");

                // Console.WriteLine("----- ACCESS MODIFIER + CONSTRUCTOR CHAINING -----");
                // _23_FixedDeposit fd = new _23_FixedDeposit("Sandeep");
                // fd.DisplayDetails();

                // Console.WriteLine("\n----- SINGLE INHERITANCE -----");
                // _23_Car car = new _23_Car();
                // car.Start();
                // car.Drive();

                // Console.WriteLine("\n----- CONSTRUCTOR CHAINING (base) -----");
                // _23_Student student = new _23_Student("Amit", 101);
                // Console.WriteLine(student.Name);
                // Console.WriteLine(student.RollNo);

                // Console.WriteLine("\n----- MULTILEVEL INHERITANCE -----");
                // _23_Employee emp = new _23_Employee();
                // emp.Breathe();
                // emp.Think();
                // emp.Work();

                // Console.WriteLine("\n----- HIERARCHICAL INHERITANCE -----");
                // _23_Circle circle = new _23_Circle();
                // _23_Rectangle rectangle = new _23_Rectangle();
                // circle.Draw();
                // rectangle.Draw();

                // Console.WriteLine("\n----- MULTIPLE INHERITANCE USING INTERFACES -----");
                // _23_Machine machine = new _23_Machine();
                // machine.Print();
                // machine.Scan();

                // Console.WriteLine("\n----- METHOD OVERRIDING (RUNTIME POLYMORPHISM) -----");
                // _23_Animal animal = new _23_Dog();
                // animal.Sound();

                // Console.WriteLine("\n----- base KEYWORD WITH OVERRIDING -----");
                // _23_AnimalBase dogBase = new _23_DogDerived();
                // dogBase.Speak();

                // Console.WriteLine("\n----- METHOD HIDING -----");
                // _23_ParentHide p = new _23_ChildHide();
                // p.Show();
                // _23_ChildHide c = new _23_ChildHide();
                // c.Show();

                // Console.WriteLine("\n----- STATIC METHOD HIDING -----");
                // _23_StaticA.Display();
                // _23_StaticB.Display();

                // Console.WriteLine("\n----- SEALED CLASS -----");
                // _23_Security security = new _23_Security();
                // security.Access();

                // Console.WriteLine("\n----- SEALED METHOD -----");
                // _23_Parent parent = new _23_Child();
                // parent.Show();

                // Console.WriteLine("\n----- COMPOSITION (HAS-A) -----");
                // _23_CarComposition carComp = new _23_CarComposition();
                // carComp.Drive();





                // //---------------DAY4---24---Getter-Setters----------------------------
                // Console.WriteLine("");

                // // ---------------- EMPLOYEE ----------------
                // _24_Employee e = new _24_Employee();   // object creation
                // e.Salary = 40000;                      // setter called

                // Console.WriteLine("Employee Salary");
                // Console.WriteLine(e.Salary);            // getter called
                // Console.WriteLine("--------------------------------");


                // // ---------------- PRODUCT ----------------
                // _24_Product p = new _24_Product();     // object creation
                // p.ProductId = 101;                     // set property
                // p.ProductName = "Laptop";              // set auto property
                // p.Price = 55000;                       // set auto property

                // Console.WriteLine("Product Details");
                // Console.WriteLine(p.ProductId);
                // Console.WriteLine(p.ProductName);
                // Console.WriteLine(p.Price);
                // Console.WriteLine("--------------------------------");


                // // ---------------- STUDENT ----------------
                // _24_Student s = new _24_Student();     // object creation
                // s.RollNo = 1;                          // set auto property
                // s.Name = "Sandeep";                    // set auto property
                // s.Course = "CSE";                      // set auto property

                // Console.WriteLine("Student Details");
                // Console.WriteLine(s.RollNo);
                // Console.WriteLine(s.Name);
                // Console.WriteLine(s.Course);
                // Console.WriteLine("--------------------------------");


                // // ---------------- CIRCLE ----------------
                // _24_Circle c = new _24_Circle(5);      // constructor call

                // Console.WriteLine("Circle Area");
                // Console.WriteLine(c.Area);              // read-only property
                // Console.WriteLine("--------------------------------");


                // //-----------------EXPRESSION-BODIED-OPERATOR-------------------
                // _25_Rectangle recObj = new _25_Rectangle();
                // recObj.Length = 12;
                // recObj.Width = 12;
                // Console.WriteLine($"Area of the rectangle is ::>> {recObj.Area}");



                // //---------DAY4---25--Get--Set---------------------------
                // Console.WriteLine("");
                // _25_Student stuObj = new _25_Student();
                // stuObj.Name = "Sandeep";
                // stuObj.Age = 23;
                // stuObj.Marks = 68;

                // stuObj.DisplayDetails();



                // //----------DAY4---26--Indexer----------------------------
                // Console.WriteLine("");

                // _26_StudentCollection stuObj = new _26_StudentCollection();
                // stuObj.SetStudent(0,"Sandeep");
                // Console.WriteLine($"Getting the Student data 0 ::>> {stuObj.GetStudent(0)}");






                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //                                                                                                              //
                //                                                #####                                                         //
                //                                                #                                                             //
                //                                                ####                                                          //
                //                                                    #                                                         //
                //                                                ####                                                          //
                //                                                                                                              //
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                // //----------DAy
                // FileLogger fl = new FileLogger();
                // fl.Ilogger.Log(); 

                // Console.WriteLine(Sqrt(25));
                // Console.WriteLine(Sqrt());






                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //                                                  #                                                            //
                //                                                #                                                              //
                //                                               #                                                               //
                //                                               ####                                                            //
                //                                               #   #                                                           //
                //                                                ###                                                            //
                //                                                                                                               //
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                // //----------------------DAY6--31---STRUCTRE-and CLASS-Diffrence----------------
                // Console.WriteLine("");

                // _31_Program _31Obj = new _31_Program();
                // _31Obj.Main();




                // //-------------------DAY6--32---Object-Class-Methods------------------------------------------
                // Console.WriteLine("");

                // _32_Program _32Obj = new _32_Program();
                // _32Obj.Main();



                // //-------------------DAY6--33---Generic-Data-Types------------------------------------------
                // Console.WriteLine("");

                // _33_Program _33Obj = new _33_Program();
                // _33Obj.Main();


                // //-------------------DAY6--34---Nullable-Coalescing-Propagation------------------------------------------
                // Console.WriteLine("");

                // _34_Program _34Obj = new _34_Program();
                // _34Obj.Main();


                // //-------------------DAY6--35---Nullable-Coalescing-Propagation------------------------------------------
                // Console.WriteLine("");

                // _35_Program obj = new _35_Program();
                // obj.Main();






                // // --------------------DAY7-37--Arrays---------------------------
                // Console.WriteLine("");

                // _37_Program _37Obj = new _37_Program();
                // _37Obj.Main();



                // // --------------------DAY7-38--COLLECTIONS---------------------------
                // Console.WriteLine("");

                // _38_Program _38Obj = new _38_Program();
                // _38Obj.Main();




                // // --------------------DAY7-39--QUESTIONS---------------------------
                // Console.WriteLine("");

                // _39_Questions _39Obj = new _39_Questions();
                // _39Obj.Main();



                // //--------------------------DAY9--40---TRY-Except--------------------
                // Console.WriteLine("");

                // TryExcept obj = new TryExcept();
                // obj.Main();




                // //--------------------------DAY10--41--Pattern--Matching---------------------
                // _41_Regex _41Obj = new _41_Regex();
                // _41Obj.Main();



                // //---------------------------DAY11---42--Garbage Collection

                // _42_Garbage _42Obj = new _42_Garbage();
                // _42Obj.Main();

                // (int, string) data = (1, "sandeep");
                // Console.WriteLine("\nType of '(int,string) data = (1,\"sandeep\");' is " + data.GetType());


                // var data1 = (1, "sandeep");
                // Console.WriteLine("\nType of 'var data1 = (1,\"sandeep\");' is " + data1.GetType());

                // var data2 = new { Id = 1, Name = "sandeep" };
                // Console.WriteLine("\nType of 'var data2 = new (1,\"sandeep\");' is " + data2.GetType());


                // _43_Tuple _43Obj = new _43_Tuple();
                // _43Obj.Main();

                // _44_LINQ _44Obj = new _44_LINQ();
                // _44Obj.Main();

                // _45_Dispose _45Obj = new _45_Dispose();
                // _45Obj.Main();

                // _46_Example_Garbage _46Obj = new _46_Example_Garbage();
                // _46Obj.Main();


                // _47_String _47Obj = new _47_String();
                // _47Obj.Main();

                // _47_Child _47ChildObj = new _47_Child();
                // // Console.WriteLine("Static memeber using Obj ::>> "+_47ChildObj.total);
                // Console.WriteLine("Static memeber ::>> "+_47_Child.total);



                // _48_Program  _48Obj = new _48_Program();
                // _48Obj.Main(); 

                // _49_Program  _49Obj = new _49_Program();
                // _49Obj.Main(); 

                // _50_Program  _50Obj = new _50_Program();
                // _50Obj.Main(); 

                // _52_Program  _52Obj = new _52_Program();
                // _52Obj.Main(); 

                // _53_Program  _53Obj = new _53_Program();
                // _53Obj.Main(); 


                // _54_Program  _54Obj = new _54_Program();
                // _54Obj.Main(); 


                // _55_Program  _55Obj = new _55_Program();
                // _55Obj.Main(); 

                // _56_Program  _56Obj = new _56_Program();
                // _56Obj.Main(); 

                // _57_Program  _57Obj = new _57_Program();
                // _57Obj.Main(); 

                // _58_Program  _58Obj = new _58_Program();
                // _58Obj.Main(); 

                // _59_Program  _59Obj = new _59_Program();
                // _59Obj.Main(); 

                // _60_Program  _60Obj = new _60_Program();
                // _60Obj.Main(); 

                // _62_Program  _62Obj = new _62_Program();
                // _62Obj.Main(); 



                // _63_GAME _63Obj = new _63_GAME();
                // _63Obj.Main();


                // _64_Threading _64Obj = new _64_Threading();
                // _64Obj.Main();


                // _65_Parallel _65Obj = new _65_Parallel();
                // _65Obj.Main();


                // _66_Async _66Obj = new _66_Async();
                // _66Obj.Main();


                // _67_Async_Task _67Obj = new _67_Async_Task();
                // _67Obj.Main();


                // _68_Thread_Diag _68Obj = new _68_Thread_Diag();
                // _68Obj.Main();


                // _69 

                // _69_Program obj = new _69_Program();
                // obj.Main();

                // _70_MyCar.Program pobj = new _70_MyCar.Program();
                // pobj.Main();


                // _71_Program obj = new _71_Program();
                // obj.Main();

                // _72_Program obj = new _72_Program();
                // obj.Main();


                // _73_Program obj = new _73_Program();
                // obj.Main();

                // Console.WriteLine(Environment.Version);

                // _74_Reflection obj = new _74_Reflection();
                // obj.Main();

                _75_Main obj = new _75_Main();
                obj.Main();
                
        }
}