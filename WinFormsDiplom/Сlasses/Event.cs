using System;
using System.Collections.Generic;

namespace WinFormsDiplom.Сlasses;

public partial class Event
{
    public int Id { get; set; }

    public string? NameEvent { get; set; }

    public string? LocationEvent { get; set; }

    public int? EventCurator { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual MovementEquipment? MovementEquipment { get; set; }
}
