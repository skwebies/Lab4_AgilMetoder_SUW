<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employeeList.aspx.cs" Inherits="Lab4_WebForm_AgilMetoder.employeeList" %>

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
            <div class="textAlign">
            <asp:Label ID="lblName" runat="server" Text="Full Name: "></asp:Label>
            <asp:TextBox ID="txtName" runat="server" Text=""></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="*Required" ForeColor="#cc3300" ControlToValidate="txtName" Display="Dynamic" ></asp:RequiredFieldValidator>

            <asp:RegularExpressionValidator ID="revName" runat="server" ErrorMessage="Please enter valid full name" ForeColor="#cc3300" ControlToValidate="txtName" ValidationExpression="^[a-zA-Z][a-zA-Z\s]+$" Display="Dynamic" ></asp:RegularExpressionValidator>
            <asp:CompareValidator ID="cvName" runat="server" ControlToValidate="txtName" ErrorMessage="Valid only text!" ForeColor="#cc3300" Operator="DataTypeCheck" Type="String" ValidationGroup="Name"></asp:CompareValidator>
            </div>
            <!--Email Field-->
            <div class="textAlign">
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="*Required" ForeColor="#cc3300" ControlToValidate="txtEmail" Display="Dynamic" ></asp:RequiredFieldValidator>

            <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="*Enter valid Email Id" ForeColor="#cc3300" ControlToValidate="txtEmail"  Display="Dynamic" ValidationExpression = "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"></asp:RegularExpressionValidator>
            </div>
            <!--Phone Field-->
            <div class="textAlign">
            <asp:Label ID="lblPhone" runat="server" Text="Phone: "></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ErrorMessage="*Required" ForeColor="#cc3300" ControlToValidate="txtPhone" Display="Dynamic"></asp:RequiredFieldValidator>

            <asp:RegularExpressionValidator ID="revPhone" runat="server" ErrorMessage="*Enter a valid phone number" ForeColor="#cc3300"  ControlToValidate="txtPhone" ValidationExpression="^([+]46)\s*(7[0236])\s*(\d{4})\s*(\d{3})$" Display="Dynamic"></asp:RegularExpressionValidator>
            <br />
            </div>
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" Width="90" Height="50" />
            <asp:Button ID="btnShow" runat="server" Text="Show"  Width="90" Height="50" OnClick="btnShow_Click" CausesValidation="false" />
        </div>

        <!--view and delete employees-->
             <div id="btnDV">
                        <asp:Button ID="btnDelete" runat="server"  Text="Delete" OnClick="btnDelete_Click" CausesValidation="false"  />
                        <asp:Button ID="btnView" runat="server" Text="Select All" OnClick="btnView_Click" CausesValidation="false"  />
              </div>
            <div id="Display">
                <asp:Label ID="lblDisplay" runat="server" Text="Employees List"></asp:Label><br />
                <hr/>
                <!--<asp:ListBox ID="lbDisplay" runat="server" Width="900"></asp:ListBox>-->
                 <table>
                     <thead>
                                <tr>
                                    <td><h3>
                                        <asp:LinkButton ID="lbtnFullName" runat="server" OnClick="lbtnFullName_Click" CausesValidation="false">Full Name</asp:LinkButton></h3></td>
                                    <td><h3>Email</h3></td>
                                    <td><h3>Phone</h3></td>
                                </tr>

                            </thead>
                
                <asp:Repeater ID="rptEmployees" runat="server">
                    <ItemTemplate>                         
                            <tbody>
                                <tr id="dataSet" >
                                    <td>
                                        <asp:Label ID="lblName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "AddName") %>'></asp:Label></td>
                                    <td>
                                        <asp:Label ID="lblEmail" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "AddEmail") %>'></asp:Label></td>
                                    <td id="tdPhone">
                                        <asp:Label ID="lblPhone" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "AddPhone") %>'></asp:Label></td>
                                    <td>
                                       <!-- <asp:LinkButton ID="lbtnEdit"  runat="server" CausesValidation="false" OnClick="lbtnEdit_Click" >Edit</asp:LinkButton></td>-->
                                    <td id="hiddenID"><asp:CheckBox ID="chkMark" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "AddEmail") %>'/></td>
                                </tr>

                            </tbody>
                        
                    </ItemTemplate>
                </asp:Repeater>



                     </table>
            </div>
      
                       
    </form>
                       
</body>
</html>
