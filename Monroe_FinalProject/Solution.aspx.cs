/*
* File Name: Solution.aspx.cs

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
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Monroe_FinalProject
{
    public partial class Solution : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdSolution68_Click(object sender, EventArgs e)
        {
            lblProblem.Text = @"LeetCode Problem 68: Given an array of strings words and a width maxWidth, format the text such that each line has exactly maxWidth characters and is fully (left and right) justified.

                              Use a greedy approach to pack as many words as possible into each line.
                              Pad spaces so that each line is exactly maxWidth characters wide.
                              Distribute extra spaces as evenly as possible between words.
                              Left-justify the last line.";

            lblTestCase.Text = "Test Case: string[] words = {'Science', 'is', 'what', 'we', 'understand', 'well', 'enough', 'to', 'explain', 'to', 'a', 'computer.', 'Art', 'is', 'everything', 'else', 'we', 'do'}, int maxWidth = 20}";
                              
                              

            string[] words = {"Science", "is", "what", "we", "understand", "well",
                              "enough", "to", "explain", "to", "a", "computer.",
                               "Art", "is", "everything", "else", "we", "do"};

            int maxWidth = 20;

            var leetCode_Problem_68 = new LeetCode_Problem_68();

            var lines = leetCode_Problem_68.FullJustify(words, maxWidth);

            litSolution.Text = "<pre>" + string.Join("\n", lines) + "</pre>";
        }

        protected void cmdSolution123_Click(object sender, EventArgs e)
        {
            lblProblem.Text = "Leet Code Problem 123: You are given an array prices where prices[i] is the price of a given stock on the ith day. Find the maximum profit you can achieve. You may complete at most two transactions.";

            lblTestCase.Text = "Test Case: int[] prices = {3, 3, 5, 0, 0, 3, 1, 4}";

            int[] prices = { 3, 3, 5, 0, 0, 3, 1, 4 };

            LeetCode_Problem_123 leetCode_Problem_123 = new LeetCode_Problem_123();

            int result = leetCode_Problem_123.MaxProfit(prices);

            lblSolution.Text = "Output: " + result.ToString();
        }

        protected void cmdSolution502_Click(object sender, EventArgs e)
        {
            lblProblem.Text = "LeetCode Problem 502: Suppose LeetCode will start its IPO soon. In order to sell a good price of its shares to Venture Capital, LeetCode would like to work on some projects to increase its capital before the IPO. Since it has limited resources, it can only finish at most k distinct projects before the IPO. Help LeetCode design the best way to maximize its total capital after finishing at most k distinct projects.\r\n\r\nYou are given n projects where the ith project has a pure profit profits[i] and a minimum capital of capital[i] is needed to start it.\r\n\r\nInitially, you have w capital. When you finish a project, you will obtain its pure profit and the profit will be added to your total capital.\r\n\r\nPick a list of at most k distinct projects from given projects to maximize your final capital, and return the final maximized capital.\r\n\r\nThe answer is guaranteed to fit in a 32-bit signed integer.";

            lblTestCase.Text = "Test Case: int k = 2, int w = 0, int[] profits = {1, 2, 3}, int[] capital = {0, 1, 1}";
            
            int k = 2;
            int w = 0;
            int[] profits = { 1, 2, 3 };
            int[] capital = { 0, 1, 1 };

            // Create an instance of the LeetCode_Problem_502 class
            LeetCode_Problem_502 leetCode_Problem_502 = new LeetCode_Problem_502();

            // Call the method and print the result
            int finalCapital = leetCode_Problem_502.FindMaximizedCapital(k, w, profits, capital);

            lblSolution.Text = "Output: " + finalCapital.ToString();
        }

        protected void cmdSolution753_Click(object sender, EventArgs e)
        {
            lblProblem.Text = @"LeetCode Problem 753: There is a safe protected by a password. The password is a sequence of n digits 
                              where each digit can be in the range [0, k - 1]. The safe checks the most recent n digits typed. 
                              Return any string of minimum length that will unlock the safe at some point of entering it.";

            lblTestCase.Text = "Test Case: int n = 2, int k = 2";

            int n = 2;
            int k = 2;

            LeetCode_Problem_753 leetCode_Problem_753 = new LeetCode_Problem_753();

            string code = leetCode_Problem_753.CrackSafe(n, k);

            lblSolution.Text = "Output: " + code;

        }

        protected void cmdClearSolution_Click(object sender, EventArgs e)
        {
            lblProblem.Text = "LeetCode Problem";
            lblTestCase.Text = "Test Case";
            lblSolution.Text = "Solution";
            litSolution.Text = "";
        }
    }
}