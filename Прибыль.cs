//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Прибыль
    {
        public int Id_Прибыли { get; set; }
        public int Id_Товара { get; set; }
        public decimal Стоимость_Привезенных_Товаров { get; set; }
        public int Количество_Привезенных_Товаров { get; set; }
        public decimal Стоимость_Продажи_Товаров { get; set; }
        public int Количество_Продажи_Товаров { get; set; }
        public Nullable<decimal> Итого { get; set; }
    }
}
