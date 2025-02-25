public class Person 
{
    string Name { get; set; }
    int Age { get; set; }

    public Person (string name_param, int age_param)
    {
        string Name = name_param;
        int Age = age_param;
    }

    public Person()
    {

    }

    public void PrintAGreeting()
    {
        Console.WriteLine("Hello " + Name + ". How are you doing?");
    }


    public static void Main(string[] args)
    {
        Person friend = new Person();
        friend.Name = "John Doe";
        friend.Age = 30;
        Person boss = new Person("Jane_Doe", 33);
        friend.PrintAGreeting();
        boss.PrintAGreeting();
    }
}

