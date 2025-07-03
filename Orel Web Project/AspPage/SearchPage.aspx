<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="Orel_Web_Project.AspPage.SearchPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <center>
            <h1>Search Page Form</h1>
    <%--<form action="register.aspx" runat="server" method="post" class="myform" onsubmit="return  CheckFormAll()" --%>>
    <form action="SearchPage.aspx" runat="server" method="post" class="myform"  >

 

     
           <input type="text" id="player" name="player" placeholder="player username" />

      <br />

      <input type="text" id="appdate" name="appdate" placeholder="Appointment date" />

      <br />


     
       
        
         <input type="submit" id="submit" name="submit" value="Search App"  />

 <br />
 

  </form>
           <%=msg %>
       </center>
</asp:Content>
