using System;

namespace zeynep
{
    class Program
    {
        static void Main()
        {
            char quit;
            do
            {
                //matrix elements
                double a11, a12, a13, a21, a22, a23, a31, a32, a33, a14, a24, a34;
                //comparing
                double min1, min2, min3, max1, max2, max3, maxmin, minmax;

                //chosing matrix size
                string answer;
                Console.WriteLine("please choose your matrix size: \n A)3*3 matrix\n B)3*4 matrix\n");
                answer = Console.ReadLine();

                //input control
                while (answer != "a" && answer != "A" && answer != "b" && answer != "B")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you chose invalid option!\n please make a new choice....");
                    Console.ForegroundColor = ConsoleColor.White;
                    answer = Console.ReadLine();

                }

                //get matrix elements
                if (answer == "a" || answer == "A")
                {

                    Console.WriteLine("\n\nplease enter the elements of 3*3 matrix s:\n");



                    //getting elements of the matrix and checking that the element is double
                    while (!double.TryParse(Console.ReadLine(), out a11))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a double number. please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a12))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a double number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a13))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a double number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a21))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a double number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a22))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a double number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a23))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a double number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a31))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a double number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a32))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a double number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a33))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a double number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                    //printing matrix and using string format for a good struct
                    Console.WriteLine("\n\nmatrix A:\n");
                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.WriteLine(string.Format("{0,-10:0.##} |", a13));


                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.WriteLine(string.Format("{0,-10:0.##} |", a23));


                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.WriteLine(string.Format("{0,-10:0.##} |", a33));


                    Console.WriteLine("\n\n\n************operation A*************\n");

                    //row summation 
                    double row1, row2, row3;
                    row1 = a11 + a12 + a13;
                    row2 = a21 + a22 + a23;
                    row3 = a31 + a32 + a33;
                    Console.WriteLine("-sum of rows:\n" + Convert.ToDouble(row1) + "\n" + Convert.ToDouble(row2) + "\n" + Convert.ToDouble(row3) + "\n");

                    //column summation
                    double col1, col2, col3;
                    col1 = a11 + a21 + a31;
                    col2 = a12 + a22 + a32;
                    col3 = a13 + a23 + a33;
                    Console.WriteLine("-sum of columns:\n" + col1 + "\n" + col2 + "\n" + col3 + "\n");

                    //sum of primary diagonal
                    double pd;
                    pd = a11 + a22 + a33;
                    Console.WriteLine("-sum of the primary diagonal:" + a11 + "+" + a22 + "+" + a33 + "=" + pd);


                    //transpose of matrix

                    Console.WriteLine("\n\ntranspose of the matrix:\n\n");
                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a21));
                    Console.WriteLine(string.Format("{0,-10:0.##} |", a31));


                    Console.Write(string.Format("|{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.WriteLine(string.Format("{0,-10:0.##} |", a32));


                    Console.Write(string.Format("|{0,-10:0.##} ", a13));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##} |", a33));



                    //calculating determinant of matrix
                    double dt;
                    dt = (a11 * a22 * a33) + (a21 * a32 * a13) + (a31 * a12 * a23) - (a13 * a22 * a31) - (a23 * a32 * a11) - (a33 * a12 * a21);
                    Console.WriteLine($"\n\n\n\n-determinant of matrix:  ({a11} * {a22} * {a33}) + ({a21} * {a32} * {a13}) + ({a31} * {a12} * {a23}) \n" +
                                                             $"- ({a13} * {a22} * {a31}) - ({a23} * {a32} * {a11}) - ({a33} * {a12} * {a21}) = {dt}");


                    Console.WriteLine("*******************************");





                    Console.WriteLine("\n\n\n***********operation B*************\n");


                    //determine matrix type 
                    bool dg = false, id = false, zo = false, sc = false, sy = false, pm = false;
                    //count variable checks permutation matrix and it count "1" elements
                    int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;

                    //symetric matrix
                    if (a12 == a21 && a13 == a31 && a23 == a32)
                    {
                        sy = true;
                        //diagonal matrix
                        if (a12 == 0 && a13 == 0 && a21 == 0 && a23 == 0 && a31 == 0 && a32 == 0)
                        {
                            dg = true;
                            //scalar?
                            if (a11 == a22 && a22 == a33)
                            {
                                sc = true;
                                //identity?
                                if (a11 == 1 && a22 == 1 && a33 == 1)
                                {
                                    id = true;
                                    zo = true;
                                    pm = true;
                                }
                            }
                        }
                        //not diagonal
                        //zero-one?
                        else
                        {
                            if ((a11 == 0 || a11 == 1) && (a12 == 0 || a12 == 1) && (a13 == 0 || a13 == 1)
                                && (a21 == 0 || a21 == 1) && (a22 == 0 || a22 == 1) && (a23 == 0 || a23 == 1)
                                && (a31 == 0 || a31 == 1) && (a32 == 0 || a32 == 1) && (a33 == 0 || a33 == 1))
                            {
                                zo = true;
                                //permutation?
                                //for rows
                                if (a11 == 1) count1++;
                                if (a12 == 1) count1++;
                                if (a13 == 1) count1++;

                                if (a21 == 1) count2++;
                                if (a22 == 1) count2++;
                                if (a23 == 1) count2++;

                                if (a31 == 1) count3++;
                                if (a32 == 1) count3++;
                                if (a33 == 1) count3++;

                                //for columns
                                if (a11 == 1) count4++;
                                if (a21 == 1) count4++;
                                if (a31 == 1) count4++;

                                if (a12 == 1) count5++;
                                if (a22 == 1) count5++;
                                if (a32 == 1) count5++;

                                if (a13 == 1) count6++;
                                if (a23 == 1) count6++;
                                if (a33 == 1) count6++;

                                if (count1 == 1 && count2 == 1 && count3 == 1 && count4 == 1 && count5 == 1 && count6 == 1)
                                {
                                    pm = true;
                                }
                            }
                        }
                    }
                    //not symetric
                    //zero-one?
                    else
                    {
                        if ((a11 == 0 || a11 == 1) && (a12 == 0 || a12 == 1) && (a13 == 0 || a13 == 1)
                                && (a21 == 0 || a21 == 1) && (a22 == 0 || a22 == 1) && (a23 == 0 || a23 == 1)
                                && (a31 == 0 || a31 == 1) && (a32 == 0 || a32 == 1) && (a33 == 0 || a33 == 1))
                        {
                            zo = true;
                            
                            //permutation?
                            //for rows
                            if (a11 == 1) count1++;
                            if (a12 == 1) count1++;
                            if (a13 == 1) count1++;

                            if (a21 == 1) count2++;
                            if (a22 == 1) count2++;
                            if (a23 == 1) count2++;

                            if (a31 == 1) count3++;
                            if (a32 == 1) count3++;
                            if (a33 == 1) count3++;

                            //for columns
                            if (a11 == 1) count4++;
                            if (a21 == 1) count4++;
                            if (a31 == 1) count4++;

                            if (a12 == 1) count5++;
                            if (a22 == 1) count5++;
                            if (a32 == 1) count5++;

                            if (a13 == 1) count6++;
                            if (a23 == 1) count6++;
                            if (a33 == 1) count6++;
                            if (count1 == 1 && count2 == 1 && count3 == 1 && count4 == 1 && count5 == 1 && count6 == 1)
                            {
                                pm = true;
                            }
                        }
                    }
                    //print matrix types
                    if (id == false) Console.WriteLine("identity matrix:  NO");
                    else Console.WriteLine("identity matrix: YES");

                    if (sc == false) Console.WriteLine("scalar matrix: NO");
                    else Console.WriteLine("Scalar matrix: YES");

                    if (dg == false) Console.WriteLine("diagonal matrix:  NO");
                    else Console.WriteLine("diagonal matrix: YES");

                    if (zo == false) Console.WriteLine("zero-one matrix: NO");
                    else Console.WriteLine("zero-one matrix: YES");

                    if (sy == false) Console.WriteLine("symetric matrix: NO");
                    else Console.WriteLine("symetric matrix: YES");

                    if (pm == false) Console.WriteLine("permutation matrix: NO");
                    else Console.WriteLine("permutation matrix: YES");





                    Console.WriteLine("\n\n\n***********operation C*************\n\n");

                    //min of each row

                    //min1
                    if (a11 < a12)
                    {
                        if (a11 < a13) min1 = a11;

                        else min1 = a13;

                    }
                    else
                    {
                        if (a12 < a13) min1 = a12;

                        else min1 = a13;

                    }
                    //min2
                    if (a21 < a22)
                    {
                        if (a21 < a23) min2 = a21;

                        else min2 = a23;
                    }
                    else
                    {
                        if (a22 < a23) min2 = a22;

                        else min2 = a23;

                    }
                    //min3
                    if (a31 < a32)
                    {
                        if (a31 < a33) min3 = a31;

                        else min3 = a33;
                    }
                    else
                    {
                        if (a32 < a33) min3 = a32;

                        else min3 = a33;

                    }
                    //max1
                    if (a11 > a21)
                    {
                        if (a11 > a31) max1 = a11;

                        else max1 = a31;
                    }
                    else
                    {
                        if (a21 > a31) max1 = a21;

                        else max1 = a31;

                    }
                    //max2
                    if (a12 > a22)
                    {
                        if (a12 > a32) max2 = a12;

                        else max2 = a32;
                    }
                    else
                    {
                        if (a22 > a32) max2 = a22;

                        else max2 = a32;

                    }
                    //max3
                    if (a13 > a23)
                    {
                        if (a13 > a33) max3 = a13;

                        else max3 = a31;
                    }
                    else
                    {
                        if (a23 > a33) max3 = a23;

                        else max3 = a33;

                    }
                    //find maxmin
                    if (min1 > min2)
                    {
                        if (min1 > min3) maxmin = min1;

                        else maxmin = min3;
                    }
                    else
                    {
                        if (min2 > min3) maxmin = min2;

                        else maxmin = min3;
                    }
                    //find minmax
                    if (max1 < max2)
                    {
                        if (max1 < max3) minmax = max1;

                        else minmax = max3;
                    }
                    else
                    {
                        if (max2 < max3) minmax = max2;

                        else minmax = max3;
                    }

                    Console.WriteLine($"minimum values of each row (min1, min2, min3): {min1}, {min2}, {min3}\n");
                    Console.WriteLine($"maximum values of each column (max1, max2, max3): {max1}, {max2}, {max3}\n");
                    Console.WriteLine($"maximum of minimum values of each row (maxmin): {maxmin} \n");
                    Console.WriteLine($"minimum of maximum values of each column (minmax): {minmax}\n");
                    if (maxmin < minmax) Console.WriteLine("compare maxmin to minmax: maxmin<minmax");
                    else if (minmax < maxmin) Console.WriteLine("compare maxmin to minmax: maxmin>minmax");
                    else Console.WriteLine("compare maxmin to minmax: maxmin=minmax");
                }


                //*****************************************************************************************
               //operation D
                else if (answer == "b" || answer == "B")
                {
                    Console.WriteLine("please enter your 3*4 matrix elements:");

                    //getting elements of the matrix and checking that the element is double
                    while (!double.TryParse(Console.ReadLine(), out a11) || a11 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number. please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a12))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a13))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a14))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a21))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a22) || (a22 - 2 * (a12 / a11)) == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a23))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a24))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a31))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a32))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a33))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    while (!double.TryParse(Console.ReadLine(), out a34))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("this isnt a valid number.  please enter a valid number...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                    Console.WriteLine("\n\nentered matrix:\n");

                    //printing the matrix
                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.##} ", a13));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a14));

                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a24));

                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.Write(string.Format("{0,-10:0.##} ", a33));
                    Console.WriteLine(string.Format("{0,-10:0.##}|", a34));


                    Console.WriteLine("\n\n\nconversion of the matrix:");

                    //converting to row echolon for with gauss elimination method step by step
                    Console.WriteLine(string.Format("\n\nstep1: R1/({0:0.##})-->R1\n", a11));
                    double temp = a11;
                    a11 /= temp;
                    a12 /= temp;
                    a13 /= temp;
                    a14 /= temp;

                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.#} ", a13));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a14));

                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a24));

                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.Write(string.Format("{0,-10:0.##} ", a33));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a34));

                    Console.WriteLine(string.Format("\n\n\n\nstep2: R2-({0:0.##})*R1-->R2\n", a21));
                    double temp1 = a21;
                    a21 = a21 - temp1 * a11;
                    a22 = a22 - temp1 * a12;
                    a23 = a23 - temp1 * a13;
                    a24 = a24 - temp1 * a14;

                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.##} ", a13));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a14));

                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a24));

                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.Write(string.Format("{0,-10:0.##} ", a33));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a34));

                    Console.WriteLine(string.Format("\n\n\n\nstep3: R3-({0:0.##})*R1-->R3\n", a31));
                    double temp2 = a31;
                    a31 = a31 - temp2 * a11;
                    a32 = a32 - temp2 * a12;
                    a33 = a33 - temp2 * a13;
                    a34 = a34 - temp2 * a14;

                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.##} ", a13));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a14));

                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a24));

                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.Write(string.Format("{0,-10:0.##} ", a33));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a34));

                    Console.WriteLine(string.Format("\n\n\n\nstep4: R2/({0:0.##})->R2\n", a22));
                    double temp3 = a22;
                    a21 /= temp3;
                    a22 /= temp3;
                    a23 /= temp3;
                    a24 /= temp3;

                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.##} ", a13));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a14));

                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a24));

                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.Write(string.Format("{0,-10:0.##} ", a33));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a34));

                    Console.WriteLine(string.Format("\n\n\n\nstep5: R1-({0:0.##})*R2-->R1\n", a21));
                    double temp4 = a12;
                    a11 = a11 - temp4 * a21;
                    a12 = a12 - temp4 * a22;
                    a13 = a13 - temp4 * a23;
                    a14 = a14 - temp4 * a24;

                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.##} ", a13));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a14));

                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a24));

                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.Write(string.Format("{0,-10:0.##} ", a33));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a34));

                    Console.WriteLine(string.Format("\n\n\n\nstep6: R3-({0:0.##})*R2-->R3\n", a32));
                    double temp5 = a32;
                    a31 = a31 - temp5 * a21;
                    a32 = a32 - temp5 * a22;
                    a33 = a33 - temp5 * a23;
                    a34 = a34 - temp5 * a24;

                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.##} ", a13));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a14));

                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a24));

                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.Write(string.Format("{0,-10:0.##} ", a33));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a34));

                    Console.WriteLine(string.Format("\n\n\n\nstep7: R3/({0:0.##})-->R3\n", a33));
                    double temp6 = a33;
                    a31 /= temp6;
                    a32 /= temp6;
                    a33 /= temp6;
                    a34 /= temp6;

                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.##} ", a13));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a14));

                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a24));

                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.Write(string.Format("{0,-10:0.##} ", a33));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a34));

                    Console.WriteLine(string.Format("\n\n\n\nstep8: R1-({0:0.##})*R3-->R1\n", a13));
                    double temp7 = a13;
                    a11 = a11 - temp7 * a31;
                    a12 = a12 - temp7 * a32;
                    a13 = a13 - temp7 * a33;
                    a14 = a14 - temp7 * a34;

                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.##} ", a13));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a14));

                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a24));

                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.Write(string.Format("{0,-10:0.##} ", a33));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a34));

                    Console.WriteLine(string.Format("\n\n\n\nstep9: R2-({0:0.##})*R3-->R2\n", a23));
                    double temp8 = a23;
                    a21 = a21 - temp8 * a31;
                    a22 = a22 - temp8 * a32;
                    a23 = a23 - temp8 * a33;
                    a24 = a24 - temp8 * a34;

                    Console.Write(string.Format("|{0,-10:0.##} ", a11));
                    Console.Write(string.Format("{0,-10:0.##} ", a12));
                    Console.Write(string.Format("{0,-10:0.##} ", a13));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a14));

                    Console.Write(string.Format("|{0,-10:0.##} ", a21));
                    Console.Write(string.Format("{0,-10:0.##} ", a22));
                    Console.Write(string.Format("{0,-10:0.##} ", a23));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a24));

                    Console.Write(string.Format("|{0,-10:0.##} ", a31));
                    Console.Write(string.Format("{0,-10:0.##} ", a32));
                    Console.Write(string.Format("{0,-10:0.##} ", a33));
                    Console.WriteLine(string.Format("{0,-10:0.##}| ", a34));

                    Console.WriteLine(string.Format("\n\n\n\nthe value of unknowns (x,y,z):\nx={0,-10:0.##}", a14));
                    Console.WriteLine(string.Format("y={0,-10:0.###}", a24));
                    Console.WriteLine(string.Format("z={0,-10:0.###}", a34));

                   
                }
                //to execute the progam again and again
                Console.WriteLine("\n\n***************************");
                Console.WriteLine("\n\n\npress to 'q' to quit...\n press anything to continue...");

                //when the users press "q" the program closes
                quit = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n\n\n");

                if (quit == 'q' || quit == 'Q') 
                    Environment.Exit(0);
            } while (quit != 'q' || quit != 'Q');
            
        }
    }
}
