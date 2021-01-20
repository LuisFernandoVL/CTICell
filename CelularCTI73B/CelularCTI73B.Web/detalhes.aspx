﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detalhes.aspx.cs" Inherits="CelularCTI73B.Web.detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title>Detalhes</title>
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
<table width="90%">
<tr>
<td style="width: 91px; height: 20px">
<strong>Fabricante:</strong></td>
<td style="width: 155px; height: 20px">
<%=aparelho.Fabricante.Nome %></td>
</tr>
<tr>
<td style="width: 91px">
<strong>Modelo:</strong></td>
<td style="width: 155px">
<%=aparelho.Modelo %></td>
</tr>
<tr>
<td style="width: 91px; height: 21px">
<strong>Dimensões:</strong></td>
<td style="width: 155px; height: 21px">
<%=aparelho.Largura + "x" +
aparelho.Altura + "x" +
aparelho.Espessura %>&nbsp;cm</td>
</tr>
<tr>
<td style="width: 91px">
<strong>Peso:</strong></td>
<td style="width: 155px">
<%=aparelho.Peso %>&nbsp;g</td>
</tr>
<tr>
<td style="width: 91px">
<strong>Quantidade:</strong></td>
<td style="width: 155px">
<%=aparelho.Quantidade %>&nbsp;em estoque</td>
</tr>
<tr>
<td style="width: 91px">
<strong>Preço (R$):</strong></td>
<td style="width: 155px">
<%=aparelho.Preco %></td>
</tr>
<tr>
<td style="width: 91px">
<strong>Desconto:</strong></td>
<td style="width: 155px">
<%=aparelho.Desconto %>&nbsp;à vista</td>
</tr>
<tr>
<td style="width: 91px">
</td>
<td style="width: 155px">
<asp:Button ID="btnComprar" runat="server"
Text="Comprar" /></td>
</tr>
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

