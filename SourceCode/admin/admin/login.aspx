<%@ Page Language="VB" AutoEventWireup="false" CodeFile="login.aspx.vb" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.4.1/css/all.css" integrity="sha384-5sAR7xN1Nv6T6+dT2mhtzEpVJvfS3NScPQTrOxhwjIuvcA67KV2R5Jz6kr4abQsz" crossorigin="anonymous">
    <link href="https://fonts.googleapis.com/css?family=Nunito:400,600|Open+Sans:400,600,700" rel="stylesheet">
    <link rel="stylesheet" href="css/spur.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.3/Chart.bundle.min.js"></script>
    <script src="js/chart-js-config.js"></script>
    <script src="https://www.google.com/recaptcha/api.js" async defer></script>
    <title>Bulk WhatsApp Sender - Reselling Panel</title>
</head>
<body>
 
   
    
        <div class="form-screen">
      
        <div class="card account-dialog">
            <div class="card-header bg-primary text-white"> Please sign in </div>
            <div class="card-body">
                <form id="form1" runat="server">
            
                 <asp:Label class="alert-danger" ID="Label1" runat="server" Text="Label" Visible="False" style="padding:5px; margin:5px; display:block"></asp:Label>
         
                    <div class="form-group">
                          <asp:TextBox  class="form-control" ID="TxtUserName" runat="server" aria-describedby="emailHelp" placeholder="Enter UserName" required></asp:TextBox>
                    </div>
                    <div class="form-group">
                    <asp:TextBox ID="TxtPassword" class="form-control" runat="server" TextMode="Password"  placeholder="Password"></asp:TextBox>
                       
                    </div>
                    <div class="form-group" style="text-align:center">
                       
                            <div class="g-recaptcha" data-sitekey="6LfofaEUAAAAAD8F-qKpzJa7dG-XEm_i_aIGceXU"></div>
                            

                       
                    </div>
                    <div class="account-dialog-actions">
              
                          <asp:Button class="btn btn-primary" ID="BtnLogin" runat="server" Text="Login" />
                        <a class="account-dialog-link" href="signup.html">Contact Us for Account</a>
                    </div>
                </form>
            </div>
        </div>
    </div>
    
    
    
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <script src="js/spur.js"></script>
</body>
</html>
