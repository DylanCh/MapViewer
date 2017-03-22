<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormApp._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function resetForm() {
            $('#fromTextBox').val('');
            $('#toTextBox').val('');
        }

        $(document).ready(function () {
            //$('#onGoogleMaps').find('input:radio').prop('checked', true);
            $('#inThisPage').hide();
            $('span').css('box-sizing', 'content-box');
            $('#resetLatLon').click(function (e) {
                e.preventDefault();
                $('#form1LatLong').find("input[type='text']").val('');
                //location.reload(true);
                $('#locationTypePanel').find('select').val('1');
            });
        });
    </script>
    

    <asp:TabContainer runat="server">
        <asp:TabPanel runat="server" HeaderText="Map Viewer" ID="TabPanel1" >
            <ContentTemplate> 
                <div>
                    <span id="locationTypePanel">
                        <asp:Label runat="server" Text="Location Type: "></asp:Label>
                        <asp:DropDownList runat="server" ID="locTypeDDList" AutoPostBack="true" OnSelectedIndexChanged="locationType_SelectedIndexChanged" >
                            <asp:ListItem runat="server" Selected="True" id="addressOption" Value="1">
                                Address
                            </asp:ListItem>
                            <asp:ListItem runat="server" id="latLonOption" Value="2">
                                Latitude & Longitude
                            </asp:ListItem>
                        </asp:DropDownList>
                    </span>
                </div>
                <div id="form1" class="tab-content" runat="server" ClientIDMode="static">
                     <asp:Table ID="formTable" runat="server" ClientIDMode="Static">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        Please enter a Point of Interest:
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="address" runat="server" ></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:RadioButtonList ID="openoptions" runat="server" ClientIDMode="Static">
                            <asp:ListItem ID="onGoogleMaps" Text="Open in Google Maps" runat="server" ClientIDMode="static" />
                            <asp:ListItem ID ="inThisPage" Text="In this page (Currently not available)" runat="server" />
                        </asp:RadioButtonList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click"/>
                        <asp:Button ID="resetBtn" runat="server" Text="Reset" OnClick="resetBtn_Click" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
                </div>
                <div id="form1LatLong" class ="tab-content" runat="server" ClientIDMode="static">
                    <asp:Table runat="server">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">
                                <asp:Label runat="server">Latitude: </asp:Label>
                            </asp:TableCell>
                            <asp:TableCell runat="server">
                                <asp:TextBox runat="server" ID="latitudeTextBox"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell runat="server">
                                <asp:RadioButtonList runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem runat="server" id="latitudeS">South</asp:ListItem>
                                    <asp:ListItem runat="server" id="latitudeN">North</asp:ListItem>
                                </asp:RadioButtonList>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">
                                <asp:Label runat="server">
                                    Longitude: 
                                </asp:Label>
                            </asp:TableCell>
                            <asp:TableCell runat="server">
                                <asp:TextBox runat="server" ID="longitudeTextBox"></asp:TextBox>
                            </asp:TableCell>
                            <asp:TableCell runat="server">
                                <asp:RadioButtonList runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem runat="server" ID="longitudeW">West</asp:ListItem>
                                    <asp:ListItem runat="server" ID="longitudeE">East</asp:ListItem>
                                </asp:RadioButtonList>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">
                                <asp:Button runat="server" Text="Search" OnClick="searchByLongitudeLatitude_click"/>
                            </asp:TableCell>
                            <asp:TableCell runat="server" ColumnSpan="2">
                                <asp:Button runat="server" id="resetLatLon" Text="Reset" hidden/>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
            </ContentTemplate>
        </asp:TabPanel>
        <asp:TabPanel runat="server" HeaderText="Trip Planner" ID="TabPanel2">
            <ContentTemplate>
            <div id="form2"class="tab-content">
                    <asp:Table runat="server">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">
                                <asp:Label runat="server">From: </asp:Label>
                            </asp:TableCell>
                            <asp:TableCell runat="server">
                                <asp:TextBox runat="server" ID="fromTextBox" ClientIDMode="Static"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">
                                <asp:Label runat="server">To: </asp:Label>
                            </asp:TableCell>
                            <asp:TableCell runat="server">
                                <asp:TextBox runat="server" ID="toTextBox" ClientIDMode="Static"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server">
                            <asp:TableCell> 
                                <asp:Button ID="submitTripButton" Text="Submit" runat="server" ClientIDMode="Static" OnClick="submitTripButton_Click" />
                                <asp:Button ID="resetTripButton" Text="Reset" runat="server" ClientIDMode="Static" OnClientClick="javascript:resetForm()" />
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
            </ContentTemplate>
        </asp:TabPanel>
    </asp:TabContainer>

    

    

    <section id="displayArea" hidden runat="server">
        <%--<iframe id="mapFrame" runat="server"
            width="800" height="600" frameborder="0" allowfullscreen></iframe>--%>
    </section>
    
</asp:Content>
