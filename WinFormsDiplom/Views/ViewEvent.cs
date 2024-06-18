using System;
using System.Collections.Generic;

namespace WinFormsDiplom.Views;

public partial class ViewEvent
{
    public int ИндентификационыйНомер { get; set; }

    public string? НазваниеМероприятия { get; set; }

    public string? МестоПроведение { get; set; }

    public string? КураторМероприятия { get; set; }

    public DateOnly? ДатаНачала { get; set; }

    public DateOnly? ДатаОкончания { get; set; }
}
