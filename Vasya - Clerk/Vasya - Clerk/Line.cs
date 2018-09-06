namespace Vasya___Clerk
{
    /// <summary>
    /// The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. Each of them has a single 100, 50 or 25 dollars bill. An "Avengers" ticket costs 25 dollars.
    /// Vasya is currently working as a clerk.He wants to sell a ticket to every single person in this line.
    /// Can Vasya sell a ticket to each person and give the change if he initially has no money and sells the tickets strictly in the order people follow in the line?
    /// Return YES, if Vasya can sell a ticket to each person and give the change with the bills he has at hand at that moment. Otherwise return NO.
    /// </summary>
    public class Line
    {
        public string Tickets(int[] peopleInLine)
        {
            int bill25 = 0;
            int bill50 = 0;
            int bill100 = 0;
            string result = "NO";
            for (int i = 0; i < peopleInLine.Length; i++)//if 25 then add to wallet
            {
                if (peopleInLine[i] == 25)
                {
                    bill25++;
                    if (i == peopleInLine.Length - 1) return result = "YES";//if this is last client return YES
                }
                //else if (peopleInLine[i] == 50 && ((peopleInLine[i] - 25) / 25) <= bill25)//possible simplify? \/
                else if (peopleInLine[i] == 50 && bill25 >= 1) //client pay with 50, check if you have at least one 25bill in your wallet
                {
                    bill50++;
                    bill25--;
                    if (i == peopleInLine.Length - 1) return result = "YES";//if this is last client return YES
                }
                else if (peopleInLine[i] == 100 && (bill25 >= 3 || bill50 >= 1 && bill25 >= 1))
                {
                    if (bill50 >= 1 && bill25 >= 0)
                    {
                        bill50--;
                        bill25--;
                        bill100++;
                    }
                    else if (bill25 >= 3)
                    {
                        bill25 -= 3 * bill25;
                        bill100++;
                    }
                    bill50++;
                    bill25--;
                    if (i == peopleInLine.Length - 1) return result = "YES";//if this is last client return YES
                }
            }
            return result;
        }
    }
}
