using System;

namespace testUnitario
{
    public static class Assert{

        public static void AreEqual(int esperado , int actual ){
            // 1 - valor esperado
            // 2 - valor actual 
               if(esperado != actual){
                   throw new Exception ("Assert AreEqual error");
               } 

        }

         public static void AreHigher(int esperado , int actual ){
            // 1 - valor esperado
            // 2 - valor actual 
               if(esperado < actual){
                   throw new Exception ("Assert AreEqual error");
               } 

        }


    }



}