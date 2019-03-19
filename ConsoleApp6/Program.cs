using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yahtzee!!");
            int[] firstRoll = RollDice(5);

            int[] savefirstRollDice = DisplayAndSave(firstRoll);

            Console.WriteLine("End of first roll. Start next roll.");

            int[] secondRoll = RollDice(5 - savefirstRollDice.Length);

            int[] savesecondRollDice = DisplayAndSave(secondRoll);

            int[] thridRoll = RollDice(5 - savefirstRollDice.Length - savesecondRollDice.Length);

            int[] savethridRollDice = DisplayAndSave(thridRoll);

            int finalScore = Score(savefirstRollDice, savesecondRollDice, savethridRollDice);


          



            Console.ReadLine();



            //Console.WriteLine("The score for player: {0}", playerscore);
            //Console.WriteLine ("The score for computer is: {0}", compturescore)
            Console.ReadLine();

        }
        public static int[] RollDice(int numberOfdice)
        {
            
                int[] numbers = new int[numberOfdice];
                Random random = new Random();
                for (int j = 0; j < numberOfdice; j++)
                    {
                        numbers[j] = random.Next(1,7);                       
                    }
            return numbers;     
 
        }

        public static int[] DisplayAndSave (int[] dice )
        {
            int[] saveDice = new int[dice.Length];
            int saveCount = 0;
            for (int i = 0; i < saveDice.Length; i++)
            {
                Console.Write(dice[i]+ " ");
            }

            for (int i = 0; i < saveDice.Length; i++)
            {
                Console.WriteLine(dice[i]);
                Console.WriteLine("Do you wish to keep dice?");
                string selection = Console.ReadLine();
                if (selection == "Yes")
                {
                    saveDice[saveCount] = dice[i];
                    saveCount++;
                }               
            }
            int[] returnDice = new int[saveCount];
            if (saveCount > 0)
            {
                for (int i = 0; i < saveCount; i++)
                {
                    returnDice[i] = saveDice[i];
                }
            }
                return returnDice;
        }
        public static int Score (int[]savedDiceone, int[]savedDicetwo, int[]savedDicethree)
        {
            int[] Scores = new int[6];
            for (int i = 0; i < savedDiceone.Length; i++)
            {
                Scores[savedDiceone[i]]++;
            }
            for (int i = 0; i < savedDicetwo.Length; i++)
            {
                Scores[savedDicetwo[i]]++;
            }
            for (int i = 0; i < savedDicethree.Length; i++)

            {
                Scores[savedDicethree[i]]++;
            }
            int finalScore = 0; 
            for (int i = 0; i < Scores.Length; i++)
            {
                if (Scores[i] > finalScore)
                {
                    finalScore = Scores[i];                    
                }   
                  
            }
            return finalScore;

   }

    }
}

/*This assignment is your first major program, you will be working on this over the next few weeks.
Our version of Yahtzee is going to be a simpler than the official game.  In our game, you will roll 5 dice and ask the user which rolls they want to keep.  You will then roll the other dice and ask the user which dice they want to keep again.  You will then roll the remaining dice one last time.  Add up the number of the dice that was rolled the most.
For example, if a user ends up with a 6, 4, 3, 3, 3 the score would be 3.  If the user rolls 5, 5, 4, 3, 3 the score would be 2.
Next the computer rolls 3 times.  Each time record the number of die that was rolled the most.  Only keep the highest score.  For example, the computer rolls 6,5,4,4,2 on the first roll, 1,1,1,3,5 on the second roll and 6, 6, 5, 4, 3 on the third roll.  The computer score is 3 because the second roll had 3 matching dice.
Print the winner with the tie going to the player.

    -5 dice/ 6 sides(1-6) with 3 rolls 
    -Two players-user and compturer

     First player rolls the dice with 5 dice
    -Decide which dice to keep
    -Dice that user does not keep gets rolled again
    -User again decides which dice to keep
    -Dice that user does not keep gets rolled again
    -Final score is based on the kept dice.
    Compture:
    -Comptur get three turns at rolling dice
    -Evaluate each of the rolls to see what the high score for each of the three rolls

    Compare the two to detrime who wins or if its a tie. 

 */

