<%@ Control Language="C#" %>
<%@ Register Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI" TagPrefix="sf" %>
<%@ Register Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI.FieldControls" TagPrefix="sfFields" %>
<%@ Register Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI.Fields" TagPrefix="sfFields" %>

<sfFields:FormManager ID="formManager" runat="server" />
<sf:ResourceLinks id="resourcesLinks1" runat="server">
    <sf:EmbeddedResourcePropertySetter Name="Telerik.Sitefinity.Resources.Themes.Default.Images.Loadings.sfLoadingFormBtns.gif"
        Static="true" ControlID="loadingImage1" ControlPropertyName="ImageUrl" />
    <sf:ResourceFile Name="Styles/MaxWindow.css" />
</sf:ResourceLinks>
<sf:ClientLabelManager id="clientLabelManager" runat="server">
    <labels>
        <sf:ClientLabel ClassId="Labels" Key="ChangesSuccessfullySaved" runat="server" />
    </labels>
</sf:ClientLabelManager>
<sf:Message runat="server" ID="message" ElementTag="div" CssClass="sfMessage sfDialogMessage" RemoveAfter="5000" FadeDuration="10" />

<h2>
    <asp:Literal runat="server" ID="lUserAuthenticationAndSSO" Text="<%$Resources:BlogsImporterModuleResources, BasicSettingsHeader %>" />
</h2>
<div class="sfSettingsSection">
    <sfFields:TextField ID="sampleTextSelect" runat="server" DisplayMode="Write" DataFieldName="Text" Title="<%$Resources:BlogsImporterModuleResources, SampleTextTitle %>" />
</div>

<div class="sfButtonArea" id="buttonsArea" runat="server">
    <asp:HyperLink ID="btnSave" runat="server" class="sfLinkBtn sfSave">
        <strong class="sfLinkBtnIn">
            <asp:Literal ID="Literal5" runat="server" Text='<%$ Resources:Labels, SaveChangesLabel %>' />
        </strong>
    </asp:HyperLink>
</div>
<div id="loadingView" runat="server" style="display: none;" class="sfLoadingFormBtns sfButtonArea">
    <sf:SfImage ID="loadingImage1" runat="server" AlternateText="<%$Resources:Labels, SavingImgAlt %>" />
</div>
<sfFields:FieldControlsBinder ID="fieldsBinder" runat="server" TargetId="fieldsBinder" 
    DataKeyNames="Id" ServiceUrl="~/eTabakovSitefinityBlogsImporter/eTabakov.Sitefinity.BlogsImporter.BlogsImporterModuleBasicSettingsService.svc/config/"/>