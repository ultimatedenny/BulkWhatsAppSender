<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false"
    CodeFile="add.aspx.vb" Inherits="add" Title="Add new Account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="card spur-card">
        <div class="card-header">
            <div class="spur-card-icon">
                <i class="fas fa-user"></i>
            </div>
            <div class="spur-card-title">
                Add New Account
            </div>
        </div>
        <div class="card-body ">
            <form id="FrmAdd">
             <div class="form-row">
                 <asp:Label ID="Label1" style="width:100%; text-align:center" runat="server" Text="Label" CssClass="alert alert-danger" role="alert" Visible=false></asp:Label>
             </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="txtUserName">
                        UserName</label>
                    <asp:TextBox ID="txtUserName" class="form-control" placeholder="UserName" runat="server" autocomplete="off"
                        required></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                    <label for="txtPassword">
                        Password</label>
                    <asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="Password" autocomplete="off"
                        required></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="txtFullName">
                        FullName</label>
                    <asp:TextBox ID="txtFullName" class="form-control" runat="server" placeholder="FullName" autocomplete="off"
                        required></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                    <label for="txtMobile">
                        Mobile</label>
                    <asp:TextBox ID="txtMobile" class="form-control" runat="server" placeholder="Mobile" autocomplete="off"
                        required></asp:TextBox>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="txtEmail">
                        E-mail</label>
                    <asp:TextBox ID="txtEmail" class="form-control" runat="server" placeholder="Email" autocomplete="off"
                        required></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                    <label for="countrylist">
                        Country</label>
                    <asp:DropDownList ID="countrylist" class="form-control" runat="server">
                        <asp:ListItem Value="Afghanistan">Afghanistan</asp:ListItem>
                        <asp:ListItem Value="Albania">Albania</asp:ListItem>
                        <asp:ListItem Value="Algeria">Algeria</asp:ListItem>
                        <asp:ListItem Value="Andorra">Andorra</asp:ListItem>
                        <asp:ListItem Value="Angola">Angola</asp:ListItem>
                        <asp:ListItem Value="Antigua and Barbuda">Antigua and Barbuda</asp:ListItem>
                        <asp:ListItem Value="Argentina">Argentina</asp:ListItem>
                        <asp:ListItem Value="Armenia">Armenia</asp:ListItem>
                        <asp:ListItem Value="Australia">Australia</asp:ListItem>
                        <asp:ListItem Value="Austria">Austria</asp:ListItem>
                        <asp:ListItem Value="Azerbaijan">Azerbaijan</asp:ListItem>
                        <asp:ListItem Value="Bahamas">Bahamas</asp:ListItem>
                        <asp:ListItem Value="Bahrain">Bahrain</asp:ListItem>
                        <asp:ListItem Value="Bangladesh">Bangladesh</asp:ListItem>
                        <asp:ListItem Value="Barbados">Barbados</asp:ListItem>
                        <asp:ListItem Value="Belarus">Belarus</asp:ListItem>
                        <asp:ListItem Value="Belgium">Belgium</asp:ListItem>
                        <asp:ListItem Value="Belize">Belize</asp:ListItem>
                        <asp:ListItem Value="Benin">Benin</asp:ListItem>
                        <asp:ListItem Value="Bhutan">Bhutan</asp:ListItem>
                        <asp:ListItem Value="Bolivia">Bolivia</asp:ListItem>
                        <asp:ListItem Value="Bosnia and Herzegovina">Bosnia and Herzegovina</asp:ListItem>
                        <asp:ListItem Value="Botswana">Botswana</asp:ListItem>
                        <asp:ListItem Value="Brazil">Brazil</asp:ListItem>
                        <asp:ListItem Value="Brunei">Brunei</asp:ListItem>
                        <asp:ListItem Value="Bulgaria">Bulgaria</asp:ListItem>
                        <asp:ListItem Value="Burkina Faso">Burkina Faso</asp:ListItem>
                        <asp:ListItem Value="Burundi">Burundi</asp:ListItem>
                        <asp:ListItem Value="Côte d'Ivoire">Côte d'Ivoire</asp:ListItem>
                        <asp:ListItem Value="Cabo Verde">Cabo Verde</asp:ListItem>
                        <asp:ListItem Value="Cambodia">Cambodia</asp:ListItem>
                        <asp:ListItem Value="Cameroon">Cameroon</asp:ListItem>
                        <asp:ListItem Value="Canada">Canada</asp:ListItem>
                        <asp:ListItem Value="Central African Republic">Central African Republic</asp:ListItem>
                        <asp:ListItem Value="Chad">Chad</asp:ListItem>
                        <asp:ListItem Value="Chile">Chile</asp:ListItem>
                        <asp:ListItem Value="China">China</asp:ListItem>
                        <asp:ListItem Value="Colombia">Colombia</asp:ListItem>
                        <asp:ListItem Value="Comoros">Comoros</asp:ListItem>
                        <asp:ListItem Value="Congo (Congo-Brazzaville)">Congo (Congo-Brazzaville)</asp:ListItem>
                        <asp:ListItem Value="Costa Rica">Costa Rica</asp:ListItem>
                        <asp:ListItem Value="Croatia">Croatia</asp:ListItem>
                        <asp:ListItem Value="Cuba">Cuba</asp:ListItem>
                        <asp:ListItem Value="Cyprus">Cyprus</asp:ListItem>
                        <asp:ListItem Value="Czech Republic">Czech Republic</asp:ListItem>
                        <asp:ListItem Value="Democratic Republic of the Congo">Democratic Republic of the Congo</asp:ListItem>
                        <asp:ListItem Value="Denmark">Denmark</asp:ListItem>
                        <asp:ListItem Value="Djibouti">Djibouti</asp:ListItem>
                        <asp:ListItem Value="Dominica">Dominica</asp:ListItem>
                        <asp:ListItem Value="Dominican Republic">Dominican Republic</asp:ListItem>
                        <asp:ListItem Value="Ecuador">Ecuador</asp:ListItem>
                        <asp:ListItem Value="Egypt">Egypt</asp:ListItem>
                        <asp:ListItem Value="El Salvador">El Salvador</asp:ListItem>
                        <asp:ListItem Value="Equatorial Guinea">Equatorial Guinea</asp:ListItem>
                        <asp:ListItem Value="Eritrea">Eritrea</asp:ListItem>
                        <asp:ListItem Value="Estonia">Estonia</asp:ListItem>
                        <asp:ListItem Value="Ethiopia">Ethiopia</asp:ListItem>
                        <asp:ListItem Value="Fiji">Fiji</asp:ListItem>
                        <asp:ListItem Value="Finland">Finland</asp:ListItem>
                        <asp:ListItem Value="France">France</asp:ListItem>
                        <asp:ListItem Value="Gabon">Gabon</asp:ListItem>
                        <asp:ListItem Value="Gambia">Gambia</asp:ListItem>
                        <asp:ListItem Value="Georgia">Georgia</asp:ListItem>
                        <asp:ListItem Value="Germany">Germany</asp:ListItem>
                        <asp:ListItem Value="Ghana">Ghana</asp:ListItem>
                        <asp:ListItem Value="Greece">Greece</asp:ListItem>
                        <asp:ListItem Value="Grenada">Grenada</asp:ListItem>
                        <asp:ListItem Value="Guatemala">Guatemala</asp:ListItem>
                        <asp:ListItem Value="Guinea">Guinea</asp:ListItem>
                        <asp:ListItem Value="Guinea-Bissau">Guinea-Bissau</asp:ListItem>
                        <asp:ListItem Value="Guyana">Guyana</asp:ListItem>
                        <asp:ListItem Value="Haiti">Haiti</asp:ListItem>
                        <asp:ListItem Value="Holy See">Holy See</asp:ListItem>
                        <asp:ListItem Value="Honduras">Honduras</asp:ListItem>
                        <asp:ListItem Value="Hungary">Hungary</asp:ListItem>
                        <asp:ListItem Value="Iceland">Iceland</asp:ListItem>
                        <asp:ListItem Value="India">India</asp:ListItem>
                        <asp:ListItem Value="Indonesia">Indonesia</asp:ListItem>
                        <asp:ListItem Value="Iran">Iran</asp:ListItem>
                        <asp:ListItem Value="Iraq">Iraq</asp:ListItem>
                        <asp:ListItem Value="Ireland">Ireland</asp:ListItem>
                        <asp:ListItem Value="Israel">Israel</asp:ListItem>
                        <asp:ListItem Value="Italy">Italy</asp:ListItem>
                        <asp:ListItem Value="Jamaica">Jamaica</asp:ListItem>
                        <asp:ListItem Value="Japan">Japan</asp:ListItem>
                        <asp:ListItem Value="Jordan">Jordan</asp:ListItem>
                        <asp:ListItem Value="Kazakhstan">Kazakhstan</asp:ListItem>
                        <asp:ListItem Value="Kenya">Kenya</asp:ListItem>
                        <asp:ListItem Value="Kiribati">Kiribati</asp:ListItem>
                        <asp:ListItem Value="Kuwait">Kuwait</asp:ListItem>
                        <asp:ListItem Value="Kyrgyzstan">Kyrgyzstan</asp:ListItem>
                        <asp:ListItem Value="Laos">Laos</asp:ListItem>
                        <asp:ListItem Value="Latvia">Latvia</asp:ListItem>
                        <asp:ListItem Value="Lebanon">Lebanon</asp:ListItem>
                        <asp:ListItem Value="Lesotho">Lesotho</asp:ListItem>
                        <asp:ListItem Value="Liberia">Liberia</asp:ListItem>
                        <asp:ListItem Value="Libya">Libya</asp:ListItem>
                        <asp:ListItem Value="Liechtenstein">Liechtenstein</asp:ListItem>
                        <asp:ListItem Value="Lithuania">Lithuania</asp:ListItem>
                        <asp:ListItem Value="Luxembourg">Luxembourg</asp:ListItem>
                        <asp:ListItem Value="Macedonia (FYROM)">Macedonia (FYROM)</asp:ListItem>
                        <asp:ListItem Value="Madagascar">Madagascar</asp:ListItem>
                        <asp:ListItem Value="Malawi">Malawi</asp:ListItem>
                        <asp:ListItem Value="Malaysia">Malaysia</asp:ListItem>
                        <asp:ListItem Value="Maldives">Maldives</asp:ListItem>
                        <asp:ListItem Value="Mali">Mali</asp:ListItem>
                        <asp:ListItem Value="Malta">Malta</asp:ListItem>
                        <asp:ListItem Value="Marshall Islands">Marshall Islands</asp:ListItem>
                        <asp:ListItem Value="Mauritania">Mauritania</asp:ListItem>
                        <asp:ListItem Value="Mauritius">Mauritius</asp:ListItem>
                        <asp:ListItem Value="Mexico">Mexico</asp:ListItem>
                        <asp:ListItem Value="Micronesia">Micronesia</asp:ListItem>
                        <asp:ListItem Value="Moldova">Moldova</asp:ListItem>
                        <asp:ListItem Value="Monaco">Monaco</asp:ListItem>
                        <asp:ListItem Value="Mongolia">Mongolia</asp:ListItem>
                        <asp:ListItem Value="Montenegro">Montenegro</asp:ListItem>
                        <asp:ListItem Value="Morocco">Morocco</asp:ListItem>
                        <asp:ListItem Value="Mozambique">Mozambique</asp:ListItem>
                        <asp:ListItem Value="Myanmar (formerly Burma)">Myanmar (formerly Burma)</asp:ListItem>
                        <asp:ListItem Value="Namibia">Namibia</asp:ListItem>
                        <asp:ListItem Value="Nauru">Nauru</asp:ListItem>
                        <asp:ListItem Value="Nepal">Nepal</asp:ListItem>
                        <asp:ListItem Value="Netherlands">Netherlands</asp:ListItem>
                        <asp:ListItem Value="New Zealand">New Zealand</asp:ListItem>
                        <asp:ListItem Value="Nicaragua">Nicaragua</asp:ListItem>
                        <asp:ListItem Value="Niger">Niger</asp:ListItem>
                        <asp:ListItem Value="Nigeria">Nigeria</asp:ListItem>
                        <asp:ListItem Value="North Korea">North Korea</asp:ListItem>
                        <asp:ListItem Value="Norway">Norway</asp:ListItem>
                        <asp:ListItem Value="Oman">Oman</asp:ListItem>
                        <asp:ListItem Value="Pakistan">Pakistan</asp:ListItem>
                        <asp:ListItem Value="Palau">Palau</asp:ListItem>
                        <asp:ListItem Value="Palestine State">Palestine State</asp:ListItem>
                        <asp:ListItem Value="Panama">Panama</asp:ListItem>
                        <asp:ListItem Value="Papua New Guinea">Papua New Guinea</asp:ListItem>
                        <asp:ListItem Value="Paraguay">Paraguay</asp:ListItem>
                        <asp:ListItem Value="Peru">Peru</asp:ListItem>
                        <asp:ListItem Value="Philippines">Philippines</asp:ListItem>
                        <asp:ListItem Value="Poland">Poland</asp:ListItem>
                        <asp:ListItem Value="Portugal">Portugal</asp:ListItem>
                        <asp:ListItem Value="Qatar">Qatar</asp:ListItem>
                        <asp:ListItem Value="Romania">Romania</asp:ListItem>
                        <asp:ListItem Value="Russia">Russia</asp:ListItem>
                        <asp:ListItem Value="Rwanda">Rwanda</asp:ListItem>
                        <asp:ListItem Value="Saint Kitts and Nevis">Saint Kitts and Nevis</asp:ListItem>
                        <asp:ListItem Value="Saint Lucia">Saint Lucia</asp:ListItem>
                        <asp:ListItem Value="Saint Vincent and the Grenadines">Saint Vincent and the Grenadines</asp:ListItem>
                        <asp:ListItem Value="Samoa">Samoa</asp:ListItem>
                        <asp:ListItem Value="San Marino">San Marino</asp:ListItem>
                        <asp:ListItem Value="Sao Tome and Principe">Sao Tome and Principe</asp:ListItem>
                        <asp:ListItem Value="Saudi Arabia">Saudi Arabia</asp:ListItem>
                        <asp:ListItem Value="Senegal">Senegal</asp:ListItem>
                        <asp:ListItem Value="Serbia">Serbia</asp:ListItem>
                        <asp:ListItem Value="Seychelles">Seychelles</asp:ListItem>
                        <asp:ListItem Value="Sierra Leone">Sierra Leone</asp:ListItem>
                        <asp:ListItem Value="Singapore">Singapore</asp:ListItem>
                        <asp:ListItem Value="Slovakia">Slovakia</asp:ListItem>
                        <asp:ListItem Value="Slovenia">Slovenia</asp:ListItem>
                        <asp:ListItem Value="Solomon Islands">Solomon Islands</asp:ListItem>
                        <asp:ListItem Value="Somalia">Somalia</asp:ListItem>
                        <asp:ListItem Value="South Africa">South Africa</asp:ListItem>
                        <asp:ListItem Value="South Korea">South Korea</asp:ListItem>
                        <asp:ListItem Value="South Sudan">South Sudan</asp:ListItem>
                        <asp:ListItem Value="Spain">Spain</asp:ListItem>
                        <asp:ListItem Value="Sri Lanka">Sri Lanka</asp:ListItem>
                        <asp:ListItem Value="Sudan">Sudan</asp:ListItem>
                        <asp:ListItem Value="Suriname">Suriname</asp:ListItem>
                        <asp:ListItem Value="Swaziland">Swaziland</asp:ListItem>
                        <asp:ListItem Value="Sweden">Sweden</asp:ListItem>
                        <asp:ListItem Value="Switzerland">Switzerland</asp:ListItem>
                        <asp:ListItem Value="Syria">Syria</asp:ListItem>
                        <asp:ListItem Value="Tajikistan">Tajikistan</asp:ListItem>
                        <asp:ListItem Value="Tanzania">Tanzania</asp:ListItem>
                        <asp:ListItem Value="Thailand">Thailand</asp:ListItem>
                        <asp:ListItem Value="Timor-Leste">Timor-Leste</asp:ListItem>
                        <asp:ListItem Value="Togo">Togo</asp:ListItem>
                        <asp:ListItem Value="Tonga">Tonga</asp:ListItem>
                        <asp:ListItem Value="Trinidad and Tobago">Trinidad and Tobago</asp:ListItem>
                        <asp:ListItem Value="Tunisia">Tunisia</asp:ListItem>
                        <asp:ListItem Value="Turkey">Turkey</asp:ListItem>
                        <asp:ListItem Value="Turkmenistan">Turkmenistan</asp:ListItem>
                        <asp:ListItem Value="Tuvalu">Tuvalu</asp:ListItem>
                        <asp:ListItem Value="Uganda">Uganda</asp:ListItem>
                        <asp:ListItem Value="Ukraine">Ukraine</asp:ListItem>
                        <asp:ListItem Value="United Arab Emirates">United Arab Emirates</asp:ListItem>
                        <asp:ListItem Value="United Kingdom">United Kingdom</asp:ListItem>
                        <asp:ListItem Value="United States of America">United States of America</asp:ListItem>
                        <asp:ListItem Value="Uruguay">Uruguay</asp:ListItem>
                        <asp:ListItem Value="Uzbekistan">Uzbekistan</asp:ListItem>
                        <asp:ListItem Value="Vanuatu">Vanuatu</asp:ListItem>
                        <asp:ListItem Value="Venezuela">Venezuela</asp:ListItem>
                        <asp:ListItem Value="Viet Nam">Viet Nam</asp:ListItem>
                        <asp:ListItem Value="Yemen">Yemen</asp:ListItem>
                        <asp:ListItem Value="Zambia">Zambia</asp:ListItem>
                        <asp:ListItem Value="Zimbabwe">Zimbabwe</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            
            
                       <div class="form-row">
                       
                                       <div class="form-group col-md-12"> 
            <div class="card spur-card">
                                <div class="card-header bg-primary text-white">
                                    <div class="spur-card-icon">
                                        <i class="fas fa-chart-bar"></i>
                                    </div>
                                    <div class="spur-card-title"> Demo Account </div>
                                    <div class="spur-card-menu">
                                    </div>
                                </div>
                                <div class="card-body "> 
                                <div class="form-row">
                <div class="form-group">
                    <div class="checkbox">
                        <label class="btn btn-default">
                            <asp:CheckBox ID="ChkGroupPoster" name="ChkGroupPoster" runat="server" Text="Group Poster" />
                        </label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="checkbox">
                        <label class="btn btn-default">
                            <asp:CheckBox ID="ChkGroupGrabber" name="ChkGroupGrabber" runat="server" Text="Group Grabber" />
                        </label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="checkbox">
                        <label class="btn btn-default">
                            <asp:CheckBox ID="ChkMultiAccount" name="ChkMultiAccount" runat="server" Text="Multi Account" />
                        </label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="checkbox">
                        <label class="btn btn-default">
                            <asp:CheckBox ID="ChkFilter" name="ChkFilter" runat="server" Text="Filter" />
                        </label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="checkbox">
                        <label class="btn btn-default">
                            <asp:CheckBox ID="ChkTurboMode" name="ChkTurboMode" runat="server" Text="Turbo Mode" />
                        </label>
                    </div>
                </div>
               
            </div>
                                </div>
                                </div>
                                </div>
                                
                               
                                
                                
                
            </div>
            <div class="form-row">
            <div class="form-group col-md-12"> 
            <div class="card spur-card">
                                <div class="card-header bg-primary text-white">
                                    <div class="spur-card-icon">
                                        <i class="fas fa-chart-bar"></i>
                                    </div>
                                    <div class="spur-card-title"> Demo Account </div>
                                    <div class="spur-card-menu">
                                    </div>
                                </div>
                                <div class="card-body "> 
                             
                    <div class="checkbox">
                        <label class="btn btn-default">
                            <asp:CheckBox ID="ChkDemoAccount" name="ChkDemoAccount" runat="server" Text="Demo Mode" />
                            <p>By Checking demo account the application will be able to send upto 3 messages only each time, on both Normal and turbo mode , Note that on demo mode user can still use other option if the permission is granted to him</p>
                        </label>
                 
                </div>
                                 </div>
                            </div>
            </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="txtFullName">
                        Expiry Date</label>
                    <asp:TextBox ID="ExpDate" name="ExpDate" class="form-control" runat="server" autocomplete="off" required></asp:TextBox>
                </div>
                <div class="form-group col-md-6">
                    <label for="countrylist">
                        Status</label>
                    <asp:DropDownList ID="DropDownListStatus" class="form-control" runat="server">
                        <asp:ListItem Value="1">Active</asp:ListItem>
                        <asp:ListItem Value="0">Disabled</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            
            <asp:Button ID="Button1"  class="btn btn-primary" runat="server" Text="Save Client" />
       
            </form>
        </div>
    </div>
</asp:Content>
