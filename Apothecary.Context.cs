﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApothecaryApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ApothecaryEntities : DbContext
    {
        private static ApothecaryEntities context;
        public ApothecaryEntities()
            : base("name=ApothecaryEntities")
        {
        }

        public static ApothecaryEntities GetContext()
        {
            if (context == null)
            {
                context = new ApothecaryEntities();
            }
            return context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Поставщики> Поставщики { get; set; }
        public virtual DbSet<Прибыль> Прибыль { get; set; }
        public virtual DbSet<Продажи> Продажи { get; set; }
        public virtual DbSet<Расчет_с_поставщиками> Расчет_с_поставщиками { get; set; }
        public virtual DbSet<Списание> Списание { get; set; }
        public virtual DbSet<Список_Товаров> Список_Товаров { get; set; }
    }
}
