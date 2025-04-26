/*
* File Name: LeetCode_Problem_68.cs

* Names: Ethan Wiehe, Ishimwe Vestine, Marc Starks, Pranavi Nallari
* emails: wieheew@mail.uc.edu, vestinie@mail.uc.edu starksmr@mail.uc.edu, nallarpi@mail.uc.edu
* Assignment Number: Final Project
* Due Date: 4/29/25
* Course #/Section: 3050/001
* Semester/Year: Spring/2025
* Brief Description of the assignment:  As a group, create a webpage that displays LeetCode

* Brief Description of what this module does: ASP.NET webform that displays buttons and labels with LeetCode Problems and Solutions
* Citations: (1) https://chatgpt.com/share/6807eee6-d5c4-8005-82c2-1a534286b98a
			 (2) https://chatgpt.com/c/680b94bb-3d64-800e-8a96-7c4e8671e33d
             (3) https://chatgpt.com/c/680b83b9-10a8-800e-94de-8d8a86c7c141
             (4) https://learn.microsoft.com/en-us/dotnet/csharp/methods
             (5) https://docs.devexpress.com/AspNetBootstrap/118670/getting-started/integration-into-an-existing-project
             (6) https://chatgpt.com/share/6807c1cf-06ac-800d-b56d-c2f75d642773
* Anything else that's relevant: LeetCode Problem Links: (1) https://leetcode.com/problems/text-justification/description/
                                                         (2) https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/
                                                         (3) https://leetcode.com/problems/ipo/
                                                         (4) https://leetcode.com/problems/cracking-the-safe/description/
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Monroe_FinalProject
{
    public class LeetCode_Problem_68
    {
        /// <summary>
        /// Limits the number of characters that can be present on each line of text
        /// </summary>
        /// <param name="words">List of words</param>
        /// <param name="maxWidth">Maximum line character count</param>
        /// <returns></returns>
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> result = new List<string>();
            int index = 0;

            while (index < words.Length)
            {
                int totalChars = words[index].Length;
                int last = index + 1;

                // Determine how many words can fit in the current line
                while (last < words.Length)
                {
                    if (totalChars + 1 + words[last].Length > maxWidth) break;
                    totalChars += 1 + words[last].Length;
                    last++;
                }

                int wordCount = last - index;
                int spaceCount = maxWidth - totalChars + (wordCount - 1);
                System.Text.StringBuilder sb = new StringBuilder();

                // If it's the last line or only one word in the line, left-justify
                if (last == words.Length || wordCount == 1)
                {
                    for (int i = index; i < last; i++)
                    {
                        sb.Append(words[i]);
                        if (i < last - 1) sb.Append(" ");
                    }
                    // Fill the remaining space with spaces
                    int remaining = maxWidth - sb.Length;
                    sb.Append(' ', remaining);
                }
                else
                {
                    // Fully justify
                    int spaces = (maxWidth - (totalChars - (wordCount - 1))) / (wordCount - 1);
                    int extra = (maxWidth - (totalChars - (wordCount - 1))) % (wordCount - 1);

                    for (int i = index; i < last; i++)
                    {
                        sb.Append(words[i]);
                        if (i < last - 1)
                        {
                            sb.Append(' ', spaces + (extra-- > 0 ? 1 : 0));
                        }
                    }
                }

                result.Add(sb.ToString());
                index = last;
            }

            return result;
        }
    }
}