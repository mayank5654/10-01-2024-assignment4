using System;
using System.Collections.Generic;
using assignment4;


    
    
        // Creating a sorted list to store products
        SortedList<int, Product> productList = new SortedList<int, Product>();

        // Adding sample products to the list
        productList.Add(1, new Product("Mobile", 36000.99, "oneplus", new DateTime(2024, 1, 1), new DateTime(2025, 12, 31)));
        productList.Add(2, new Product("Laptop", 86000.99, "apple", new DateTime(2024, 2, 1), new DateTime(2028, 11, 30)));
        productList.Add(3, new Product("fridge", 34000.99, "samsung", new DateTime(2024, 3, 1), new DateTime(2026, 10, 31)));
        productList.Add(4, new Product("geyser", 22000.99, "bajaj", new DateTime(2024, 4, 1), new DateTime(2027, 9, 30)));
        productList.Add(5, new Product("tv", 55000.99, "samsung", new DateTime(2024, 5, 1), new DateTime(2025, 8, 31)));

        // Displaying product details
        Console.WriteLine("Index\tKey\tPName\t\tPrice\tBrand\tMfDate\t\tExpDate");
        Console.WriteLine("-------------------------------------------------------------");
        foreach (var product in productList)
        {
            Console.WriteLine($"{product.Key}\t{product.Key}\t{product.Value.PName}\t{product.Value.PPrice}\t{product.Value.PBrand}\t{product.Value.MfDate.ToShortDateString()}\t{product.Value.ExpDate.ToShortDateString()}");
        }
    //////////////////////////////////////////////////
    ///



