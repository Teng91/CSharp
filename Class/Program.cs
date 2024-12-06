using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         double x = Math.Pow(2, 10);
    //         System.Console.WriteLine("x = " + x);

    //         double y = Math.Sqrt(x);
    //         System.Console.WriteLine("y = " + y);

    //         Calculator c = new Calculator();
    //         int z = c.Add(2, 3);
    //         Console.WriteLine("z = " + z);

    //         Calculator d = new Calculator();
    //         string str = d.Today();
    //         Console.WriteLine(str);

    //         c.PrintSum(4, 6);
    //     }
    // }

    // class Calculator
    // {
    //     public int Add(int a, int b)
    //     {
    //         int result = a + b;
    //         return result;
    //     }

    //     public string Today()
    //     {
    //         int day = DateTime.Now.Day;
    //         return day.ToString();
    //     }

    //     public void PrintSum(int a, int b)
    //     {
    //         int result = a + b;
    //         Console.WriteLine(result);
    //     }
    // }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { ID = 1, Name = "Joy"};
            System.Console.WriteLine(student.ID);
            System.Console.WriteLine(student.Name);
            student.Report(); // Report()不是靜態方法，不能直接透過類名來調用
            // 解法:如果真的要調用類名，需要聲明Report()為靜態方法(前面加上static修飾)
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public void Report()
        {
            System.Console.WriteLine($"I'm #{ID} student, my name is {Name}."); // 兩種寫法是一樣的
            System.Console.WriteLine("I'm #{0} student, my name is {1}.", ID, Name);
        }
    }
}
