// Задача 43. Напишите программу, которая найдет точку пересечения 2х прямых, заданных уравнениями у=k1*х + b1; y=k2*x + b2. Коэффициенты задаются пользователем.
Console.Clear();
Console.WriteLine("This program finds the point of intersection of lines: у=k1*х + b1 and y=k2*x + b2.");
EnterCoeff("k1");
double k1=Convert.ToDouble(Console.ReadLine());
EnterCoeff("b1");
double b1=Convert.ToDouble(Console.ReadLine());
EnterCoeff("k2");
double k2=Convert.ToDouble(Console.ReadLine());
EnterCoeff("b2");
double b2=Convert.ToDouble(Console.ReadLine());

FindCoordinates(k1,k2,b1,b2); 

void FindCoordinates(double k1, double k2, double b1, double b2)
{
  double [] coord = new double [2]; // coord[0]=x; coord[1]=y 
  
  if (k1==k2 && b1==b2)
    {
        Console.WriteLine("The lines match. You've entered the same coefficients for both lines.");
        return;
    } 
  else if (k1==k2)
    {
        Console.WriteLine("The lines are parallel.");
        return;
    }
  else
   {
       coord[0] = (b2-b1)/(k1-k2);
       coord[1] = k1*coord[0] + b1;
       Console.WriteLine($"The point of intersection of lines: у={k1}*х + {b1} and y={k2}*x + {b2} equal to [{coord[0]} ; {coord[1]}].");
   }
  
} 


void EnterCoeff (string nameCoeff)
{
   Console.Write($"Enter coefficient {nameCoeff}: ") ;
}

