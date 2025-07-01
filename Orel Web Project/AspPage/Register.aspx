<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Orel_Web_Project.AspPage.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <center>
        <h1>Register Form</h1>
    <%--<form action="register.aspx" runat="server" method="post" class="myform" onsubmit="return  CheckFormAll()" --%>>
    <form action="register.aspx" runat="server" method="post" class="myform"  >

 

      <input type="text" id="fname" name="fname" placeholder="first name"  />

      <br />
           <input type="text" id="barber" name="barber" placeholder="1-barber 2-client" />

      <br />

      <input type="text" id="password" name="password" placeholder="password" />

      <br />


     
        <input type="text" id="phone" name="phone" placeholder="phone number" />

<br />
        
         <input type="submit" id="submit" name="submit" value="register"  />

 <br />
 

  </form>
       </center>
</asp:Content>

