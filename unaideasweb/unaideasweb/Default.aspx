<%@ Page Title="UNAIDEAS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="unaideasweb._Default"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <head>
        <link href="Content/master/estilo.css" rel="stylesheet" media="screen">
        <link rel="stylesheet" type="text/css" href="Content/bootstrap.min.css">
        </asp:ContentPlaceHolder>
    </head>
      <img src="img/barra-superior-home.png" id="barra-superior">

        <img src="img/una-ideas-logo.png" id="logo-una-ideas">

        <nav id="menu">
            <ul>
                <li><a href="index.html">Início</a></li>
                <li><a href="cadastro_user.html">Cadastrar</a></li>
                <li>Sobre</li>
                <li style="height: 30px; top:100px;"><span style="font-size:20pt; vertical-align:top">Fale conosco</span></li>
            </ul>
        </nav>
        <table id="tabela">
            <tr>
                <td>
                    <a href="login.html">
                        <div onmouseover="mostraDescricao('descricao-idealizador', 'descricao-professor', 'descricao-investidor')" onmouseout="esconde('descricao-idealizador')" id="quadro1" class="quadros">
                            <p>Idealizador</p>
                            <img id="icone-aluno" src="img/icone-aluno.png">
                            <p id="descricao-idealizador" class="descricao" style="display:none">Você é um aluno? Tem um projeto em mente? Escolha essa opção para cadastrar a sua ideia no nosso sistema!</p>			
                        </div>
                    </a>
                </td>

                <td>
                    <a href="login.html">
                        <div onmouseover="mostraDescricao('descricao-professor', 'descricao-investidor', 'descricao-idealizador')" onmouseout="esconde('descricao-professor')" id="quadro2" class="quadros">
                            <p>Professor</p>
                            <img id="icone-professor" src="img/icone-professor.png">
                            <p id="descricao-professor" class="descricao" style="display:none">Você é professor? Escolha essa opção para ter acesso ao andamento dos projetos e demais funcionalidades.</p>
                        </div>
                    </a>
                </td>

                <td>
                    <a href="login.html">
                        <div onmouseover="mostraDescricao('descricao-investidor', 'descricao-idealizador', 'descricao-professor')" onmouseout="esconde('descricao-investidor')" id="quadro3" class="quadros">
                            <p>Investidor</p>
                            <img id="icone-investidor" src="img/icone-investidor.png">
                            <p id="descricao-investidor" class="descricao" style="display:none">É um investidor? Que tal dar uma olhada nos promissores projetos que a instituição tem preparado?</p>
                        </div>
                    </a>
                </td>
            </tr>
        </table>


        <script src="Scripts/jquery-2.1.3.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>

        <script>
                            function mostraDescricao(exibe, esconde, esconde2) {
                                document.getElementById(exibe).style.display = "block";
                                document.getElementById(esconde).style.display = "none";
                                document.getElementById(esconde2).style.display = "none";
                            }

                            function esconde(esconder) {
                                document.getElementById(esconder).style.display = "none";
                            }
        </script>
    <!--<div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>-->

</asp:Content>
