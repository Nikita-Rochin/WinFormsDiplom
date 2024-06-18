using System;
using System.Collections.Generic;
using WinFormsDiplom.Сlasses;

namespace WinFormsDiplom;

public partial class MovementEquipment
{
    public int Id { get; set; }

    public int? IdEquipment { get; set; }

    public int? IdEvent { get; set; }

    public int? IdStaffSender { get; set; }

    public int? IdStaffRecipient { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? DateTransfer { get; set; }

    public DateOnly? DateReturn { get; set; }

    public string? Remark { get; set; }

    public virtual Equipment? IdEquipmentNavigation { get; set; }

    public virtual Event IdNavigation { get; set; } = null!;

    public virtual Staff? IdStaffRecipientNavigation { get; set; }

    public virtual Staff? IdStaffSenderNavigation { get; set; }
}
