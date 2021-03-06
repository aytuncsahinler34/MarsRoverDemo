using MarsRoverDemo.Enums;
using MarsRoverDemo.Models;
using System;

namespace MarsRoverDemo
{
    public static class MainRoverClass
    {
        public static DirectionEnum heading = DirectionEnum.N;

        public static void SetPosition(this Rover rover, int x, int y, DirectionEnum direction) {
            if (rover.position == null) 
            {
                rover.position = new Position(x, y);
            }
            else 
            {
                rover.position.x = x;
                rover.position.y = y;
            }

            heading = direction;
        }

        public static string CurrentPosition(this Rover rover) 
        {
            return rover.position.x + " " + rover.position.y + " " + rover.heading;
        }

        public static void Process(this Rover rover, string command) {
            for (int i = 0; i < command.Length; i++) {
                rover.RunCommand(command[i]);
            }
        }

        public static void RunCommand(this Rover rover, char command) {
            if ('L' == command)
                rover.TurnLeft();
            else if ('R' == command)
                rover.TurnRight();
            else if ('M' == command) {
                if (!rover.Move())
                    Console.WriteLine("Where are you trying to go?");
            }
            else {
                Console.WriteLine("Wrong parameters!..");
            }
        }

        public static bool Move(this Rover rover) 
        {
            if (!rover.plateau.IsMoveAvailable(rover.position)) {
                return false;
            }

            switch (heading) {
                case DirectionEnum.N:
                    rover.position.y += 1;
                    break;
                case DirectionEnum.E:
                    rover.position.x += 1;
                    break;
                case DirectionEnum.S:
                    rover.position.y -= 1;
                    break;
                case DirectionEnum.W:
                    rover.position.x -= 1;
                    break;
            }

            return true;
        }

        public static void TurnLeft(this Rover rover) {
            heading = ((int)heading - 1) < (int)DirectionEnum.N ? DirectionEnum.W : (DirectionEnum)((int)heading - 1);
        }

        public static void TurnRight(this Rover rover) {
            heading = ((int)heading + 1) > (int)DirectionEnum.W ? DirectionEnum.N : (DirectionEnum)((int)heading + 1);
        }
    }
}
