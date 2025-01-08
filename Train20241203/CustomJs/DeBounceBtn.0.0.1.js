/// <reference path="../javascript/jquery-3.7.1.min.js" />
(function ($) {
    $.widget("custom.DeBounceBtn", {
        options: {
            // 延遲時間
            delay: 600,

            // 客戶端驗證
            clientValidation: null,

            // 是否驗證通過
            isValidate: function () { return true; },

            // 執行動作
            action: null
        },
        _create: function () {
            let THIS = this;
            let script = THIS.element.attr("onclick");                        
            let timeId = null;
                        
            THIS.element.attr("type", "button").removeAttr("onclick").click(function () {
                if (!!THIS.options.clientValidation)
                    THIS.options.clientValidation();
                else
                    eval(script);
                
                if (THIS.options.isValidate()) {
                    debugger;
                    if (!!timeId) clearTimeout(timeId);
                    timeId = setTimeout(function () {
                        if (!!THIS.options.action)
                            THIS.options.action();
                        else
                            __doPostBack(THIS.element.attr("name"), '');            
                    }, THIS.options.delay);                            
                }
                
            });      
        }
    });
})(jQuery);