using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AirportProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            StreamWriter streamWriter = new StreamWriter("project.txt");
            Console.WriteLine("enter count");
            int count = int.Parse(Console.ReadLine());
            string operation;
            do
            {
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "employees":
                        Console.WriteLine("enter emp");
                        List<Employees> employees = new List<Employees>();
                        for (int i = 0; i < count; i++)
                        {
                            var dann = Console.ReadLine().Split();
                            Employees emp = new Employees(dann[0], dann[1], int.Parse(dann[2]), dann[3], dann[4]);
                            employees.Add(emp);
                            using (streamWriter)
                            {
                                streamWriter.Write(dann[0]);
                                streamWriter.Write(dann[1]);
                                streamWriter.Write(dann[2]);
                                streamWriter.Write(dann[3]);
                            }
                        }
                        employees.ForEach(x => x.PrintInfo());
                        break;
                    case "pasanger":
                        Console.WriteLine("enter pass");
                        List<Pasanger> p = new List<Pasanger>();
                        var danni = Console.ReadLine().Split();
                        Pasanger pas = new Pasanger(danni[0], danni[1], int.Parse(danni[2]), int.Parse(danni[3]), danni[4], danni[5]);
                        p.Add(pas);
                        using (streamWriter)
                        {
                            streamWriter.Write(danni[0]);
                            streamWriter.Write(danni[1]);
                            streamWriter.Write(danni[2]);
                            streamWriter.Write(danni[3]);
                        }
                        p.ForEach(x => x.PrintInfo());
                        break;
                        case "fly":
                        Console.WriteLine("enter fly");
                        List<Fly> f = new List<Fly>();
                        var dannis = Console.ReadLine().Split();
                        Fly fly = new Fly(int.Parse(dannis[0]), int.Parse(dannis[1]), dannis[2], dannis[3]);
                        f.Add(fly);
                        using (streamWriter)
                        {
                            streamWriter.Write(dannis[0]);
                            streamWriter.Write(dannis[1]);
                            streamWriter.Write(dannis[2]);
                            streamWriter.Write(dannis[3]);
                        }
                        f.ForEach(x => x.PrintInfo());
                        break;
                }
            } while (operation != "employees" || operation != "fly" || operation != "pasanger");
        StreamReader reader = new StreamReader("project.txt");
        reader.Close();
        
        }
    }
}
