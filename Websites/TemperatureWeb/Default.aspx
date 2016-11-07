<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2><font-color="red">Temperature Conversion</font-></h2>
    </div>
        <p>
            Please enter a numeric values. All results will be rounded.</p>
        <p>
            <strong>Convert from C to F:</strong></p>
        <p>
            <asp:TextBox ID="c2fText" runat="server"></asp:TextBox>
            <asp:Button ID="c2fButton" runat="server" OnClick="c2fButton_Click" Text="Convert" />
        </p>
        <p>
            Result:
            <asp:Label ID="c2fResult" runat="server" style="font-weight: 700"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <strong>Convert F to C:</strong></p>
        <p>
            <asp:TextBox ID="f2cText" runat="server"></asp:TextBox>
            <asp:Button ID="f2cButton" runat="server" OnClick="f2cButton_Click" Text="Button" />
        </p>
        <p>
            Result:
            <asp:Label ID="f2cResult" runat="server" style="font-weight: 700"></asp:Label>
        </p>
        <p>
            By: Thao Vo - CSE 598</p>
    </form>
</body>
</html>
