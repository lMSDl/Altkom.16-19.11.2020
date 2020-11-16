using System;
using System.Collections.Generic;

namespace WPCSharp.DesignPatterns.Creational.Singleton
{
    public sealed class Context
    {
        private readonly Dictionary<string, string> _settings = new Dictionary<string, string>();

        private static readonly Lazy<Context> _instance = new Lazy<Context> (() => new Context());

        static Context()
        {
        }

        private Context()
        {
            Console.WriteLine("Inicjalizacja ustawień");

            _settings.Add("1", "A");
            _settings.Add("2", "B");
            _settings.Add("3", "C");
        }
        public static Context GetInstance()
        {
            return _instance.Value;
        }

        //public static Context Instance { get; } = new Context();

        public string GetSettings(string key)
        {
            return _settings[key];
        }
        public void SetSettings(string key, string value)
        {
            _settings[key] = value;
        }
    }
}