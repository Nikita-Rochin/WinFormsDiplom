using System;
using System.Collections.Generic;
using WinFormsDiplom.Сlasses;

namespace WinFormsDiplom;

public partial class Staff
{
    public int Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Patronymic { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Building { get; set; }

    public string? Cabinet { get; set; }

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    public virtual ICollection<MovementEquipment> MovementEquipmentIdStaffRecipientNavigations { get; set; } = new List<MovementEquipment>();

    public virtual ICollection<MovementEquipment> MovementEquipmentIdStaffSenderNavigations { get; set; } = new List<MovementEquipment>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
