using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Programmer: Tim Peou
/// Final Project: Create an Inventory program to keep track of some inventory items.
/// </summary>

namespace FinalProject
{   
    /// <summary>
    /// IT Fdn Class Project Template.cs
    /// Write a program to keep track of some inventory items as shown below.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // use an interger to keep track of the count of items in your inventory			

            // create an array of your ItemData struct

            // use a never ending loop that shows the user what options they can select 

            // as long as no one Quits, continue the inventory update

            // in that loop, show what user can select from the list

            // read the user's input and then create what case it falls


            //Create an Intance of InventoryItem

            InventoryItem inventorydata = new InventoryItem();

            do
            {
                //// Let the user specify the action from the Menu

                Console.WriteLine("Inventory Tracking Console Application: ");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine();                
                Console.WriteLine("Please Choose (1-5) from the Menu Below: ");
                Console.WriteLine();

                Console.WriteLine("[1]: Add Item to the List");
                Console.WriteLine("[2]: List all Item from the List");
                Console.WriteLine("[3]: Change Item from the List");
                Console.WriteLine("[4]: Delete Item from the List");
                Console.WriteLine("[5]: Quit this Program");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------");


                string strx = Console.ReadLine();   // read user's input	

                int optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

                Console.WriteLine(); // provide an extra blank line on screen

                switch (optx)
                {

                    case 1: // add an item to the list if this option is selected
                        {
                            inventorydata.AddItem();         
                                                        
                            break;
                        }
                        
                    case 2:  //list all items in current database if this option is selected

                        inventorydata.ListItem();                      
                        

                        break;


                    case 3: //change items in the list if this option is selected
                        {
                            inventorydata.ChangeItem();

                            break;
                        }

                    case 4: //delete items in the list if this option is selected
                        {

                            inventorydata.DeleteItem();
                            break;
                        }

                    case 5: //quit the program if this option is selected
                        {
                           
                            Console.Write("Are you sure that you want to quit(y/n)?");                            
                            string strresp = Console.ReadLine();
                            Console.WriteLine();

                            if (strresp == "y")
                            {

                                Console.WriteLine("Good Bye!");
                                Console.WriteLine();
                                Environment.Exit(0);                             
                                
                            }
                            else
                            {
                                optx = 0;   //as long as it is not 5, the process is not breaking
                            }
                            break;
                        }

                    default:
                        {
                            Console.Write("Invalid Option, Try again Choose (1-5) From Menu Below:");
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                        }
                }
            } while (true);
        }

    }
}




