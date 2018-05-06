using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace bills2April2618
{
    class Program
    {
        



        static void Main(string[] args)
        {

            Console.WriteLine("Bills Program\n\n");
            
            

            string strReadOne;
            StreamReader readf = new StreamReader("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileOne.txt");
            strReadOne = readf.ReadLine();
            Console.WriteLine("The month is: " + strReadOne);
            readf.Close();

            
            // dont kill the hunger  self indulence has an i in it
            

            string strAnswer;
            string strAnswer2;
            string strAnswer3;
            string strAnswer4;

            bool boolContinue = true;
            bool boolRead = true;


            while (boolContinue)
            {
                Console.WriteLine("Read only (yes) or Write and Read (no)\n");
            strAnswer = Console.ReadLine();

            

           

                switch (strAnswer)
                {
                    case "yes":
                        boolRead = true;
                        boolContinue = false;
                        break;

                    case "no":
                        boolRead = false;
                        boolContinue = false;
                        break;

                    default:
                        boolContinue = true;
                        break;

                }
            }

            if (boolRead == false)
            {
                string strMonth;

                Console.WriteLine("What is the month?\n");
                strMonth = Console.ReadLine();

                string tagOne = String.Format("The month is {0}", strMonth);
                Console.WriteLine("\n\n" + tagOne + "\n\n");

                StreamWriter F = new StreamWriter("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileOne.txt");

                F.WriteLine(strMonth);
                F.Close();



                StreamWriter FC = new StreamWriter("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileTwo.txt");

                bool boolContinue2 = true;
                
                

                while (boolContinue2)
                {

                    Console.WriteLine("Did you pay the bill for the City of Anadarko? yes / no ");
                    strAnswer2 = Console.ReadLine();


                    switch (strAnswer2)
                    {
                        case "yes":
                            
                            boolContinue2 = false;
                            FC.WriteLine("yes");
                            FC.Close();
                            break;

                        case "no":
                            
                            boolContinue2 = false;
                            FC.WriteLine("no");
                            FC.Close();
                            break;

                        default:
                            boolContinue2 = true;
                            break;
                    }


                }

                StreamWriter FATT = new StreamWriter("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileThree.txt");

                bool boolContinue3 = true;



                while (boolContinue3)
                {

                    Console.WriteLine("Did you pay the bill for the ATT? yes / no ");
                    strAnswer3 = Console.ReadLine();


                    switch (strAnswer3)
                    {
                        case "yes":

                            boolContinue3 = false;
                            FATT.WriteLine("yes");
                            FATT.Close();
                            break;

                        case "no":

                            boolContinue3 = false;
                            FATT.WriteLine("no");
                            FATT.Close();
                            break;

                        default:
                            boolContinue3 = true;
                            break;
                    }


                }





                StreamWriter FONG = new StreamWriter("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileFour.txt");

                bool boolContinue4 = true;



                while (boolContinue4)
                {

                    Console.WriteLine("Did you pay the bill for the ONG? yes / no ");
                    strAnswer4 = Console.ReadLine();


                    switch (strAnswer4)
                    {
                        case "yes":

                            boolContinue4 = false;
                            FONG.WriteLine("yes");
                            FONG.Close();
                            break;

                        case "no":

                            boolContinue4 = false;
                            FONG.WriteLine("no");
                            FONG.Close();
                            break;

                        default:
                            boolContinue4 = true;
                            break;
                    }


                }








            }


            string strMMMonth;
            StreamReader tr = new StreamReader("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileOne.txt");
            strMMMonth = tr.ReadLine();
            Console.WriteLine("\n\n" + strMMMonth + "\n\n");
            
            tr.Close();

            string strCity;

            StreamReader ct = new StreamReader("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileTwo.txt");
            strCity = ct.ReadLine();
            Console.WriteLine("City paid: " + strCity);

            ct.Close();

            string strATT;

            StreamReader at = new StreamReader("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileTwo.txt");
            strATT = at.ReadLine();
            Console.WriteLine("ATT paid: " + strATT);

            at.Close();



            string strONG;

            StreamReader ong = new StreamReader("C:\\Users\\fuego\\Desktop\\BillsProgramDataFile\\FileFour.txt");
            strONG = ong.ReadLine();
            Console.WriteLine("ONG paid: " + strONG + "\n\n");

            at.Close();



            Console.WriteLine("press enter.......");
            Console.ReadLine();

        }
    }
}
