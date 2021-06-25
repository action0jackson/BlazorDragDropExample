using System.Collections.Generic;
using DragDropExample.Models;
using Microsoft.AspNetCore.Components;

namespace DragDropExample.Components
{
    public partial class DragDropable
    {
        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
