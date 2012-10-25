<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Eventos.ascx.cs" Inherits="TargetPoker.Client.controls.Eventos" %>
<script type="text/javascript">
    $(function () {
        $('#loopedCarousel2').loopedCarousel({            
            vertical: true,
            container: '.container2',
            slides: '.slides2',
            pagination: '.pagination',
            autoStart: 5000, // Set to positive number for auto interval and interval time
            slidespeed: 300, // Speed of slide animation
            fadespeed: 300, // Speed of fade animation		
            padding: 5, // Padding between items
            showPagination: false, // Shows pagination links	
            items: 2
        });
    });
</script>
<h2>Eventos</h2>
<div class="inner">
    <div id="loopedCarousel2">
        <div class="container2">
            <div class="slides2">
                <asp:Repeater ID="rptEventos" runat="server">
                    <ItemTemplate>
                        <div>
                            <span class="button"><%# Eval("Data") %></span>
                            <p><%# Eval("Descricao") %></p>
                            <div class="line-small"></div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</div>
<h6>
    <asp:Label ID="lblEmBreve" runat="server" Text="Em breve." Visible="false"></asp:Label></h6>

<!--<a href="#" class="link">Leia +</a>-->
