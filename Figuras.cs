 using System;
 
 class Figuras
    {
        public static int cuadrado(int ladoIn)
        {
            int lado, area;
          //  Console.WriteLine("Ingrese un lado del cuadrado");
          //  lado = Convert.ToInt16(Console.ReadLine());
            lado = ladoIn;
            area = lado * lado;
          //  Console.WriteLine("El area del cuadrado es : " + area);
          //  Console.ReadKey();

           return area;
        }

        public static void circulo()
        {
            double radio,area,pi =3.1416;
            Console.WriteLine("Ingrese el radio del circulo");
            radio = Convert.ToDouble(Console.ReadLine());
            area = pi * Math.Pow(radio,2);
            Console.WriteLine("El area del circulo es : " + area);
            Console.ReadKey();     
        }


        public static void rectangulo()
        {
            int b,h, area;
            Console.WriteLine("Ingrese la base del rectangulo");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la altura rectangulo");
            h = Convert.ToInt16(Console.ReadLine());
            area = b * h;
            Console.WriteLine("El area del rectangulo es : " + area);
            Console.ReadKey();
        }

         public static void triangulo()
        {
            int b,h, area;
            Console.WriteLine("Ingrese la base del triangulo");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la altura triangulo");
            h = Convert.ToInt16(Console.ReadLine());
            area = b * h/2;
            Console.WriteLine("El area del triangulo es : " + area);
            Console.ReadKey();
        }
        



    }
