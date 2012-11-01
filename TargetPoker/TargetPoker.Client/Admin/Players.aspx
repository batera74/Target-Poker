<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Players.aspx.cs" Inherits="TargetPoker.Client.Admin.Players" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/players_admin.css" rel="stylesheet" type="text/css" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="h-indent">Cadastro de jogadores!</h2>
    <div id="form-player">
        <div class="row-1">
            <span class="text-form fleft">Nome:</span>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        <div class="row-1">
            <span class="text-form fleft">Sobrenome:</span>
            <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
        </div>
        <div class="row-1">
            <span class="text-form fleft">Data de Nascimento:</span>
            <asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox>
        </div>
        <div class="row-1">
            <span class="text-form fleft">Email:</span>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>
        <div class="row-1">
            <span class="text-form fleft">Target Team:</span>
            <asp:CheckBox ID="chkTargetTeam" runat="server" />
        </div>
    </div>
</asp:Content>
