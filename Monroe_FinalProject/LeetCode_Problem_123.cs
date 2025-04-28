/*
* File Name: LeetCode_Problem_123.cs

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
using System.Web;

namespace Monroe_FinalProject
{
    public class LeetCode_Problem_123
    {
        /// <summary>
        /// Determines the maximum profit given an array of stocks
        /// </summary>
        /// <param name="prices">List of stock prices</param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int n = prices.Length;
            if (n == 0) return 0;

            int[] left = new int[n];   // Max profit up to day i
            int[] right = new int[n];  // Max profit from day i to end

            // Fill left[]: max profit from 0 to i
            int minPrice = prices[0];
            for (int i = 1; i < n; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                left[i] = Math.Max(left[i - 1], prices[i] - minPrice);
            }

            // Fill right[]: max profit from i to n-1
            int maxPrice = prices[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                maxPrice = Math.Max(maxPrice, prices[i]);
                right[i] = Math.Max(right[i + 1], maxPrice - prices[i]);
            }

            // Combine both transactions
            int maxProfit = 0;
            for (int i = 0; i < n; i++)
            {
                maxProfit = Math.Max(maxProfit, left[i] + right[i]);
            }

            return maxProfit;
        }
    }
}