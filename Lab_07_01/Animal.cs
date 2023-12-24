namespace Lab_07_01;

public class Animal
{
    public enum eFavouriteFood
    {
        Meat,
        Plants,
        Everything
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class CommentAttribute : Attribute
    {
        public string Comment { get; set; }

        public CommentAttribute(string comment)
        {
            Comment = comment;
        }
    }

    [Comment("Реализация абстрактного класса животного")]
    public abstract class Alimal
    {
        private string Country { get; set; }
        private string HideFromOtherAnimals { get; set; }
        private string Name { get; set; }
        private string WhatAnimal { get; set; }

        private enum eClassificationAnimal
        {
            Hebivores,
            Carnivores,
            Omnivores
        }

        public Alimal(string country, string hideFromOtherAnimals, string name, string whatAnimal)
        {
            Country = country;
            HideFromOtherAnimals = hideFromOtherAnimals;
            Name = name;
            WhatAnimal = whatAnimal;
        }

        public string GetClassificationAnimal()
        {
            return "Undef";
        }

        public abstract eFavouriteFood GetFavoriteFood();
        public abstract void SayHello();
    }

    [Comment("Реализация класса коровы на основе животного")]
    public class Cow : Alimal
    {
        public Cow() : base("", "", "", "")
        {
        }

        public Cow(string country, string hideFromOtherAnimals, string name, string whatAnimal) : base(country,
            hideFromOtherAnimals, name, whatAnimal)
        {
        }

        public string Country { get; set; }
        public string HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public string WhatAnimal { get; set; }

        public override eFavouriteFood GetFavoriteFood()
        {
            return eFavouriteFood.Plants;
        }

        public override void SayHello()
        {
            Console.WriteLine("MOOOO");
        }
    }

    [Comment("Реализация класса льва на основе животного")]
    public class Lion : Alimal
    {
        public Lion() : base("", "", "", "")
        {
        }

        public string Country { get; set; }
        public string HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public string WhatAnimal { get; set; }

        public Lion(string country, string hideFromOtherAnimals, string name, string whatAnimal) : base(country,
            hideFromOtherAnimals, name, whatAnimal)
        {
        }

        public override eFavouriteFood GetFavoriteFood()
        {
            return eFavouriteFood.Meat;
        }

        public override void SayHello()
        {
            Console.WriteLine("meow");
        }
    }
    
    [Comment("Реализация класса льва на основе животного")]
    public class Pig : Alimal
    {
        public Pig() : base("", "", "", "")
        {
        }

        public string Country { get; set; }
        public string HideFromOtherAnimals { get; set; }
        public string Name { get; set; }
        public string WhatAnimal { get; set; }

        public Pig(string country, string hideFromOtherAnimals, string name, string whatAnimal) : base(country,
            hideFromOtherAnimals, name, whatAnimal)
        {
        }

        public override eFavouriteFood GetFavoriteFood()
        {
            return eFavouriteFood.Everything;
        }

        public override void SayHello()
        {
            Console.WriteLine("Oink oink");
        }
    }


}