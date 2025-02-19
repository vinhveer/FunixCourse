﻿namespace ProductManagementStatic
{
    internal class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price:C}";
        }
    }
}
