using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oopLab1
{
	public class Rhombuses
	{
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private int x3;
        private int y3;
        private int x4;
        private int y4;
        public Rhombuses(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }        

        public int getX1()
        {
            return this.x1;
        }
        public void setX1(int x1)
        {
            this.x1 = x1;
        }
        public int getY1()
        {
            return this.y1;
        }
        public void setY1(int y1)
        {
            this.y1 = y1;
        }
        public int getX2()
        {
            return this.x2;
        }
        public void setX2(int x2)
        {
            this.x2 = x2;
        }
        public int getY2()
        {
            return this.y2;
        }
        public void setY2(int y2)
        {
            this.y2 = y2;
        }
        public int getX3()
        {
            return this.x3;
        }
        public void setX3(int x3)
        {
            this.x3 = x3;
        }
        public int getY3()
        {
            return this.y3;
        }
        public void setY3(int y3)
        {
            this.y3 = y3;
        }
        public int getX4()
        {
            return this.x4;
        }
        public void setX4(int x4)
        {
            this.x4 = x4;
        }
        public int getY4()
        {
            return this.y4;
        }
        public void setY4(int y4)
        {
            this.y4 = y4;
        }
        public double squareRhombuses()
        {
            var d1 = Math.Sqrt(Math.Pow(this.x2 - this.x1, 2) + Math.Pow(this.y2 - this.y1, 2));
            var d2 = Math.Sqrt(Math.Pow(this.x4 - this.x3, 2) + Math.Pow(this.y4 - this.y3, 2));
            return Math.Ceiling(d1 * d2 / 2);
        }
        public double perimeterRhombuses()
        {
            var d1 = Math.Sqrt(Math.Pow(this.x2 - this.x1, 2) + Math.Pow(this.y2 - this.y1, 2));
            return Math.Ceiling(d1 * 4);
        }

        public static double operator +(Rhombuses r1, Rhombuses r2)
        {
            double area1 = r1.squareRhombuses();
            double area2 = r2.squareRhombuses();
            return area1 + area2;
        }

        public void Move(double distance)
        {
            this.x1 += (int)distance;
            this.x2 += (int)distance;
            this.x3 += (int)distance;
            this.x4 += (int)distance;
        }

        public bool isRhombus()
        {
            double diagonal1 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            double diagonal2 = Math.Sqrt(Math.Pow(x2 - x4, 2) + Math.Pow(y2 - y4, 2));
            double side1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double side2 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));

            // Проверяем, что все стороны равны
            if (side1 != side2 || side1 != diagonal1 / 2 || side2 != diagonal2 / 2)
            {
                return false;
            }

            // Проверяем, что диагонали пересекаются под прямым углом
            double k1 = (y2 - y1) / (x2 - x1);
            double k2 = (y4 - y3) / (x4 - x3);
            if (k1 * k2 != -1)
            {
                return false;
            }

            // Если все условия выполнены, фигура является ромбом
            return true;
        }

        public void AddToVertices(Rhombuses rhombus2)
        {
           // Знаходимо мінімальне значення серед усіх координат другого ромба
            double minX = Math.Min(rhombus2.x1, Math.Min(rhombus2.x2, Math.Min(rhombus2.x3, rhombus2.x4)));
             double minY = Math.Min(rhombus2.y1, Math.Min(rhombus2.y2, Math.Min(rhombus2.y3, rhombus2.y4)));
             double minVal = Math.Min(minX, minY);

             // Перевіряємо, чи мінімальне значення більше за 1
                 if (minVal > 1)
                {
                // Додаємо мінімальне значення до всіх координат першого ромба
                x1 += (int)minVal; y1 += (int)minVal;
                x2 += (int)minVal; y2 += (int)minVal;
                x3 += (int)minVal; y3 += (int)minVal;
                x4 += (int)minVal; y4 += (int)minVal;
                
                Console.WriteLine("Min value is " + minVal);

            }
            else
            {
                throw RankException("Min value not > 1. Try again");
           
            }
        }

        private Exception RankException(string v)
        {
            throw new NotImplementedException();
        }

        public void DecrementCoordinates(int amount)
        {
            x1 -= amount;
            y1 -= amount;
            x2 -= amount;
            y2 -= amount;
            x3 -= amount;
            y3 -= amount;
            x4 -= amount;
            y4 -= amount;
        }


        public bool AllCoordinatesNonZero(Rhombuses r1, Rhombuses r2)
        {
            return r1.x1 != 0 && r1.y1 != 0 && r1.x2 != 0 && r1.y2 != 0
                && r1.x3 != 0 && r1.y3 != 0 && r1.x4 != 0 && r1.y4 != 0
                && r2.x1 != 0 && r2.y1 != 0 && r2.x2 != 0 && r2.y2 != 0
                && r2.x3 != 0 && r2.y3 != 0 && r2.x4 != 0 && r2.y4 != 0;
        }

        public override string ToString()
        {
            return $"Rhombus with vertices ({x1},{y1}), ({x2},{y2}), ({x3},{y3}), ({x4},{y4})";
        }

    }
}

