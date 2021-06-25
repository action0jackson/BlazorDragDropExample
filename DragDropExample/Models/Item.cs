using System.Collections.Generic;

namespace DragDropExample.Models
{
    public class Item
    {
        public string Name { get; set; }
        public List<Item> Children { get; set; } = new List<Item>();
    }
}
