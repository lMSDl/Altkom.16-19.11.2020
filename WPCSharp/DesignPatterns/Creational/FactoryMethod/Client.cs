using System;
using System.Collections.Generic;
using System.Text;
using WPCSharp.DesignPatterns.Creational.Builder;

namespace WPCSharp.DesignPatterns.Creational.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "Down";
            elevator.Execute(action, 5);
            elevator.Execute(ElevatorActions.Up.ToString(), 1);
            elevator.Execute(ElevatorActions.Up.ToString(), 5);
            elevator.Execute(ElevatorActions.Up.ToString(), 3);
        }
    }
}
