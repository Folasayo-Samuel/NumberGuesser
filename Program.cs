using System;

namespace NumberGuesser
{
	class Program
	{
		static void Main(string[]args)
		{
			GetAppInfo();
			
			GreetUser();
			
			while(true){
			//Init correct number
			// var correctNumber = 7;
			
			// Create a new randome object
			var random = new Random();
			
			//Init correct number
			var correctNumber = random.Next(1, 18);
			
			// Init guess variable
			var guess = 0;
			
			// Ask user for number
			Console.WriteLine("Guess a number between 1 and 18");
			
			while(guess != correctNumber)
			{
				var input = Console.ReadLine();

				// Make sure its a number
				if(!int.TryParse(input, out guess))
				{
					// Print error message
					PrintColorMessage(ConsoleColor.Red, "Please use actual number");
					// Keep going
					continue;
				}
				
				// Cast to int and put in guess
				guess = Int32.Parse(input);
				
				// Match guess to correct  
				if(guess != correctNumber)
				{
					PrintColorMessage(ConsoleColor.Red, "Wrong number please try again");
				}
			}
			
			// Ouput success message
			PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");
			
			// Ask to play again
			Console.WriteLine("Play Again? [Y or N]");
			
			// Get answer
			var answer = Console.ReadLine().ToUpper();
			
			if(answer == "Y")
			{
				continue;
			}else if(answer == "N")
			{
				return;
			}
			else
			{
				return;
			}
			
			}
			
		}
		//  Get app info
		static void GetAppInfo()
		{
			// Set app variables
			var appName = "NumberGuesser";
			var appVersion = "1.0.0";
			var appAuthor =  "Folasayo Samuel";
			
			// Change text color
			Console.ForegroundColor = ConsoleColor.Blue;
			
			// Write out app info
			Console.WriteLine("{0}: Versrion {1} by {2}", appName, appVersion, appAuthor);
			
			//Reset tex color
			Console.ResetColor();
		}
		
		// Greet user
		static void GreetUser()
		{
			// Ask users name
			Console.WriteLine("What is your name?");
			
			//Get user input
			var inputName = Console.ReadLine();
			
			Console.WriteLine("Hello {0}, let's play a game...", inputName);
		}
		
		// Print color message
		static void PrintColorMessage(ConsoleColor color, string message)
		{
			// Change text color
					Console.ForegroundColor = color;
					
					// Tell user it's not a number
					Console.WriteLine(message);
					
					// Reset text color
					Console.ResetColor();
					
		}
	}
}