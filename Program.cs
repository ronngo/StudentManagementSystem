using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace KiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program program = new Program();
            Student student = new Student();

            int choice = 0;

            do
            {
                Console.WriteLine("1.Insert new Student");
                Console.WriteLine("2.View list of Student");
                Console.WriteLine("3.Search Student");
                Console.WriteLine("4.Exit");
                 Console.WriteLine("\n");
                Console.WriteLine("Please select an item : ");
                choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1 :
                   program.AddStudent();
                break;
                   
                case 2 :
                    program.ViewStudent();
                break;

                case 3 :
                    program.FindStudent();
                break;

                case 4 :

                break;
            }        
            } while (choice != 4);       
    }

    int count = 0;
    Hashtable ListStudent = new Hashtable();

    public void AddStudent()
    {
        Student student = new Student();
        student.ID = count;
        Console.WriteLine("Nhap fullname : ");
        student.FullName = Console.ReadLine();
        Console.WriteLine("Nhap dateofbirth : ");
        student.DateofBirth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Nhap native : ");
        student.Native = Console.ReadLine();
        Console.WriteLine("Nhap class : ");
        student.Class = Console.ReadLine();
        Console.WriteLine("Nhap phoneno : ");
        student.PhoneNo = Console.ReadLine();
        Console.WriteLine("Nhap mobile : ");
        student.Mobile = Int32.Parse(Console.ReadLine());
        ListStudent.Add(count, student);
        count++;
    }

    public void ViewStudent()
    {
        foreach (Student item in ListStudent.Values)
        {
            item.Display();
        }
    }
    public void FindStudent()
    {
        string name;
        Console.WriteLine("Nhap tim kiem student : ");
        name = Console.ReadLine();
        foreach (Student item in ListStudent.Values)
         if (item.FullName.Equals(name))
             item.Display();
         
         else Console.WriteLine("khong tim thay ten");

    }      
    }
}