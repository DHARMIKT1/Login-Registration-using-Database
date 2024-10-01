<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Login___Registration_using_Database.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h2>Register Here</h2>
                <asp:TextBox ID="txtUserName" placeholder="Enter User Name" runat="server"></asp:TextBox>
                <br /><br />

                <asp:TextBox ID="txtName" placeholder="Enter Your Name" runat="server"></asp:TextBox>
                <br /><br />

                <asp:TextBox ID="txtEmail" placeholder="Enter Your Email" runat="server"></asp:TextBox>
                <br /><br />

                <asp:TextBox ID="txtPhoneNumber" placeholder="Enter Your Phone Number" runat="server"></asp:TextBox>
                <br /><br />

                <asp:TextBox ID="txtPassword" placeholder="Enter Password" runat="server" TextMode="Password"></asp:TextBox>
                <br /><br />

                <asp:TextBox ID="txtConfirmPassword" placeholder="Confirm Password" runat="server" TextMode="Password"></asp:TextBox>
                <br /><br />

                <asp:Button ID="btnRegistration" runat="server" Text="Register" OnClick="btnRegistration_Click" />
                <br /><br />

                <asp:Label ID="Label1" runat="server" Text="Already registered?"></asp:Label>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Login</asp:LinkButton>

                <br /><br />
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>
