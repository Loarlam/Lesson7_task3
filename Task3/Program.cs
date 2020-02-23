/*Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change. 
В классе  Program  создайте два  метода:  
- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass значение «изменено». 
- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено». 
Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса. Измените, значения полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. Проанализируйте полученные результаты. 
*/
using System;

namespace Task3
{
    struct MyStruct
    {
        public string change;
    }

    class Program
    {
        static void StruktTaker(ref MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();
            MyClass myClass = new MyClass();

            myStruct.change = "не изменено";
            myClass.change = "не изменено";

            Console.WriteLine($"Значение поля change структуры MyStruct {myStruct.change}");
            Console.WriteLine($"Значение поля change класса MyClass {myClass.change}");
            Console.WriteLine(new string('-', 30));

            StruktTaker(ref myStruct);
            ClassTaker(myClass);

            Console.WriteLine($"Значение поля change структуры MyStruct после метода StruktTaker {myStruct.change}");
            Console.WriteLine($"Значение поля change класса MyClass после метода ClawssTaker {myClass.change}");

            Console.ReadKey();
        }
    }
}
