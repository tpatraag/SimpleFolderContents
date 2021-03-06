﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleFolderContents._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Directory contents</h2>
            <p>
                <asp:Label ID="lblDirContents" Text="Directory Contents List" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlDirectoryContents" runat="server"></asp:DropDownList>
            </p>
            <p>
                <asp:Label ID="lblError" runat="server" Visible="False"></asp:Label>
            </p>
        </div>
    </div>

</asp:Content>
