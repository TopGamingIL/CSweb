<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="Orel_Web_Project.AspPage.Game" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    body {
        background-color: #006400;
        padding: 12px;
        color: white;
        font-family: sans-serif;
    }

    .center {
        text-align: center;
    }

    .card-scroll {
        overflow-x: auto;
        white-space: nowrap;
        margin-bottom: 10px;
    }

    .card-panel img {
        height: 120px;
        margin: 4px;
    }

    .button-row {
        display: flex;
        justify-content: center;
        gap: 10px;
        margin-top: 32px;
    }

    .chip-bet {
        display: flex;
        justify-content: center;
        gap: 20px;
        margin-top: 24px;
    }

    .chip-bet span {
        font-size: 14px;
    }

    .big-button {
        width: 160px;
        height: 60px;
        font-size: 16px;
        margin-top: 32px;
    }
</style>

<!-- Dealer Section -->
<div class="center">
    <h3>Dealer</h3>
</div>

<div class="card-scroll">
    <asp:Panel ID="pnlDealerCards" runat="server" CssClass="card-panel"></asp:Panel>
</div>

<div class="center">
    <asp:Label ID="lblDealerValue" runat="server" Text="0" />
</div>

<!-- Player Section -->
<div class="center" style="margin-top: 24px;">
    <h3>Player</h3>
</div>

<div class="card-scroll">
    <asp:Panel ID="pnlPlayerCards" runat="server" CssClass="card-panel"></asp:Panel>
</div>

<div class="center">
    <asp:Label ID="lblPlayerValue" runat="server" Text="0" />
</div>

<!-- Buttons -->
<div class="button-row">
    <asp:Button ID="btnHit" runat="server" Text="Hit" CssClass="btn" OnClick="BtnHit_Click" />
    <asp:Button ID="btnStand" runat="server" Text="Stand" CssClass="btn" OnClick="BtnStand_Click" />
    <asp:Button ID="btnDouble" runat="server" Text="Double Down" CssClass="btn" OnClick="BtnDouble_Click" />
</div>

<!-- Chips and Bet -->
<div class="chip-bet">
    <span>Chips: <asp:Label ID="lblChips" runat="server" Text="0" /></span>
    <span>Bet: <asp:Label ID="lblBet" runat="server" Text="0" /></span>
</div>

<!-- Play Again -->
<div class="center">
    <asp:Button ID="btnPlayAgain" runat="server" Text="Play Again" CssClass="big-button" Visible="false" OnClick="BtnPlayAgain_Click" />
</div>


</asp:Content>
