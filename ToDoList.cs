
using System.Reflection.Emit;

public class ToDoList
{
    static int maxTasks = 10;
    static string[] tasks = new string[maxTasks];    // Create a string to store 10 tasks.
    static int taskCount = 0;           // Number of tasks are store at initiation, hence Zero.
    static int nullTaskCount;           // Number of tasks that are 'null' at the moment.
    //static int taskCompleteIndex;       // Number / Index of the task to be marked as 'complete'.
    //static string taskString;           // Temp 'string' datatype to store specific strings in 'tasks[]'


    // Method to AddTasks()
    static void AddTask()
    {
        if (taskCount < 10)
        {
            Console.WriteLine("Add a task to the To-Do-List. The list contains " + taskCount + " tasks.");
            tasks[taskCount] = Console.ReadLine();
            taskCount++;
            nullTaskCount--;
        }

        else if( taskCount >= 10)
        {
            Console.WriteLine("Task list is full. " + taskCount + " tasks are pending to be completed. Cannot add more tasks.");
        }
            
    }            
    

    
    // Method to Count 'null / empty' tasks
    static int CountNullTasks(string[] tasks)
    {
        nullTaskCount = 0;          //Make the 'counting' variable == Zero, before starting to count
        for (int i = 0; i < maxTasks; i++)
        {
            if (tasks[i] == null)
            {
                nullTaskCount++;    //Count empty task in the string array
            }
        }
        Console.WriteLine("There are " + nullTaskCount + " Null (or Empty) tasks in the 'tasks[]' array.");
        return nullTaskCount;
    }



    // Method to ViewTasks()
    static void ViewTasks(int taskCount)
    {
        
        if( /*(taskCount < tasks.Count()) && */(taskCount != 0) && (tasks[taskCount-1] != null) )       // Check if 'tasks' variable is 'empty' or if the 'tasks' variable contains a 'null'
        {
            for (int i = 0; i < taskCount; i++)
            {
                Console.WriteLine("Task " + (i+1) + ":" + tasks[i]);
            }

            Console.WriteLine("These are all the tasks stored in the memory.");
        }

        else
        {
            Console.WriteLine("There are " + taskCount + " tasks in the memory. Please try again.");
        }
            
    }



    // Method to CompleteTask()
    static void CompleteTask()
    {
        Console.WriteLine("Mark the tasks to be marked as 'Complete' by entering the 'index' value of the Task.");
        int taskCompleteIndex = Convert.ToInt32(Console.ReadLine());    // Number / Index of the task to be marked as 'complete'.
        
        if ((taskCompleteIndex > 0) && (taskCompleteIndex <= taskCount))
        {
            string taskString = tasks[taskCompleteIndex-1];                 // Temp 'string' datatype to store specific strings in 'tasks[]'
            taskString = tasks[taskCompleteIndex-1];
            tasks[taskCompleteIndex-1] = taskString + "(Completed.)";
        }
            
        else
        {
            Console.WriteLine(taskCompleteIndex + " is invalid number / out of bounds. The number value must be between Zero and " + (taskCount+1) );
        } 
            
        ViewTasks(taskCount);
        
    }

    /*public static void Main()
    {
        bool okay = true;

        Label reStartMain = new Label();

        reStartMain:
        while(okay)
        {
            Console.WriteLine("");
            Console.WriteLine("Select your action number based on the following options.");
            Console.WriteLine("1. Add Task to List.");
            Console.WriteLine("2. View Tasks in List.");
            Console.WriteLine("3. Mark Task as 'Complete'.");
            Console.WriteLine("4. Count the number of empty memory locations in the List.");
            Console.WriteLine("5. Exit the Program Application.");
            
            string numb_choice = Console.ReadLine();
            
            switch (numb_choice)
            {
                case "1":
                    AddTask();
                    goto reStartMain;
                case "2":
                    ViewTasks(taskCount);
                    goto reStartMain;
                case "3":
                    CompleteTask();
                    goto reStartMain;
                case "4":
                    CountNullTasks(tasks);
                    goto reStartMain;
                case "5":
                    okay = false;
                    break;

                default:
                    Console.WriteLine("This is an invalid numer choice. Please select the option from '1' to '5'.");
                    goto reStartMain;
                
            }
            
            //* //AddTask();
            //nullTaskCount = CountNullTasks(tasks);
            //AddTask();
            //ViewTasks(taskCount);
            //
        }
        //
        
    }*/
}


