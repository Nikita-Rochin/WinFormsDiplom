using System;
using System.Collections.Generic;

namespace WinFormsDiplom.Views;

public partial class ViewMovEqDataTransferAsc
{
    public int ИндентификационныйНомер { get; set; }

    public int? ИнвентарныйНомер { get; set; }

    public string? СотрудникОтправитель { get; set; }

    public string? СотрудникПолучатель { get; set; }

    public string? НазваниеМероприятия { get; set; }

    public int? Количество { get; set; }

    public DateOnly? ДатаПередачи { get; set; }

    public DateOnly? ДатаВозврата { get; set; }

    public string? Замечания { get; set; }
}
