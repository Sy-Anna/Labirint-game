﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint_game
{
	internal class MazeProgram
	{

		static void Main(string[] args)
		{
			bool[,] vertWalls = new bool[3, 3];
			bool[,] horWalls = new bool[2, 4];
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					vertWalls[i, j] = false;
				}
			}
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					horWalls[i, j] = false;
				}
			}
			MazeClass test = new MazeClass(vertWalls, horWalls);
			test.MovePlayer(true, false);
			test.MovePlayer(false, false);
			for (int i = 0; i < 4; i++)
			{
				test.MovePlayer(true, true);
				test.MovePlayer(false, true);
				test.WriteFullStatus();
			}
			Console.ReadLine();
		}

	}
}
