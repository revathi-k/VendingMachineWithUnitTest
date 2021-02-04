<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="VendingMachineNew.Home" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Vending Machine</title>
    <link rel="stylesheet" type="text/css" href="css/popup.css" />
<link rel="stylesheet" type="text/css" href="css/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release"></asp:ScriptManager>
        <asp:UpdatePanel ID="upnlMain" runat="server">
    <ContentTemplate>
        <asp:Panel ID="PnlMain" runat="server">
           
                                <asp:Panel ID="pnlGridview" runat="server" ScrollBars="auto">
                                <asp:GridView ID="grdProducts" runat="server" datakeynames="ProductPrice" AutoGenerateColumns="false" Width="95%" ShowFooter="true"  CellSpacing="0"  OnRowDataBound="grdProducts_RowDataBound">
                                    <Columns>
                                        <asp:TemplateField HeaderText="SNo.">
                                            <ItemTemplate>
                                                <asp:Label ID="txtPrdID" runat="server" CssClass="inputText" Text='<%#Eval("ProductID")%>' BorderStyle="None"></asp:Label><br />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Product Name">
                                            <ItemTemplate>
                                                <asp:Label ID="txtPrdName" runat="server" CssClass="inputText" Text='<%#Eval("ProductName")%>' BorderStyle="None"></asp:Label><br />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Price ($)">
                                            <ItemTemplate>
                                                <asp:Label ID="txtAmt" runat="server" Text='<%#Eval("ProductPrice")%>' CssClass="inputText" BorderStyle="None"></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        
                                        <asp:TemplateField HeaderText=" ">
                                            <ItemTemplate>
                                                <asp:Button ID="btnBuy" runat="server" Text="BUY"  OnClick="btnBuy_Click" ToolTip="Buy" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                                     <asp:Button runat="server" ID="btnDummy" Style="display: none" />
                    <cc1:ModalPopupExtender ID="modelPopup" runat="server" CancelControlID="imgBtnClose" BackgroundCssClass="modalBackground"
                        PopupControlID="pnlCoinInsertionPopup" TargetControlID="btnDummy">
                    </cc1:ModalPopupExtender>
                    <asp:Panel ID="pnlCoinInsertionPopup" runat="server" CssClass="modalPopup" Style="display: none">
                        <div class="popup-panel-header">
                            <div style="display: inline-block;">
                                <h1>
                                    <asp:Label ID="lblHeadding" runat="server" Text="Insert Coins"></asp:Label></h1>
                            </div>
                            <div class=" float-right msg">
                                <span class="msg-pos" id="requiedMsg" runat="server">* Indicates required fields </span>
                                <asp:ImageButton ID="imgBtnClose" ImageUrl="~/Images/close1.png" runat="server" />
                            </div>
                        </div>
                         <asp:Panel ID="Panel1" runat="server">
                             <div class=" inputwidth140 popup-form-table popup-content-scrol">
                                 <table>
                                     <tr>
                                        <td colspan="2">
                                            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
                                        </td>
                                    </tr>
                                      <tr>
                                        <td>
                                            <asp:Label ID="lblAmt" runat="server" Text="Insert Coins"></asp:Label><span id="spnGiftAmt" runat="server" style="color: red">*</span>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtInputCoins" runat="server" Width="200px" onkeydown = "return (!(event.keyCode>=65) && event.keyCode!=32);" AutoPostBack="true" OnTextChanged="txtInputCoins_TextChanged"></asp:TextBox>
               
                                        </td>
                                    </tr>
                                     <tr>

                                        <td>
                                            <asp:Label ID="lblCurrencyType" runat="server" Text="Currency Type"></asp:Label><span id="spnQuantity" runat="server" style="color: red">*</span>
                                        </td>
                                        <td class="selectbox">
                                            <asp:DropDownList runat="server" ID="ddlCurrencyType" CheckBoxes="true" EmptyMessage="Select Quantity" ToolTip="Select Quantity"  DefaultMessage="Select Quantity" CssClass="border-none" MaxHeight="200" OnSelectedIndexChanged="ddlCurrencyType_SelectedIndexChanged">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                 </table>
                                 </div>
                             <div>
                                  <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-default" ToolTip="Click Here To Cancel Current Operation" OnClick="btnCancel_Click"></asp:Button>
                                 <asp:Button ID="btnProceed" runat="server" Text="ProceedTo Pay" CssClass="btn btn-default" ToolTip="Click Here To Proceed" OnClick="btnProceed_Click"></asp:Button>
                             </div>
                             </asp:Panel>
                                </asp:Panel>
             

        </asp:Panel>
            </asp:Panel>
    </ContentTemplate>
  <%-- <Triggers>
        <asp:PostBackTrigger ControlID="grdSGMSC" />
   </Triggers>--%>
</asp:UpdatePanel>
    </form>
</body>
</html>
