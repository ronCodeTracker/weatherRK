using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace bills2April2618
{
    class Program
    {
        // program starts here
        static void Main(string[] args)
        {
            // heading
            Console.WriteLine("Bills Program\n\n");
            //the month of last use of program
            // declare the variable used for month
            string str_Read_Month_Data;
            //Stream that allows program to save and read from saved data
            //read the file found at location (desktop)
            StreamReader sr_Read_Month_Data = new StreamReader("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileOne.txt");
            //assign to a variable
            str_Read_Month_Data = sr_Read_Month_Data.ReadLine();
            //output the month form the saved file
            Console.WriteLine("The month is: " + str_Read_Month_Data);
            //close the stream
            sr_Read_Month_Data.Close();
            //6666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666Condition for read/write
            //declare variable for switch statement that determines if the program reads the data or changes the data for the bills program
            string str_Answer_readORwrite;
            //declare boolean variable to flag or decide to continue or not
            bool bool_Continue = true;
            //declare a boolean variable to decide to read or write to the data files that tell us if the bills need paying
            bool bool_Read = true;
            while (bool_Continue)// while loop for read or write question
            {
                Console.WriteLine("Read only (yes) or Write and Read (no)\n");
                str_Answer_readORwrite = Console.ReadLine();//input 
                switch (str_Answer_readORwrite)//switch case(better than if statements)
                {
                    case "yes":// we want to read only
                        bool_Read = true;// flag when program arrives at the read condition the flag determine that it should write and not read
                        bool_Continue = false;//move on to next part of the program
                        break;//break the switchcase loop
                    case "no"://j we want to write or change the data for billing
                        bool_Read = false;// flag when program arrives at the read condition the flag determine that it should write and not read
                        bool_Continue = false;//move on to next part of the program
                        break;//break the switchcase loop
                    default://if not yes or no continue to input till there is a yes or no answer
                        bool_Continue = true;//continue loop
                        break;//break the switchcase loop
                }
            }   //******************************************************************************************************************************
            if (bool_Read == false)// if we do not want to read we want to write which is the next part of the program skip if we want to read
            {
                string str_Month_Input;//declare variable for input of the month
                Console.WriteLine("What is the month?\n");// input the month
                str_Month_Input = Console.ReadLine();// input the month
                string tag_month_input = String.Format("The month is {0}", str_Month_Input);
                Console.WriteLine("\n\n" + tag_month_input + "\n\n");
                StreamWriter F = new StreamWriter("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileOne.txt");//stream for writing the month of billing
                F.WriteLine(str_Month_Input);//write the data to file
                F.Close();//close file  //_______________________________________________________________________________________________________________
                //#########################################################################################################################################
                // code for the first bill needing payed
                StreamWriter sw_One = new StreamWriter("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileTwo.txt");// #####################################
                bool bool_Continue_One = true;
                string str_Answer_One;
                while (bool_Continue_One)
                {
                    Console.WriteLine("Did you pay the bill for the City of Anadarko? yes / no ");
                    str_Answer_One = Console.ReadLine();
                    switch (str_Answer_One)
                    {
                        case "yes":
                            bool_Continue_One = false;
                            sw_One.WriteLine("yes");
                            sw_One.Close();
                            break;
                        case "no":
                            bool_Continue_One = false;
                            sw_One.WriteLine("no");
                            sw_One.Close();
                            break;
                        default:
                            bool_Continue_One = true;
                            break;
                    } }
                //  ###################################################################################################################################Second Bill
                StreamWriter sw_Two = new StreamWriter("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileThree.txt");
                bool bool_Continue_Two = true;
                string str_Answer_Two;
                while (bool_Continue_Two)
                {
                    Console.WriteLine("Did you pay the bill for the ATT? yes / no ");
                    str_Answer_Two = Console.ReadLine();
                    switch (str_Answer_Two)
                    {
                        case "yes":
                            bool_Continue_Two = false;
                            sw_Two.WriteLine("yes");
                            sw_Two.Close();
                            break;
                        case "no":
                            bool_Continue_Two = false;
                            sw_Two.WriteLine("no");
                            sw_Two.Close();
                            break;
                        default:
                            bool_Continue_Two = true;
                            break;
                    } }
                //########################################################################################################################################Third Bill
                StreamWriter sw_Three = new StreamWriter("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileFour.txt");
                bool bool_Continue_Three = true;
                string str_Answer_Three;
                while (bool_Continue_Three)
                {
                    Console.WriteLine("Did you pay the bill for the ONG? yes / no ");
                    str_Answer_Three = Console.ReadLine();
                    switch (str_Answer_Three)
                    {
                        case "yes":
                            bool_Continue_Three = false;
                            sw_Three.WriteLine("yes");
                            sw_Three.Close();
                            break;
                        case "no":
                            bool_Continue_Three = false;
                            sw_Three.WriteLine("no");
                            sw_Three.Close();
                            break;
                        default:
                            bool_Continue_Three = true;
                            break;
                    } }
            }// end of writing to files for bill paid
            //#######################################################################################################################################################

            string str_Month_Out;
            StreamReader stream_reader = new StreamReader("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileOne.txt");
            str_Month_Out = stream_reader.ReadLine();
            Console.WriteLine("\n\n" + str_Month_Out + "\n\n");
            stream_reader.Close();//7777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777Bill one read data
            string str_City;
            StreamReader sr_One = new StreamReader("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileTwo.txt");
            str_City = sr_One.ReadLine();
            Console.WriteLine("City paid: " + str_City);
            sr_One.Close();
            //77777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777Bill two read data
            string str_ATT;
            StreamReader sr_Two = new StreamReader("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileTwo.txt");
            str_ATT = sr_Two.ReadLine();
            Console.WriteLine("ATT paid: " + str_ATT);
            sr_Two.Close();
            //777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777Bill three read data
            string str_ONG;
            StreamReader sr_Three = new StreamReader("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileFour.txt");
            str_ONG = sr_Three.ReadLine();
            Console.WriteLine("ONG paid: " + str_ONG + "\n\n");
            sr_Three.Close();
            // the end
            Console.WriteLine("press enter.......");
            Console.ReadLine();
        }}}
