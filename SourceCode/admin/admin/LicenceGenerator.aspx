<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="LicenceGenerator.aspx.vb" Inherits="LicenceGenerator" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h1 class="dash-title">License Generator</h1>
    <div class="form-group">
    <asp:Label ID="Label1" class="alert alert-danger" role="alert" runat="server" Text="Label" Visible=false></asp:Label>
 </div>
    <div class="form-group">
        <label for="exampleFormControlTextarea1">
            Request Code</label>
      
        <asp:TextBox   class="form-control" ID="TextBox1" runat="server" TextMode="MultiLine" rows="3"></asp:TextBox>
    </div>
    
     <div class="form-group">
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </div> 
    <div class="form-group">
    <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Create License" />
    </div> 
    <div class="form-group">
        <label for="exampleFormControlTextarea1">
           Generated License</label>
        <asp:TextBox class="form-control" ID="TextBox2" runat="server" TextMode="MultiLine"
            Rows="3"></asp:TextBox>
    </div>
</asp:Content>

