//Shaun Aguirre-Reyes
//10/17/22
//2:21pm
//Console will ask the user for their name and input what the user inputs while saying
//"Good Afternoon (User Name)"

Console.Clear();

string playAgain = "yes";
while(playAgain == "yes"){

Console.WriteLine("What is Your Name?");

string myName = Console.ReadLine();

Console.WriteLine("Good Afternoon " + myName);

Console.WriteLine("Do you want to play again?");
playAgain = Console.ReadLine();
if(playAgain == "yes"){
    Console.WriteLine("Lets play again");
}else{
    Console.WriteLine("Have a great day :)");
}

}