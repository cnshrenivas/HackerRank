// See https://aka.ms/new-console-template for more information
using HackerRank.Tests;

Console.WriteLine("Hello, World!");
BitManipulation bitManipulation = new BitManipulation();


//var singlenumber_result = bitManipulation.SingleNumber(new List<int> { 1, 2, 3, 4, 3, 2, 1 });
//Console.WriteLine(singlenumber_result);

//var maximumxor_result = bitManipulation.maximizingXor(10, 15);

//var sansaXOR_result = bitManipulation.sansaXor(new List<int> { 3, 4, 5, 6 });

//int median = SearchingAndSorting.findMedian(new List<int> { 0, 1, 2, 4, 6, 5, 3 });

var result = SearchingAndSorting.icecreamParlor(4, new List<int> { 1, 4,5,3,2 }); //1,4
//var result = SearchingAndSorting.icecreamParlor(4, new List<int> {2,2,4,3});

//List<int> arr = new List<int> { 7, 2, 5, 3, 5, 3 };
//List<int> brr = new List<int> { 7, 4, 5, 6, 2, 5, 3, 3 };
////List<int> arr = new List<int> { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
////List<int> brr = new List<int> { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
//var missingNumbers = SearchingAndSorting.missingNumbers(arr, brr);

#region Recursion Test Inputs
//Recursion.staircase(6);

var fibonacci_result = Recursion.Fibonacci(5);
#endregion

