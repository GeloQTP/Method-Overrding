namespace Method_Overriding // 3-2-23
                            // Done
                            // Done 1.0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();    
            Cat cat = new Cat();
            Pig pig = new Pig();   

            dog.speak();
            cat.speak();
            pig.speak();
        }
    }
}

 abstract class Animal // you can also use 'virtual' so you don't have to put anything on the class name
{
    public abstract void speak(); // public virtual void speak(){ 'algorithm is required' }
    
}

/*
 *  class Animal // another wait overriding
  {
    public virtual void speak()
    {
        // algorithm
    }   

   }
 */

class Dog : Animal 
{ 
    public override void speak()
    {
        Console.WriteLine("THe Dog goes *bark*");
    }
}

class Cat : Animal
{
    public override void speak()
    {
        Console.WriteLine("The Cat goes *meow*");
    }  
}

class Pig : Animal
{
    public override void speak()
    {
        Console.WriteLine("The Pig goes *oink*");
    }
}