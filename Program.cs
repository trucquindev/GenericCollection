
using System;
using System.Collections.Generic;


class Program
{
    static List<int> numbers = new List<int>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Tao list so");
            Console.Write("Chon: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 0) break;

            switch (choice)
            {
                case 1: Bai1(); break;

            }

        }

    }

    static void Bai1()
    {
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());
        numbers.Clear();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }
        Console.WriteLine("Danh sach so vua nhap:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }




}
