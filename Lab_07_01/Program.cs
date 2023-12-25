// using System.Xml.Serialization;
// using static Lab_07_01.Animal;
//
//
// Cow cow = new Cow
// {
//     Country = "USA",
//     HideFromOtherAnimals = "Green Pastures",
//     Name = "Corova",
//     WhatAnimal = "Cow"
// };
// Lion lion = new Lion
// {
//     Country = "USA",
//     HideFromOtherAnimals = "Green Pastures",
//     Name = "Lev",
//     WhatAnimal = "Lion"
// };
// Pig pig = new Pig
// {
//     Country = "USA",
//     HideFromOtherAnimals = "Green Pastures",
//     Name = "Svin",
//     WhatAnimal = "Pig"
// };
//
//
// XmlSerializer serializer1 = new XmlSerializer(typeof(Cow));
// XmlSerializer serializer2 = new XmlSerializer(typeof(Lion));
// XmlSerializer serializer3 = new XmlSerializer(typeof(Pig));
//
// using (StreamWriter writer = new StreamWriter("/Users/pavelerokhin/CS_Labs/Lab_07/Cow.xml"))
// {
//     serializer1.Serialize(writer, cow);
//     serializer2.Serialize(writer, lion);
//     serializer3.Serialize(writer, pig);
// }
//
//

using System.Reflection;
using System.Xml.Linq;
internal class Task
{
    private static void Main()
    {
        var mylib = Assembly.LoadFrom("/Users/pavelerokhin/CS_Labs/Lab_07/Lab_07_01/bin/Debug/net7.0/Lab_07_01.dll");
        var types = mylib.GetExportedTypes(); 
        XDocument xdoc = new XDocument();
        uint num;
        XElement Classes = new XElement("classes");
        xdoc.Add(Classes);
        foreach (var type in types) {
            XElement el = new XElement("class");
            XAttribute el_attr = new XAttribute("name", type.FullName);
            el.Add(el_attr);
            XElement Properties = new XElement("properties");
            el.Add(Properties);
            XElement Methods = new XElement("methods");
            el.Add(Methods);
            num = 1;
            foreach (var method in type.GetMethods()) { Methods.Add(new XElement($"method{num}",method)); ++num; }
            num = 1;
            foreach (var prop in type.GetProperties()) { Properties.Add(new XElement($"property{num}", prop)); ++num; }
            Classes.Add(el);
        }
        
        xdoc.Save("classes.xml");
    }
}