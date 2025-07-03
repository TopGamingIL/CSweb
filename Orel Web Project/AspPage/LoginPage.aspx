<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Orel_Web_Project.AspPage.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <center>
   <h1>Login Form</h1>
    <form action="LoginPage.aspx" runat="server" method="post" class="myform"  >

 

      <input type="text" id="username" name="username" placeholder="username"  />

     

      <br />

      <input type="text" id="password" name="password" placeholder="password" />

      <br />
        
         <input type="submit" id="submit" name="submit" value="Login"  />

 <br />
 

  </form>
       <%=msg %>
       </center>
</asp:Content>

