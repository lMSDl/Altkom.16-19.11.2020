﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.SOLID.O
{
    public class TaxCalculator
    {
        public double CalculateTax(double Price) { return Price * 0.22; }
    }
    public class Item
    {
        public double Price { get; set; }
        public string Name { get; set; }
    }
    public class CashRegister
    {
        public TaxCalculator taxCalc = new TaxCalculator();
        public double CalculatePrice(Item[] Items)
        {
            double _price = 0;
            foreach (Item item in Items)
            {
            _price += item.Price + taxCalc.CalculateTax(item.Price);
            }
            return _price;
        }
        public void PrintBill(Item[] Items)
        {
            foreach (var item in Items)
                Console.WriteLine("towar {0} : cena {1} + podatek {2}",
                item.Name, item.Price, taxCalc.CalculateTax(item.Price));
        }
    }
}
