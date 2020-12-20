using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace AppDomainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сейчас будем запускать другую сборку в нашем процессе");
            AppDomain ad = AppDomain.CreateDomain("Мой домен");
             
            ad.ExecuteAssembly(@"F:\c#\Thread\DomainTest\bin\Release\DomainTest.exe");
            Console.ReadLine();
        }
    }
}
