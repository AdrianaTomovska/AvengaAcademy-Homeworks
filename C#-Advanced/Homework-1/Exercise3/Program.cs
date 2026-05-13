
int userWins = 0;
int computerWins = 0;
int draws = 0;

 Random rand = new Random();

bool running  = true;

while (running)
{
    Console.Clear();

    Console.WriteLine("ROCK PAPER SCISSORS");
    Console.WriteLine("1. Play");
    Console.WriteLine("2. Stats");
    Console.WriteLine("3.Exit");

    string choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            PlayGame();
            break;

        case "2":
            ShowStats();
            break;

        case "3":
            running = false;
            break;

        default: 
            Console.WriteLine("Invalid option.");
            Pause();
            break;
    }
}

void PlayGame()
{
    Console.Clear();

    Console.WriteLine("Choose:");
    Console.WriteLine("rock");
    Console.WriteLine("paper");
    Console.WriteLine("scissors");
    Console.WriteLine("Your choice: ");

    string userChoice = Console.ReadLine().ToLower();

    if(userChoice != "rock" &&  userChoice != "paper" && userChoice != "scissors")
    {
        Console.WriteLine("Invalid choice");
        Pause();
        return;
    }

    string[] options = { "rock", "paper", "scissors" };

    string computerChoice = options[rand.Next(options.Length)];

    Console.WriteLine();
    Console.WriteLine($"You picked: {userChoice}");
    Console.WriteLine($"Computer picked: {computerChoice}");
    Console.WriteLine();

    if(userChoice == computerChoice)
    {
        Console.WriteLine("It's a draw!");
        draws++;
    }
    else if ((userChoice == "rock" && computerChoice == "scissors") ||
            (userChoice == "paper" && computerChoice == "rock") ||
            (userChoice == "scissors" && computerChoice == "paper"))
    {
        Console.WriteLine("You win!!!");
        userWins++;
    }
    else
    {
        Console.WriteLine("Computer wins");
        computerWins++;
    }

    Pause();
}

void ShowStats()
{
    Console.Clear();

    int totalGames = userWins + computerWins + draws;

    double winPercentage = 0;
    double lossPercentage = 0;

    if (totalGames > 0)
    {
        winPercentage =
                    (double)userWins / totalGames * 100;

        lossPercentage =
            (double)computerWins / totalGames * 100;
    }

    Console.WriteLine("Stats");
    Console.WriteLine($"User wins: {userWins}");
    Console.WriteLine($"Computer wins: {computerWins}");
    Console.WriteLine($"Draws: {draws}");
    Console.WriteLine();

    Console.WriteLine($"Win percentage: {winPercentage:F2}%");
    Console.WriteLine($"Loss percentage: {lossPercentage:F2}%");

    Pause();
}

static void Pause()
{
    Console.WriteLine();
    Console.WriteLine("Press ENTER to return to menu...");
    Console.ReadLine();
}
    