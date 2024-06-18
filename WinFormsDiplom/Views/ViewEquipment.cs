using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WinFormsDiplom.Views;

public partial class ViewEquipment
{
    public int ИндентификационыйНомер { get; set; }

    public int? ИнвентарныйНомер { get; set; }

    public string? Категория { get; set; }

    public string? Модель { get; set; }

    public decimal? БалансоваяСтоимость { get; set; }

    public string? ОтветственныйСотрудник { get; set; }

    public string? Статус { get; set; }
}
