using System;
using System.Collections.Generic;

namespace WinFormsDiplom;

public partial class CategoriesEquipment
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();
}
