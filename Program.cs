
using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Tao list so");
            Console.WriteLine("2. Tinh tong list so");
            Console.WriteLine("3. Tim so lon nhat");
            Console.WriteLine("4. Dem so chan");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 0) break;

            switch (choice)
            {
                case 1: Bai1(); break;
                case 2: Bai2(); break;
                case 3: Bai3(); break;
                case 4: Bai4(); break;
                default: Console.WriteLine("Lua chon khong hop le!"); break;
            }

        }

    }

    static void Bai1()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<int> numbers = new List<int>();

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

    static void Bai2()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<int> numbers = new List<int>();

        Console.Write("Nhap so luong: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        int sum = 0;
        foreach (int x in numbers)
            sum += x;

        Console.WriteLine("Tong = " + sum);
    }

    static void Bai3()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<int> numbers = new List<int>();

        Console.Write("Nhap so luong: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        int max = numbers[0];
        foreach (int x in numbers)
            if (x > max) max = x;

        Console.WriteLine("So lon nhat: " + max);
    }

    static void Bai4()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<int> numbers = new List<int>();

        Console.Write("Nhap so luong: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        int evenCount = 0;
        foreach (int x in numbers)
            if (x % 2 == 0) evenCount++;

        Console.WriteLine("So luong so chan: " + evenCount);
    }
}

// Bài 1. Tạo danh sách số nguyên
// Tạo List<int>

// Thêm 5 số bất kỳ

// In các phần tử ra màn hình.

// Bài 2. Tính tổng các phần tử
// Nhập các số nguyên vào List<int>

// Tính tổng các phần tử trong danh sách.

// Bài 3. Tìm số lớn nhất
// Nhập danh sách số nguyên.

// Tìm và in ra số lớn nhất trong List<int>.

// Bài 4. Đếm số chẵn
// Tạo List<int>

// Đếm bao nhiêu số chẵn trong danh sách.

// Bài 5. Xóa phần tử khỏi List
// Tạo List<string> chứa tên sinh viên.

// Xóa một tên do người dùng nhập.

// Bài 6. Kiểm tra phần tử tồn tại
// Tạo List<string>

// Kiểm tra một chuỗi có tồn tại trong danh sách hay không.

// Bài 7. Sắp xếp danh sách
// Nhập List<int>

// Sắp xếp tăng dần và in kết quả.