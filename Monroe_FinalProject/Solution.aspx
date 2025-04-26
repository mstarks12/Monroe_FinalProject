<!-- 
* File Name: Solution.aspx

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
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Solution.aspx.cs" Inherits="Monroe_FinalProject.Solution" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Team Monroe Final Project</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</head>
<body>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <form id="form1" runat="server">
        <div>
            <div style="margin-left: auto; margin-right: auto; text-align: center; font-size: 24px;">
                <asp:Label ID="lblHeader" runat="server" Text="IS3050 Final Project Team Monroe"></asp:Label>
                <br />
                <asp:Label ID="lblTeamMembers" runat="server" Text="Team Members: Ethan Wiehe, Ishimwe Vestine, Marc Starks, Pranavi Nallari"></asp:Label>
            </div>

            <br />

            <div style="margin-left: auto; margin-right: auto; text-align: center;">
                <asp:Button ID="cmdSolution68" runat="server" Text="Solution 68" OnClick="cmdSolution68_Click" BackColor="LightBlue" />
                <asp:Button ID="cmdSolution123" runat="server" Text="Solution 123" OnClick="cmdSolution123_Click" BackColor="LightGoldenrodYellow"/>
                <asp:Button ID="cmdSolution502" runat="server" Text="Solution 502" OnClick="cmdSolution502_Click" BackColor="LightCoral" />
                <asp:Button ID="cmdSolution753" runat="server" Text="Solution 753" OnClick="cmdSolution753_Click" BackColor="LightGreen" />
                <asp:Button ID="cmdClearSolution" runat="server" Text="Clear Solution" OnClick="cmdClearSolution_Click" BackColor="LightSalmon" />
            </div>

            <br />
            <br />

            <div style="margin-left: auto; margin-right: auto; text-align: center;">
                <asp:Label ID="lblProblem" runat="server" Text="LeetCode Problem"></asp:Label>

                <br />
                <br />

                <asp:Label ID="lblTestCase" runat="server" Text="Test Case"></asp:Label>

                <br />
                <br />

                <asp:Label ID="lblSolution" runat="server" Text="Solution"></asp:Label>

                <br />
                <br />

                <asp:Literal ID="litSolution" runat="server"></asp:Literal>
            </div>
        </div>
    </form>
</body>
</html>
