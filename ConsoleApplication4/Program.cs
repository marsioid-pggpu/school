using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolDomains;
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SchoolContext db = new SchoolContext())
            {


                //Country country1 = new Country { Name = "Россия" };
                //Country country2 = new Country { Name = "Украина" };
                //db.Countries.AddRange(new List<Country> { country1, country2 });
                //db.SaveChanges();
                //Region region1 = new Region { Name = "Пермь", Country = country1 };
                //Region region2 = new Region { Name = "Екатеринбург", Country = country1 };
                //Region region3 = new Region { Name = "Киев", Country = country2 };
                //Region region4 = new Region { Name = "Луганск", Country = country2 };
                //db.Regions.AddRange(new List<Region> { region1, region2, region3, region4 });
                //db.SaveChanges();
                //Area area1 = new Area { Name = "Свердловский район", SName = "С", Region = region1 };
                //Area area2 = new Area { Name = "Ленинский район", SName = "Л", Region = region1 };
                //Area area3 = new Area { Name = "Район 1", SName = "Р1", Region = region2 };
                //Area area4 = new Area { Name = "Район 2", SName = "Р2", Region = region2 };
                //Area area5 = new Area { Name = "Район 3", SName = "Р3", Region = region3 };
                //Area area6 = new Area { Name = "Район 4", SName = "Р4", Region = region4 };
                //db.Areas.AddRange(new List<Area> { area1, area2, area3, area4, area5, area6 });
                //db.SaveChanges();
                //School school1 = new School { Name = "Школа №1", Type = "Общ.", Index = "614001", Street = "ул. Роу", House = "12", House2 = "Б", Phone = "2145674", Boss = "Иванова Марина Сергеевна", Area = area1 };
                //School school2 = new School { Name = "Школа №5", Type = "Общ.", Index = "614001", Street = "ул. Роу", House = "26", House2 = "", Phone = "2145667", Boss = "Петрова Марина Сергеевна", Area = area1 };
                //School school3 = new School { Name = "Школа №6", Type = "Общ.", Index = "614004", Street = "ул. Коу", House = "12", House2 = "", Phone = "2145645", Boss = "Сидорова Марина Сергеевна", Area = area2 };
                //School school4 = new School { Name = "Школа №7", Type = "Общ.", Index = "614001", Street = "ул. Роу", House = "56", House2 = "", Phone = "2143474", Boss = "Иванова Ольга Сергеевна", Area = area3 };
                //School school5 = new School { Name = "Школа №8", Type = "Общ.", Index = "614007", Street = "ул. Соу", House = "12", House2 = "А", Phone = "2145454", Boss = "Иванова Евгения Сергеевна", Area = area3 };
                //School school6 = new School { Name = "Школа №9", Type = "Общ.", Index = "614001", Street = "ул. Соу", House = "23", House2 = "Б", Phone = "2143454", Boss = "Иванова Светлана Сергеевна", Area = area4 };
                //School school7 = new School { Name = "Школа №15", Type = "Общ.", Index = "614008", Street = "ул. Роу", House = "12", House2 = "А", Phone = "2345674", Boss = "Иванова Марина Олеговна", Area = area5 };
                //School school8 = new School { Name = "Школа №20", Type = "Общ.", Index = "614001", Street = "ул. Роу", House = "123", House2 = "", Phone = "2145674", Boss = "Иванова Марина Ивановна", Area = area6 };
                //db.Schools.AddRange(new List<School> { school1, school2, school3, school4, school5, school6, school7, school8 });
                //db.SaveChanges();
                //Class class1 = new Class { Parallel = "3", Litera = "А", Type = "Общ.", School = school1 };
                //Class class2 = new Class { Parallel = "4", Litera = "Б", Type = "Общ.", School = school2 };
                //Class class3 = new Class { Parallel = "7", Litera = "Б", Type = "Общ.", School = school3 };
                //Class class4 = new Class { Parallel = "1", Litera = "Б", Type = "Углуб.", School = school3 };
                //Class class5 = new Class { Parallel = "4", Litera = "В", Type = "Общ.", School = school3 };
                //Class class6 = new Class { Parallel = "3", Litera = "Б", Type = "Углуб.", School = school4 };
                //Class class7 = new Class { Parallel = "3", Litera = "В", Type = "Общ.", School = school5 };
                //Class class8 = new Class { Parallel = "6", Litera = "Б", Type = "Углуб.", School = school6 };
                //Class class9 = new Class { Parallel = "8", Litera = "Б", Type = "Общ.", School = school7 };
                //Class class10 = new Class { Parallel = "3", Litera = "А", Type = "Общ.", School = school8 };
                //db.Classes.AddRange(new List<Class> { class1, class2, class3, class4, class5, class6, class7, class8, class9, class10 });
                //db.SaveChanges();
                //Child child1 = new Child { LastName = "Петров", FirstName = "Иван", SurName = "Петрович", Sex = true, Class = class2 };
                //Child child2 = new Child { LastName = "Иванова", FirstName = "Ольга", SurName = "Максимовна", Sex = false, Class = class6 };
                //Child child3 = new Child { LastName = "Козлов", FirstName = "Максим", SurName = "Олегович", Sex = true, Class = class1 };
                //Child child4 = new Child { LastName = "Сидоров", FirstName = "Максим", SurName = "Иванович", Sex = true, Class = class2 };
                //Child child5 = new Child { LastName = "Петров", FirstName = "Евгений", SurName = "Олегович", Sex = true, Class = class3 };
                //Child child6 = new Child { LastName = "Иванов", FirstName = "Петр", SurName = "Иванович", Sex = true, Class = class4 };
                //Child child7 = new Child { LastName = "Козлов", FirstName = "Евгений", SurName = "Олегович", Sex = true, Class = class2 };
                //Child child8 = new Child { LastName = "Петров", FirstName = "Петр", SurName = "Иванович", Sex = true, Class = class4 };
                //Child child9 = new Child { LastName = "Козлов", FirstName = "Петр", SurName = "Олегович", Sex = true, Class = class5 };
                //Child child10 = new Child { LastName = "Петров", FirstName = "Сергей", SurName = "Олегович", Sex = true, Class = class7 };
                //Child child11 = new Child { LastName = "Козлов", FirstName = "Сергей", SurName = "Иванович", Sex = true, Class = class8 };
                //Child child12 = new Child { LastName = "Петров", FirstName = "Максим", SurName = "Олегович", Sex = true, Class = class8 };
                //Child child13 = new Child { LastName = "Петров", FirstName = "Максим", SurName = "Иванович", Sex = true, Class = class10 };
                //Child child14 = new Child { LastName = "Козлов", FirstName = "Иван", SurName = "Олегович", Sex = true, Class = class2 };
                //Child child15 = new Child { LastName = "Петров", FirstName = "Иван", SurName = "Иванович", Sex = true, Class = class1 };
                //db.Childs.AddRange(new List<Child> { child1, child2, child3, child4, child5, child6, child7, child8, child9, child10, child11, child12, child13, child14, child15 });
                //db.SaveChanges();
                //ChildInfo childinfo1 = new ChildInfo { ChildId = child1.ChildId, Index = "614000", City = "Пермь", Street = "Ленина", House = "12", House2 = "", Flat = "33", Phone = "89121234567",  };
                //ChildInfo childinfo2 = new ChildInfo { ChildId = child2.ChildId, Index = "614002", City = "Пермь", Street = "Революции", House = "17", House2 = "Б", Flat = "1", Phone = "89127654321" };
                //ChildInfo childinfo3 = new ChildInfo { ChildId = child3.ChildId, Index = "614006", City = "Нытва", Street = "Стахановская", House = "13", House2 = "", Flat = "123", Phone = "89123456789" };
                //ChildInfo childinfo4 = new ChildInfo { ChildId = child4.ChildId, Index = "614007", City = "Пермь", Street = "Генкеля", House = "2", House2 = "", Flat = "2", Phone = "89123456756" };
                //ChildInfo childinfo5 = new ChildInfo { ChildId = child5.ChildId, Index = "614005", City = "Пермь", Street = "Куйбышева", House = "6", House2 = "А", Flat = "33", Phone = "89123445785" };
                //ChildInfo childinfo6 = new ChildInfo { ChildId = child6.ChildId, Index = "614006", City = "Пермь", Street = "Генкеля", House = "8", House2 = "", Flat = "12", Phone = "89123465489" };
                //ChildInfo childinfo7 = new ChildInfo { ChildId = child7.ChildId, Index = "614002", City = "Березники", Street = "Фонтанная", House = "9", House2 = "", Flat = "23", Phone = "89123456765" };
                //ChildInfo childinfo8 = new ChildInfo { ChildId = child8.ChildId, Index = "614001", City = "Пермь", Street = "Куйбышева", House = "23", House2 = "В", Flat = "96", Phone = "89123456749" };
                //ChildInfo childinfo9 = new ChildInfo { ChildId = child9.ChildId, Index = "614019", City = "Нытва", Street = "Стахановская", House = "1", House2 = "", Flat = "34", Phone = "89123456643" };
                //ChildInfo childinfo10 = new ChildInfo { ChildId = child10.ChildId, Index = "614012", City = "Пермь", Street = "Фонтанная", House = "7", House2 = "", Flat = "76", Phone = "89123456464" };
                //ChildInfo childinfo11 = new ChildInfo { ChildId = child11.ChildId, Index = "614006", City = "Пермь", Street = "Генкеля", House = "7", House2 = "Б", Flat = "12", Phone = "89123456357" };
                //ChildInfo childinfo12 = new ChildInfo { ChildId = child12.ChildId, Index = "614045", City = "Губаха", Street = "Фонтанная", House = "16", House2 = "В", Flat = "76", Phone = "89123456457" };
                //ChildInfo childinfo13 = new ChildInfo { ChildId = child13.ChildId, Index = "614002", City = "Пермь", Street = "Луначарского", House = "34", House2 = "", Flat = "94", Phone = "89123456354" };
                //ChildInfo childinfo14 = new ChildInfo { ChildId = child14.ChildId, Index = "614009", City = "Пермь", Street = "Стахановская", House = "10", House2 = "", Flat = "23", Phone = "89123456764" };
                //ChildInfo childinfo15 = new ChildInfo { ChildId = child15.ChildId, Index = "614006", City = "Пермь", Street = "Куйбышева", House = "11", House2 = "А", Flat = "11", Phone = "89123456367" };
                //db.ChildsInfo.AddRange(new List<ChildInfo> { childinfo1, childinfo2, childinfo3, childinfo4, childinfo5, childinfo6, childinfo7, childinfo8, childinfo9, childinfo10, childinfo11, childinfo12, childinfo13, childinfo14, childinfo15 });
                //db.SaveChanges();
                //Console.WriteLine("Объекты успешно сохранены");



                //Console.WriteLine("Список объектов:");
                //foreach (Country c in db.Countries)
                //{
                //    Console.WriteLine("Страна {0}", c.Name);
                //    foreach (Region r in c.Regions)
                //    {
                //        Console.WriteLine(" Город: {0}", r.Name);
                //        foreach (Area a in r.Areas)
                //        {
                //            Console.WriteLine("  Район: {0}, Сокращение: {1}", a.Name, a.SName);
                //            foreach (School s in a.Schools)
                //            {
                //                Console.WriteLine("   Школа: {0} - {1} {2} {3} {4} {5} {6} {7}", s.Name, s.Type, s.Index, s.Street, s.House, s.House2, s.Phone, s.Boss);
                //                foreach (Class cl in s.Classes)
                //                {
                //                    Console.WriteLine("    Класс: {0} {1} {2}", cl.Parallel, cl.Litera, cl.Type);
                //                    foreach (Child ch in cl.Childs)
                //                    {
                //                        Console.WriteLine("     Ребенок: {0} {1} {2} Пол: {3} Адрес: {4}, {5} {6} {7}{8}-{9}", ch.LastName, ch.FirstName, ch.SurName, ch.Sex, ch.ChildInfo.Index, ch.ChildInfo.Street, ch.ChildInfo.Street, ch.ChildInfo.House, ch.ChildInfo.House2, ch.ChildInfo.Flat);
                //                    }
                //                }
                //            }
                //        }
                //    }
                //}

                Locality locality1 = new Locality { Name = "Свердловский", ShName = "С" };
                Locality locality2 = new Locality { Name = "Ленинский", ShName = "Л" };
                db.Localities.AddRange(new List<Locality> { locality1, locality2 });
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");
                foreach (Locality l in db.Localities)
                {
                    Console.WriteLine("Район: {0} - {1}", l.Name, l.ShName);
                }

                
            }
            Console.Read();
        }
    }








    
    
    class SchoolContext : DbContext
    {
        public SchoolContext()
            :base("DbConnection"){ }
        
        public DbSet<Locality> Localities { get; set; }
        public DbSet<SchoolType> SchoolsType { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<ClassType> ClassTypes { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Child> Childs { get; set; }
    }

}
