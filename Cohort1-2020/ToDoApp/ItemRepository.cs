using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDoApp
{
    public class ItemRepository
    {
        public ItemContext itemContext;

        public ItemRepository()                     //Ensures database is created and sets up the syntax for database interaction
        {
            itemContext = new ItemContext();
            itemContext.Database.EnsureCreated();
        }

        public void AddItem(ToDoItem item)          //Add an item
        {
            itemContext.Add(item);
            itemContext.SaveChanges();
        }

        public void DeleteItem(int id)              //Delete an item
        {
            ToDoItem delItem = itemContext.ToDoItems.Where(x => x.Id == id).FirstOrDefault();
            itemContext.Remove(delItem);
            itemContext.SaveChanges();
        }

        public void ChangeItem(int id)              //Mark an item as done
        {
            ToDoItem updateItem = itemContext.ToDoItems.Where(x => x.Id == id).FirstOrDefault();
            if (updateItem.Pending == true)
            {
                updateItem.Pending = false;
            }
            else
            {
                updateItem.Pending = true;
            }
            itemContext.Update(updateItem);
            itemContext.SaveChanges();
        }

        public List<ToDoItem> PrintPending()        //Print pending items
        {
            List<ToDoItem> pendPrint = itemContext.ToDoItems.Where(x => x.Pending == true).ToList();
            return pendPrint;
        }

        public List<ToDoItem> PrintComplete()       //Print completed items
        {
            List<ToDoItem> compPrint = itemContext.ToDoItems.Where(x => x.Pending == false).ToList();
            return compPrint;
        }

        public List<ToDoItem> PrintAll()            //Print all items
        {
            List<ToDoItem> all = itemContext.ToDoItems.ToList();
            return all;
        }

        public bool IdChecker(int id)               //Checks to make sure the id entered is available
        {
            ToDoItem idCheck = itemContext.ToDoItems.Where(x => x.Id == id).FirstOrDefault();
            if (idCheck != null)
            {
                return true;
            }
            return false;
        }

        public ToDoItem FindItem(int id)            //Finds the ID # associated with what the user chose
        {
            return itemContext.ToDoItems.Where(x => x.Id == id).FirstOrDefault();
        }
    }



}
