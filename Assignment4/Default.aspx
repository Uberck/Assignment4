<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment4.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title></title>
      <style type="text/css">
         #form1 {
         width: 420px;
         }
      </style>
   </head>
   <body>
      <form id="form1" runat="server">
         <div>
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Text="Web Calculator using Methods"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Enter 1st value:   "></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtNumerator" runat="server"></asp:TextBox>
            <br />
            <br />
         </div>
         <asp:Label ID="Label2" runat="server" Text="Enter 2nd value:  "></asp:Label>
         &nbsp;
         <asp:TextBox ID="txtDenominator" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="Label3" runat="server" Text="Select an operation using one of the buttons below."></asp:Label>
         <p>
            <asp:Label ID="lblResult" runat="server" Text="Result:"></asp:Label>
         </p>
         <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
         <p>
            &nbsp;
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="+" Width="50px" />
            &nbsp;&nbsp; &nbsp;
            <asp:Button ID="btnSubtract" runat="server" OnClick="btnSubtract_Click" Text="-" Width="50px" />
            &nbsp;
            &nbsp;&nbsp;
            <asp:Button ID="btnMultiply" runat="server" OnClick="btnMultiply_Click" Text="*" Width="50px" />
            &nbsp;&nbsp; &nbsp;
            <asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" Text="÷" Width="50px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
         </p>
      </form>
   </body>
</html>