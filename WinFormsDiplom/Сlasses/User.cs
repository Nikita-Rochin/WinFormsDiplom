using System;
using System.Collections.Generic;

namespace WinFormsDiplom.Сlasses;

public partial class User
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? UserName { get; set; }

    public int? IdStaff { get; set; }

    public virtual Staff? IdStaffNavigation { get; set; }
}
