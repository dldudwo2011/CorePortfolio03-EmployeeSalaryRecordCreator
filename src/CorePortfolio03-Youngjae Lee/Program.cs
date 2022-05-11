/*
 *
 *      Purpose: To code a program that creates an employee salary record for a small business.
 *      
 *      
 *      Input: Name of the employee (string), salary of the employee (double), file path(string), menu selection (int)
 *      
 *   
 *      Process: Create 8 methods which are DisplayMenu(), PromptForNewEmployee(), DisplayNamesAndSalary(), GetSafeInt(), GetSafeDouble(), PromptForFilePath(),
 *               ReadFromFile(), WriteToFile().
 *               
 *               DisplayMenu() method will display menu using Console.WriteLine method.
 *               
 *               PromptForNewEmployee() method will accept string[] names, double[] salaries, and int employeeCount as its parameter and return an updated employeeCount (int).
 *               It will prompt the user for the name and salary of the employee and add them to the corresponding array. 
 *               
 *               DisplayNamesAndSalary() method will accept string[] names, double[] salaries, and int employeeCount as its parameter and return nothing. It will display 
 *               the current names and salaries in the array, in the form of columns. One column will be named name and the other column will be named salary. 
 *               The value in the salary column will be right-aligned where the value of the name column will be left-aligned.
 *               
 *               GetSafeInt() will accept the string message as its parameter and return the integer value user had entered. It will display the message(Its parameter) for the user to enter an 
 *               integer value. Error checking logic will be implemented.
 *               
 *               GetSafeDouble() method will be the same as GerSameInt() method except for the value it accepts and returns is the double value.
 *               
 *               PromptForFilePath() method will ask the user to enter a file path and return the file path user had entered (string).
 *               
 *               ReadFromFile() method will accept string filePath, string[] names, and double[] salaries as its parameter and return the total number of the employees read (int).
 *               It will make use of the StreamReader class to read the file in the file path it received as the parameter and transfer the values read into the names and the 
 *               salaries array.
 *               
 *               WriteToFile() method will accept string filePath, string[] names, double[] salaries, and int employeeCount as its parameter and return nothing. It will make an use
 *               of the StreamWriter class to write to the file in the file path it received as the parameter. It will write the current values in the names and salaries array using a 
 *               for loop that repeats [employeeCount] times.
 *               
 *               The main method will first prompt the user to set the array size by calling the GetSafeInt() method. When the user had entered the size, it will create the names and 
 *               salaries array with the size of value the user had entered. It will then have the "employeeCount" variable to track the current number of employee in the array and 
 *               the "quit" variable that controls the while loop that contains the menu. In the while loop, it will display the menu by calling the DisplayMenu() method and prompt
 *               the user for a choice by calling the GetSafeInt() method. When the user enters a choice, it will then be stored in a variable and directed to a switch statement that
 *               depends on the value of the variable. 
 *               
 *               
 *               If the user enters 1, it will call the PromptForNewEmployee method and update the employeeCount by storing its return value to the employeeCount variable.
 *               
 *               If the user enters 2, it will call the DisplayNamesAndSalary method and display the names and salaries of the current employees.
 *               
 *               If the user enters 3, it will call the ReadFromFile method and update the employeeCount by storing its return value to the employeeCount variable.
 *               
 *               If the user enters 4, it will call the WriteToFile method.
 *               
 *               If the user enters 5, set the quit variable to true.
 *               
 *               The default case of the switch will display an error message in case the user had entered a wrong integer value.
 *
 *-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 *      Output: 1. Enter the size of the array:
 *      
 *              2.                 Menu
 *                  ===========================================
                    1. Enter the Name and Salary of an Employee
                    2. Display Employee Salaries
                    3. Read Salaries from File
                    4. Write Salaries to File
                    5. Exit

                3. Please make a choice:

                4. If the user selects 1 
                    1. Enter the name of the employee:
                    2. Enter the salary for employee:
                    3. Employee [Employee name] with a salary of $[Employee salary] added
            
                   If the user selects 2
                    1.
                       Name               Salary
 *                     ========         ========
 *                     [name 1]       [salary 1]
 *                        .                .
 *                        .                .
 *                        .                .
 *                        
 *                 If the user selects 3
 *                  1. Enter the file path:
 *                  2. Total of [employeeCount] employees read
 *                  
 *                 If the user selects 4
 *                  1. Enter the file path:
 *                  2. Total of [employeeCount] employees written
 *                  
 *                 If the user selects 5
 *                  1. Good-bye
 *      
 *------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 *      Test plan
 *      
 *      Test case 1: Enter the Name and Salary of an Employee
 *      Test data: 1 for the menu selection, "James" for the name, and "16.20" for the salary
 *      Expected result: "Employee added"
 *      
 *      
 *      Test case 2: Display Employee Salaries
 *      Test data: 2 for the menu selection and currently have 1 employee named James who has a salary of 16.20
 *      Expected result: 
 *                         Name           Salary
 *                         ========     ========
 *                         James           $16.2
 *
 *
 *      Test case 3: Read Salaries from File
 *      Test data: 3 for the menu selection and "C:\Users\skske\Documents\test.csv" for the file path (test.csv has 3 employees)
 *      Expected result: "Total of 3 employees read"
 *      
 *      
 *      Test case 4: Write Salaries to File
 *      Test data: 4 for the menu selection and "C:\Users\skske\Documents\test.csv" for the file path (Currently 1 employee in the array)
 *      Expected result: "Total of 1 employees written"
 *      
 *      
 *      Test case 5: Exit
 *      Test data: 5 for the menu selection
 *      Expected result: "Good-bye"
 *      
 *-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------      
 *      
 *      
 *      Author: Youngjae Lee
 *      
 *      
 *      Last modified date: 2021 Mar 28
 */


using System;
using System.IO;

namespace CorePortfolio03_Youngjae_Lee
{
    class Program
    {



        //display menu method
        static void DisplayMenu()
        {
            //displaying menu
            Console.WriteLine("{0,22}","Menu");
            Console.WriteLine("============================================");
            Console.WriteLine("1. Enter the Name and Salary of an Employee");
            Console.WriteLine("2. Display Employee Salaries");
            Console.WriteLine("3. Read Salaries from File");
            Console.WriteLine("4. Write Salaries to File");
            Console.WriteLine("5. Exit");
            Console.WriteLine();

        }



        //PromptForNewEmployee method
        static int PromptForNewEmployee(string[] names, double[] salaries, int employeeCount)
        {
            //variable to store the total number of employee
            int totalNumOfEmployee = employeeCount;

            //ask the user to enter the name of the employee
            Console.WriteLine("Enter the name of the employee:");

            //add the user-input(employee name) to the names array
            names[totalNumOfEmployee] = Console.ReadLine();

            //add the user-input(employee salary) to the salaries array
            salaries[totalNumOfEmployee] = GetSafeDouble("Enter the salary for employee:");

            //complete message
            Console.WriteLine($"Employee \"{names[totalNumOfEmployee]}\" with a salary of ${salaries[totalNumOfEmployee]} added");

            Console.WriteLine();

            //incrementing the total number of employee by 1
            totalNumOfEmployee++;

            //returning the total number of employee
            return totalNumOfEmployee;
        }

        //Display names and salary method
        static void DisplayNamesAndSalary(string[] names, double[] salaries, int employeeCount)
        {
            //creating the name and salary column
            Console.WriteLine("{0,-10} {1,10}", "Name", "Salary");
            Console.WriteLine("{0,-10} {1,10}", "========","========");

            //for loop declaration
            for (int index = 0; index < employeeCount; index++)
            {
                //displaying the name and salarie of the employee
                Console.WriteLine("{0,-10} {1,10}", $"{names[index]}", $"${salaries[index]}");
            }
            Console.WriteLine();
        }

        //getting the user-input(int) method
        static int GetSafeInt(string message)
        {
            int integerValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine(message);
                validInput = int.TryParse(Console.ReadLine(), out integerValue);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input! You must enter an integer value for the answer");
                }
            }

            return integerValue;
        }

        //getting the user-input(double) method
        static double GetSafeDouble(string message)
        {
            double doubleValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine(message);
                validInput = double.TryParse(Console.ReadLine(), out doubleValue);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input! You must enter a double value for the answer");
                }
            }

            return Math.Round(doubleValue, 2);
        }

        //Prompt for file path method
        static string PromptForFilePath()
        {
            //asking the user for the file path
            Console.WriteLine("Enter the file path:");

            //storing the file path
            string filePath = Console.ReadLine();

            //returning the file path
            return filePath;
        }

        //read from file method
        static int ReadFromFile(string filePath, string[] names, double[] salaries)
        {
            //to store the total number of employees read
            int employeeCount = 0;

            try
            {
                //constructing a StreamReader instance for reading from a csv file
                StreamReader reader = new StreamReader(filePath);

                //creating a string variable to store the line read from the csv file
                string lineText;

                //setting index variable initially to 0 to indicate the index of array
                int index = 0;

                //reading one line at time until we reach the end of the file (EOF)
                while ((lineText = reader.ReadLine()) != null)
                {
                    //splitting the line values into an array of value 
                    string[] lineArray = lineText.Split(',');

                    //storing the first element (The name of the employee) of the lineArray array
                    string name = lineArray[0];

                    //storing the second element (The salary of the employee) of the lineArray array
                    double salary = double.Parse(lineArray[1]);

                    //transfer the value of name to names array
                    names[index] = name;

                    //transfer the value of salary to salaries array
                    salaries[index] = salary;

                    //incrementing the index number and the employee count
                    index++;
                    employeeCount++;
                }

                //displaying total number of employees read
                Console.WriteLine($"Total of {employeeCount} employees read");

                Console.WriteLine();

                //closing the file
                reader.Close();
            }

            //exception handling
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from {filePath} with exception {ex.Message}");
            }

            //returning the number of employees read
            return employeeCount;
        }
       
        //write to file method
        static void WriteToFile(string filePath, string[] names, double[] salaries, int employeeCount)
        {
            try
            {

                //constructing a StreamReader instance for writing to a csv file
                StreamWriter writer = new StreamWriter(filePath);

                
                    //for loop 
                    for (int index = 0; index < employeeCount; index++)
                    {
                        //writing the name and salary 
                        writer.Write($"{names[index]},{salaries[index]}");
                        writer.WriteLine();
                    }

                //complete message
                Console.WriteLine($"Total of {employeeCount} employees written");

                Console.WriteLine();

                //closing the file
                writer.Close();
            }

            //exception handling
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to {filePath} with exception {ex.Message}");
            }

        }
        static void Main(string[] args)
        {

            //asking the user for the size of the array
            int sizeOfArray = GetSafeInt("Enter the size of the array:");

            //creating the array based on the number user had entered
            string[] names = new string[sizeOfArray];
            double[] salaries = new double[sizeOfArray];

            //setting employeecount initially to 0
            int employeeCount = 0;

            //setting quit variable to control the loop
            bool quit = false;

            while (!quit)
            {

                //displaying the menu
                DisplayMenu();

                //storing the choice user has made
                int userChoice = GetSafeInt("Please make a choice:");

                Console.WriteLine();

                //switch statement
                switch (userChoice)
                {
                    //if the user entered 1 (adding an employee)
                    case 1:

                        //calling the PromptForNewEmployee method
                        employeeCount = PromptForNewEmployee(names, salaries, employeeCount);

                        break;

                    //if the user entered 2 (displaying the name and salary of employees)
                    case 2:

                        //calling the DisplayNamesAndSalary method
                        DisplayNamesAndSalary(names, salaries, employeeCount);

                        break;

                    //if the user entered 3 (reading a file)
                    case 3:


                        //calling the ReadFromFile method and storing its return value 
                        employeeCount = ReadFromFile(PromptForFilePath(), names, salaries);

                        break;

                    //if the user entered 4 (writing to a file)
                    case 4:


                        //calling the WriteToFile method
                        WriteToFile(PromptForFilePath(), names, salaries, employeeCount);

                        break;

                    //if the user entered 5 (Exit)
                    case 5:

                        //saying good-bye
                        Console.WriteLine("Good-bye");

                        //setting quit to true
                        quit = true;

                        break;

                    //handling invalid input
                    default:
                        Console.WriteLine("Invalid input! Please try again.");
                        break;
                }
            }
        }
    }
}
