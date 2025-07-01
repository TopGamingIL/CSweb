<%@ Page Title="" Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="AddApp.aspx.cs" Inherits="Orel_Web_Project.AspPage.AddApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <center>
   <h1>Add App Form</h1>
    <form action="AddApp.aspx" runat="server" method="post" class="myform"  >

 

      <input type="text" id="fname" name="fname" placeholder="client name"  />

      <br />
           <input type="text" id="barber" name="barber" placeholder="barber name" />

      <br />

      <input type="text" id="appdate" name="appdate" placeholder="Appointment date" />

      <br />


     
        <input type="text" id="hour" name="hour" placeholder="Appointment hour" />

<br />
        
         <input type="submit" id="submit" name="submit" value="Add App"  />

 <br />
 

  </form>
       </center>
</asp:Content>
