%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientePage.aspx.cs" Inherits="CadastroClientes.Web.ClientePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cliente Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewClientes" runat="server" AutoGenerateColumns="False" OnRowCommand="GridViewClientes_RowCommand">
                <Columns>
                    <asp:BoundField DataField="CPF" HeaderText="CPF" SortExpression="CPF" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                    <asp:BoundField DataField="RG" HeaderText="RG" SortExpression="RG" />
                    <asp:BoundField DataField="DataNascimento" HeaderText="Data Nascimento" SortExpression="DataNascimento" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="Sexo" HeaderText="Sexo" SortExpression="Sexo" />
                    <asp:BoundField DataField="EstadoCivil" HeaderText="Estado Civil" SortExpression="EstadoCivil" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
