﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employeeList.aspx.cs" Inherits="Lab4_WebForm_AgilMetoder.employeeList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Lists</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
    <link href='https://fonts.googleapis.com/css?family=Source+Sans+Pro:400,300,700' rel='stylesheet' type='text/css' />
</head>
<body>
    <form id="form1" runat="server">
        <h1 class="logo">Employee Manager</h1>
        <div id="txtSet">
            <!--Name Field-->
            <asp:Label ID="lblName" runat="server" Text="Full Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <!--Email Field-->
            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <!--Phone Field-->
            <asp:Label ID="lblPhone" runat="server" Text="Phone"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" ></asp:TextBox>
            <asp:Button ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
        </div>
        <!--button sets-->
        <div id="btnDV">
            <!--view and delete employees-->
            <asp:Label ID="lblDisplay" runat="server" Text="Employees List"></asp:Label>
          
            

        </div>
        <div id="Display">
            <asp:ListBox ID="listbox" runat="server" Height="369px" Width="474px" OnSelectedIndexChanged="listbox_SelectedIndexChanged"></asp:ListBox>
            
          
            

        </div>
        <div id="delete">
            <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" Width="112px" />
        </div>
    </form>
</body>
</html>
