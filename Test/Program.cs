using System;
using DataAccess;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonData.CreateJson());
            Console.WriteLine(SQLiteDataBase.CreateDataBase());
            SQLiteDataBase.CreateTable();
        }
    }
}
