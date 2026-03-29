using System;

int playerRank = 42;
int opponentRank = 38;
int difference = Math.Abs(playerRank - opponentRank);
Console.WriteLine(difference);

if (difference >= 5)
	{
		Console.WriteLine("Skill gap is too large");
	}
else
{
	Console.WriteLine("Players are evenly matched");
}
