using System.Collections.Generic;
using System.Security.Cryptography;

public class Dictionary
{
    static void Main()
    {
        var list = new List<string>(){
                                    "unknown:email@mail.com",
                                    "Sasha:sasha1995@sasha.ru",
                                    "Tom:Tom1998@gmail.com",
                                    "Sam:sami@mail.ru",
                                    "Bill:bibb@google.com",
                                    "Bob:Bobb33@mail.ru",
                                    "C:CiDed@gmail.com",
                                    "Mariya:Masha333@mail.ru",
                                    "Franz:Kafka@gmail.com",
                                    "Fiona:Fialka1999@mail.ru",
                                    "Fiona:Fiona333@gmail.com",
                                    "Fill:Spencer123@google.com",
                                    "s:sasok25@mail.ru",
                                    "sasha1995:sasha1995@sasha.ru",
                                    "sasha:alex99@mail.ru",
                                    "s1:ssok@mail.ru",
                                    "sania:shurik2020@google.com",
                                    "sS:sasok25@mail.ru",
                                    "vasia:Vasek12@mail.re",
                                    "Aaron:А@A.A\n"
                                    };

        var dictionary = new Dictionary<string, List<string>>();
        dictionary = OptimizeContacts(list);
        foreach (var item in dictionary)
        {
            Console.WriteLine(item.Key + " -> " + String.Join(",", item.Value));
        }
        Console.ReadLine();
    }

    private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
    {
        var dictionary = new Dictionary<string, List<string>>();

        foreach (var contact in contacts)
        {
            var key = GetContactName(contact);
            if (!dictionary.ContainsKey(GetContactName(contact))) 
            {
                dictionary[key] = new List<string>();
                dictionary[key].Add(contact);
            }
            else
            {
                dictionary[key].Add(contact);
            }
        }
        return dictionary;
    }

    private static string GetContactName(string contacts) 
    {
        string contactName = contacts.Split(":").First();
        return contactName.Count() > 1 ? contactName.Substring(0,2) : contactName;
    }
}