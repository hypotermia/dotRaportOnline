<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebApp.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource2">
            <Columns>
                <asp:BoundField DataField="NAMA_ASPEK" HeaderText="NAMA_ASPEK" ReadOnly="True" SortExpression="NAMA_ASPEK" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="Raport_Online.OnlineRaporEntities" EntityTypeName="" GroupBy="NAMA_ASPEK" Select="new (key as NAMA_ASPEK, it as ASPEK)" TableName="ASPEK">
        </asp:LinqDataSource>
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="NAMA_ASPEK" HeaderText="NAMA_ASPEK" SortExpression="NAMA_ASPEK" />
                <asp:BoundField DataField="DIBUAT_OLEH" HeaderText="DIBUAT_OLEH" SortExpression="DIBUAT_OLEH" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineRaporConnectionString %>" SelectCommand="SELECT [NAMA_ASPEK], [DIBUAT_OLEH] FROM [ASPEK]"></asp:SqlDataSource>
    </form>
</body>
</html>
