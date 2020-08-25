using System;


namespace TravelersJourney
{
    
    public class Berserker
    {
        
    }    

    class ConsoleJourney
    {
        static void Main()
        {
            // pr =  player response


            //  Open of game. Change Font Color to Blue
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to my game. Please use all lower case letters in every answer...");
            Console.WriteLine("What is your name, traveler?");

            //  Get Player Name and Welcome to the Game.
            string playerName = Console.ReadLine();
            Console.WriteLine("Hello, " + playerName + "! \nLets start your journey. \n \n \nPress any key to continue.");
            Console.ReadLine();
            Console.Clear();

            //  start the Intro Narrative.
            Console.Write("You awaken. \nIts dark and the air feels cool. You are outside. Where, you do not know.\n" +
                "Your back aches. You realize you are lying on the ground. \nYou slowly lift yourself up on your feet." +
                "You carry a satchel, but it is empty except for a few coins stuck to the bottom. Its quiet out here.\n" +
                "Too quiet. \n \nYou start walking down the path.");


            //  Continue to Next Page and Clear Screen.
            Console.WriteLine("Press Enter Continue.....");
            Console.ReadLine();
            Console.Clear();

            //  Narrative Continues. Begin the first player choice.
            Console.Write("In the sky, you notice Luna is full tonight, but the tall trees that outline the path ahead\n " +
                          "block the full weight of the light she shines from above. \n \n'How did I get here,' you ask yourself." +
                          "\n \nYou take a deep breath and slow your thoughts. You need to find shelter. You need to find some\n" +
                          "someplace to figure out what happened to you. Standing in the road, in the cold, alone is not the place\n" +
                          "do it. \n \n'All roads lead somewhere,' you mutter, 'should be " +
                          "a village somewhere near. \n \nYou start walking down the road.\n\n");

            //  Continue to Next Page and Clear Screen.
            Console.WriteLine("Continue.....");
            Console.ReadLine();
            Console.Clear();

            //  Player's first choice in the game. Which path to take.
            Console.Write("");




            // reset color change.  >> Console.ResetColor

            //string travelerName()
            //{
            //    Console.WriteLine("Welcome to my game. Please use all lower case letters in every answer...");
            //    Console.WriteLine("What is your name, traveler?");
            //    string playerName = Console.ReadLine();
            //    return playerName as string;
            //}






            //public class OldWomanEncounter (OldWomanEncounter) = new OldWomanEncounter;



            //string pr2 = "";
            //string pr3 = "";
            //string playerName = "";
            //string playerResponse = "";
            //string firstPath = "";



            //Console.WriteLine("Welcome to my game. Please use all lower case letters in every answer...");
            //Console.WriteLine("What is your name, traveler?");
            //playerName = Console.ReadLine();



            //Console.WriteLine("Hello, " + playerName);
            //Console.WriteLine("Would you like to play a game with me ? ");
            //playerResponse = Console.ReadLine();



            //if (playerResponse == "yes")
            //{
            //    Console.WriteLine("Awesome!");
            //    Console.WriteLine("Now lets begin, you start at the fork in the road with two paths. Do you go right or left?");
            //    pr2 = Console.ReadLine();


            //        if (pr2 == "right")
            //        {
            //            Console.WriteLine("While walking down the right path, you encounter a Old Woman standing on the side of the road. \n");
            //            Console.WriteLine("Do you want to stop and talk to her? \n");

            //            pr3 = Console.ReadLine();


            //            if (pr3 == "yes")
            //            {
            //                Console.Clear();
            //                Console.WriteLine("\n \n Old Woman: Ah I've been waiting for you. \r\n \n Me? You Reply. \r\n \n" +
            //                   "Old Woman: Yes Im here to warn you about a group of bandits on the road up ahead.\r\n \n" +
            //                   "Old Woman: I would suggest taking this path behind me that goes through the forest. " + playerName + ". \n" +
            //                   "You and the Old Woman part ways, and you head down the path behind her. \n" +
            //                   "Thoughts of where this path leads enter your mind, and you become lost in those thoughts. \n \n" +
            //                   "You continue down the road.... \n");



            //            }
            //            else if (pr3 == "no")
            //            {
            //                Console.Clear();
            //                Console.WriteLine("As you walk by her, you feel her gaze come to rest on you, so you hurry past her. \n" +
            //                    "You shudder at the thought of the paleness in the Old Woman's face. \n " +
            //                    "You feel like you made the right decision to pass her by.");



            //            }

            //            return firstPath = "woman" + pr3;

            //        }
            //        else if (pr2 == "left")
            //        {
            //            Console.WriteLine("You walk down the left path for a while and come across a Berserker \r\n" +
            //            "who wants to join you on your journey. \r\n \n" +
            //            "Do you say yes to him or tell him no and continue on the path? \n");

            //            pr3 = Console.ReadLine();
            //            Console.Clear();

            //            if (pr3 == "yes")
            //            {
            //                Console.WriteLine("Berserker: Hah, I'm glad you said yes, now lets get to that town up head. " + playerName);


            //            }
            //            else if (pr3 == "no")
            //            {
            //                Console.WriteLine("Hahaha, well since I can't join I guess my only option is to kill you. \n \n" +
            //                    "Are you ready for a fight?");


            //            }

            //            return "berserker" + pr3;
            //        }


            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Ah well, that sucks," + playerName + ". Maybe next time");
            //            Console.WriteLine("Press enter to close.....");
            //            Console.ReadLine();

            //            return "quit";
            //        }

            //    }
            //}
            //else if (playerResponse == "no")
            //{
            //    Console.WriteLine("Ah well, that sucks....");
            //    Console.WriteLine("Press enter to close.....   you quiter.");
            //    Console.ReadLine();

            //}


            //if (firstPath == "womanYES")

            //{
            //    Console.WriteLine("FINALLY GOT IT");
            //}

        }
    }
}
