using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ThanaNita.Turtles.One;

namespace TurtleLab.Project;

internal class Project
{
	public static void Run()
	{
		SetPenSize(2);
		SetPenColor(Color.Goldenrod);
		SetSpeed(1000);
		var position = Position;
        var direction = Direction;
        BigPetal();
		Small();
        BigPetal();
		Small();
		BigPetal();
		Small();
		BigPetal();
		Small();
		Dot(Color.White, 250);
        Dot(Color.Goldenrod, 235);
        Dot(Color.White, 160);
        Dot(Color.Goldenrod, 110);
	}
	private static void BigPetal()
	{
		var position = Position;
		Forward(50);
		Biggest(1, 1.5f);
		Biggest(-1, 1.5f);
		Fill(Color.Goldenrod);
		Big(1, 1.15f);
		Big(-1, 1.15f);
		Fill(Color.White);
		Big(1, 1f);
		Big(-1, 1f);
		Fill(Color.Goldenrod);
		Big(1, 0.85f);
		Big(-1, 0.85f);
		Fill(Color.White);
		Big(1, 0.75f);
		Big(-1, 0.75f);
		Fill(Color.Goldenrod);
		TurnRight(45);
		Position = position;
	}
	private static void Big(int sign, float scale)
	{
		var position = Position;
		var direction = Direction;
		TurnLeft(90 * sign);
		for (int i = 0; i < 20; ++i)
		{
			TurnRight(7 * sign);
			Forward(10 * scale);
		}
		for (int i = 0; i < 3; ++i)
		{
			TurnLeft(2 * sign);
			Forward(20.5f * scale);
		}
		Direction = direction;
		Position = position;
	}
	private static void Biggest(int sign, float scale)
	{
		var position = Position;
		var direction = Direction;
		TurnLeft(90 * sign);
		for (int i = 0; i < 16; ++i)
		{
			TurnRight(7 * sign);
			Forward(11.5f * scale);
		}
		TurnRight(160 * sign);
		ArcLeft(120 * sign, 20);
		TurnLeft(150 * sign);
		for (int i = 0; i < 4; ++i)
		{
			TurnRight(8f * sign);
			Forward(12f * scale);
		}
		for (int i = 0; i < 4; ++i)
		{
			TurnLeft(2 * sign);
			Forward(20f * scale);
		}
		Direction = direction;
		Position = position;
	}
	static void Small()
	{
		var centerPosition = Position;
		var centerDirection = Direction;
		PenUp();
		Forward(190);
		TurnRight(90);
		var direction = Direction;
		var position = Position;
		PenDown();
		TurnLeft(90);
		ArcRight(40, 70);
		Direction = direction;
		TurnLeft(115);
		Forward(65);
		Position = position;
		Direction = direction;
		TurnLeft(90);
		ArcLeft(40, 70);
		Direction = direction;
		TurnLeft(65);
		Forward(65);
		Fill(Color.Goldenrod);
		Direction = direction;
		Position = position;
		PenUp();
		TurnLeft(90);
		Forward(110);
		//Direction = directon;
		PenDown();
		TurnLeft(150);
		Forward(80);
		Direction = direction;
		TurnLeft(90);
		ArcRight(100, 53);
		Direction = direction;
		TurnRight(40);
		ArcRight(100, 53);
		TurnRight(150);
		Forward(80);
		TurnLeft(90);
		Fill(Color.Goldenrod);
		Position = centerPosition;
		Direction = centerDirection;
		TurnRight(45);
	}
}