<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="profile.aspx.vb" Inherits="profile" title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="card-body ">
    <h1 class="dash-title">Change Password</h1>

        <div class="form-row">
            <asp:Label ID="Label1" Style="width: 100%; text-align: center" runat="server" Text="Label"
                CssClass="alert alert-danger" role="alert" Visible="false"></asp:Label>
        </div>
                <div class="form-row">
            <div class="form-group col-md-12">
      
      </div> 
      </div> 
      
        <div class="form-row">
            <div class="form-group col-md-12">
                <label for="txtUserName">
                    Old Passowrd</label>
                <asp:TextBox ID="txtoldPassword" class="form-control" placeholder="Old Password" runat="server" TextMode=Password></asp:TextBox>
            </div>
            <div class="form-group col-md-12">
                <label for="txtPassword">
                    New Password</label>
                <asp:TextBox ID="txtNewPassword" runat="server" class="form-control" placeholder="New Password" TextMode=Password></asp:TextBox>
                
            </div>
            
                        <div class="form-group col-md-12">
                <label for="txtPassword">
                  Confirm Password</label>
                <asp:TextBox ID="TxtConfirm" runat="server" class="form-control" placeholder="Confirm Password" TextMode=Password></asp:TextBox>
            </div>
        </div>
           
            <asp:Button ID="Button1" runat="server" class="btn btn-primary mb-2" Text="Change password" />
    </div>

</asp:Content>

