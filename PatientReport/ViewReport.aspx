<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewReport.aspx.cs" Inherits="PatientReport.ViewReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
    <<div style="margin-bottom: 286px, auto" >
    
    </div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="Page_Load" style="margin-left: 460px; margin-top: 244px" Height="189px" Width="304px">
        </asp:GridView>
    
    </form>
</body>
</html>
