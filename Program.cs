using System;
using System.Diagnostics.Metrics;
using oopLab1;

class Application
{
    static int x1, y1, x2, y2, x3, y3, x4, y4;
    static int x11, y11, x22, y22, x33, y33, x44, y44;

    public static void Main(String[] args)
    {
        Rhombuses[] rhombArray = new Rhombuses[17];

        while (true)
        {
            menu();
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    consoleInputCalculationArea();
                    break;
                case 2:
                    consoleInputCalculationPerimeter();
                    break;
                case 3:
                    array(rhombArray);
                    break;
                case 4:
                    PerAndSq();
                    break;
                case 5:
                    operatorPlus();
                    break;
                case 6:
                    replaceRhombous();
                    break;
                case 7:
                    findMinValue();
                    break;
                case 8:
                    compareRomb();
                    break;
                case 9:
                    Decrement();
                    break;
                case 10:
                    if (zeroСheck())
                    {
                        Console.WriteLine("--------");
                        Console.WriteLine("Value zero was not found");
                        Console.WriteLine("--------");

                    }
                    else {
                        Console.WriteLine("--------");
                        Console.WriteLine("Value zero was found");
                        Console.WriteLine("--------");
                    }

                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You can not use " + num);
                    break;

            }


        }
    }

    public static void menu()
    {
        Console.WriteLine("Press 1 - to calculate the area of ​​the rhombus");
        Console.WriteLine("Press 2 - to calculate the perimeter of the rhombus");
        Console.WriteLine("Press 3 - to create array");
        Console.WriteLine("Press 4 - to calculate the area and perimeter of the rhombus");
        Console.WriteLine("Press 5 - Rhombus + double");
        Console.WriteLine("Press 6 - to replace rhombous");
        Console.WriteLine("Press 7 - to find the minimum value");
        Console.WriteLine("Press 8 - to compare 2 rhombuses");
        Console.WriteLine("Press 9 - to decrement coordinates");
        Console.WriteLine("Press 10 - check null occurrence");
        Console.WriteLine("Press 0 - to exit the program");

    }

    public static void consoleInputCalculationArea()
    {
        
        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());
        Rhombuses rhombuses = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);

        if(true) {
            Console.WriteLine("--------");
            Console.WriteLine("R = " + rhombuses);
            Console.WriteLine("--------");
            Console.WriteLine("Rhombus square = " + rhombuses.squareRhombuses());
            Console.WriteLine("--------");
        }
        else
        {
            Console.WriteLine("--------");
            Console.WriteLine("Wrong coordinates");
            Console.WriteLine("Please, try again");
            Console.WriteLine("--------");

        }



    }

    public static void consoleInputCalculationPerimeter()
    {
        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());
        Rhombuses rhombuses2 = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Console.WriteLine("--------");
        Console.WriteLine("R = " + rhombuses2);
        Console.WriteLine("--------");
        Console.WriteLine("Perimeter = " + rhombuses2.perimeterRhombuses());
        Console.WriteLine("--------");
    }

    public static void array(Rhombuses[] rhombArray)
    {
        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());


        for (int i = 0; i < rhombArray.Length / 2; i++)
        {
            rhombArray[i] = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
            rhombArray[rhombArray.Length - i - 1] = new Rhombuses(
                rhombArray[i].getX4(), rhombArray[i].getY4(),
                rhombArray[i].getX3(), rhombArray[i].getY3(),
                rhombArray[i].getX2(), rhombArray[i].getY2(),
                rhombArray[i].getX1(), rhombArray[i].getY1()
            );
        }

        for (int i = 0; i < rhombArray.Length; i++)
        {
            Console.WriteLine(rhombArray[i]);
        }


    }

    public static void PerAndSq()
    {
        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());

        Rhombuses rhombuses2 = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Console.WriteLine("--------");
        Console.WriteLine("R = " + rhombuses2);
        Console.WriteLine("--------");
        Console.WriteLine("Perimeter = " + rhombuses2.perimeterRhombuses());
        Console.WriteLine("--------");
        Rhombuses rhombuses = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Console.WriteLine("Rhombus square = " + rhombuses.squareRhombuses());
        Console.WriteLine("--------");

    }

    public static void operatorPlus()
    {
        Console.WriteLine("First r: ");
        Console.WriteLine("↓");
        Console.WriteLine("");

        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("Second r: ");
        Console.WriteLine("↓");
        Console.WriteLine("");

        Console.WriteLine("Enter x1");
        x11 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y11 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x22 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y22 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x33 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y33 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x44 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y44 = Convert.ToInt32(Console.ReadLine());

        Rhombuses r1 = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Rhombuses r2 = new Rhombuses(x11, y11, x22, y22, x33, y33, x44, y44);
        double totalArea = r1 + r2;
        Console.WriteLine("--------");
        Console.WriteLine("R1 = " + r1);
        Console.WriteLine("--------");
        Console.WriteLine("R2 = " + r2);
        Console.WriteLine("--------");
        Console.WriteLine($"Total area of rhombuses r1 and r2 is: {totalArea}");
        Console.WriteLine("--------");
    }

    public static void replaceRhombous()
    {
        Console.WriteLine("You should to enter coordinates");
        Console.WriteLine("↓");
        Console.WriteLine("");

        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());

        Rhombuses r1 = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);

        Console.WriteLine("Now enter the distance how much you want to rotate the rhombus");
        Console.WriteLine("↓");
        Console.WriteLine("");

        Console.WriteLine("Distance: ");
        double distance = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("--------");
        Console.WriteLine("R = " + r1);
        Console.WriteLine("--------");
        r1.Move(distance);
        Console.WriteLine("Moved rhombus: " + r1);
        Console.WriteLine("--------");
    }

    public static void findMinValue()
    {
        Console.WriteLine("First r: ");
        Console.WriteLine("↓");
        Console.WriteLine("");

        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("Second r: ");
        Console.WriteLine("↓");
        Console.WriteLine("");

        Console.WriteLine("Enter x1");
        x11 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y11 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x22 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y22 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x33 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y33 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x44 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y44 = Convert.ToInt32(Console.ReadLine());

        Rhombuses r1 = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Rhombuses r2 = new Rhombuses(x11, y11, x22, y22, x33, y33, x44, y44);

        Console.WriteLine("--------");
        Console.WriteLine("R1 = " + r1);
        Console.WriteLine("--------");
        Console.WriteLine("R2 = " + r2);
        Console.WriteLine("--------");
        Console.WriteLine("After");
        Console.WriteLine("");
        Console.WriteLine("↓");
        Console.WriteLine("");

        r1.AddToVertices(r2);

        Console.WriteLine("R1 = " + r1);
        Console.WriteLine("--------");
    }

    public static void compareRomb()
    {
        Console.WriteLine("First r: ");
        Console.WriteLine("↓");
        Console.WriteLine("");

        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("Second r: ");
        Console.WriteLine("↓");
        Console.WriteLine("");

        Console.WriteLine("Enter x1");
        x11 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y11 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x22 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y22 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x33 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y33 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x44 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y44 = Convert.ToInt32(Console.ReadLine());

        Rhombuses r1 = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Rhombuses r2 = new Rhombuses(x11, y11, x22, y22, x33, y33, x44, y44);

        var squareR1 = r1.squareRhombuses();
        var squareR2 = r2.squareRhombuses();

        Console.WriteLine("--------");
        Console.WriteLine("R1 = " + r1);
        Console.WriteLine("--------");
        Console.WriteLine("R2 = " + r2);

        if (squareR1 > squareR2)
        {
            Console.WriteLine("--------");
            Console.WriteLine("Square R1 = " + squareR1);
            Console.WriteLine("--------");
            Console.WriteLine("Square R2 = " + squareR2);
            Console.WriteLine("--------");
            Console.WriteLine("The area of Rhombus 1 is greater than the area of Rhombus 2");
            Console.WriteLine("--------");

        }
        else if (squareR1 < squareR2)
        {
            Console.WriteLine("--------");
            Console.WriteLine("Square R1 = " + squareR1);
            Console.WriteLine("--------");
            Console.WriteLine("Square R2 = " + squareR2);
            Console.WriteLine("--------");
            Console.WriteLine("The area of Rhombus 2 is greater than the area of Rhombus 1");
            Console.WriteLine("--------");

        }
        else
        {
            Console.WriteLine("--------");
            Console.WriteLine("Square R1 = " + squareR1);
            Console.WriteLine("--------");
            Console.WriteLine("Square R2 = " + squareR2);
            Console.WriteLine("--------");
            Console.WriteLine("The areas of both rhombuses are equal");
            Console.WriteLine("--------");

        }
    }

    public static void Decrement()
    {
        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());

        Rhombuses r1 = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);

        Console.WriteLine("Now enter decrement: ");
        var decrement = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("--------");
        Console.WriteLine("Before: ");
        Console.WriteLine("R1 = " + r1);
        Console.WriteLine("--------");

        r1.DecrementCoordinates(decrement);

        Console.WriteLine("After");
        Console.WriteLine("R1 = " + r1);
        Console.WriteLine("--------");

    }

    public static bool zeroСheck() {
        Console.WriteLine("First r: ");
        Console.WriteLine("↓");
        Console.WriteLine("");

        Console.WriteLine("Enter x1");
        x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("Second r: ");
        Console.WriteLine("↓");
        Console.WriteLine("");

        Console.WriteLine("Enter x1");
        x11 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y1");
        y11 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x2");
        x22 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y2");
        y22 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x3");
        x33 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y3");
        y33 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter x4");
        x44 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter y4");
        y44 = Convert.ToInt32(Console.ReadLine());

        Rhombuses r1 = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Rhombuses r2 = new Rhombuses(x11, y11, x22, y22, x33, y33, x44, y44);

        if (r1.AllCoordinatesNonZero(r1, r2))
        {
            return true;
;
        }

        return false;
    }

  





}



