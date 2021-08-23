using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");
    MooseSays("Scream is the best horror movie, you heard it here first folks!");

    // ScreamQuestion();
    // MovieQuestion();
    // LoveQuestion();

    // doing some refactoring

    MooseQuestion("Is Billy Loomis the best Ghostface?", "THAT MAKES ME ENTHUSIASTIC!!!!!!!!!!!", "Ew, what? You're probably a Roman Bridger stan.");
    MooseQuestion("What's your favorite scary movie? Is it Scream?", "MINE TOO!!!", "You're lame :|");
    MooseQuestion("Do you believe in love?", "SAME HERE! I think I've already found my soulmate <3", "WHAT?! But love is amazing! :<");
}

void MooseQuestion(string question, string yResponse, string nResponse)
{
    bool isTrue = MooseAsks($"{question} (Y/N): ");
    if (isTrue)
    {
        MooseSays(yResponse);
    }
    else
    {
        MooseSays(nResponse);
    }
}

// more refactoring above

// void MovieQuestion()
// {
//     bool isTrue = MooseAsks("What's your favorite scary movie? Is it Scream?");
//     if (isTrue)
//     {
//         MooseSays("MINE TOO!!!");
//     }
//     else
//     {
//         MooseSays("You're lame :|");
//     }
// }

// void LoveQuestion()
// {
//     bool isTrue = MooseAsks("Do you believe in love?");
//     if (isTrue)
//     {
//         MooseSays("SAME HERE! I think I've already found my soulmate <3");
//     }
//     else
//     {
//         MooseSays("WHAT?! But love is amazing! :<");
//     }
// }


void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}