using System;

namespace shadowtrilogy.co.uk;

class Password {

      public static bool isTyped(String password, bool CaseSensitive){

        if(password.Equals("")){
          Console.WriteLine("Error! Password cannot be empty; contact the developer to change this");
          return false;
        }
             
           string? typed = Console.ReadLine();

          //Checks if CaseSensitive mode is on
           if(CaseSensitive){

            //Checks if the inputed string is equal to the typed string              
               if(password.Equals(typed)){
                //if so returns true;
                return true;

               } else {

                return false;
               }

         //If CaseSensitive mode is off
           } else {
    

          //Attempts to allow s to be null
          string? s = typed;
          
          //Then does a try-catch
          try{
            //Then makes sure the password isn't empty
            if(!s.Equals("")){
              if(s.ToLower().Equals(password.ToLower())){

                return true;
              } 
                else{

                return false;
              }
            } else if(s.Equals("")){
            Console.WriteLine("Please input a value... ");
            return false;
                
            }
           } catch(NullReferenceException){
            Console.WriteLine("Please input a value... ");
            return false;
           }
           }
           return false;
      }




      public static bool isTyped(String password){
             
           string? typed = Console.ReadLine();

          //Checks if CaseSensitive mode is on
          

            //Checks if the inputed string is equal to the typed string              
               if(password.Equals(typed)){
                //if so returns true;
                return true;

               } else {

                return false;
               }
      }
}