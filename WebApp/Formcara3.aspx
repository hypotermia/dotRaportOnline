<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formcara3.aspx.cs" Inherits="WebApp.Formcara3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <table style="width:100%;">
                <tr>
                    <td>nama</td>
                    <td>
                        <asp:TextBox ID="namainput" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="namainput" ErrorMessage="*NamaWajibDiisi" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;hayo</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>umur<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="umurinput" ErrorMessage="*MaafUmurExpaied" MaximumValue="30tahun" MinimumValue="18tahun">(th)</asp:RangeValidator>
                    </td>
                    <td>
                        <asp:TextBox ID="umurinput" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="umurinput" Display="Dynamic" ErrorMessage="*UmurWajibDiisi" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;ciye</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>email</td>
                    <td>
                        <asp:TextBox ID="emailinput" runat="server" Height="22px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailinput" ErrorMessage="*emailWajibDiisi" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="simpan" runat="server" Height="46px" OnClick="Button1_Click" Text="Simpan" Width="122px" />
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
