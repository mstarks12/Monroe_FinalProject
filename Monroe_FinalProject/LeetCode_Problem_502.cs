/*
* File Name: LeetCode_Problem_502.cs

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
using System.Web;

namespace Monroe_FinalProject
{
    public class LeetCode_Problem_502
    {
        /// <summary>
        /// Determines the maximum capital to be received from an IPO
        /// </summary>
        /// <param name="k">Number of projects</param>
        /// <param name="w">Initial capital</param>
        /// <param name="profits">Profit number</param>
        /// <param name="capital">Capital number</param>
        /// <returns></returns>
        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            int n = profits.Length;
            var projects = new List<(int cap, int profit)>();

            // Pair up capital and profit for sorting and processing
            for (int i = 0; i < n; i++)
            {
                projects.Add((capital[i], profits[i]));
            }

            // Sort projects by required capital ascending
            projects.Sort((a, b) => a.cap.CompareTo(b.cap));

            // Use a list to simulate a max heap of affordable profits
            List<int> available = new List<int>();
            int index = 0;

            for (int i = 0; i < k; i++)
            {
                // Add all projects we can afford with current capital
                while (index < n && projects[index].cap <= w)
                {
                    available.Add(projects[index].profit);
                    index++;
                }

                // If there are no available projects, we break early
                if (available.Count == 0) break;

                // Select the max profit project
                int maxProfit = int.MinValue;
                int maxIndex = -1;

                for (int j = 0; j < available.Count; j++)
                {
                    if (available[j] > maxProfit)
                    {
                        maxProfit = available[j];
                        maxIndex = j;
                    }
                }

                // Remove the selected project from the list and update capital
                available.RemoveAt(maxIndex);
                w += maxProfit;
            }

            return w;
        }
    }
}