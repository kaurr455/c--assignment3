class Program
{
    static void Main(string[] args)
    {
        
        Person bob = new Person();
        Console.WriteLine(bob.IsValidated()); 

        // Ramanpreet-kaur-Assignment3

        Person kim = new Person("kim", "smith");
        Console.WriteLine(kim.IsValidated()); 

        Console.ReadKey();
    }
}