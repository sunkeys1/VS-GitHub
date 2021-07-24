using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите имя группы: ");
            using (var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Rammstein",
                    Year = 1994


                };
                var group2 = new Group()
                {
                    Name = "Linkin Park",
                    
                };
                

                context.Groups.Add(group);
                context.Groups.Add(group2);
                context.SaveChanges();

                var songs = new List<Song>()
                {
                    new Song() {Name = "In the end", GroupId = group2.Id },
                    new Song() {Name = "Nubm", GroupId = group2.Id},
                    new Song() {Name = "Muttre", GroupId = group.Id}
                };

                context.Songs.AddRange(songs);
                context.SaveChanges();

                foreach (var song in songs)
                {
                    //Console.WriteLine($"Id {group.Id} Name {group.Name} Year {group.Year}");
                    Console.WriteLine($"Song name {song.Name} Group name {song.Group.Name}");

                }
                Console.ReadLine();
                //Enable-Migrations - включает добавление в базу данных новые штуки
                //
                // Add-Migration Имя - добавление той самой новой штуки (синхронизация)
                // Update-Migration - обновляет эту новую штуку в БД
            }
        }
    }
}
