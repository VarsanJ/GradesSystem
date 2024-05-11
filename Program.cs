//NAME: Varsan Jeyakkumar
//DATE: 2024-05-01
//Title: File Sort Practise
//PURPOSE: To create a program that stores grades and names
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VJ_BubbleSortPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Introduction to the Program
            string strUser = "";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to the Grade Analyzer, a program built using bubble sort algorithms using C#\nThis program was developed by Varsan Jeyakkumar\n");
            Console.ForegroundColor = ConsoleColor.White;

            //Arrays for the program - Sets arrays for the program
            int[] intGrades, intGradesSorted; //Grades
            string[] strFirstNames, strFirstNamesSorted; //First Names
            string[] strLastNames, strLastNamesSorted; //Last Names

            //Declares temp arrays to move information
            int[] intGradesTemp;
            string[] strFirstNameTemp, strLastNameTemp;

            //Limits for the program - Sets initial total number of students
            int intStudents; //Variable declared for number of students
            while (true)
            {
                Console.WriteLine("How many students would you like to initially enter?");
                strUser = Console.ReadLine();
                intStudents = Int32.Parse(strUser); //Converts user entry to integer
                if (intStudents > 0) //Ensures the number of students is above one
                {
                    Console.WriteLine(intStudents + " students will be initially stored!");
                    break;
                }
                else //Runs this case if it does not work
                {
                    Console.WriteLine("Please enter a valid number more than 1!");
                    Proceed();
                }
            }

            //Amendments to Arrays - Modifies arrays to new length
            //4 arrays for grades
            intGrades = new int[intStudents];
            intGradesSorted = new int[intStudents];
            intGradesTemp = new int[intStudents];
            
            int[] intGradesOriginal = new int[intStudents];

            //4 arrays for first names
            strFirstNames = new string[intStudents];
            strFirstNamesSorted = new string[intStudents];
            strFirstNameTemp = new string[intStudents];
            
            string[] strFirstNameOriginal = new string[intStudents];

            //4 arrays for last names
            strLastNames = new string[intStudents];
            strLastNamesSorted = new string[intStudents];
            strLastNameTemp = new string[intStudents];
            
            string[] strLastNameOriginal = new string[intStudents];

            //Initial List - Adds values to the initial unsorted list
            int intGradeInput;
            string strFirstNameInput, strLastNameInput;

            for (int i = 0; i < intStudents; i++) //For loop limit
            {
                Console.WriteLine("User " + (i + 1) + " first name:"); //First Names Input
                strUser = Console.ReadLine();
                strFirstNameInput = strUser; //Stores as input
                strFirstNames[i] = strFirstNameInput;
                strFirstNameOriginal[i] = strFirstNameInput;
                Console.WriteLine("User " + (i + 1) + " last name:"); //Last Names Input
                strUser = Console.ReadLine();
                strLastNameInput = strUser; //Stores as input
                strLastNames[i] = strLastNameInput;
                strLastNameOriginal[i] = strLastNameInput;
                Console.WriteLine("User " + (i + 1) + " grade percentage:"); //Grades Input
                strUser = Console.ReadLine();
                intGradeInput = Int32.Parse(strUser);
                intGrades[i] = intGradeInput; //Stores as input
                intGradesOriginal[i] = intGradeInput;
                Console.WriteLine("Entry " + (i + 1) + " has been entered!\n\n");
            }
            
            Console.Clear();

            Proceed(); //Proceeds to the main menu

            //Menu variables
            string strOption, strTemp;
            int intTemp;

            //Menu Loop
            while (true)
            {
                MenuDisplay(); //Displays the menu
                strUser = Console.ReadLine();
                strOption = strUser.ToUpper();

                //Creates sorted loop by grades if necessary 
                if ((strOption == "D") || (strOption == "H") || (strOption == "I") || (strOption == "J"))
                {
                    for (int i = 0; i < intStudents; i++)
                    {
                        //Moves all values to the sorted list
                        intGradesSorted[i] = intGrades[i];
                        strLastNamesSorted[i] = strLastNames[i];
                        strFirstNamesSorted[i] = strFirstNames[i];
                    }

                    //Sorts the loop using bubble sort algorithms
                    for (int i = 0; i < intStudents; i++) //Loop 1
                    {
                        for (int j = 0; j < intStudents - 1; j++) //Loop 2
                        {
                            if (intGradesSorted[j] < intGradesSorted[j + 1])
                            {
                                //Switches out the values using bubble sort
                                intTemp = intGradesSorted[j];
                                intGradesSorted[j] = intGradesSorted[j + 1];
                                intGradesSorted[j + 1] = intTemp;

                                strTemp = strLastNamesSorted[j];
                                strLastNamesSorted[j] = strLastNamesSorted[j + 1];
                                strLastNamesSorted[j + 1] = strTemp;

                                strTemp = strFirstNamesSorted[j];
                                strFirstNamesSorted[j] = strFirstNamesSorted[j + 1];
                                strFirstNamesSorted[j + 1] = strTemp;
                            }
                        }
                    }
                }

                if (strOption == "B") //sorts by last first in advance
                {
                    for (int i = 0; i < intStudents; i++)
                    {
                        //Moves all values to the sorted list
                        intGradesSorted[i] = intGrades[i];
                        strLastNamesSorted[i] = strLastNames[i];
                        strFirstNamesSorted[i] = strFirstNames[i];
                    }

                    //Sorts the loop using bubble sort algorithms
                    for (int i = 0; i < intStudents; i++)
                    {
                        for (int j = 0; j < intStudents - 1; j++)
                        {
                            if (strLastNamesSorted[j].CompareTo(strLastNamesSorted[j + 1]) > 0) //string bubble sort
                            {
                                //Switches out the values
                                intTemp = intGradesSorted[j];
                                intGradesSorted[j] = intGradesSorted[j + 1];
                                intGradesSorted[j + 1] = intTemp;

                                strTemp = strLastNamesSorted[j];
                                strLastNamesSorted[j] = strLastNamesSorted[j + 1];
                                strLastNamesSorted[j + 1] = strTemp;

                                strTemp = strFirstNamesSorted[j];
                                strFirstNamesSorted[j] = strFirstNamesSorted[j + 1];
                                strFirstNamesSorted[j + 1] = strTemp;
                            }
                        }
                    }
                }

                if (strOption == "C") //sorts by first name in advance
                {
                    for (int i = 0; i < intStudents; i++)
                    {
                        //Moves all values to the sorted list
                        intGradesSorted[i] = intGrades[i];
                        strLastNamesSorted[i] = strLastNames[i];
                        strFirstNamesSorted[i] = strFirstNames[i];
                    }

                    //Sorts the loop using bubble sort algorithms
                    for (int i = 0; i < intStudents; i++)
                    {
                        for (int j = 0; j < intStudents - 1; j++)
                        {
                            if (strFirstNamesSorted[j].CompareTo(strFirstNamesSorted[j + 1]) > 0) //string bubble sort
                            {
                                //Switches out the values
                                intTemp = intGradesSorted[j];
                                intGradesSorted[j] = intGradesSorted[j + 1];
                                intGradesSorted[j + 1] = intTemp;

                                strTemp = strLastNamesSorted[j];
                                strLastNamesSorted[j] = strLastNamesSorted[j + 1];
                                strLastNamesSorted[j + 1] = strTemp;

                                strTemp = strFirstNamesSorted[j];
                                strFirstNamesSorted[j] = strFirstNamesSorted[j + 1];
                                strFirstNamesSorted[j + 1] = strTemp;
                            }
                        }
                    }
                }

                Console.Clear();

                //Menu Individual Options
                if (strOption == "A")
                {
                    //Displays the unsorted list
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(string.Format("{0,20} {1,20} {2,20}", "First Name", "Last Name", "Grade"));
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < intGradesOriginal.Length; i++)
                    {
                        Console.WriteLine(string.Format("{0,20} {1,20} {2,20}", strFirstNameOriginal[i], strLastNameOriginal[i], intGradesOriginal[i]));
                    }
                    Console.WriteLine("");
                    Proceed();
                }
                else if (strOption == "B")
                {
                    //Displays list sorted by lastname
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(string.Format("{0,20} {1,20} {2,20}", "First Name", "Last Name", "Grade"));
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < intGradesSorted.Length; i++)
                    {
                        Console.WriteLine(string.Format("{0,20} {1,20} {2,20}", strFirstNamesSorted[i], strLastNamesSorted[i], intGradesSorted[i]));
                    }
                    Console.WriteLine("");
                    Proceed();
                }
                else if (strOption == "C")
                {
                    //Displays list sorted by firstname
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(string.Format("{0,20} {1,20} {2,20}", "First Name", "Last Name", "Grade"));
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < intGradesSorted.Length; i++)
                    {
                        Console.WriteLine(string.Format("{0,20} {1,20} {2,20}", strFirstNamesSorted[i], strLastNamesSorted[i], intGradesSorted[i]));
                    }
                    Console.WriteLine("");
                    Proceed();
                }
                else if (strOption == "D")
                {
                    //Displays list sorted by grade
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(string.Format("{0,20} {1,20} {2,20}", "First Name", "Last Name", "Grade"));
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int i = 0; i < intGradesSorted.Length; i++)
                    {
                        Console.WriteLine(string.Format("{0,20} {1,20} {2,20}", strFirstNamesSorted[i], strLastNamesSorted[i], intGradesSorted[i]));
                    }
                    Console.WriteLine("");
                    Proceed();
                }
                else if (strOption == "E")
                {
                    int intDelete = 0;
                    if (intStudents <= 1)
                    {
                        Console.WriteLine("Exiting the Program since only one student saved!");
                        Proceed();
                        break;
                    }
                    //Displays the unsorted list so that user can select a number                   
                    while (true)
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(string.Format("{0,20} {1,20} {2,20} {3,20}", "#", "First Name", "Last Name", "Grade"));
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int i = 0; i < intGrades.Length; i++)
                        {
                            Console.WriteLine(string.Format("{0,20} {1,20} {2,20} {3,20}", i + 1, strFirstNames[i], strLastNames[i], intGrades[i]));
                        }
                        Console.WriteLine("\nWhich student would you like to delete (select the corresponding number)");
                        strUser = Console.ReadLine();
                        intDelete = Int32.Parse(strUser);
                        if ((intDelete <= intGrades.Length) && (intDelete >= 1))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input!");
                            Proceed();
                        }
                    }
                    intDelete--; //Sets delete for location within array
                    //Moves to temp file
                    for (int i = 0; i < intGradesSorted.Length; i++)
                    {
                        intGradesTemp[i] = intGrades[i];
                        strLastNameTemp[i] = strLastNames[i];
                        strFirstNameTemp[i] = strFirstNames[i];
                    }
                    //Changes array to remove the deleted value
                    intStudents--;
                    intGrades = new int[intStudents];
                    intGradesSorted = new int[intStudents];
                    strLastNames = new string[intStudents];
                    strLastNamesSorted = new string[intStudents];
                    strFirstNames = new string[intStudents];
                    strFirstNamesSorted = new string[intStudents];
                    //Moves all values to keep to the new file
                    for (int i = 0; i < (intGrades.Length + 1); i++)
                    {
                        if (i < intDelete)
                        {
                            intGrades[i] = intGradesTemp[i];
                            strLastNames[i] = strLastNameTemp[i];
                            strFirstNames[i] = strFirstNameTemp[i];
                        }
                        else if (i > intDelete)
                        {
                            intGrades[i - 1] = intGradesTemp[i];
                            strLastNames[i - 1] = strLastNameTemp[i];
                            strFirstNames[i - 1] = strFirstNameTemp[i];
                        }
                    }
                    Console.WriteLine("The student has been successfully deleted");
                    //Ending
                    Proceed();
                    intGradesTemp = new int[intStudents];
                    strFirstNameTemp = new string[intStudents];
                    strLastNameTemp = new string[intStudents];
                }
                else if (strOption == "F")
                {
                    //Collects inputs for additional user entry
                    Console.WriteLine("Please state the user's FIRST NAME");
                    strUser = Console.ReadLine();
                    strFirstNameInput = strUser;
                    Console.WriteLine("Please state the user's LAST NAME");
                    strUser = Console.ReadLine();
                    strLastNameInput = strUser;
                    Console.WriteLine("Please state the user's GRADE");
                    strUser = Console.ReadLine();
                    intGradeInput = Int32.Parse(strUser);
                    //Moves to temp file
                    for (int i = 0; i < intGradesSorted.Length; i++)
                    {
                        intGradesTemp[i] = intGrades[i];
                        strLastNameTemp[i] = strLastNames[i];
                        strFirstNameTemp[i] = strFirstNames[i];
                    }
                    //Changes array to add the additional value
                    intStudents++; //Adds one to the # of students
                    intGrades = new int[intStudents];
                    intGradesSorted = new int[intStudents];
                    strLastNames = new string[intStudents];
                    strLastNamesSorted = new string[intStudents];
                    strFirstNames = new string[intStudents];
                    strFirstNamesSorted = new string[intStudents];
                    //Adds the values before new entry
                    for (int i = 0; i < (intStudents - 1); i++)
                    {
                        intGrades[i] = intGradesTemp[i];
                        strLastNames[i] = strLastNameTemp[i];
                        strFirstNames[i] = strFirstNameTemp[i];
                    }
                    //Adds the new entry
                    intGrades[intStudents - 1] = intGradeInput;
                    strLastNames[intStudents - 1] = strLastNameInput;
                    strFirstNames[intStudents - 1] = strFirstNameInput;
                    //Changes temp loops
                    intGradesTemp = new int[intStudents];
                    strFirstNameTemp = new string[intStudents];
                    strLastNameTemp = new string[intStudents];

                    Console.WriteLine("The list has been modified!");//Inform user
                    Proceed();
                }
                else if (strOption == "G")
                {
                    //Declares the total and the number of students to calculate the average
                    int intTotal = 0;
                    decimal decAverage = 0;

                    //Adds up all grades in the system
                    for (int i = 0; i < intGrades.Length; i++)
                    {
                        intTotal += intGrades[i];
                    }

                    //Divides to get average
                    decAverage = (decimal)intTotal / intGrades.Length;
                    decAverage = Math.Round(decAverage, 2);

                    //Displays the rounded average
                    Console.WriteLine("The average grade of the students is " + decAverage + "%");
                    Proceed();
                }
                else if (strOption == "H")
                {
                    //Outputs the highest mark student using the sorted list made in advance
                    Console.WriteLine("The student with the highest mark is " + strFirstNamesSorted[0] + " " + strLastNamesSorted[0]);
                    Console.WriteLine("The student mark is " + intGradesSorted[0] + "%");

                    Proceed();
                }
                else if (strOption == "I")
                {
                    //Declares variables for the lowest number which is end of array
                    int intLowest;
                    intLowest = intGradesSorted.Length - 1;

                    //Outputs the greatest mark student
                    Console.WriteLine("The student with the lowest mark is " + strFirstNamesSorted[intLowest] + " " + strLastNamesSorted[intLowest]);
                    Console.WriteLine("The student mark is " + intGradesSorted[intLowest] + "%");

                    Proceed();
                }
                else if (strOption == "J")
                {
                    //Declares variables for the median
                    int intMedian;
                    intStudents = intGrades.Length;

                    //determines the median value
                    if (intStudents % 2 != 0) //Odd number means that there is a perfectly middle value
                    {
                        intMedian = (intStudents / 2) + 1 - 1;
                        Console.WriteLine("The median grade is " + intGradesSorted[intMedian] + "%");
                    }
                    else //Even number means two values must be added
                    {
                        decimal decMedian;
                        decMedian = (decimal)(intGradesSorted[(intStudents / 2) - 1] + intGradesSorted[(intStudents / 2) + 1 - 1]) / 2;
                        Console.WriteLine("The median grade is " + decMedian + "%");
                    }

                    Proceed();
                }
                else if (strOption == "K")
                {
                    //Exits the loop and proceeds to termination
                    break;
                }
                else
                {
                    //Identifies the user input as invalid
                    Console.WriteLine("Please enter a valid input!");
                    Proceed();
                }

            }

            //Termination of the Program
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("Press any key to fully exit this program!");
            Console.ReadKey(); //Awaits user key to exit the program


        }
        static void MenuDisplay()
        {
            Console.WriteLine("Please select an option from the list below!");
            //Displays Options to the User
            Console.ForegroundColor = ConsoleColor.Magenta; //colour
            Console.WriteLine("A. List in saved order");
            Console.WriteLine("B. List sorted by last names (A-Z)");
            Console.WriteLine("C. List sorted by first names (A-Z)");
            Console.WriteLine("D. List sorted by grades (High - Low)");
            Console.WriteLine("E. Delete a student");
            Console.WriteLine("F. Add a student");
            Console.WriteLine("G. Student average for the class");
            Console.WriteLine("H. Student with the highest grade");
            Console.WriteLine("I. Student with the lowest grade");
            Console.WriteLine("J. Median grade of the student");
            Console.WriteLine("K. Exit");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Proceed() //Will proceed with whatever action, such as returning to the menu
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; //colour
            Console.WriteLine("Press any key to proceed!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(); //Awaits user key to proceed
            Console.Clear();
        }
    }
}
