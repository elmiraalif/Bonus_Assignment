<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weekly_calendar.aspx.cs" Inherits="n01318198_Bonus_ElmiraAlif.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weekly Calendar</title>
</head>
<body>
    <form id="form1" runat="server">
        <%-- Goal: to get the workdays and show the entire month with correct messages!
             Using a checkbox list to get the workdays!
            
            --%>
        <section>
            <asp:CheckBoxList ID="weekdays" runat="server">
	            <asp:ListItem Text="Saturday" Value="saturday"></asp:ListItem>
	            <asp:ListItem Text="Sunday" Value="sunday"></asp:ListItem>
	            <asp:ListItem Text="Monday" Value="monday"></asp:ListItem>
                <asp:ListItem Text="Tuesday" Value="tuesday"></asp:ListItem>
                <asp:ListItem Text="Wednesday" Value="Wednesday"></asp:ListItem>
                <asp:ListItem Text="Thursday" Value="thursday"></asp:ListItem>
                <asp:ListItem Text="Friday" Value="friday"></asp:ListItem>
            </asp:CheckBoxList>
        </section>
        <section runat="server" id="october_calendar"></section>
        <section>
            <input type="submit" value="Submit" />
        </section>
    </form>
</body>
</html>
