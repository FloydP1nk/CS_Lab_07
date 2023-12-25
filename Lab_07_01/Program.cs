using System.Xml.Serialization;
using static Lab_07_01.Animal;


Cow cow = new Cow
{
    Country = "USA",
    HideFromOtherAnimals = "Green Pastures",
    Name = "Bessie",
    WhatAnimal = "Cow"
};
XmlSerializer serializer = new XmlSerializer(typeof(Cow));
using (StreamWriter writer = new StreamWriter("/Users/pavelerokhin/CS_Labs/Cow.xml"))
{
    serializer.Serialize(writer, cow);
}