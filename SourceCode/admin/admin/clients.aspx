<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="clients.aspx.vb" Inherits="clients" title="Account list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="col-lg-12">
                            <div class="card spur-card">
                                <div class="card-header">
                                    <div class="spur-card-icon">
                                        <i class="fas fa-users"></i>
                                    </div>
                                    <div class="spur-card-title">Accounts list</div>
                                    <div style="padding-left:10px;">
                                    <a href="add.aspx" class="btn btn-primary mb-2" >New Account</a>
                                    </div>
                                </div>
                                <div class="card-body ">
                                    <table class="table table-hover table-in-card">
                                        <thead>
                                            <tr>
                                                <th scope="col">#</th>
                                                <th scope="col">UserName</th>
                                                <th scope="col">Full Name</th>
                                                <th scope="col">Mobile</th>
                                                <th scope="col">Expiry Date</th>
                                                <th scope="col">Status</th>
                                                 <th scope="col"></th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                        
                                        <%
                                            Dim _dal As New dal
                                            Dim dt As Data.DataTable
                                            Dim dr As Data.DataRow
                                            dt = _dal.LoadDataTable("SELECT * FROM Clients")
                                            For Each dr In dt.Rows
                                            %>
                                            <tr>
                                                <th scope="row"><% =dr("ClientID")%></th>
                                                <td><% =dr("ClientUserName")%></td>
                                                <td><% =dr("ClientFullName")%></td>
                                                <td><a href="https://api.whatsapp.com/send?phone=<% =dr("ClientMobile")%>&text=Hello" target=_blank><img src="img/whatsapp.png" /></a> <% =dr("ClientMobile")%></td>
                                                <td>
                                                <span class="badge badge-pill badge-<% =GetDateColor(dr("ClientExpiryDate")) %>"> <% =CDate(dr("ClientExpiryDate")).ToString("dd MMM yyyy")%></span>
                                               </td>
                                                <td> <span class="badge badge-pill badge-<% =GetBadgeColor(dr("ClientStatus")) %>"><% =GetStatus(dr("ClientStatus"))%></span></td>
                                                <td>
                                                <a href="edit.aspx?id=<% =dr("ClientID") %>" class="btn btn-info btn-sm  mb-1">Modify</a>
                                            
                                                
                                                <button type="button"  class="btn btn-warning btn-sm  mb-1" data-toggle="modal" data-target="#dlg<% =dr(0) %>">
                                                  Delete
                                                </button>
                                                <div class="modal fade" id="dlg<% =dr(0) %>" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle"
                                        aria-hidden="true">
                                        <div class="modal-dialog modal-dialog-centered" role="document">
                                            <div class="modal-content">
                                                <div class="modal-header">
                                                    <h5 class="modal-title" id="exampleModalLongTitle">
                                                        Delete Account</h5>
                                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                        <span aria-hidden="true">&times;</span>
                                                    </button>
                                                </div>
                                                <div class="modal-body">
                                                    Are you sure you want to delete this account?
                                                </div>
                                                <div class="modal-footer">
                                                    <button type="button" class="btn btn-secondary" data-dismiss="modal">
                                                        Cancel</button>
                                                    <button type="button" onclick="DeleteClick('<% =dr(0) %>')" id="DeleteAccount" class="btn btn-primary" data-dismiss="modal">
                                                        Delete</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                                </td>
                                             
                                            </tr>
                                            <%
                                            Next
                                                %>
                     
                                        </tbody>
                                    </table>
                                    
                                </div>
                            </div>
                        </div>

                        <script>
                        
                           var aaa='400'; 
                           
                           function setVal(b) 
                           { 
                           aaa=b;
                           }
                     
                            function DeleteClick(a)
                            {
                                window.location.href = "delete.aspx?id=" + a ;
                            
                            }
                        </script>
</asp:Content>

