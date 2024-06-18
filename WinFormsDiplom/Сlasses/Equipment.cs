using System;
using System.Collections.Generic;

namespace WinFormsDiplom;

public partial class Equipment
{
    public int Id { get; set; }

    public int? InventoryNumber { get; set; }

    public int? Category { get; set; }

    public string? Model { get; set; }

    public decimal? BookValue { get; set; }

    public int? FinanciallyResponsible { get; set; }

    public int? Status { get; set; }

    public virtual CategoriesEquipment? CategoryNavigation { get; set; }

    public virtual Staff? FinanciallyResponsibleNavigation { get; set; }

    public virtual ICollection<MovementEquipment> MovementEquipments { get; set; } = new List<MovementEquipment>();

    public virtual Status? StatusNavigation { get; set; }
}
