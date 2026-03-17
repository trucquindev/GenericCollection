
using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

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
            Console.WriteLine("9. Loai bo phan tu trung lap");
            Console.WriteLine("10. Tim so nho nhat");
            Console.WriteLine("11. Hien thi danh sach sinh vien");
            Console.WriteLine("12. Tim sinh vien theo ten");
            Console.WriteLine("13. Dem so sinh vien");
            Console.WriteLine("14. Xoa sinh vien theo ID");
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
                case 9: Bai9(); break;
                case 10: Bai10(); break;
                case 11: Bai11(); break;
                case 12: Bai12(); break;
                case 13: Bai13(); break;
                case 14: Bai14(); break;
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

    static void Bai9()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<int> numbers = new List<int>();
        List<int> newList = new List<int>();

        Console.Write("Nhap so luong: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        foreach (int x in numbers)
            if (!newList.Contains(x))
                newList.Add(x);

        foreach (int x in newList)
            Console.WriteLine(x);
    }

    static void Bai10()
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

        int min = numbers[0];
        foreach (int x in numbers)
            if (x < min) min = x;

        Console.WriteLine("So nho nhat: " + min);
    }

    static void Bai11()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<Student> students = new List<Student>();

        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();
            Console.Write("Nhap ID: ");
            s.Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            s.Name = Console.ReadLine();
            students.Add(s);
        }
        Console.WriteLine("Danh sach sinh vien:");
        foreach (Student s in students)
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}");
    }

    static void Bai12()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<Student> students = new List<Student>();

        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();
            Console.Write("Nhap ID: ");
            s.Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            s.Name = Console.ReadLine();
            students.Add(s);
        }

        Console.Write("Nhap ten sinh vien can tim: ");
        string nameToFind = Console.ReadLine();

        bool found = false;
        foreach (var s in students)
            if (s.Name == nameToFind)
            {
                Console.WriteLine(s.Id + " - " + s.Name);
                found = true;
                break;
            }
        if (!found)
            Console.WriteLine("Khong tim thay sinh vien co ten " + nameToFind);
    }

    static void Bai13()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<Student> students = new List<Student>();

        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();
            Console.Write("Nhap ID: ");
            s.Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            s.Name = Console.ReadLine();
            students.Add(s);
        }

        Console.WriteLine("Tong so sinh vien: " + students.Count);
    }

    static void Bai14()
    {
        Console.WriteLine("Nguyen Truc Quynh");
        Console.WriteLine("22115053122335");

        List<Student> students = new List<Student>();

        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();
            Console.Write("Nhap ID: ");
            s.Id = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten: ");
            s.Name = Console.ReadLine();
            students.Add(s);
        }

        Console.Write("Nhap ID sinh vien can xoa: ");
        int idToRemove = int.Parse(Console.ReadLine());

        Student studentToRemove = null;
        foreach (var s in students)
            if (s.Id == idToRemove)
            {
                studentToRemove = s;
                break;
            }
        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            Console.WriteLine("Da xoa sinh vien co ID " + idToRemove);
        }
        else
            Console.WriteLine("Khong tim thay sinh vien co ID " + idToRemove);
    }
}
