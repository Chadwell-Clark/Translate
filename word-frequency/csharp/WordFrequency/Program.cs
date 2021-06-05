﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordFrequency
{
    class Program
    {
        static void Main(string[] args)
        {




            string getText = "Look again at that dot. That's here. That's home. That's us. On it everyone you love, everyone you know, everyone you ever heard of, every human being who ever was, lived out their lives. The aggregate of our joy and suffering, thousands of confident religions, ideologies, and economic doctrines, every hunter and forager, every hero and coward, every creator and destroyer of civilization, every king and peasant, every young couple in love, every mother and father, hopeful child, inventor and explorer, every teacher of morals, every corrupt politician, every \"superstar,\" every \"supreme leader,\" every saint and sinner in the history of our species lived there--on a mote of dust suspended in a sunbeam. The Earth is a very small stage in a vast cosmic arena. Think of the rivers of blood spilled by all those generals and emperors so that, in glory and triumph, they could become the momentary masters of a fraction of a dot. Think of the endless cruelties visited by the inhabitants of one corner of this pixel on the scarcely distinguishable inhabitants of some other corner, how frequent their misunderstandings, how eager they are to kill one another, how fervent their hatreds. Our posturings, our imagined self-importance, the delusion that we have some privileged position in the Universe, are challenged by this point of pale light. Our planet is a lonely speck in the great enveloping cosmic dark. In our obscurity, in all this vastness, there is no hint that help will come from elsewhere to save us from ourselves. The Earth is the only world known so far to harbor life. There is nowhere else, at least in the near future, to which our species could migrate. Visit, yes. Settle, not yet. Like it or not, for the moment the Earth is where we make our stand. It has been said that astronomy is a humbling and character-building experience. There is perhaps no better demonstration of the folly of human conceits than this distant image of our tiny world. To me, it underscores our responsibility to deal more kindly with one another, and to preserve and cherish the pale blue dot, the only home we've ever known. - Carl Sagan";
            Dictionary<string, int> freqCounts = new Dictionary<string, int>();


            //ContainsKey


            // Regex regex = new Regex(@"[^a-zA-Z]g");
            string text = Regex.Replace(getText, "[^A-Za-z]g", "");
            string[] words = text.Split(" ");

            foreach (string word in words)
            {

                if (word.Trim() == "")
                {
                    continue;
                }
                if (freqCounts.ContainsKey(word))
                {
                    freqCounts[word] += 1;
                }
                else
                {
                    freqCounts.Add(word, 1);
                }
            }

            // Console.WriteLine(words);

            foreach (KeyValuePair<string, int> item in freqCounts)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }




        }
    }
}
