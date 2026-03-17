
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
            Console.WriteLine("5. Xoa sinh vien");
            Console.WriteLine("6. Kiem tra phan tu ton tai");
            Console.WriteLine("7. Sap xep danh sach");
            Console.WriteLine("8. Dao nguoc danh sach");
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
                case 5: Bai5(); break;
                case 6: Bai6(); break;
                case 7: Bai7(); break;
                case 8: Bai8(); break;
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

    static void Bai5()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<string> students = new List<string>();

        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap ten sinh vien: ");
            students.Add(Console.ReadLine());
        }

        Console.Write("Nhap ten sinh vien can xoa: ");
        string nameToRemove = Console.ReadLine();

        if (students.Remove(nameToRemove))
        {
            Console.WriteLine("Da xoa " + nameToRemove);
            Console.WriteLine("Danh sach sinh vien sau khi xoa:");
            foreach (string name in students)
                Console.WriteLine(name);

        }

        else
            Console.WriteLine(nameToRemove + " khong ton tai trong danh sach.");
    }

    static void Bai6()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<string> items = new List<string>();

        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu: ");
            items.Add(Console.ReadLine());
        }

        Console.Write("Nhap chuoi can kiem tra: ");
        string searchString = Console.ReadLine();

        if (items.Contains(searchString))
            Console.WriteLine(searchString + " ton tai trong danh sach.");
        else
            Console.WriteLine(searchString + " khong ton tai trong danh sach.");
    }

    static void Bai7()
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

        numbers.Sort();

        Console.WriteLine("Danh sach sau khi sap xep:");
        foreach (int num in numbers)
            Console.Write(num + " ");
    }

    static void Bai8()
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

        numbers.Reverse();

        Console.WriteLine("Danh sach sau khi dao nguoc:");
        foreach (int num in numbers)
            Console.Write(num + " ");
    }
}

// Bài 8. Đảo ngược danh sách
// Tạo List<int>

// Đảo ngược thứ tự phần tử.

// Bài 9. Loại bỏ phần tử trùng lặp
// Nhập List<int>

// Tạo danh sách mới không chứa phần tử trùng.

// Bài 10. Tìm phần tử nhỏ nhất
// Viết chương trình tìm giá trị nhỏ nhất trong List<int>.

// Bài 11. Lưu danh sách sinh viên
// Tạo class:

// class Student {     public int Id;     public string Name; }
// Lưu danh sách sinh viên trong List<Student>

// In thông tin sinh viên.

// Bài 12. Tìm sinh viên theo tên
// Từ List<Student>

// Tìm sinh viên theo tên nhập vào.

// Bài 13. Đếm số sinh viên
// Đếm tổng số sinh viên trong List<Student>.

// Bài 14. Xóa sinh viên theo ID
// Nhập ID

// Xóa sinh viên có ID đó khỏi danh sách.