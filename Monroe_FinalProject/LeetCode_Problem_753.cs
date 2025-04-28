/*
* File Name: LeetCode_Problem_753.cs

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
             (7) https://chatgpt.com/c/6807bdad-2ec4-800d-bf38-b61b0c265714
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
    public class LeetCode_Problem_753
    {
        /// <summary>
        /// Organizes new string based on correct code
        /// </summary>
        /// <param name="n">Sequence of digits</param>
        /// <param name="k">Top of potential range</param>
        /// <returns></returns>
        public string CrackSafe(int n, int k)
        {
            HashSet<string> visited = new HashSet<string>();
            StringBuilder result = new StringBuilder();

            string start = new string('0', n - 1);
            DFS(start, visited, result, n, k);

            result.Append(start); // append the start to complete the sequence
            return result.ToString();
        }

        /// <summary>
        /// Determines the next number of the sequence
        /// </summary>
        /// <param name="node">Current sequence number</param>
        /// <param name="visited">Temporary sequence</param>
        /// <param name="result">Final sequence</param>
        /// <param name="n">Sequence of digits</param>
        /// <param name="k">Top of potential range</param>
        private void DFS(string node, HashSet<string> visited, StringBuilder result, int n, int k)
        {
            for (int i = 0; i < k; i++)
            {
                string next = node + i;
                if (!visited.Contains(next))
                {
                    visited.Add(next);
                    DFS(next.Substring(1), visited, result, n, k);
                    result.Append(i);
                }
            }
        }
    }
}