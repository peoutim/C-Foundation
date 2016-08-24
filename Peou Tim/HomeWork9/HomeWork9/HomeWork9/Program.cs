using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace HomeWork9
{
    /// <summary>
    /// Programmer: Tim Peou
    /// Requirement:Modify the following FileIOProject to load and save all the inventory items
    /// using either binary or soap formatting.
    /// C# provides the StreamWriter and StreamReader classes from the System.IO namespace 
    /// </summary>
    class Menu
    {
        private string[] menuItems;
        private readonly int maxItems;
        private int currentOption;

        public Menu()
        {
            menuItems = new string[]
                {
                "Add an item",
                "Change an item",
                "Delete an item",
                "List all items",
                "Quit"
                };

            maxItems = menuItems.Length;
        }

        public bool GetOption()
        {
            DisplayMenu();

            string str = Console.ReadLine();

            currentOption = 0;
            try
            {
                currentOption = int.Parse(str);

                // The last item (maxItems) is the Quit option.
                return currentOption == maxItems;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }

            return false;
        }

        public void DisplayMenu()
        {
            int itemNumber = 1;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n");

            foreach (string str in menuItems)
            {
                Console.WriteLine("{0}. {1}",
                    itemNumber, str);

                itemNumber++;
            }
        }

        public int CurrentOption
        {
            get
            {
                return currentOption;
            }
        }

    }
    // TODO: Make the structure serializable

    [Serializable]    //This is an attribute for Binary Formatter

    struct InvItem
    {
        public int ItemNumber;
        public string Description;
        public double Price;
        public int Quantity;

        public override bool Equals(object o)
        {
            InvItem item = (InvItem)o;

            return ItemNumber == item.ItemNumber;
        }

        public override int GetHashCode()
        {          

            throw new Exception();
        }

    }
    class Inventory
    {
        ArrayList items = new ArrayList();

        public Inventory()
        {

        }

        private string FileName = "inventory.dat";

        FileStream stream = File.Create("inventory.dat");

        // TODO: Create a formatter object

        private BinaryFormatter formatter = new BinaryFormatter();


        public void LoadFile()
        {
            // TODO: Check if the file exists and load the file

            if (File.Exists(FileName))
            {
                try
                {

                    FileStream stream = File.Open(FileName, FileMode.Open);
                    items = (ArrayList)formatter.Deserialize(stream);
                    stream.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("After Input: File Created  -Check Bin Folder"); 
                }//End Try Catch
            }//End If      
           
        }

        public void SaveFile()
        {
            // TODO: Save the file

            try
            {
                FileStream stream = File.Create(FileName);
                formatter.Serialize(stream, items);
                stream.Close();              
                              
            }
            catch(Exception)
            {
                Console.WriteLine("Unable to save information");

            }//End Try Catch        
            
        }

        public void Add()
        {
            InvItem item;
            string str;

            Console.Write("Enter item #:");
            str = Console.ReadLine();
            item.ItemNumber = int.Parse(str);

            Console.Write("Enter description:");
            item.Description = Console.ReadLine();

            Console.Write("Enter price:");
            str = Console.ReadLine();
            item.Price = double.Parse(str);

            Console.Write("Enter quantity:");
            str = Console.ReadLine();
            item.Quantity = int.Parse(str);

            bool found = items.Contains(item);

            if (found)
            {
                Console.WriteLine("item already exists");
                return;
            }

            items.Add(item);
        }

        public void Change()
        {
            InvItem item;
            string str;

            Console.Write("Enter item #:");
            str = Console.ReadLine();
            item.ItemNumber = int.Parse(str);
            item.Description = "";
            item.Price = 0;
            item.Quantity = 0;

            int index = items.IndexOf(item);

            if (index < 0)
            {
                Console.WriteLine("item not found");
                return;
            }

            item = (InvItem)items[index];

            Console.WriteLine("Old description  :" + item.Description);
            Console.Write("Enter description:");
            item.Description = Console.ReadLine();

            Console.WriteLine("Old price  :" + item.Price);
            Console.Write("Enter price:");
            str = Console.ReadLine();
            item.Price = double.Parse(str);

            Console.WriteLine("Old quantity  :" + item.Quantity);
            Console.Write("Enter quantity:");
            str = Console.ReadLine();
            item.Quantity = int.Parse(str);

            items[index] = item;
        }
        public void Delete()
        {
            InvItem item;
            string str;

            Console.Write("Enter item #:");
            str = Console.ReadLine();
            item.ItemNumber = int.Parse(str);
            item.Description = "";
            item.Price = 0;
            item.Quantity = 0;

            int index = items.IndexOf(item);

            if (index >= 0)
            {
                items.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("item not found");
            }
        }
        public void ListAll()
        {
            foreach (InvItem item in items)
            {
                Console.WriteLine(
                    "{0,4} {1} {2:c} {3,3}",
                    item.ItemNumber,
                    item.Description,
                    item.Price,
                    item.Quantity);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            Menu mainMenu = new Menu();

            // Load the c:\inventory.dat file.

            inventory.LoadFile();

            while (mainMenu.GetOption() != true)
            {
                switch (mainMenu.CurrentOption)
                {
                    case 1: // Add
                        {
                            inventory.Add();
                            break;
                        }
                    case 2: // Change
                        {
                            inventory.Change();
                            break;
                        }
                    case 3: // Delete
                        {
                            inventory.Delete();
                            break;
                        }
                    case 4: // List all
                        {
                            inventory.ListAll();
                            break;
                        }
                    case 5: // Quit
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option");
                            break;
                        }
                } // switch
            } // while

            inventory.SaveFile();

        } // Main()
    } // class ProjectMain
}
    

