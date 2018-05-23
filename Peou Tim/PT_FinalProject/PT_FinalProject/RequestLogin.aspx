<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="RequestLogin.aspx.cs" Inherits="PT_FinalProject.RequestLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
    <div>
         <h1>Please Submit your Request Below</h1>
    </div>
    <div><label>Name:</label><input type="text" id="name" runat="server" /></div>
    <div><label>EmailAddress:</label><input type="email" placeholder="me@mydomain.com" required="required" id="emailaddress" runat="server"/></div>
    <div><label>LoginName:</label><input type="text" id="loginname" runat="server" /></div>
    <div><label>Reason For Access?</label></div>
    <div><textarea placeholder="Please include your reason for access" id="reason" runat="server" style="height: 136px; width: 405px" spellcheck="true"></textarea></div>
    <div>
        <button type="submit">Submit</button>
    </div>

    <div><p>A Logon Account and Password will be sent to you once a staff member review your request</p></div>
    
       
</asp:Content>
