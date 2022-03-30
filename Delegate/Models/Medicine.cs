using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Models
{
    internal class Medicine
    {
        private static int _id;
        public  int Id { get; }
        public string Name { get; set; }    
        public string Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; }

        public Medicine(string name, double price, int count)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = Price;
            Count = count;
        }

        public void Sell()
        {
            Count--;   
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id{Id}- Name{Name}- Price{Price}- Count{Count}");
        }
    }
}
