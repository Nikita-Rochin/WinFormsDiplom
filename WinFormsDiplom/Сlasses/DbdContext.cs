using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WinFormsDiplom.Views;

namespace WinFormsDiplom.Сlasses;

public partial class DbdContext : DbContext
{
    public DbdContext()
    {
    }

    public DbdContext(DbContextOptions<DbdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoriesEquipment> CategoriesEquipments { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<MovementEquipment> MovementEquipments { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<ViewCatEq> ViewCatEqs { get; set; }

    public virtual DbSet<ViewEquipment> ViewEquipments { get; set; }

    public virtual DbSet<ViewEvent> ViewEvents { get; set; }

    public virtual DbSet<ViewMovEqDataTransferAsc> ViewMovEqDataTransferAscs { get; set; }

    public virtual DbSet<ViewMovEqDateReturnAsc> ViewMovEqDateReturnAscs { get; set; }

    public virtual DbSet<ViewMovEqDateTransferDesc> ViewMovEqDateTransferDescs { get; set; }

    public virtual DbSet<ViewMovEqDateTransferDesck> ViewMovEqDateTransferDescks { get; set; }

    public virtual DbSet<ViewStaff> ViewStaffs { get; set; }

    public virtual DbSet<ViewStatus> ViewStatuses { get; set; }

    public virtual DbSet<ViewUser> ViewUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=HOME-PC\\SQLEXPRESS;Database=DBD;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriesEquipment>(entity =>
        {
            entity.ToTable("categories_equipment");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.ToTable("equipment");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BookValue)
                .HasColumnType("money")
                .HasColumnName("book_value");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.FinanciallyResponsible).HasColumnName("financially_responsible");
            entity.Property(e => e.InventoryNumber).HasColumnName("Inventory_number");
            entity.Property(e => e.Model)
                .HasColumnType("text")
                .HasColumnName("model");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK_equipment_categories_equipment1");

            entity.HasOne(d => d.FinanciallyResponsibleNavigation).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.FinanciallyResponsible)
                .HasConstraintName("FK_equipment_staff");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_equipment_Status");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateStart).HasColumnName("date_start");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EventCurator).HasColumnName("event_curator");
            entity.Property(e => e.LocationEvent)
                .IsUnicode(false)
                .HasColumnName("location_event");
            entity.Property(e => e.NameEvent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name_event");
        });

        modelBuilder.Entity<MovementEquipment>(entity =>
        {
            entity.ToTable("Movement_equipment");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.DateReturn).HasColumnName("date_return");
            entity.Property(e => e.DateTransfer).HasColumnName("date_transfer");
            entity.Property(e => e.IdEquipment).HasColumnName("id_equipment");
            entity.Property(e => e.IdEvent).HasColumnName("id_event");
            entity.Property(e => e.IdStaffRecipient).HasColumnName("id_staff_recipient");
            entity.Property(e => e.IdStaffSender).HasColumnName("id_staff_sender");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Remark)
                .HasColumnType("text")
                .HasColumnName("remark");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.MovementEquipment)
                .HasForeignKey<MovementEquipment>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movement_equipment_Events");

            entity.HasOne(d => d.IdEquipmentNavigation).WithMany(p => p.MovementEquipments)
                .HasForeignKey(d => d.IdEquipment)
                .HasConstraintName("FK_Movement_equipment_equipment");

            entity.HasOne(d => d.IdStaffRecipientNavigation).WithMany(p => p.MovementEquipmentIdStaffRecipientNavigations)
                .HasForeignKey(d => d.IdStaffRecipient)
                .HasConstraintName("FK_Movement_equipment_staff1");

            entity.HasOne(d => d.IdStaffSenderNavigation).WithMany(p => p.MovementEquipmentIdStaffSenderNavigations)
                .HasForeignKey(d => d.IdStaffSender)
                .HasConstraintName("FK_Movement_equipment_staff");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.ToTable("staff");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Building)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("building");
            entity.Property(e => e.Cabinet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cabinet");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("patronymic");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(18)
                .IsFixedLength()
                .HasColumnName("phone_number");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.ToTable("Status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdStaff).HasColumnName("id_staff");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdStaff)
                .HasConstraintName("FK_Users_staff");
        });

        modelBuilder.Entity<ViewCatEq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CatEq");

            entity.Property(e => e.ИндентификационыйНомер).HasColumnName("Индентификационый номер");
            entity.Property(e => e.НазваниеКатегории)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Название категории");
        });

        modelBuilder.Entity<ViewEquipment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Equipment");

            entity.Property(e => e.БалансоваяСтоимость)
                .HasColumnType("money")
                .HasColumnName("Балансовая стоимость");
            entity.Property(e => e.ИнвентарныйНомер).HasColumnName("Инвентарный номер");
            entity.Property(e => e.ИндентификационыйНомер).HasColumnName("Индентификационый номер");
            entity.Property(e => e.Категория)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Модель).HasColumnType("text");
            entity.Property(e => e.ОтветственныйСотрудник)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ответственный сотрудник");
            entity.Property(e => e.Статус)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("статус");
        });

        modelBuilder.Entity<ViewEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Events");

            entity.Property(e => e.ДатаНачала).HasColumnName("Дата начала");
            entity.Property(e => e.ДатаОкончания).HasColumnName("Дата окончания");
            entity.Property(e => e.ИндентификационыйНомер).HasColumnName("Индентификационый номер");
            entity.Property(e => e.КураторМероприятия)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Куратор мероприятия");
            entity.Property(e => e.МестоПроведение)
                .IsUnicode(false)
                .HasColumnName("Место проведение");
            entity.Property(e => e.НазваниеМероприятия)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Название мероприятия");
        });

        modelBuilder.Entity<ViewMovEqDataTransferAsc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MovEqDataTransferAsc");

            entity.Property(e => e.ДатаВозврата).HasColumnName("Дата возврата");
            entity.Property(e => e.ДатаПередачи).HasColumnName("Дата передачи");
            entity.Property(e => e.Замечания).HasColumnType("text");
            entity.Property(e => e.ИнвентарныйНомер).HasColumnName("Инвентарный номер");
            entity.Property(e => e.ИндентификационныйНомер).HasColumnName("Индентификационный номер");
            entity.Property(e => e.НазваниеМероприятия)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Название мероприятия");
            entity.Property(e => e.СотрудникОтправитель)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Сотрудник отправитель");
            entity.Property(e => e.СотрудникПолучатель)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Сотрудник получатель");
        });

        modelBuilder.Entity<ViewMovEqDateReturnAsc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MovEqDateReturnAsc");

            entity.Property(e => e.ДатаВозврата).HasColumnName("Дата возврата");
            entity.Property(e => e.ДатаПередачи).HasColumnName("Дата передачи");
            entity.Property(e => e.Замечания).HasColumnType("text");
            entity.Property(e => e.ИнвентарныйНомер).HasColumnName("Инвентарный номер");
            entity.Property(e => e.ИндентификационныйНомер).HasColumnName("Индентификационный номер");
            entity.Property(e => e.НазваниеМероприятия)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Название мероприятия");
            entity.Property(e => e.СотрудникОтправитель)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Сотрудник отправитель");
            entity.Property(e => e.СотрудникПолучатель)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Сотрудник получатель");
        });

        modelBuilder.Entity<ViewMovEqDateTransferDesc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MovEqDateTransferDesc");

            entity.Property(e => e.ДатаВозврата).HasColumnName("Дата возврата");
            entity.Property(e => e.ДатаПередачи).HasColumnName("Дата передачи");
            entity.Property(e => e.Замечания).HasColumnType("text");
            entity.Property(e => e.ИнвентарныйНомер).HasColumnName("Инвентарный номер");
            entity.Property(e => e.ИндентификационныйНомер).HasColumnName("Индентификационный номер");
            entity.Property(e => e.НазваниеМероприятия)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Название мероприятия");
            entity.Property(e => e.СотрудникОтправитель)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Сотрудник отправитель");
            entity.Property(e => e.СотрудникПолучатель)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Сотрудник получатель");
        });

        modelBuilder.Entity<ViewMovEqDateTransferDesck>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MovEqDateTransferDesck");

            entity.Property(e => e.ДатаВозврата).HasColumnName("Дата возврата");
            entity.Property(e => e.ДатаПередачи).HasColumnName("Дата передачи");
            entity.Property(e => e.Замечания).HasColumnType("text");
            entity.Property(e => e.ИнвентарныйНомер).HasColumnName("Инвентарный номер");
            entity.Property(e => e.ИндентификационныйНомер).HasColumnName("Индентификационный номер");
            entity.Property(e => e.НазваниеМероприятия)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Название мероприятия");
            entity.Property(e => e.СотрудникОтправитель)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Сотрудник отправитель");
            entity.Property(e => e.СотрудникПолучатель)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Сотрудник получатель");
        });

        modelBuilder.Entity<ViewStaff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Staff");

            entity.Property(e => e.Имя)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ИндентификационыйНомер)
                .ValueGeneratedOnAdd()
                .HasColumnName("Индентификационый номер");
            entity.Property(e => e.Кабинет)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Корпус)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.НомерТелефона)
                .HasMaxLength(18)
                .IsFixedLength()
                .HasColumnName("Номер телефона");
            entity.Property(e => e.Отчество)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Фамилия)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ЭлПочта)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Эл. почта");
        });

        modelBuilder.Entity<ViewStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Status");

            entity.Property(e => e.ИндентификационыйНомер)
                .ValueGeneratedOnAdd()
                .HasColumnName("Индентификационый номер");
            entity.Property(e => e.ТипСтатуса)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Тип статуса");
        });

        modelBuilder.Entity<ViewUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Users");

            entity.Property(e => e.ИмяПользователя)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Имя пользователя");
            entity.Property(e => e.ИндентификационыйНомер).HasColumnName("Индентификационый номер");
            entity.Property(e => e.Логин)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Пароль)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Сотрудник)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
