
using System.ComponentModel;
using System.Runtime.InteropServices;

Animal a = new Dog("rex", 3, "labrador");
a.Eat();


class Animal
{
    public string Name = string.Empty;
    public int Age;

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Eat()
    {
        Console.WriteLine(Name + " eating");
    }
    
    
}

class Dog : Animal 
{
    public string Breed = string.Empty;
    public Dog(string name, int age, string breed):base(name, age)
    {
        Breed = breed;
        
    }

    public void Bark()
    {
        Console.WriteLine(Name + "woof");
    }
}

class Cat : Animal
{
    public string Color = string.Empty;
    public Cat(string name, int age, string color): base(name, age)
    {
        Color = color;
    }

    public void Meow()
    {
        Console.WriteLine(Name + "mewo");
    }
}