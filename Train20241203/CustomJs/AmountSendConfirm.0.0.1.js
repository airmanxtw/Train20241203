/// <reference path="../javascript/jquery-3.7.1.min.js" />
(function ($) {
    $.widget("custom.AmountSendConfirm", {
        options: {    
            script: null,
            title: "訊息",
            message:"內容",
            height: 450,
            width: 550,
            autoOpen: false,
            modal:true,
            confirmBtnText: "確定",
            cancelBtnText: "取消",
            confirmCallBack: function () { },
            closeCallBack: function () { }
        },
        _create: function () {
            var THAT = this;
            this._contentDiv = $("<div>", { html: this.options.message });            
            this.element.attr("title", this.options.title)
                .append(this._contentDiv)
                .dialog({    
                    autoOpen: this.options.autoOpen,
                    height: this.options.height,
                    width: this.options.width,
                    modal: this.options.modal,
                    buttons: {
                        [this.options.confirmBtnText]: function () {
                            THAT.options.confirmCallBack();
                            THAT.element.dialog("close");
                            eval(THAT.options.script);
                        },
                        [this.options.cancelBtnText]: function () {
                            THAT.options.closeCallBack();
                            THAT.element.dialog("close");
                        }
                    }
                });
        },
        _refresh: function () {
            this.element.dialog("option", "title", this.options.title);
            this._contentDiv.html(this.options.message);
        },
        _setOptions: function () {
            this._superApply(arguments);
            this._refresh();
        },
        _setOption: function (key, value) {
            this._super(key, value);
        },
        openDialog: function () {
            this.element.dialog("open");
        },
        closeDialog: function () {
            this.element.dialog("close");
        }
    });
})(jQuery);