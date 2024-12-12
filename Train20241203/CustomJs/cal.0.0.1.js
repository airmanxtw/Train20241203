/// <reference path="../javascript/jquery-3.7.1.min.js" />
$(function () {
    $.widget("myui.Cal", {
        options: {
            a: 0,
            b: 0,
            formular: function (a, b) {
                return a + b;
            },
            resultCallBack: null
        },
        _create: function () {

            this.inputA = $("<input>", {
                attr: {
                    id: "inputA",
                    type: "number"
                },

            });

            this.inputB = $("<input>", {
                attr: {
                    id: "inputB",
                    type: "number"
                },

            });

            this.BtnCal = $("<button>", {
                attr: {
                    id: "b1"
                },
                text: "計算"
            });

            this._on(this.BtnCal, {
                click: "calAB"
            });

            this.element.append(this.inputA).append(this.inputB).append(this.BtnCal);
            this._refresh();
        },
        _refresh: function () {
            this.inputA.val(this.options.a);
            this.inputB.val(this.options.b);
        },
        calAB: function (event) {
            var a = this.inputA.val();
            var b = this.inputB.val();
            var result = this.options.formular(a, b);
            this.options.resultCallBack(result);
            event.preventDefault();

        },
        setB: function (b) {
           
            this.options.b = b;
            this._refresh();
        }

    });


});