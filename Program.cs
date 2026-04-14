using LINQAssignment02.DataSources;
using LINQAssignment02.Helpers;
using LINQAssignment02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static LINQAssignment02.DataSources.Source;

namespace LINQAssignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + new string('-', 70) + "\n" + new string('-', 70) + "\n");

            #region LINQ ASSIGNMENT 02

            #region Question 01

            //1.Get top 3 most expensive products
            //=======================================

            //var top3 = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var p in top3)
            //    Console.WriteLine(p);

            #endregion

            #region Question 02
            //========================================
            //2.show page 2 of products, with page size = 5
            //=======================================

            //var page2 = ProductList.Skip(5).Take(5);

            //foreach (var p in page2)
            //    Console.WriteLine(p);

            #endregion

            #region Question 03
            //========================================
            //3.Take products from the list as long as Their UnitPrice is less than $25
            //(list is ordered by price).
            //========================================

            //var result3 = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);

            //foreach (var p in result3)
            //    Console.WriteLine(p);

            #endregion

            #region Question 04
            //========================================
            //4.Check if ALL products in the "Seafood" category are in stock
            //========================================

            //bool allInStock = ProductList.Where(p => p.Category == "Seafood")
            //                             .All(p => p.UnitsInStock > 0);

            //Console.WriteLine(allInStock);

            #endregion

            #region Question 05
            //========================================
            //5.Check if the ID list contains 9
            //int[] ids = { 3, 9, 13, 18 };
            //==========================================

            //int[] ids = { 3, 9, 13, 18 };

            //bool contains9 = ids.Contains(9);
            //Console.WriteLine(contains9);

            #endregion

            #region Question 06
            //========================================
            //6.Group all products by Category and
            //print each group with its product count.
            //========================================

            //var group6 = ProductList.GroupBy(p => p.Category);

            //foreach (var g in group6)
            //{
            //    Console.WriteLine($"{g.Key} - Product Count: {g.Count()}");
            //}

            #endregion

            #region Question 07
            //========================================
            //7.Group products by Category and project only product names per group
            //========================================

            //var group7 = ProductList.GroupBy(p => p.Category)
            //                        .Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName) });

            //foreach (var g in group7)
            //{
            //    Console.WriteLine("\n" + new string('-', 50) + "\n");
            //    Console.WriteLine(g.Category);
            //    foreach (var name in g.Names)
            //        Console.WriteLine(name);
            //}

            //// OR

            //Console.WriteLine("\n" + new string('-', 50) + "\n" + new string('-', 50));

            //var group07 = ProductList.GroupBy(p => p.Category);

            //foreach (var g in group07)
            //{
            //    Console.WriteLine("\n" + new string('-', 50) + "\n");
            //    Console.WriteLine(g.Key);
            //    foreach (var p in g)
            //    {
            //        Console.WriteLine(p.ProductName);
            //    }
            //}

            #endregion

            #region Question 08
            //========================================
            //8.Find all categories that have MORE THAN 3 products
            //========================================

            //var result8 = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);

            //foreach (var g in result8)
            //    Console.WriteLine(g.Key);

            #endregion

            #region Question 09
            //========================================
            //9.Using QUERY SYNTAX, group customers by Country,
            //and for each group select { Country, Count, TotalOrderValue }.
            //=========================================

            //var result9 = from c in CustomerList
            //              group c by c.Country into g
            //              select new 
            //              {
            //                  Country = g.Key,
            //                  Count = g.Count(),
            //                  TotalOrderValue = g.SelectMany(c => c.Orders).Sum(o => o.Total)
            //              };

            //foreach (var r in result9)
            //{
            //    Console.WriteLine(r);
            //}

            #endregion

            #region Question 10
            //========================================
            //10.Calculate the total number of units in stock across all products
            //========================================

            //var totalUnits = ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(totalUnits);

            #endregion

            #region Question 11 
            //========================================
            //11.Find the CHEAPEST and MOST EXPENSIVE product prices
            //========================================

            //var minPrice = ProductList.Min(p => p.UnitPrice);
            //var maxPrice = ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"Min: {minPrice}, Max: {maxPrice}");

            #endregion

            #region Question 12
            //========================================
            //12.Get a distinct list of all product categories
            //========================================

            //var categories = ProductList.Select(p => p.Category).Distinct();

            //foreach (var c in categories)
            //    Console.WriteLine(c);

            #endregion

            #region Question 13
            //========================================
            //13.find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //========================================

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 }; 
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //// 1, 5, 7, 11
            //var result13 = setA.Except(setB);

            //foreach (var x in result13)
            //    Console.WriteLine(x);

            #endregion

            #region Question 14
            //========================================
            //14.Find countries that appear in list1 but NOT in list2 (case -insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //========================================

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //// Germany, UK
            //var result14 = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var c in result14)
            //    Console.WriteLine(c);

            #endregion

            #region Question 15
            //========================================
            //15.Build a Dictionary<int, Product> keyed by ProductID.
            //Then retrieve and print the product with ID = 18.
            //========================================

            //var dict = ProductList.ToDictionary(p => p.ProductID);

            //if (dict.TryGetValue(18, out var product))
            //    Console.WriteLine(product);

            #endregion

            #region Question 16
            //========================================
            //16.Get the first product whose price is greater than $50.
            //=========================================

            //var result16 = ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(result16);

            #endregion

            #region Question 17
            //========================================
            //17.Try to get the first product with a price > $500.
            //it returns null instead of throwing.
            //========================================

            //var result17 = ProductList.FirstOrDefault(p => p.UnitPrice > 500);

            //if (result17 != null)
            //    Console.WriteLine(result17);
            //else
            //    Console.WriteLine("Not Found");

            #endregion

            #region Question 18

            //18.Generate a multiplication table row for 7

            #endregion

            #region Question 19

            //19.Generate even numbers between 1 and 30.

            #endregion

            #region Question 20

            //20.Concatenate the first 3 product names with
            //the first 3 customer company names into a single sequence.

            #endregion

            #region Question 21

            //21.Pair each product with a customer(by position)
            //and produce a string "ProductName sold to CompanyName".

            #endregion

            #endregion

            Console.WriteLine("\n" + new string('-', 70) + "\n" + new string('-', 70));


        }
    }
}
