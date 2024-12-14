/// <reference path="../javascript/jquery-3.7.1.min.js" />
(function ($) {
    $.widget("custom.SelectItemDialog", {
        options: {
            title: "title",
            headers: [{ key: 'id', title: '編號', width: '70px', align: 'center' }, { key: 'text', title: '名稱', width: '', align: 'left' }],
            key: "id",
            items: [],
            itemValue: 'id',
            itemText: 'text',
            selectLimit: 1,
            height: 450,
            width: 550,
            delay: 800,
            searchKeyCallBack: null,
            confirmCallBack: null,
            closeCallBack: null
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
                keyup: "inputEvent"
            });

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
                                    $.map(THIS.selectItemDiv.find(":checked"), function (item, i) {
                                        return $.grep(THIS.options.items, function (t) { return t[THIS.options.itemValue] == $(item).data("id") })[0]
                                    }));
                            },
                            "取消": function () {
                                THIS.options.closeCallBack();
                            }
                        }
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

            this.table = $("<table>", {
                attr: { id: "table20241213" },
                css: { width: "100%" }
            });

            this.thead = $("<thead>", {
                "class": "ui-widget-header ui-corner-all"
            }).appendTo(this.table);

            this.theadTr = $("<tr>").append($("<th>", { css: { width: "50px" }, text: "選擇" }))
                .append(
                    $.map(this.options.headers, function (header) {
                        return $("<th>", {
                            text: header.title,
                            css: { "text-align": "center", width: header.width }
                        });
                    })
                )
                .appendTo(this.thead);


            this.tbody = $("<tbody>").appendTo(this.table);

            $.each(this.options.items, function (i, item) {

                THAT.checkItem =
                    $("<input>", {
                        attr: { type: THAT.options.selectLimit > 1 ? 'checkbox' : 'radio', "data-id": item[THAT.options.itemValue], name: 'items' }
                    });

                THAT._on(THAT.checkItem, {
                    click: "clickItemEvent"
                });

                THAT.tbodyTr = $("<tr>").append($("<td>", { css: { 'text-align': 'center' } }).append(THAT.checkItem)).append(
                    $.map(THAT.options.headers, function (header) {
                        return $("<td>", {
                            text: item[header.key],
                            css: { "text-align": header.align, cursor: "pointer" }
                        });
                    })
                ).appendTo(THAT.tbody);

                THAT._on(THAT.tbodyTr, {
                    click: 'tbodyTrClickEvent'
                });

            });

            this.selectItemDiv.empty().append(this.table);
        },
        openDialog: function () {
            this.dialogDiv.dialog("open");
        },
        closeDialog: function () {
            this.dialogDiv.dialog("close");
        },
        clickItemEvent: function (event) {
            var _selected = this.selectItemDiv.find(":checked").length;

            if (this.options.selectLimit < 1 || (this.options.selectLimit > 1 && _selected > this.options.selectLimit))
                $(event.target).prop("checked", false);
            else {
                if (this.options.selectLimit == 1)
                    $(event.target).parent().parent().siblings().removeClass("ui-state-active");
                if ($(event.target).prop("checked"))
                    $(event.target).parent().parent().addClass("ui-state-active");
                else
                    $(event.target).parent().parent().removeClass("ui-state-active");
            }
            event.stopPropagation();

        },
        tbodyTrClickEvent: function (event) {
            $(event.target).parent().find("input").trigger("click");
        },
        _timeID20241211: null,
        inputEvent: function (event) {
            var THAT = this;
            if (this._timeID20241211 != null)
                clearTimeout(this._timeID20241211);

            this._timeID20241211 = setTimeout(function () {
                THAT.options.searchKeyCallBack(event.target.value);
            }, this.options.delay);
        },
        setItems: function (items) {
            this.options.items = $.extend([], items);
            this._refresh();
        },
        joinItem: function (conf) {
            var rs = "";
            $.each(conf.items, function (i, item) {
                rs += item[conf.key];                
                if (i < conf.items.length - 1)
                    rs += conf.separator;
            });            
            return rs;
        }
    });
})(jQuery);