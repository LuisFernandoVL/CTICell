<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs"
Inherits="_Default" %>
<%@ Import Namespace="CelularCTI73B.Model.Entidades" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title>Celulares Max-Mobile</title>
<link href="estilos.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="frmPrincipal" runat="server">
<table border="1" bordercolor="#3399CC"
cellpadding="0" cellspacing="0"
width="750px">
<tr>
<td colspan="2"><img src="images/cabecalho.jpg" /></td>
</tr>
    <tr>
<td width="25%" valign="top">
<table width="100%" cellpadding="0"
cellspacing="0" class="menu">
<tr>
<th>Menu</th>
</tr>
<tr>
<td><a href="default.aspx">Home</a></td>
</tr>
<tr>
<td class="zebra">
<a href="cadastrar.aspx">Cadastrar</a></td>
</tr>
<tr>
<td><a href="buscar.aspx">Buscar</a></td>
</tr>
</table>
</td>
<td width="75%">
<table class="conteudo">
<tr>
<th>Home</th>
</tr>
<tr>
<td align=center
style="height: 99px">
<!-- CONTEUDO AQUI -->
<table width="70%">
<% foreach(Aparelho a in ap) { %>
<tr>
<td><!--<img src="images/icone.jpg" />--></td>
<td align="left">
<b><%=a.Fabricante.Nome + " " + a.Modelo %></b><br />
R$ <%=a.Preco %><br />
<i><%=a.Quantidade %> em estoque</i><br />
<a href="detalhes.aspx?aparelho=<%=a.Id_Aparelho %>">
Mais detalhes</a></td>
</tr>
<% } %>
</table>


</td>
</tr>
</table>
</td>
</tr>
</table>
</form>
</body>
</html>