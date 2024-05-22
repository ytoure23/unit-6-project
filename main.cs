using System;

class Program {
  public static void Main (string[] args) {
    
    //Console.WriteLine ("Rock,Paper,or Sissors?");
  
      
    int playerScore = 0;
    int computerScore = 0;
    while(true){
      
      
      Console.WriteLine ("Rock,Paper,or scissors?");
      
      string userChoice = Console.ReadLine();
      //random number gen that generates the number choices at random making the computer pick the choices at random
      Random rnd = new Random();
      int RandomNumberGen = rnd.Next(3);
      string[] computerArray = {"rock", "paper", "scissor"};
      string computerChoice = computerArray[RandomNumberGen];      
      //rock= 0 paper=1 sissor=2

      
      if(userChoice == "rock")
      {
        if(computerChoice == userChoice)
        {
          Console.WriteLine("Tie");
        }
        else if(computerChoice == "scissor")
        {
          Console.WriteLine("You WIN!");
          playerScore++;
        } 
        else if(computerChoice == "paper")
        {
          Console.WriteLine("YOU LOSE!");
        
          computerScore++;
      
          }
      }
      
      else if(userChoice == "paper")
      {
        if(computerChoice == userChoice)
        {
          Console.WriteLine("Tie");
        }
        else if(computerChoice == "scissor")
        {
          Console.WriteLine("You WIN!");
          playerScore++;
        } 
        else if(computerChoice == "rock")
        {
          Console.WriteLine("YOU LOSE!");
          computerScore++;
          }
       
      }
      
      else if(userChoice == "scissor")
      {
        if(computerChoice == userChoice)
        {
          Console.WriteLine("Tie");
        }
        else if(computerChoice == "rock")
        {
          Console.WriteLine("You WIN!");
          playerScore++;
        } 
        else if(computerChoice == "paper")
         {
           Console.WriteLine("YOU LOSE!");
           computerScore++;
         }
       }

      if(userChoice == "quit")
      {
      break;
      }
      //makes the score for both the computer and player
      
      Console.WriteLine("Player Score: " + playerScore + " Computer Score: "   + computerScore);
      
    
      }    
   //creates a file to store the scores that the player has ahcived.
    System.IO.File.AppendAllText("scores.txt", "Player Score: " + playerScore + " Computer Score: " + computerScore);
    
    }
}