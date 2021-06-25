using System.Collections.Generic;
using DragDropExample.Models;

namespace DragDropExample.Pages
{
    public partial class Index
    {
        public List<Item> Items { get; set; }

        protected override void OnInitialized()
        {
            // Generate Items
            Items = new List<Item>
            {
                new Item { Name = "One"},
                new Item { Name = "Two"},
                new Item
                {
                    Name = "Three",
                    Children = new List<Item>
                    {
                        new Item { Name = "Three A" },
                        new Item { Name = "Three B" },
                        new Item { Name = "Three C" }
                    }
                },
                new Item { Name = "Four"},
                new Item { Name = "Five"},
                new Item { Name = "Six"},
                new Item
                {
                    Name = "Seven",
                    Children = new List<Item>
                    {
                        new Item { Name = "Seven A" },
                        new Item
                        {
                            Name = "Seven B",
                            Children = new List<Item>
                            {
                                new Item { Name = "Seven B 1" },
                                new Item { Name = "Seven B 2" },
                                new Item { Name = "Seven B 3" }
                            }
                        },
                        new Item { Name = "Seven C" }
                    }
                },
                new Item { Name = "Eight"},
                new Item { Name = "Nine"},
                new Item { Name = "Ten"}
            };

            base.OnInitialized();
        }
    }
}
