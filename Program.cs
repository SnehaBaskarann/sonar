using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Text;

namespace mysqlefcore
{
  class Program
  {
    public static void Main(string[] args)
    {

      while (true)
      {
        Console.WriteLine("\t\t\t Doctor Management System");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.WriteLine("1.Insert\t 2.Print\t 3.Update\t 4.Remove\t 5.Exit ");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
          case 1:
            CreateData.InsertData();
            break;
          case 2:
            PrintData.ReadData();
            break;
          case 3:
            UpdateData.EditData();
            break;
          case 4:
            DeleteData.RemoveData();
            break;
          case 5:
            Environment.Exit(0);
            break;
          default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
        }
      }
    }

  }
}
