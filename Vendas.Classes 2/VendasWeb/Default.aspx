<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VendasWeb.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Cliente</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Código: 
        <br />
        <asp:TextBox runat="server" ID="txtCodigo"/>
        <br />
        Nome:<br />
<asp:TextBox runat="server" ID="txtNome" />
        <br />
        Data de Nascimento:<br />
<asp:TextBox runat="server" ID="txtDataNasc" />
        <br />
        Peso: 
        <br />
        <asp:TextBox runat="server" ID="txtPeso" />
        <br />
        Sexo:
        <asp:RadioButtonList runat="server" ID="rblSexo">
            <asp:ListItem Text="Masculino" Value="M" />
            <asp:ListItem Text="Feminino" Value="F" />
        </asp:RadioButtonList>
        <br />
        <asp:Button Text="Cadastrar" ID="btnCadastrar" runat="server" 
            onclick="btnCadastrar_Click" />
        <br />
        <hr />
        <br />
        <asp:GridView runat="server" ID="gvDados" EmptyDataText="Nenhum dado." 
            CellPadding="4" ForeColor="#333333" GridLines="None" 
            AutoGenerateColumns="False" Width="500px" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="codigo" HeaderText="Código" 
                    DataFormatString="{0:D6}" ItemStyle-HorizontalAlign="Center">
                <ItemStyle Width="60px" />
                </asp:BoundField>
                <asp:BoundField DataField="nome" HeaderText="Nome" ItemStyle-HorizontalAlign="Center">
            <ItemStyle Width="250px" />
            </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
