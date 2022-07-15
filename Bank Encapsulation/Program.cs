using Bank_Encapsulation;
var account1 = new BankAccount();
//Console.WriteLine("Please Enter the amount you would like to deposit");
//var amount = double.Parse(Console.ReadLine());
//account1.Deposit(amount);

//Console.WriteLine("Please enter the amount you would like to withdraw");
//amount = double.Parse(Console.ReadLine());
//account1.Withdraw(amount);

//Console.WriteLine("Ok thank you!");
//Console.WriteLine("Here is your remaining balance");
//account1.GetBalance();

while (true)
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Get Balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Exit");
    Console.WriteLine();
    bool didParse = double.TryParse(Console.ReadLine(), out double x);
    Console.WriteLine();
    if (x == 1)
    {
        GetBalance(account1);
    }
    else if (x == 2)
    {
        DepositLoop(account1);
    }
    else if (x == 3)
    {
        WithdrawLoop(account1);
    }
    else
    {
        break;
    }
}

static void DepositLoop(BankAccount myAccount)
{
    string userInput;
    while (true)
    {
        Console.WriteLine("How much would you like to deposit?");
        bool depositParsed = double.TryParse(Console.ReadLine(), out double depositAmount);
        myAccount.Deposit(depositAmount);

        Console.WriteLine("Would you like to deposit more?   yes/no");
        userInput = Console.ReadLine().ToLower();
        if (userInput == "yes")
        {
            continue;
        }
        break;
    }
}

static void WithdrawLoop(BankAccount myAccount)
{
    string userInput;
    while (true)
    {
        Console.WriteLine("How much would you like to withdraw?");
        bool withdrawParsed = double.TryParse(Console.ReadLine(), out double withdrawAmount);
        myAccount.Withdraw(withdrawAmount);

        Console.WriteLine("Would you like to withdraw more?   yes/no");
        userInput = Console.ReadLine().ToLower();
        if (userInput == "yes")
        {
            continue;
        }
        break;
    }
}

static void GetBalance(BankAccount myAccount)
{
    myAccount.GetBalance();
    Console.WriteLine();
}
