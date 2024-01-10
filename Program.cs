using System;
using System.Collections.Generic;
using assignment4;


    
    
        // Creating a sorted list to store products
        SortedList<int, Product> productList = new SortedList<int, Product>();

        // Adding sample products to the list
        productList.Add(1, new Product("ProductA", 19.99, "BrandA", new DateTime(2024, 1, 1), new DateTime(2024, 12, 31)));
        productList.Add(2, new Product("ProductB", 29.99, "BrandB", new DateTime(2024, 2, 1), new DateTime(2024, 11, 30)));
        productList.Add(3, new Product("ProductC", 9.99, "BrandC", new DateTime(2024, 3, 1), new DateTime(2024, 10, 31)));
        productList.Add(4, new Product("ProductD", 39.99, "BrandD", new DateTime(2024, 4, 1), new DateTime(2024, 9, 30)));
        productList.Add(5, new Product("ProductE", 49.99, "BrandE", new DateTime(2024, 5, 1), new DateTime(2024, 8, 31)));

        // Displaying product details
        Console.WriteLine("Index\tKey\tPName\t\tPrice\tBrand\tMfDate\t\tExpDate");
        Console.WriteLine("-------------------------------------------------------------");
        foreach (var product in productList)
        {
            Console.WriteLine($"{product.Key}\t{product.Key}\t{product.Value.PName}\t{product.Value.PPrice}\t{product.Value.PBrand}\t{product.Value.MfDate.ToShortDateString()}\t{product.Value.ExpDate.ToShortDateString()}");
        }
    


