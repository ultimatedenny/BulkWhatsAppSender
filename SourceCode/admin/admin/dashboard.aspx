<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="dashboard.aspx.vb" Inherits="dashboard" title="Bulk WhatsApp sender - Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="row dash-row">
                    <div class="col-xl-4">
                            <div class="stats stats-success ">
                                <h3 class="stats-title"> All Accounts </h3>
                                <div class="stats-content">
                                    <div class="stats-icon">
                                        <i class="fas fa-users"></i>
                                    </div>
                                    <div class="stats-data">
                                        <div class="stats-number"><% =Getall()%></div>
                                        <div class="stats-change">
                                            <span class="stats-percentage">Accounts</span>
                                            
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-xl-4">
                            <div class="stats stats-warning">
                                <h3 class="stats-title"> Expiring Accounts </h3>
                                <div class="stats-content">
                                    <div class="stats-icon">
                                        <i class="fas fa-users"></i>
                                    </div>
                                    <div class="stats-data">
                                        <div class="stats-number"><% =GetExpirying()%></div>
                                                                   <div class="stats-change">
                                            <span class="stats-percentage">Accounts</span>
                                            
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                        
                        <div class="col-xl-4">
                            <div class="stats stats-danger">
                                <h3 class="stats-title">Expired Accounts </h3>
                                <div class="stats-content">
                                    <div class="stats-icon">
                                        <i class="fas fa-users"></i>
                                    </div>
                                    <div class="stats-data">
                                        <div class="stats-number"><% =GetExpired()%></div>
                                    <div class="stats-change">
                                            <span class="stats-percentage">Accounts</span>
                                            
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    
     <div class="row dash-row">               
                    
                    <div class="col-xl-6">
                            <div class="card spur-card">
                                <div class="card-header bg-warning text-white">
                                    <div class="spur-card-icon">
                                        <i class="fas fa-history"></i>
                                    </div>
                                    <div class="spur-card-title"> Expiring Account </div>
                                </div>
                                <div class="card-body ">
                                
                         
                                    <div class="notifications">
                                    
                                    <%
                                        If GetLastExpiring.Rows.Count > 0 Then
                                        %>
                                    
                                           <%
                                    Dim dr As Data.DataRow
                                    For Each dr In GetLastExpiring.Rows
                                 %>
                                        <a href="edit.aspx?id=<%=dr(0) %>" class="notification">
                                            <div class="notification-icon">
                                                <i class="fas fa-history"></i>
                                            </div>
                                            <div class="notification-text"><% =dr(2)%></div>
                                            <span class="notification-time">within <% =DateDiff(DateInterval.Day, Now.AddDays(-1), CDate(dr("ClientExpiryDate")))%> days</span>
                                        </a>
                       
                                        <%
                                        Next
                                            %>
                
                                        <%
                                        Else
                                            %>
                                        <p style="padding:6px; font-style:italic;">No accounts expiring soon...</p>
                                        <%
                                        End If
                                            %>
                                        
                                    </div>
                                </div>
                            </div>
                        </div>
                    
                    
                                  <div class="col-xl-6">
                            <div class="card spur-card">
                                <div class="card-header bg-danger text-white">
                                    <div class="spur-card-icon">
                                        <i class="fas fa-times-circle"></i>
                                    </div>
                                    <div class="spur-card-title"> Expired Accounts </div>
                                </div>
                                <div class="card-body ">
                                    <div class="notifications">
                                    
                       <%
                      
                           
                           If GetLastExpired.Rows.Count > 0 Then
                               For Each dr In GetLastExpired.Rows
                                 %>
                                        <a href="edit.aspx?id=<%=dr(0) %>" class="notification">
                                            <div class="notification-icon">
                                                <i class="fas fa-times-circle"></i>
                                            </div>
                                            <div class="notification-text"><% =dr(2)%></div>
                                            <span class="notification-time"> <% =DateDiff(DateInterval.Day, CDate(dr("ClientExpiryDate")), Now)%> days ago</span>
                                        </a>
                                        <%
                                        Next
                                            %>
                   
                                        <%
                                        Else
                                            
                                            %>
                                              <p style="padding:6px; font-style:italic;">No expired account...</p>
                                            
                                        <%
                                            
                                        End If
                                            %>
                                    </div>
                                </div>
                            </div>
                        </div>
                    
                    
                    </div> 
                    
</asp:Content>



