<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="UpdateUSER.aspx.cs" Inherits="Orel_Web_Project.AspPage.UpdateUSER" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1>Update User Form</h1>
    <form action="UpdateUSER.aspx" runat="server" method="post" class="myform" onsubmit="return  CheckFormAll()" >

 

   <input type="text" id="fname" name="fname" placeholder="first name"  />

  

   <br />

   <input type="text" id="password" name="password" placeholder="password" />

   <br />


   <input type="submit" id="submit" name="submit" value="register"  />
         </form>

</asp:Content>
