using System;

namespace ToDoApp
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public bool Pending { get; set; }

        public ToDoItem(string desc)
        {
            Desc = desc;
            Pending = true;
        }
    }
}
