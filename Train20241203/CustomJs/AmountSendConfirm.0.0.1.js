/// <reference path="../javascript/jquery-3.7.1.min.js" />
(function ($) {
    $.widget("custom.AmountSendConfirm", {
        options: {
            script: null,            
            height: 450,
            width: 550
        },
        _create: function () {
            var THAT = this;            
            this.element.attr("title", "提示訊息")
                .append($("<div>", {text:"hello"}))
                .dialog({    
                    autoOpen: false,
                    height: this.options.height,
                    width: this.options.width,
                    modal: true,
                    buttons: {
                        "已了解上述訊息並確定完成填表": function () {                            
                            eval(THAT.options.script);
                        },
                        "取消": function () {
                            $(this).dialog("close");
                        }
                    }
                });
        },
        _setOptions: function () {
            this._superApply(arguments);            
        },
        _setOption: function (key, value) {
            this._super(key, value);
        },
        openDialog: function () {
            this.element.dialog("open");
        },
    });
})(jQuery);