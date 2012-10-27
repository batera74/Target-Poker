<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TargetPoker.Client.Default" %>
<%@ Register TagPrefix="rpt" TagName="Eventos" Src="~/controls/Eventos.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(function () {
            $('#loopedCarousel').loopedCarousel({
                showPagination: false, // Shows pagination links
                padding: 5, // Padding between items
                items: 3
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="loopedCarousel">
        <div class="container">
            <div class="slides">
                <div>
                    <a href="#">
                        <img src="images/foto1.png" width="316" height="303"></a> <i><span class="s3">Como<br>
                            <b>Jogar</b></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto2.png" width="316" height="303"></a> <i><span class="s1">Dicas<br>
                            <b>e Estratégias</b></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto3.png" width="316" height="303"></a> <i><span class="s2">O que é<br>
                            <small>Texas Hold'em</small></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto4.png" width="316" height="303"></a> <i><span class="s2">Nossos<br>
                            <small>Jogadores</small></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto5.png" width="316" height="303"></a> <i><span class="s3">Sit n' Go<br>
                            <b>e Torneios</b></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto6.png" width="316" height="303"></a> <i><span class="s1">Nossos<br>
                            <b>Parceiros</b></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto1.png" width="316" height="303"></a> <i><span class="s3">Como<br>
                            <b>Jogar</b></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto2.png" width="316" height="303"></a> <i><span class="s1">Dicas<br>
                            <b>e Estratégias</b></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto3.png" width="316" height="303"></a> <i><span class="s2">O que é<br>
                            <small>Texas Hold'em</small></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto4.png" width="316" height="303"></a> <i><span class="s2">Nossos<br>
                            <small>Jogadores</small></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto5.png" width="316" height="303"></a> <i><span class="s3">Sit n' Go<br>
                            <b>e Torneios</b></span><a href="#">Veja +</a></i>
                </div>
                <div>
                    <a href="#">
                        <img src="images/foto6.png" width="316" height="303"></a> <i><span class="s1">Nossos<br>
                            <b>Parceiros</b></span><a href="#">Veja +</a></i>
                </div>
            </div>
        </div>
        <a href="#" class="previous"></a><a href="#" class="next"></a>
    </div>
    <!-- content -->
    <section id="content">
        <div class="wrapper">
            <div id="indent">
                <article class="col-1">
                    <rpt:Eventos runat="server" ID="rptEventos" />
                </article>
                <article class="col-2">
                    <h2 class="h-indent">Seja bem vindo!</h2>
                    <div class="inner2">
                        <h6>Bem vindo ao nosso site!</h6>
                        <p>Aqui você encontrará o que há de melhor sobre poker na região. Torneios e Sit n' Go's, Dicas e Estratégias, Notícias e muito mais.</p>
                        <p>Você que é um amante do poker, não pode deixar de ficar por dentro do melhor do poker da Baixada Santista. Venha participar com a gente!</p>
                    </div>
                </article>
                <article class="col-3">
                    <h2 class="h-indent2">Ranking</h2>
                    <div class="inner3">
                        <ul class="list-1">
                            <li><span>
                                <img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /></span><strong>Diego Rabelo</strong></li>
                            <li><span>
                                <img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_empty.png" /></span><strong>Lucas Capellini</strong></li>
                            <li><span>
                                <img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_half.png" /><img src="images/star_empty.png" /></span><strong>Ramiro Gameiro</strong></li>
                            <li><span>
                                <img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_half.png" /></span><strong>Carlos Rocha</strong></li>
                            <li><span>
                                <img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /></span><strong>Guilherme Andrade</strong></li>
                            <li class="extra"><span>
                                <img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_full.png" /><img src="images/star_empty.png" /></span><strong>Vicente Araújo</strong></li>
                        </ul>
                        <a href="#" class="link">Todos os jogadores</a>
                    </div>
                </article>
            </div>
        </div>
    </section>
</asp:Content>
