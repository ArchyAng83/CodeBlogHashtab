using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogHashtab
{
    class Program
    {
        static void Main(string[] args)
        {
            var superHashTable = new SuperHashTable<Person>(100);
            var person = new Person() { Name = "Вася", Age = 25, Gender = 0 };
            superHashTable.Add(new Person() { Name = "Петя", Age = 35, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Андрей", Age = 23, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Аня", Age = 30, Gender = 1 });
            superHashTable.Add(person);

            Console.WriteLine(superHashTable.Search(new Person() { Name = "Вася", Age = 25, Gender = 0 }));
            Console.WriteLine(superHashTable.Search(person));


            Console.ReadLine();

            var person1 = new Person() { Name = "Петя", Age = 35, Gender = 0, Id = 1 };
            var person2 = new Person() { Name = "Андрей", Age = 23, Gender = 0, Id = 2 };
            var person3 = new Person() { Name = "Аня", Age = 30, Gender = 1, Id = 3 };
            var hashTable = new HashTable<int, Person>(100);
            hashTable.Add(person1.Id, person1);
            hashTable.Add(person2.Id, person2);
            hashTable.Add(person3.Id, person3);
            

            Console.WriteLine(hashTable.Search(person1.Id, person1));
            Console.WriteLine(hashTable.Search(18, person2));

            Console.ReadLine();

            var badHashTable = new BadHashTable<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);
            badHashTable.Add(7);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));


            Console.ReadLine();
        }
    }
}
