using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;


namespace Homework_lesson_3
{
    internal class Boxing_gloves : Inventory    // Боксерские перчатки
    {
        public string? glove_size;    // размер перчаток
        //
        public Boxing_gloves(string Name, string Description, float Product_price, string Dimensions, int Quantity, string Manufacturer, string Status, string glove_size) 
        {
            this.Name = Name;  // наименование  перчаток
            this.Description = Description;   // описание перчаток
            this.Product_price = Product_price;   // Стоимость перчаток
            this.Dimensions = Dimensions;     // Габаритные размеры перчаток
            this.Quantity = Quantity;     // Количество единиц на складе
            this.Manufacturer = Manufacturer;     // Производитель перчаток
            this.Status = Status;     // Текущий статус перчаток
            this.glove_size = glove_size;      // Размер перчаток
        }

    }
}
