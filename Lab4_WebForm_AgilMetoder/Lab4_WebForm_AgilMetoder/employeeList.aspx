<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employeeList.aspx.cs" Inherits="Lab4_WebForm_AgilMetoder.employeeList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Lists</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
    <link href='https://fonts.googleapis.com/css?family=Source+Sans+Pro:400,300,700' rel='stylesheet' type='text/css' />
    <style type="text/css">
    </style>
</head>
<body>
    <div id="header">
        <h1 class="logo">Employee Manager</h1>
    </div>

    <form runat="server">

    <div id="content">
        
        <div id="txtSet">
            <!--Name Field-->
            <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox> <br />
            <!--Name Field-->
            <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox> <br />
            <!--Email Field-->
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox> <br />
            <!--Phone Field-->
            <asp:Label ID="lblPhone" runat="server" Text="Phone: "></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox> <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
        </div>
        <!--button sets-->
        <div id="btnDV">
            <!--view and delete employees-->
            <asp:Button ID="Button2" runat="server" Text="Delete" />
            <asp:Button ID="Button3" runat="server" Text="View" />
            

        </div>
        <div id="Display">
            <asp:Label ID="lblDisplay" runat="server" Text="Employees List"></asp:Label>
            <asp:ListBox ID="lbDisplay" runat="server" OnSelectedIndexChanged="lbDisplay_SelectedIndexChanged"></asp:ListBox>
        </div>
 
   </div>
        </form>
</body>

</html>
