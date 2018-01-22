using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_assignment07
{
    class L03_assignment07
    {
        static void Main(string[] args)
        {
            //create new cd and add info
            ClassCD nightwish = new ClassCD();
            nightwish.Artist = "Nightwish";
            nightwish.Name = "Endless Forms Most Beautiful";
            nightwish.Genre = "Symphonic metal";
            nightwish.Price = 19.9;

            //used to print song info
            int numberOfSongs = 0;

            //creat enew song and add song info
            ClassSongs shudder = new ClassSongs();
            shudder.Name = "Shudder Before the Beautiful";
            shudder.DurationMethod(6, 29);
            nightwish.SongList[numberOfSongs] = shudder;
            numberOfSongs++;
            
            //creat enew song and add song info
            ClassSongs weak = new ClassSongs();
            weak.Name = "Weak Fantasy";
            weak.DurationMethod(5, 29);
            nightwish.SongList[numberOfSongs] = weak;
            numberOfSongs++;

            //creat enew song and add song info
            ClassSongs elan = new ClassSongs();
            elan.Name = "Elan";
            elan.DurationMethod(4, 45);
            nightwish.SongList[numberOfSongs] = elan;
            numberOfSongs++;

            //creat enew song and add song info
            ClassSongs yours = new ClassSongs();
            yours.Name = "Yours Is an Empty Hope";
            yours.DurationMethod(5, 23);
            nightwish.SongList[numberOfSongs] = yours;
            numberOfSongs++;
            
            //print infos
            printCdInfo(nightwish);
            for (int i = 0; i < numberOfSongs; i++)
            {
                printSongInfo(nightwish.SongList[i]);
            }           
            Console.WriteLine();
        }

        //prints cd info
        static void printCdInfo(ClassCD nightwish)
        {
            Console.WriteLine("CD");
            Console.WriteLine("-Artist: " + nightwish.Artist);
            Console.WriteLine("-Name: " + nightwish.Name);
            Console.WriteLine("-Genre: " + nightwish.Genre);
            Console.WriteLine("-Price: " + nightwish.Price + "$");
        }

        //prints song info
        static void printSongInfo(ClassSongs song)
        {
            Console.WriteLine("--- Name: " + song.Name + " - " + song.Duration.Minute + ":" + song.Duration.Second);
        }
    }
}