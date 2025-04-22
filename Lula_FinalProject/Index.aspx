<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Final_Project.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Ethan's Problem 42 Section -->
        <asp:Button ID="btnShowSolution" runat="server" Text="Problem 42" OnClick="btnShowSolution_Click" />
        <br />

        <asp:Label ID="lblDescription" runat="server" Font-Bold="true" Text=""></asp:Label>
        <br />

        <asp:Label ID="lblTestCase1" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblResult1" runat="server" Text=""></asp:Label>
        <br />

        <asp:Label ID="lblTestCase2" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblResult2" runat="server" Text=""></asp:Label>
        </div>
        <div>

        </div>
    </form>
</body>
</html>
