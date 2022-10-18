//Harrison Busby
//10/18/2022
//Mini Challenge 7
//Reverse it

string endString = "";
while(endString != "End"){
string inputNumber = "";
string reverseInput = "";
int remainder = 0;
int reverseNumber = 0;
bool numberBool = true;
int realNumber = 0;
Console.WriteLine("Lets reverse some numbers!");
Console.WriteLine("Please enter some numbers.");
inputNumber = Console.ReadLine();
numberBool = Int32.TryParse(inputNumber, out realNumber);
if (numberBool)
{   
    while (realNumber > 0)
    {   remainder = realNumber % 10;
        realNumber = realNumber / 10;
        reverseNumber = (reverseNumber * 10) + remainder;
    }
Console.WriteLine(inputNumber + " | " + reverseNumber);
}else{
    for (int i = inputNumber.Length - 1;i >= 0; i--)
    {
        reverseInput = reverseInput + inputNumber[i];
    }
Console.WriteLine(inputNumber + " | " + reverseInput);
} 
    Console.WriteLine("Please type 'End' To Terminate the program or press 'Enter' to play again");
    endString = Console.ReadLine().ToLower();
}
