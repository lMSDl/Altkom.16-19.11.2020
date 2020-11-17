﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.DesignPatterns.Creational.ObjectPool
{
    public class Item
    {
        private bool isCollected;

        public bool IsVisible { get; set; }
        public bool IsCollected
        {
            get => isCollected;
            set
            {
                if (isCollected = value)
                    IsVisible = false;
            }
        }

        public byte[] Content { get; } = new byte[1024];
    }
}
