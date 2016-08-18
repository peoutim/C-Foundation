using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject
{
    /// <summary>
    /// Programmer: Tim Peou
    /// Final Project: Create an Inventory program to keep track of some inventory items.
    /// </summary>
        
    struct ItemData
    {
        //Declare Struct Variables

        public int itemIDNo;
        public string sDescription;
        public double dblPricePerItem;
        public int iQuantityOnHand;
        public double dblOurCostPerItem;
        public double dblValueOfItem;

        public override bool Equals(object obj)
        {
            ItemData data = (ItemData)obj;

            return itemIDNo == data.itemIDNo;
        }
        public override int GetHashCode()
        {
            // Comment to explain if there is a real problem with providing GetHashCode() 

            throw new Exception("Unsure: I was trying to resolve a green ItemData squiggly Line");
        }

    }
    class InventoryItem
    {
        //Create a List Array of structs.

        ArrayList ItemList = new ArrayList();

        //Create Constructor

        public InventoryItem()
        {

        }

        //Create Add Method to add Item to the list

        public void AddItem()
        {
            //Add InventoryItem itemdata;  

            ItemData data = new ItemData();

           // for (int i = 0; i < 1; i++)
            //{
                Console.Write("Enter Item ID Number: ");
                data.itemIDNo = int.Parse(Console.ReadLine());

                Console.Write("Enter Item Description: ");
                data.sDescription = Console.ReadLine();

                Console.Write("Enter Price Per Item: ");
                data.dblPricePerItem = double.Parse(Console.ReadLine());

                Console.Write("Enter Quantity on Hand: ");
                data.iQuantityOnHand = int.Parse(Console.ReadLine());

                Console.Write("Enter Our Cost Per Item: ");
                data.dblOurCostPerItem = double.Parse(Console.ReadLine());

                Console.Write("Enter Value of item: ");
                data.dblValueOfItem = double.Parse(Console.ReadLine());
           // }

            bool found = ItemList.Contains(data);

            if (found)
            {
                Console.WriteLine("Item already exists in the Inventory");
                
                return;
            }

            ItemList.Add(data);
        }

        //Create Method to List all items from List

        public void ListItem()
        {

            foreach (ItemData data in ItemList)
            {
                Console.WriteLine("ItemID  Description         Price    QOH    Cost     Value");
                Console.WriteLine("------  ----------------    -----    ----   -----    -----");

                
            Console.WriteLine("{0,-7} {1,-19} {2,4:C} {3,4} {4,10:C} {5,8:C}", data.itemIDNo, data.sDescription,
                              data.dblPricePerItem, data.iQuantityOnHand, data.dblPricePerItem, data.dblValueOfItem);
            Console.WriteLine();
        }
    }

        //Construct a method to change List Item.

        public void ChangeItem()
        {
            // Console.Write("Please enter an item ID No:");
            //        string strchgid = Console.ReadLine();
            //        int chgid = int.Parse(strchgid);
            //        bool fFound = false;

            //        for (int i = 0; i < itemdata.Length; i++)
            //        {
            //            if (itemdata[i].ItemIDNo == chgid)
            //            {
            //                fFound = true;
            //                code to show what has to happen if the item in the list is found
            //                 reset the count to show a new count for your list
            //                 (Note: your list is now increased by one item)
            //            }
            //        }

            //        if (!fFound) // and if not found
            //        {
            //            Console.WriteLine("Item {0} not found", chgid);
            //        }

            ItemData data = new ItemData();

            Console.Write("Enter an Item ID to change:");
            
            data.itemIDNo = int.Parse(Console.ReadLine());

            data.sDescription = "";

            data.dblPricePerItem = 0;

            data.iQuantityOnHand = 0;

            int index = ItemList.IndexOf(data);

            if (index < 0)
            {
                Console.WriteLine();            
                Console.WriteLine("Item ID not found. Verified Item ID to Change is Correct.");
                Console.WriteLine();
                return;
            }

            data = (ItemData)ItemList[index];

            Console.WriteLine("Previous Item Description  :" + data.sDescription);
            Console.Write("Enter New Item Description:");
            data.sDescription = Console.ReadLine();


            Console.WriteLine("Previous Item Price  :" + data.dblPricePerItem);
            Console.Write("Enter New Item Price:");          
            data.dblPricePerItem = double.Parse(Console.ReadLine());

            Console.WriteLine("Previous Item Quantity On Hand  :" + data.iQuantityOnHand);
            Console.Write("Enter New Item Quantity On Hand:");
            data.iQuantityOnHand= int.Parse(Console.ReadLine());


            ItemList[index] = data;    

        }

        //Construct a method to delete item from List.

        public void DeleteItem()
        {
            //Console.Write("Please enter an item ID No:");
            //        string strnewid = Console.ReadLine();
            //        int newid = int.Parse(strnewid);
            //        bool fDeleted = false;

            //        for (int i = 0; i < itemdata.Length; i++)
            //        {
            //            if (itemdata[i].ItemIDNo == newid)
            //            {
            //                fDeleted = true;
            //                delete the item if you found it
            //                 reset the count to show a new count for your list
            //                (Note: your list is now reduced by one item)
            //            }
            //        }

            //        if (fDeleted) // hint the user that you deleted the requested item
            //        {
            //            Console.WriteLine("Item deleted");
            //        }
            //        else // if did not find it, hint the user that you did not find it in your list
            //        {
            //            Console.WriteLine("Item {0} not found", newid);
            //        }

            ItemData data = new ItemData();

            Console.Write("Enter Item ID to Delete:");
           
            data.itemIDNo = int.Parse(Console.ReadLine());

            
            data.sDescription = "";
            data.dblPricePerItem = 0;
            data.iQuantityOnHand = 0;

            int index = ItemList.IndexOf(data);

            if (index >= 0)
            {
                ItemList.RemoveAt(index);
            }
            else
            {
                Console.WriteLine();               
                Console.WriteLine("Item ID not found. Verified Item ID to Delete is Correct.");
                Console.WriteLine();
            }

        }
    }

}




