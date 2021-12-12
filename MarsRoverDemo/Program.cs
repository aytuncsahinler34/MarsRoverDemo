using MarsRoverDemo.Enums;
using MarsRoverDemo.Models;
using System;

namespace MarsRoverDemo
{
	class Program
	{
        static void Main(string[] args) {
            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(1, 2);

            Rover rover = new Rover(plateau, position, DirectionEnum.N);
            rover.Process("LMLMLMLMM");
            Console.WriteLine(rover.CurrentPosition()); 


            rover.SetPosition(3, 3, DirectionEnum.E);
            rover.Process("MMRMMRMRRM");
            Console.WriteLine(rover.CurrentPosition());
            Console.ReadKey();
        }
    }
}
