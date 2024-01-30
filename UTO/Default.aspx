    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UTO._Default" MasterPageFile="~/MPMain.Master" %>
    <asp:Content ID="contentdefaultHead" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
    <asp:Content  ID="contentdefault" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
        <script src="App_Themes/jquery-1.4.4.min.js"></script>

    <style>
        @keyframes slidy {
        0% { left: 0%; }
        8% { left: 0%; }
        10% { left: -100%; }
        18% { left: -100%; }
        20% { left: -200%; }
        28% { left: -200%; }
        30% { left: -300%; }
        38% { left: -300%; }
        40% { left: -400%; }
        48% { left: -400%; }
        50% { left: -500%; }
        58% { left: -500%; }
        60% { left: -600%; }
        68% { left: -600%; }
        70% { left: -700%; }
        78% { left: -700%; }
        80% { left: -800%; }
        88% { left: -800%; }
        90% { left: -900%; }
        98% { left: -900%; }                        
        100% { left: -1000%; }                        
        }

        body { margin: 0; } 
        div#slider { overflow: hidden; }
        div#slider figure img { width: 8.3333%; float: left;}
        div#slider figure { 
          position: relative;
          width: 1200%;
          margin: 0;
          left: 0;
          text-align: left;
          font-size: 0;
          animation: 30s slidy infinite; 
        }
    </style>
    <div class="divwithoutgrid" style="text-align:center" >
    <div class="titulo">Unidad técnica de ozono</div>
    <hr />
    <br />
    </div>
<%--    <object  style="margin-left:auto; margin-right:auto;" id="flash1" data="images/DUTO.swf" height="250" type="application/x-shockwave-flash" width="450">
    <param name="movie" value="images/DUTO.swf" />--%>

<div id="slider">
        <figure>
          <img src="images/01-2014.jpg" alt="">
            <img src="images/02-2014.jpg" alt="">
            <img src="images/03-2014.jpg" alt="">
            <img src="images/04-2014.jpg" alt="">
            <img src="images/05-2014.jpg" alt="">
            <img src="images/06-2014.jpg" alt="">
            <img src="images/07-2014.jpg" alt="">
            <img src="images/08-2014.jpg" alt="">
            <img src="images/09-2014.jpg" alt="">
            <img src="images/10-2014.jpg" alt="">
            <img src="images/11-2014.jpg" alt="">
            <img src="images/12-2014.jpg" alt="">       
                         
        </figure>
    </div>         


    <%--</object>--%>
    
    <br />
    </asp:Content>

