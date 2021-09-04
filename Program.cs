using System;
using System.Reflection;

namespace testUnitario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("Test!");
            Console.WriteLine("  ");
            int pruebasExitosas =0;
            int pruebasFallidas =0;
            
    //      int lado = 6;
    //      Console.WriteLine("El area del cuadrado es : " + Figuras.cuadrado(lado));
            
            var metodos = typeof(Program).GetMethods(BindingFlags.Public | BindingFlags.Static );

            foreach (var mtd in metodos)
            {   
                try
                {   
                   mtd.Invoke(null,null);       
                   pruebasExitosas ++;  
                }
                catch 
                {
                   pruebasFallidas++;
                }
            }
        Console.WriteLine($"Pruebas exitosas # {pruebasExitosas}");
        Console.WriteLine($"Pruebas fallidas # {pruebasFallidas  }");
        }    

        public static void PruebaCuadradoIgualesUno(){
            // Arrange
            int valorEsperado = 25;
            int valorActual =0;
            int lado =5;
            // Act
            valorActual = Figuras.cuadrado(lado);    
            // Assert
            Assert.AreEqual(valorEsperado,valorActual);
        }


         public static void PruebaCuadradoIgualesDos(){
            // Arrange
            int valorEsperado = 16;
            int valorActual =0;
            int lado =4;
            // Act
            valorActual = Figuras.cuadrado(lado);    
            // Assert
            Assert.AreEqual(valorEsperado,valorActual);
        }


          public static void PruebaCuadradoIgualesTres(){
            // Arrange
            int valorEsperado = 9;
            int valorActual =0;
            int lado =3;
            // Act
            valorActual = Figuras.cuadrado(lado);    
            // Assert
            Assert.AreEqual(valorEsperado,valorActual);
        }


        public static void PruebaCuadradoMayorUno(){
            // Arrange
            int valorEsperado = 8;
            int valorActual =0;
            int lado =3;
            // Act
            valorActual = Figuras.cuadrado(lado);    
            // Assert
            Assert.AreHigher(valorEsperado,valorActual);
        }

        




    }
}
