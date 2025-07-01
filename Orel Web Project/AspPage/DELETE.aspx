<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="DELETE.aspx.cs" Inherits="Orel_Web_Project.AspPage.DELETE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Delete Form</h1>
         <form action="DELETE.aspx" runat="server" method="post" class="myform" onsubmit="return  CheckFormAll()" >

 

   

   <input type="text" id="password" name="password" placeholder="password" />

   <br />


   <input type="submit" id="submit" name="submit" value="DELETE"  />
         </form>

</asp:Content>

