Type.registerNamespace("eTabakov.Sitefinity.Modules.BlogsImport.Widgets.Designer");

eTabakov.Sitefinity.Modules.BlogsImport.Widgets.Designer.BlogsImportWidgetDesigner = function (element) {
    this._title = null;
    this._description = null;
    this._example = null;
    this._metaFieldNameTextBox = null;

    eTabakov.Sitefinity.Modules.BlogsImport.Widgets.Designer.BlogsImportWidgetDesigner.initializeBase(this, [element]);
}

eTabakov.Sitefinity.Modules.BlogsImport.Widgets.Designer.BlogsImportWidgetDesigner.prototype = {
    /* --------------------------------- set up and tear down --------------------------------- */
    initialize: function () {
        /* Here you can attach to events or do other initialization */
        eTabakov.Sitefinity.Modules.BlogsImport.Widgets.Designer.BlogsImportWidgetDesigner.callBaseMethod(this, 'initialize');
    },
    dispose: function () {
        /* this is the place to unbind/dispose the event handlers created in the initialize method */
        eTabakov.Sitefinity.Modules.BlogsImport.Widgets.Designer.BlogsImportWidgetDesigner.callBaseMethod(this, 'dispose');
    },

    /* --------------------------------- public methods ---------------------------------- */

    findElement: function (id) {
        var result = jQuery(this.get_element()).find("#" + id).get(0);
        return result;
    },

    /* Called when the designer window gets opened and here is place to "bind" your designer to the control properties */
    refreshUI: function () {        
        var controlData = this._propertyEditor.get_control(); /* JavaScript clone of your control - all the control properties will be properties of the controlData too */

        /* RefreshUI Title */
        jQuery(this.get_title()).val(controlData.Title);
        /* RefreshUI Description */
        jQuery(this.get_description()).val(controlData.Description);
        /* RefreshUI Example */
        jQuery(this.get_example()).val(controlData.Example);
    },

    /* Called when the "Save" button is clicked. Here you can transfer the settings from the designer to the control */
    applyChanges: function () {
        var controlData = this._propertyEditor.get_control();

        controlData.Title = jQuery(this.get_title()).val();
        controlData.Description = jQuery(this.get_description()).val();
        controlData.Example = jQuery(this.get_example()).val();
        controlData.MetaField.FieldName = this.get_metaFieldNameTextBox().get_value();
    },


    /* --------------------------------- properties -------------------------------------- */

    /* Title properties */
    get_title: function () { return this._title; }, 
    set_title: function (value) { this._title = value; },

    /* Description properties */
    get_description: function () { return this._description; }, 
    set_description: function (value) { this._description = value; },

    /* Example properties */
    get_example: function () { return this._example; }, 
    set_example: function (value) { this._example = value; },

    /* metaFieldNameTextBox properties */
    get_metaFieldNameTextBox: function () { return this._metaFieldNameTextBox; },
    set_metaFieldNameTextBox: function (value) { this._metaFieldNameTextBox = value; }
}

eTabakov.Sitefinity.Modules.BlogsImport.Widgets.Designer.BlogsImportWidgetDesigner.registerClass('eTabakov.Sitefinity.Modules.BlogsImport.Widgets.Designer.BlogsImportWidgetDesigner', Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesignerBase);

