public class Person_Class_Object 
{
    string Name { get; set; }
    int Age { get; set; }

    public Person_Class_Object (string name_param, int age_param)
    {
        string Name = name_param;
        int Age = age_param;
    }

    public Person_Class_Object()
    {

    }

    public void PrintAGreeting()
    {
        Console.WriteLine("Hello " + Name + ". How are you doing?");
    }


    public static void Main(string[] args)
    {
        Person_Class_Object  friend = new Person_Class_Object ();
        friend.Name = "John Doe";
        friend.Age = 30;
        Person_Class_Object  boss = new Person_Class_Object ("Jane_Doe", 33);
        friend.PrintAGreeting();
        boss.PrintAGreeting();
    }
}

