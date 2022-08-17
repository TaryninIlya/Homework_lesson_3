namespace Homework_lesson_3
{
    internal class Program
    {                                                                                                                                                              //
        static void Main(string[] args)
        {

            Boxing_gloves Everlast_PowerLock_PU = new Boxing_gloves("Everlast PowerLock PU", "Снарядные перчатки", 4500, "20x35x15", 5, "Everlast", "В наличии", "10OZ");      // печатки Everlast PowerLock PU
            //
            Console.WriteLine($"Наименование  перчаток: ");
            Console.WriteLine(Everlast_PowerLock_PU.Name);
            //
            Console.WriteLine($"Описание перчаток: ");
            Console.WriteLine(Everlast_PowerLock_PU.Description);
            //
            Console.WriteLine($"Стоимость перчаток: ");
            Console.WriteLine(Everlast_PowerLock_PU.Product_price);
            //
            Console.WriteLine($"Габаритные размеры перчаток: ");
            Console.WriteLine(Everlast_PowerLock_PU.Dimensions);
            //
            Console.WriteLine($"Количество единиц на складе: ");
            Console.WriteLine(Everlast_PowerLock_PU.Quantity);
            //
            Console.WriteLine($"Производитель перчаток: ");
            Console.WriteLine(Everlast_PowerLock_PU.Manufacturer);
            //
            Console.WriteLine($"Текущий статус перчаток: ");
            Console.WriteLine(Everlast_PowerLock_PU.Status);
            //
            Console.WriteLine($"Размер перчаток: ");
            Console.WriteLine(Everlast_PowerLock_PU.glove_size);
        }
    }
}