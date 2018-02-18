///<summary>
///Toteuta pienimuotoinen MyMailBook-ohjelma, jolla voit hakea ja tallentaa tuttujesi sähköposti (yksinkertaisuuden vuoksi oletetaan tässä että kullakin tutulla on vain yksi sähköpostiosoite).
///Luo luokka Friend, jolla on ominaisuudet Name ja Email. 
///Tee kokoelmaluokka MailBook, joka alustettaessa hakee tekstitiedostosta tutut.csv ja heidän sp-osoitteensa ja tallentaa ne Friend-olioihin. 
///Kokoelmaluokalla MailBook on readonly ominaisuus on Friends, joka palauttaa listan Friend-olioita. Toteuta pääohjelmaan ja/tai em. MailBook-luokkaan seuraavat toiminnot:
///- ohjelman käynnistyessä lukee tiedostosta tutut ja näyttää montako nimeä sai luettua
///- näyttää kaikki ystävät näytöllä
///- haku, jolle annetaan ystävän nimi tai sen alkuosa.Haku hakee lambda-funktiolla kaikki ystävät, joitten nimestä löytyy etsitty merkkijono.Huomaa että haku saattaa tuottaa yhden tai useamman tuloksen.
///- uuden ystävän lisääminen, ystävän tiedot täytyy myös tallentaa em.tekstitiedostoon, huom: toteuta sopiva poikkeusten käsittely
///</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_assignment_02
{
    class L11_02_Main
    {
        static void Main(string[] args)
        {
            //new mailbook
            MailBook mailBook = new MailBook();

            //reading mailbook
            Console.WriteLine("Mailbook contains {0} names:", mailBook.Friends.Count());
            foreach (Friend f in mailBook.Friends)
            {
                Console.WriteLine("Name: {0}", f.Name);
            }

            //looping menu
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\n1=Find a friend\n2=Add a friend\n0=Quit");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                    case "1":
                        mailBook.FindFriend();
                        break;
                    case "2":
                        mailBook.AddFriend();
                        break;
                    case "0":
                        quit = true;
                        break;
                }
            }
        }
    }
}
