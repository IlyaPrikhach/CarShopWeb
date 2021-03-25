using System;
using System.Collections.Generic;
using System.Text;

namespace СarShop.DataLayer
{
    public class SampleData
    {
        public static void InitData(EFDBContext context)
        {
            context.Cars.Add(new Entities.Car()
            {
                Name = "Audi A6",
                Description = "Летопись победителей премии WCOTY началась в 2005 году с седана Audi A6 третьего поколения. Кстати, именно эта машина под индексом C6 первой среди моделей с четырьмя кольцами получила новую (в то время) радиаторную решётку Singleframe ",
                ManufactureYear = 2005,
                Price = 5000
            });

            context.Cars.Add(new Entities.Car()
            {
                Name = "Lexus LS460",
                Description = "Модель предлагали с задним и полным приводом, со стандартной и удлиненной колёсной базой, а также с бензиновыми и гибридным силовыми агрегатами. За 10 лет производства это поколение обновлялось дважды - в 2009 и 2012 годах.",
                ManufactureYear = 2007,
                Price = 8000
            });

            context.Cars.Add(new Entities.Car()
            {
                Name = "Mazda2",
                Description = "Компактный хетчбэк Mazda2, известный на домашнем рынке с 1996 года под именем Demio, был удостоен высшей награды WCOTY в третьем поколении. Автором стремительного облика модели был тогдашний шеф-дизайнер японской марки Икуо Маеда. Эта Mazda2 базировалась на платформе DE, которую в 2008 году Ford позаимствовал для очередной «Фиесты».",
                ManufactureYear = 2008,
                Price = 6000
            });
            context.SaveChanges();
        }
    }
}
