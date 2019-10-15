<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coordinate.aspx.cs" Inherits="n01318198_Bonus_ElmiraAlif.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coordinate</title>
</head>
<body>
    <form id="form1" runat="server">
        <%-- Creating an input for X--%>
        <div>
            <label>Enter a value for X(on x-axis)</label>
            <asp:TextBox runat="server" ID="x_value"></asp:TextBox>
            <asp:CompareValidator runat="server" EnableClientScript="true" ControlToValidate ="x_value" ErrorMessage="Please enter a non-zero Number" ValueToCompare="0" Operator="NotEqual"></asp:CompareValidator>
        </div>
            <%-- Creating an input for Y--%>
        <div>
            <label>Enter a value for Y (on y-axis)</label>
            <asp:TextBox runat="server" ID="y_value"></asp:TextBox>
            <asp:CompareValidator runat="server" EnableClientScript="true" ControlToValidate="y_value" ErrorMessage="Please enter a non-zero Number!" ValueToCompare="0" Operator="NotEqual"></asp:CompareValidator>
        </div>
        <section runat="server" id="quadrant_result">

        </section>
        <section>
            <input type="submit" value="submit" />
        </section>
    </form>
</body>
</html>
