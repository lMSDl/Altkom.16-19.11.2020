﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WPCSharp.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {

        private static readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        //static Elevator()
        //{
        //    var type = typeof(IElevatorOperation);
        //    _operations = AppDomain.CurrentDomain.GetAssemblies()
        //        .SelectMany(x => x.GetTypes())
        //        .Where(x => !x.IsInterface)
        //        .Where(x => type.IsAssignableFrom(x))
        //        .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
        //        .ToDictionary(x => x.GetType().Name.Substring(nameof(Elevator).Length));
        //}

        public void Execute(string action, int floor)
        {
            Execute(CreateOperation(action), floor);
        }
        public void Execute(IElevatorOperation command, int floor)
        {
            command?.Operate(floor);
        }

        public IElevatorOperation CreateOperation(string action)
        {
            if (!_operations.ContainsKey(action))
                _operations[action] = (IElevatorOperation)Activator.CreateInstance(Type.GetType($"{GetType().Namespace}.{nameof(Elevator)}{action}"));
            return _operations[action];

            //IElevatorOperation operation = null;
            //switch (nameof(Elevator) + action)
            //{
            //    case nameof(ElevatorDown):
            //        operation = new ElevatorDown();
            //        break;
            //    case nameof(ElevatorUp):
            //        operation = new ElevatorUp();
            //        break;
            //}
            //return operation;
        }
    }
}
