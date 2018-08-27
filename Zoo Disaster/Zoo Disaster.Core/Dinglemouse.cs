using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Disaster.Core
{
    /// <summary>
    ///    STORY
    ///    A freak power outage at the zoo has caused all of the electric cage doors to malfunction and swing open...
    ///    All the animals are out and some of them are eating each other!
    ///    
    ///    It's a Zoo Disaster!
    ///    
    ///    Here is a list of zoo animals, and what they can eat
    ///    o   antelope eats grass
    ///    o   big-fish eats little-fish
    ///    o   bug eats leaves
    ///    o   bear eats big-fish
    ///    o   bear eats bug
    ///    o   bear eats chicken
    ///    o   bear eats cow
    ///    o   bear eats leaves
    ///    o   bear eats sheep
    ///    o   chicken eats bug
    ///    o   cow eats grass
    ///    o   fox eats chicken
    ///    o   fox eats sheep
    ///    o   giraffe eats leaves
    ///    o   lion eats antelope
    ///    o   lion eats cow
    ///    o   panda eats leaves
    ///    o   sheep eats grass
    ///    
    ///    Kata Task
    ///    
    ///    INPUT
    ///    A comma-separated string representing all the things at the zoo
    ///    TASK
    ///    Figure out who eats who until no more eating is possible.
    ///    
    ///    OUTPUT
    ///    A list of strings (refer to the example below) where:
    ///    o   The first element is the initial zoo (same as INPUT)
    ///    o   The last element is a comma-separated string of what the zoo looks like when all the eating has finished
    ///    o   All other elements (2nd to last-1) are of the form X eats Y describing what happened
    ///    Notes
    ///    o   Animals can only eat things beside them
    ///    o   Animals always eat to their LEFT before eating to their RIGHT
    ///    o   Always the LEFTMOST animal capable of eating will eat before any others
    ///    o   Any other things you may find at the zoo (which are not listed above) do not eat anything and are not edible

    /// </summary>
    public class Dinglemouse
    {
        public static Dictionary<string, List<string>> WhoEatsWhoRules = new Dictionary<string, List<string>>()
        {
            {"antelope", new List<string>{"grass"}},
            {"big-fish", new List<string>{"little-fish"}},
            {"bug", new List<string>{"leaves"}},
            {"bear", new List<string>{"big-fish", "bug", "chicken", "cow", "leaves", "sheep",}},
            {"chicken", new List<string>{"bug"}},
            {"cow", new List<string>{"grass"}},
            {"fox", new List<string>{"chicken", "sheep"}},
            {"giraffe", new List<string>{"leaves"}},
            {"lion", new List<string>{"antelope", "cow"}},
            {"panda", new List<string>{"leaves"}},
            {"sheep", new List<string>{"grass"}},
            {"grass", new List<string>{} },
            {"little-fish", new List<string>{} },
            {"leaves", new List<string>{} },

        };

        public static string[] WhoEatsWho(string input)
        {
            //check if string is Empty return nothing;) 
            if (input.Length == 0)
            {
                return new string[] { "" };
            }
            //split input
            string[] inputArray = input.Split(',');
            //create list from array
            List<string> whoIsAliveList = inputArray.ToList<string>();
            //Add items which are not included in dictionary
            foreach (var item in whoIsAliveList)
            {
                if (!WhoEatsWhoRules.ContainsKey(item))
                {
                    WhoEatsWhoRules.Add(item, null);
                }
            }
            List<string> outputList = new List<string>();
            outputList.Add(input);
            for (int i = 0; i < whoIsAliveList.Count; i++)
            {
                //check if it isnt last zoo member
                if (i == 0 && whoIsAliveList.Count == 1)
                {
                    continue;
                }
                //check if item have possibility to eat something
                if (WhoEatsWhoRules[whoIsAliveList[i]] == null)
                {
                    continue;
                }
                //menu for first zoo member
                if (i == 0)
                {

                    if (WhoEatsWhoRules[whoIsAliveList[i]].Contains(whoIsAliveList[i + 1]))
                    {
                        outputList.Add($"{whoIsAliveList[i]} eats {whoIsAliveList[i + 1]}");
                        //if somebody eat somebody then eaten is removed from zoo list
                        whoIsAliveList.RemoveAt(i + 1);
                        //i=-1 - after loop is increment by 1 and its zero, so its for return to begin of list
                        i = -1;
                        continue;
                    }
                }
                //menu for last zoo member
                else if (i == whoIsAliveList.Count - 1)
                {
                    if (WhoEatsWhoRules[whoIsAliveList[i]].Contains(whoIsAliveList[i - 1]))
                    {
                        outputList.Add($"{whoIsAliveList[i]} eats {whoIsAliveList[i - 1]}");
                        //if somebody eat somebody then eaten is removed from zoo list
                        whoIsAliveList.RemoveAt(i - 1);
                        i = -1;
                        continue;
                    }
                }
                //menu for zoo members betweent first and lastone
                else
                {
                    if (WhoEatsWhoRules[whoIsAliveList[i]].Contains(whoIsAliveList[i - 1]))
                    {
                        outputList.Add($"{whoIsAliveList[i]} eats {whoIsAliveList[i - 1]}");
                        //if somebody eat somebody then eaten is removed from zoo list
                        whoIsAliveList.RemoveAt(i - 1);
                        i = -1;
                        continue;
                    }
                    else if (WhoEatsWhoRules[whoIsAliveList[i]].Contains(whoIsAliveList[i + 1]))
                    {
                        outputList.Add($"{whoIsAliveList[i]} eats {whoIsAliveList[i + 1]}");
                        //if somebody eat somebody then eaten is removed from zoo list
                        whoIsAliveList.RemoveAt(i + 1);
                        i = -1;
                        continue;
                    }
                }

            }
            outputList.Add(string.Join(",", whoIsAliveList.ToArray()));

            return outputList.ToArray();
        }
    }
}
