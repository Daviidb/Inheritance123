﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise
    {
        private string title = "";
        private double price = 0;

        public double getPrice()
        {
            return Price;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public Book(string itemId, string title) : this(itemId, title, 0) { }

        public Book(string itemId) : this(itemId, "") { }

        public Book() { }



        public override string ToString()
        {
            string result = null;

            result += "ItemId: " + ItemId + ", ";
            result += "Title: " + title + ", ";
            result += "Price: " + price;

            return result;
        }
        public override double GetValue()
        {
            return Price;

        }


    }
}
