```javascript
 var timeId;
        $("#InsertButton").removeAttr("onclick").attr("type", "button").click(function () {
           
            WebForm_DoPostBackWithOptions(new WebForm_PostBackOptions("ctl00$ContentPlaceHolder1$editStud1$InsertButton", "", true, "G1", "", false, false));
                                
            if (WebForm_OnSubmit()) {
           
                if (!!timeId) {
                    clearTimeout(timeId);
                }
                timeId = setTimeout(function () {
                    __doPostBack("ctl00$ContentPlaceHolder1$editStud1$InsertButton", "")
                }, 2000)           
            }
           
        });