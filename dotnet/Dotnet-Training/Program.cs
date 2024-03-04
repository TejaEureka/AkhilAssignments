//1.Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
//(if less than 60 cm small, greater than 60 and less than 160 medium , greater than 160 is tall.)
/*
int A = Convert.ToInt32 (Console.ReadLine());
if (A < 60)
{
    Console.WriteLine("Small");

}
else if (A > 60 && A<160)
{
    Console.WriteLine("Medium");

}
else
{
    Console.WriteLine("Tall");
}
*/

/*Write a C# Sharp program to find the largest of three numbers.
int A = 20;int B = 30; int c = 50;
if (A > B && A > c) 
{
    Console.WriteLine("Largest number is A :" +A);
}
else if (B > A && B>c)
{
    Console.WriteLine("Largest number is B :" + B);
}
else
{
    Console.WriteLine("Largest number is C :" + c);
}
*/
/*Write a C# Sharp program to read roll no, name and marks of three subjects
//and calculate the total,
//percentage
//and garde. 
//(if percentage is less than 35 F , if between 35 to 60 C , between 60 to 80 B, more than 80 is A)
Console.WriteLine("Enter Rollno:");
int rollno = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Name:");
string name = Console.ReadLine();
Console.WriteLine("Enter subject1 marks:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter subject2 marks:");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter subject3 marks:");
int m3 = Convert.ToInt32(Console.ReadLine());

int total = m1 + m2 + m3;
Console.WriteLine("Total is: " + total);

decimal percent = (decimal) total / 3;
Console.WriteLine("Percent is: " + percent);

if (percent < 35)
{
    Console.WriteLine("Grade is: F");
}
else if (percent < 60)
{
    Console.WriteLine("Grade is: C");
}
else if (percent < 80)
{
    Console.WriteLine("Grade is: B");
}
else
{
    Console.WriteLine("Grade is: A");
}

//Create an array to store the names of five students.
//Create a list to store the scores of each student corresponding to their position in the array.
//Allow the user to input scores for each student.
//Calculate and display the average score of all students.
//Display the names of students along with their scores.
//Allow the user to search for a student by name and display their score.

String[] names = new string[5];
names[0] = "Akhil";
names[1] = "Rohith";
names[2] = "karthik";
names[3] = "charan";
names[4] = "Venkat";

List<int> scores = new List<int>();

for (int i = 0; i < names.Length; i++)
{
    int score = Convert.ToInt32(Console.ReadLine());


    scores.Add(score);
}

int TotalScore = 0;


for(int i=0;i<scores.Count; i++)
{
    TotalScore += scores[i];
}

decimal avg = (decimal) TotalScore / scores.Count;

Console.WriteLine("Average Score :" + avg);

for (int i =0; i<scores.Count; i++)
{
    Console.WriteLine(names[i] +" : "+ scores[i]);

}

string name = Console.ReadLine();
for (int i = 0; i<names.Count(); i++)
{
    if(names[i] == name)
    {
        Console.WriteLine(names[i] + "  " + scores[i]);
    }
    
}

//Accept a string input from the user.
//Display the length of the input string.
//Convert the input string to uppercase and display it.
//Check if the input string contains the word "CSharp" (case-insensitive) and display the result.
//Replace all occurrences of the letter 'a' in the string with '*'.
//Display the input string in reverse order.
//Count and display the number of vowels in the string.

//Console.WriteLine("Enter a String:");
string s = Console.ReadLine();

Console.WriteLine("Length of string is: " + s.Length);
Console.WriteLine("string in uppercase: " + s.ToUpper());
Console.WriteLine("Is string contains CSharp: " + s.Contains("CSharp"));
Console.WriteLine("Replace a with * of string is: " + s.Replace('a', '*'));

char[] cs = s.ToCharArray();

Console.WriteLine("string in reverse: " + new string(cs.Reverse().ToArray()));

int count = 0;

foreach (var c in cs)
{
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        count++;
}

Console.WriteLine("no of vowels in string: " + count);

/*
//Create a base class called Shape with a virtual method CalculateArea() that returns a double.
//Create two derived classes: Circle and Rectangle, both inheriting from the Shape class.
//In each derived class, override the CalculateArea() method to provide specific implementations for calculating the area of a circle and a rectangle, respectively.
//Create a method called PrintAreaDetails() in the base class that prints the details of the shape, including its type and area.
//In the Main method of your program, create instances of both the Circle and Rectangle classes.
//Call the PrintAreaDetails() method on each instance to demonstrate polymorphic behavior.

class Shape
{
    public virtual double CalculateArea()
    {
        return 0.0;
    }

    public void PrintAreaDetails()
    {
        Console.WriteLine($"Shape Type: {GetType().Name}");
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine();
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        circle.PrintAreaDetails();
        rectangle.PrintAreaDetails();
    }
}



/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter a String:");
    string s = Console.ReadLine();

    Console.WriteLine("Length of string is: " + s.Length);
    Console.WriteLine("string in uppercase: " + s.ToUpper());
    Console.WriteLine("Is string contains CSharp: " + s.Contains("CSharp"));
    Console.WriteLine("Replace a with * of string is: " + s.Replace('a', '*'));

    char[] cs = s.ToCharArray();

    Console.WriteLine("string in reverse: " + new string(cs.Reverse().ToArray()));

    int count = 0;

    foreach (var c in cs)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            count++;
    }

    Console.WriteLine("no of vowels in string: " + count);

}





        List<string> stringsList = new List<string>();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter a String:");
            string inputString = Console.ReadLine();
            stringsList.Add(inputString);
        }

        for (int i = 0; i < stringsList.Count; i++ )

        {
            Console.WriteLine("Length of string is: " + stringsList[i].Length);
            Console.WriteLine("String in uppercase: " + stringsList[i].ToUpper());
            Console.WriteLine("Is string contains CSharp: " + stringsList[i].Contains("CSharp"));
            Console.WriteLine("Replace a with * of string is: " + stringsList[i].Replace('a', '*'));

            char[] cs = stringsList[i].ToCharArray();

            Console.WriteLine("String in reverse: " + new string(cs.Reverse().ToArray()));

            int count = 0;

            foreach (var c in cs)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    count++;
            }

            Console.WriteLine("Number of vowels in string: " + count);
            Console.WriteLine();
        }
    

*/

//Create a program that uses a SortedList to store the names and ages of five people.
//Allow the user to input names and ages for each person.
//Display the names and ages in ascending order based on age.
//Allow the user to search for a person by name and display their age.

//1.Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
//(if less than 60 cm small, greater than 60 and less than 160 medium , greater than 160 is tall.)
/*
int A = Convert.ToInt32 (Console.ReadLine());
if (A < 60)
{
    Console.WriteLine("Small");

}
else if (A > 60 && A<160)
{
    Console.WriteLine("Medium");

}
else
{
    Console.WriteLine("Tall");
}
*/

/*Write a C# Sharp program to find the largest of three numbers.
int A = 20;int B = 30; int c = 50;
if (A > B && A > c) 
{
    Console.WriteLine("Largest number is A :" +A);
}
else if (B > A && B>c)
{
    Console.WriteLine("Largest number is B :" + B);
}
else
{
    Console.WriteLine("Largest number is C :" + c);
}
*/
/*Write a C# Sharp program to read roll no, name and marks of three subjects
//and calculate the total,
//percentage
//and garde. 
//(if percentage is less than 35 F , if between 35 to 60 C , between 60 to 80 B, more than 80 is A)
Console.WriteLine("Enter Rollno:");
int rollno = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Name:");
string name = Console.ReadLine();
Console.WriteLine("Enter subject1 marks:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter subject2 marks:");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter subject3 marks:");
int m3 = Convert.ToInt32(Console.ReadLine());

int total = m1 + m2 + m3;
Console.WriteLine("Total is: " + total);

decimal percent = (decimal) total / 3;
Console.WriteLine("Percent is: " + percent);

if (percent < 35)
{
    Console.WriteLine("Grade is: F");
}
else if (percent < 60)
{
    Console.WriteLine("Grade is: C");
}
else if (percent < 80)
{
    Console.WriteLine("Grade is: B");
}
else
{
    Console.WriteLine("Grade is: A");
}

//Create an array to store the names of five students.
//Create a list to store the scores of each student corresponding to their position in the array.
//Allow the user to input scores for each student.
//Calculate and display the average score of all students.
//Display the names of students along with their scores.
//Allow the user to search for a student by name and display their score.

String[] names = new string[5];
names[0] = "Akhil";
names[1] = "Rohith";
names[2] = "karthik";
names[3] = "charan";
names[4] = "Venkat";

List<int> scores = new List<int>();

for (int i = 0; i < names.Length; i++)
{
    int score = Convert.ToInt32(Console.ReadLine());


    scores.Add(score);
}

int TotalScore = 0;


for(int i=0;i<scores.Count; i++)
{
    TotalScore += scores[i];
}

decimal avg = (decimal) TotalScore / scores.Count;

Console.WriteLine("Average Score :" + avg);

for (int i =0; i<scores.Count; i++)
{
    Console.WriteLine(names[i] +" : "+ scores[i]);

}

string name = Console.ReadLine();
for (int i = 0; i<names.Count(); i++)
{
    if(names[i] == name)
    {
        Console.WriteLine(names[i] + "  " + scores[i]);
    }
    
}

//Accept a string input from the user.
//Display the length of the input string.
//Convert the input string to uppercase and display it.
//Check if the input string contains the word "CSharp" (case-insensitive) and display the result.
//Replace all occurrences of the letter 'a' in the string with '*'.
//Display the input string in reverse order.
//Count and display the number of vowels in the string.

//Console.WriteLine("Enter a String:");
string s = Console.ReadLine();

Console.WriteLine("Length of string is: " + s.Length);
Console.WriteLine("string in uppercase: " + s.ToUpper());
Console.WriteLine("Is string contains CSharp: " + s.Contains("CSharp"));
Console.WriteLine("Replace a with * of string is: " + s.Replace('a', '*'));

char[] cs = s.ToCharArray();

Console.WriteLine("string in reverse: " + new string(cs.Reverse().ToArray()));

int count = 0;

foreach (var c in cs)
{
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        count++;
}

Console.WriteLine("no of vowels in string: " + count);

/*
//Create a base class called Shape with a virtual method CalculateArea() that returns a double.
//Create two derived classes: Circle and Rectangle, both inheriting from the Shape class.
//In each derived class, override the CalculateArea() method to provide specific implementations for calculating the area of a circle and a rectangle, respectively.
//Create a method called PrintAreaDetails() in the base class that prints the details of the shape, including its type and area.
//In the Main method of your program, create instances of both the Circle and Rectangle classes.
//Call the PrintAreaDetails() method on each instance to demonstrate polymorphic behavior.

class Shape
{
    public virtual double CalculateArea()
    {
        return 0.0;
    }

    public void PrintAreaDetails()
    {
        Console.WriteLine($"Shape Type: {GetType().Name}");
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine();
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        circle.PrintAreaDetails();
        rectangle.PrintAreaDetails();
    }
}



/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter a String:");
    string s = Console.ReadLine();

    Console.WriteLine("Length of string is: " + s.Length);
    Console.WriteLine("string in uppercase: " + s.ToUpper());
    Console.WriteLine("Is string contains CSharp: " + s.Contains("CSharp"));
    Console.WriteLine("Replace a with * of string is: " + s.Replace('a', '*'));

    char[] cs = s.ToCharArray();

    Console.WriteLine("string in reverse: " + new string(cs.Reverse().ToArray()));

    int count = 0;

    foreach (var c in cs)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            count++;
    }

    Console.WriteLine("no of vowels in string: " + count);

}





        List<string> stringsList = new List<string>();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter a String:");
            string inputString = Console.ReadLine();
            stringsList.Add(inputString);
        }

        for (int i = 0; i < stringsList.Count; i++ )

        {
            Console.WriteLine("Length of string is: " + stringsList[i].Length);
            Console.WriteLine("String in uppercase: " + stringsList[i].ToUpper());
            Console.WriteLine("Is string contains CSharp: " + stringsList[i].Contains("CSharp"));
            Console.WriteLine("Replace a with * of string is: " + stringsList[i].Replace('a', '*'));

            char[] cs = stringsList[i].ToCharArray();

            Console.WriteLine("String in reverse: " + new string(cs.Reverse().ToArray()));

            int count = 0;

            foreach (var c in cs)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    count++;
            }

            Console.WriteLine("Number of vowels in string: " + count);
            Console.WriteLine();
        }
    
*/


//Create a program that uses a SortedList to store the names and ages of five people.
//Allow the user to input names and ages for each person.
//Display the names and ages in ascending order based on age.
//Allow the user to search for a person by name and display their age.

//1.Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
//(if less than 60 cm small, greater than 60 and less than 160 medium , greater than 160 is tall.)
/*
int A = Convert.ToInt32 (Console.ReadLine());
if (A < 60)
{
    Console.WriteLine("Small");

}
else if (A > 60 && A<160)
{
    Console.WriteLine("Medium");

}
else
{
    Console.WriteLine("Tall");
}
*/

/*Write a C# Sharp program to find the largest of three numbers.
int A = 20;int B = 30; int c = 50;
if (A > B && A > c) 
{
    Console.WriteLine("Largest number is A :" +A);
}
else if (B > A && B>c)
{
    Console.WriteLine("Largest number is B :" + B);
}
else
{
    Console.WriteLine("Largest number is C :" + c);
}
*/
/*Write a C# Sharp program to read roll no, name and marks of three subjects
//and calculate the total,
//percentage
//and garde. 
//(if percentage is less than 35 F , if between 35 to 60 C , between 60 to 80 B, more than 80 is A)
Console.WriteLine("Enter Rollno:");
int rollno = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Name:");
string name = Console.ReadLine();
Console.WriteLine("Enter subject1 marks:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter subject2 marks:");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter subject3 marks:");
int m3 = Convert.ToInt32(Console.ReadLine());

int total = m1 + m2 + m3;
Console.WriteLine("Total is: " + total);

decimal percent = (decimal) total / 3;
Console.WriteLine("Percent is: " + percent);

if (percent < 35)
{
    Console.WriteLine("Grade is: F");
}
else if (percent < 60)
{
    Console.WriteLine("Grade is: C");
}
else if (percent < 80)
{
    Console.WriteLine("Grade is: B");
}
else
{
    Console.WriteLine("Grade is: A");
}

//Create an array to store the names of five students.
//Create a list to store the scores of each student corresponding to their position in the array.
//Allow the user to input scores for each student.
//Calculate and display the average score of all students.
//Display the names of students along with their scores.
//Allow the user to search for a student by name and display their score.

String[] names = new string[5];
names[0] = "Akhil";
names[1] = "Rohith";
names[2] = "karthik";
names[3] = "charan";
names[4] = "Venkat";

List<int> scores = new List<int>();

for (int i = 0; i < names.Length; i++)
{
    int score = Convert.ToInt32(Console.ReadLine());


    scores.Add(score);
}

int TotalScore = 0;


for(int i=0;i<scores.Count; i++)
{
    TotalScore += scores[i];
}

decimal avg = (decimal) TotalScore / scores.Count;

Console.WriteLine("Average Score :" + avg);

for (int i =0; i<scores.Count; i++)
{
    Console.WriteLine(names[i] +" : "+ scores[i]);

}

string name = Console.ReadLine();
for (int i = 0; i<names.Count(); i++)
{
    if(names[i] == name)
    {
        Console.WriteLine(names[i] + "  " + scores[i]);
    }
    
}

//Accept a string input from the user.
//Display the length of the input string.
//Convert the input string to uppercase and display it.
//Check if the input string contains the word "CSharp" (case-insensitive) and display the result.
//Replace all occurrences of the letter 'a' in the string with '*'.
//Display the input string in reverse order.
//Count and display the number of vowels in the string.

//Console.WriteLine("Enter a String:");
string s = Console.ReadLine();

Console.WriteLine("Length of string is: " + s.Length);
Console.WriteLine("string in uppercase: " + s.ToUpper());
Console.WriteLine("Is string contains CSharp: " + s.Contains("CSharp"));
Console.WriteLine("Replace a with * of string is: " + s.Replace('a', '*'));

char[] cs = s.ToCharArray();

Console.WriteLine("string in reverse: " + new string(cs.Reverse().ToArray()));

int count = 0;

foreach (var c in cs)
{
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        count++;
}

Console.WriteLine("no of vowels in string: " + count);

/*
//Create a base class called Shape with a virtual method CalculateArea() that returns a double.
//Create two derived classes: Circle and Rectangle, both inheriting from the Shape class.
//In each derived class, override the CalculateArea() method to provide specific implementations for calculating the area of a circle and a rectangle, respectively.
//Create a method called PrintAreaDetails() in the base class that prints the details of the shape, including its type and area.
//In the Main method of your program, create instances of both the Circle and Rectangle classes.
//Call the PrintAreaDetails() method on each instance to demonstrate polymorphic behavior.

class Shape
{
    public virtual double CalculateArea()
    {
        return 0.0;
    }

    public void PrintAreaDetails()
    {
        Console.WriteLine($"Shape Type: {GetType().Name}");
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine();
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        circle.PrintAreaDetails();
        rectangle.PrintAreaDetails();
    }
}



/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter a String:");
    string s = Console.ReadLine();

    Console.WriteLine("Length of string is: " + s.Length);
    Console.WriteLine("string in uppercase: " + s.ToUpper());
    Console.WriteLine("Is string contains CSharp: " + s.Contains("CSharp"));
    Console.WriteLine("Replace a with * of string is: " + s.Replace('a', '*'));

    char[] cs = s.ToCharArray();

    Console.WriteLine("string in reverse: " + new string(cs.Reverse().ToArray()));

    int count = 0;

    foreach (var c in cs)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            count++;
    }

    Console.WriteLine("no of vowels in string: " + count);

}





        List<string> stringsList = new List<string>();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter a String:");
            string inputString = Console.ReadLine();
            stringsList.Add(inputString);
        }

        for (int i = 0; i < stringsList.Count; i++ )

        {
            Console.WriteLine("Length of string is: " + stringsList[i].Length);
            Console.WriteLine("String in uppercase: " + stringsList[i].ToUpper());
            Console.WriteLine("Is string contains CSharp: " + stringsList[i].Contains("CSharp"));
            Console.WriteLine("Replace a with * of string is: " + stringsList[i].Replace('a', '*'));

            char[] cs = stringsList[i].ToCharArray();

            Console.WriteLine("String in reverse: " + new string(cs.Reverse().ToArray()));

            int count = 0;

            foreach (var c in cs)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    count++;
            }

            Console.WriteLine("Number of vowels in string: " + count);
            Console.WriteLine();
        }
    



//Create a program that uses a SortedList to store the names and ages of five people.
//Allow the user to input names and ages for each person.
//Display the names and ages in ascending order based on age.
//Allow the user to search for a person by name and display their age.

using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> waitingLine = new Queue<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Enqueue (Join the line)");
            Console.WriteLine("2. Dequeue (Get service)");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice (1-3): ");
            int choice;

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        EnqueuePerson();
                        break;
                    case 2:
                        DequeuePerson();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            DisplayQueue();
        }
    }

    static void EnqueuePerson()
    {
        Console.Write("Enter the name of the person to enqueue: ");
        string person = Console.ReadLine();
        waitingLine.Enqueue(person);
        Console.WriteLine($"{person} has joined the line.");
    }

    static void DequeuePerson()
    {
        if (waitingLine.Count > 0)
        {
            string person = waitingLine.Dequeue();
            Console.WriteLine($"{person} has been served.");
        }
        else
        {
            Console.WriteLine("Queue is empty. No one to serve.");
        }
    }

    static void DisplayQueue()
    {
        Console.WriteLine("Current Queue:");
        foreach (var person in waitingLine)
        {
            Console.WriteLine(person);
        }
        Console.WriteLine();
    }
}


using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

//8.Create a program that uses a Queue to simulate a waiting line for a service.
//Allow the user to enqueue (join the line) and dequeue(get service) people.
//Display the current queue after each enqueue or dequeue operation.
//Implement error handling to handle dequeue from an empty queue.


using System;
using System.Collections;

class ServiceQueue
{
    private Queue<string> waitingLine;

    public ServiceQueue()
    {
        waitingLine = new Queue<string>();
    }

    public void EnqueuePerson(string person)
    {
        waitingLine.Enqueue(person);
        DisplayQueue();
    }

    public void DequeuePerson()
    {
        if (waitingLine.Count > 0)
        {
            string person = waitingLine.Dequeue();
            Console.WriteLine($"{person} has been served.");
            DisplayQueue();
        }
        else
        {
            Console.WriteLine("The queue is empty. No one to dequeue.");
        }
    }

    private void DisplayQueue()
    {
        Console.WriteLine("Current Queue:");
        foreach (var person in waitingLine)
        {
            Console.Write($"{person} ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        ServiceQueue serviceQueue = new ServiceQueue();

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Enqueue (Join the line)");
            Console.WriteLine("2. Dequeue (Get service)");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name to enqueue: ");
                    string enqueueName = Console.ReadLine();
                    serviceQueue.EnqueuePerson(enqueueName);
                    break;

                case 2:
                    serviceQueue.DequeuePerson();
                    break;

                case 3:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}


//9.Create a program that uses a Dictionary to store contact information (name and phone number) for five people.
//Allow the user to input names and phone numbers for each person.
//Display the contact information for a person based on their name.
//Allow the user to search for a person by name and display their phone number.

using System;
using System.Collections.Generic;

class ContactManager
{
    private Dictionary<string, string> contactDictionary;

    public ContactManager()
    {
        contactDictionary = new Dictionary<string, string>();
    }

    public void AddContact(string name, string phoneNumber)
    {
        contactDictionary[name] = phoneNumber;
        DisplayContacts();
    }

    public void DisplayContacts()
    {
        Console.WriteLine("Contact Information:");

        foreach (var contact in contactDictionary)
        {
            Console.WriteLine($"Name: {contact.Key}, Phone Number: {contact.Value}");
        }
    }

    public void SearchContactByName(string name)
    {
        if (contactDictionary.ContainsKey(name))
        {
            string phoneNumber = contactDictionary[name];
            Console.WriteLine($"{name}'s phone number is: {phoneNumber}");
        }
        else
        {
            Console.WriteLine($"{name} not found in the contact list.");
        }
    }
}

class Program
{
    static void Main()
    {
        ContactManager contactManager = new ContactManager();

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter the name of person {i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter the phone number for {name}: ");
            string phoneNumber = Console.ReadLine();

            contactManager.AddContact(name, phoneNumber);
        }

        Console.Write("\nEnter the name to search: ");
        string searchName = Console.ReadLine();
        contactManager.SearchContactByName(searchName);
    }
}






//10.Write a program to pull Stocks price history details of Close price for the latest day available in DB, where stock symbol starts with A.

using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPriceHistory
{
    internal class Program
    {
        static void Main()
        {
            string connectionString = "Server=endeavourtech.ddns.net;Port=31240;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT ticker_symbol, MAX(trading_date) AS latest_date, close_price " +
                                                    "FROM endeavour.stocks_price_history sph " +
                                                    "WHERE ticker_symbol LIKE 'A%' " +
                                                    "GROUP BY ticker_symbol, close_price", conn);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Ticker Symbol: {reader["ticker_symbol"]}");
                        Console.WriteLine($"Latest Date: {reader["latest_date"]}");
                        Console.WriteLine($"Close Price: {reader["close_price"]}");
                        Console.WriteLine();
                    }

                    if (!reader.HasRows)
                    {
                        Console.WriteLine("No stock price history found for stock symbols starting with 'A'.");
                    }
                }
            }
        }
    }
}





//11.Write a program to pull sector name from DB based on sector id, If User enters 10 in command prompt, the program should print "Healthcare".



using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SectorLookup
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter sector ID: ");
            if (int.TryParse(Console.ReadLine(), out int sectorId))
            {
                string connectionString = "Server=endeavourtech.ddns.net;Port=31240;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";

                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT sector_name FROM endeavour.sector_lookup WHERE sector_id = @sectorId", conn);
                    cmd.Parameters.AddWithValue("sectorId", sectorId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string sectorName = result.ToString();
                        Console.WriteLine($"Sector Name: {sectorName}");
                    }
                    else
                    {
                        Console.WriteLine("Sector ID not found");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid sector ID.");
            }
        }
    }
}


//12.Write a program to pull stock fundamentals(all columns) from DB based on ticker symbol, If User enters AAPL in command prompt, the program should print


using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFundamentals
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Enter Ticker Symbol: ");
            string tickerSymbol = Console.ReadLine();


            string connectionString = "Server=endeavourtech.ddns.net;Port=31240;User Id=evr_sql_app;Password=5LViU5pLkSjRHECec9NF4wRxxV;Database=StocksDB;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {

                conn.Open();


                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM endeavour.stock_fundamentals WHERE ticker_symbol = @tickerSymbol", conn);
                cmd.Parameters.AddWithValue("tickerSymbol", tickerSymbol);


                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {

                        Console.WriteLine($"ticker_symbol: {reader["ticker_symbol"]}");
                        Console.WriteLine($"subsector_id: {reader["subsector_id"]}");
                        Console.WriteLine($"sector_id: {reader["sector_id"]}");
                        Console.WriteLine($"market_cap: {reader["market_cap"]}");
                        Console.WriteLine($"current_ratio: {reader["current_ratio"]}");
                        Console.WriteLine($"price_to_book_ratio: {reader["price_to_book_ratio"]}");
                        Console.WriteLine($"peg: {reader["peg"]}");
                        Console.WriteLine($"epsqq: {reader["epsqq"]}");
                        Console.WriteLine($"eps_nxtyear: {reader["eps_nxtyear"]}");
                        Console.WriteLine($"eps_ttm: {reader["eps_ttm"]}");
                        Console.WriteLine($"roe: {reader["roe"]}");
                        Console.WriteLine($"insider_ownership: {reader["insider_ownership"]}");
                        Console.WriteLine($"debt_equity_ratio: {reader["debt_equity_ratio"]}");
                        Console.WriteLine($"trailing_pe: {reader["trailing_pe"]}");
                        Console.WriteLine($"forward_pe: {reader["forward_pe"]}");
                    }
                    else
                    {

                        Console.WriteLine("Ticker Symbol not found");
                    }
                }
            }
        }
    }
}



*/

//13.Create endpoint / stockpricehistory /{ tickerSymbol}
//to given all stock history for that ticker symbol for last 1 year





//14. Create endpoint/stockpricehistory/{tickerSymbol}? startDate = { date }&endDate={date} it should return stock price history for that specific time frame sent by user. Response should also contain its sector and subsector details



//______________________________________________________________

