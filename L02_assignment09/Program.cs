/*Hannu Oksman
Tee tekstipohjainen Hirsipuu-peli. Voit kovakoodata arvattavan sanan ja toteuta looppi, jossa käyttäjältä kysytään seuraavaa kirjainta. Muista
näyttää aina kirjaimen jälkeen oikein arvatut kirjaimet sanan oikealla kohdalla(käytä esim _-alaviivaa ei arvattujen kirjainten kohdalla). 
Voit näyttää myös jo arvatut ei käytetyt -kirjaimet.Päätä itse milloin pelaaja joutuu hirteen.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_assignment09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Word Guess Game\nYou will be hanged after ten guesses.");
            int maxGuesses = 10;
            char[] charWord = { 'G', 'u', 'e', 's', 's'};
            int charLenght = 0;
            foreach (char c in charWord)
            {
                charLenght++;
            }
            int guessCount = 0;
            char[] charReveal = new char[charLenght];
            for (int i = 0; i < charLenght; i++)
            {
                charReveal[i] = '_';
            }
            string guessedLetters = null;
            while(guessCount < maxGuesses)
            {
                Console.Write("Guess a letter: ");
                string answerLetter = Console.ReadLine();
                char guess = System.Convert.ToChar(answerLetter);
                for (int i = 0; i < charLenght; i++)
                {
                    if (charWord[i] == guess)
                    {
                        charReveal[i] = guess;
                    }
                    Console.Write(charReveal[i]);
                }
                guessedLetters = guessedLetters + answerLetter;
                Console.WriteLine();
                int revealCount = 0;
                for (int i = 0; i < charLenght; i++)
                {
                    if (charReveal[i] != '_')
                    {
                        revealCount++;
                    }
                }
                if (revealCount == charLenght)
                {
                    Console.WriteLine("Congratulations! You guessed the word!");
                    break;
                }
                Console.Write("Already guessed letters: " + guessedLetters);
                Console.WriteLine();
                guessCount++;
                if (guessCount == maxGuesses)
                {
                    Console.WriteLine("You failed to guess the word!");
                }
            }
        }
    }
}
