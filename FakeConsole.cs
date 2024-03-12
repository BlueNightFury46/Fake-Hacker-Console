namespace shadowtrilogy.co.uk;

using System;

class FakeConsole{


      public static void FakeHackerConsole(){
        Console.CursorVisible = false;

     Console.ResetColor();
     Console.BackgroundColor = ConsoleColor.Black;
     Console.ForegroundColor = ConsoleColor.DarkGreen;
     for(int i = 0; i <= 10;i++){
       Console.WriteLine("Loading algorithms...");
       Thread.Sleep(100);
       Console.WriteLine("");
       
       Thread.Sleep(50);
        Console.WriteLine("Running algorithms...");
        Thread.Sleep(50);
        Console.WriteLine("");
         Console.WriteLine("Executing algorithms...");
         Thread.Sleep(50);
         Console.WriteLine("");
         Thread.Sleep(50);
          Console.WriteLine("Decrypting bits...");
          Thread.Sleep(75);
          Console.WriteLine("");
          Thread.Sleep(75);
           Console.WriteLine("Encrypting passwords...");
           Thread.Sleep(200);
             Console.WriteLine("Enter Additional keys...");

       #nullable disable warnings
       if(Console.ReadLine().ToString().Equals("exit")){
           break;
       }


       if(i == 2){
        Console.WriteLine("Keys Incorrect...");
        Thread.Sleep(1000);
       Console.WriteLine("Stage " + i + " out of 10 failed...");
       Thread.Sleep(1000);
       } else {
       Thread.Sleep(1000);
       Console.WriteLine("Stage " + i + " out of 10 complete...");
       Thread.Sleep(1000);
       }
       

      }

Thread.Sleep(200);

        
      Console.CursorVisible = true;
       Console.ResetColor();
     Console.BackgroundColor = ConsoleColor.Black;
     Console.ForegroundColor = ConsoleColor.White;

      Console.Beep();
           Thread.Sleep(200);
            Console.Beep();
            Thread.Sleep(200);
             Console.Beep();
            
      Console.WriteLine("\nExiting with code 0");
      
      }
}