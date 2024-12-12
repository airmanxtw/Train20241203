//(function ($) {
$(function () {
    $.widget("custom.SelectItemDialog", {
        options: {
            title: "title",
            items: [],
            itemValue: 'id',
            itemText: 'text',
            selectLimit: 1,
            height: 450,
            width: 550,
            delay: 800,
            searchKeyCallBack: null,
            confirmCallBack: null
        },
        _create: function () {
            var THIS = this;

            this.selectItemDiv = $("<div>", {
                attr: {
                    id: "items20241211"
                }
            });
            this.searchInput = $("<input>", {
                attr: {
                    id: "input20241211",
                    placeholder: "輸入關鍵字搜尋"
                },
                css: { width: "100%" }
            })

            this._on(this.searchInput, {
                keydown: "inputEvent"
            });

            //this._on(this.searchInput, {
            //    input: "inputEvent"
            //});

            this.dialogDiv =
                $("<div>", {
                    attr: {
                        id: "dialogDiv20241210",
                        title: this.options.title
                    }
                })
                    .append(this.searchInput)
                    .append(this.selectItemDiv)
                    .insertAfter(this.element)
                    .dialog({
                        autoOpen: false,
                        height: this.options.height,
                        width: this.options.width,
                        modal: true,
                        buttons: {
                            "確定": function () {
                                THIS.options.confirmCallBack(
                                    THIS.selectItemDiv.find(":checked").map(function (i, item) {
                                        return { id: $(item).data("id"), text: $(item).next().text() };
                                    }));
                                $(this).dialog("close");
                            },
                            "取消": function () {
                                $(this).dialog("close");
                            }
                        }
                    });

            this._on(this.element, {
                click: "openDialog"
            });

            this._refresh();

        },
        _setOptions: function () {
            this._superApply(arguments);
            this._refresh();
        },
        _setOption: function (key, value) {
            this._super(key, value);
        },
        _refresh: function () {
            var THAT = this; 
            var data = $.map(this.options.items, function (item, index) {
                THAT.checkItem =
                    $("<input>", {
                        attr: { type: THAT.options.selectLimit > 1 ? 'checkbox' : 'radio', "data-id": item[THAT.options.itemValue], name: 'items' }
                    });

                THAT._on(THAT.checkItem, {
                    click: "clickItemEvent"
                });

                return $("<div>")
                    .append(THAT.checkItem)
                    .append($("<label>", {
                        text: item[THAT.options.itemText]
                    }));
            });

           this.selectItemDiv.empty().append(data);
        },
        openDialog: function (event) {
            this.dialogDiv.dialog("open");
            event.preventDefault();
        },
        clickItemEvent: function (event) {
            var _selected = this.selectItemDiv.find(":checked").length;
            if (this.options.selectLimit < 1 || (this.options.selectLimit > 1 && _selected > this.options.selectLimit))
                event.preventDefault();
        },
        _timeID20241211: null,
        inputEvent: function (event) {
            alert(event.target.value);
            //var THAT = this;
            //if (this._timeID20241211 != null)
            //    clearTimeout(this._timeID20241211);

            //this._timeID20241211 = setTimeout(function () {
            //    THAT.options.searchKeyCallBack(event.target.value);
            //}, this.options.delay);

        },
        setItems: function (items) {
            
            this.options.items = $.extend([], items);
            this._refresh();
        }
    });
});
//})(jQuery);