<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Eventos.ascx.cs" Inherits="TargetPoker.Client.controls.Eventos" %>

<h2>Eventos</h2>
<div class="inner">
    <asp:Repeater ID="rptEventos" runat="server">
        <ItemTemplate>
            <span class="button"><%# Eval("Data") %></span>
            <p><%# Eval("Descricao") %></p>
            <div class="line-small"></div>
        </ItemTemplate>
    </asp:Repeater>
</div>
<h6>
    <asp:Label ID="lblEmBreve" runat="server" Text="Em breve." Visible="false"></asp:Label></h6>

<!--<a href="#" class="link">Leia +</a>-->
