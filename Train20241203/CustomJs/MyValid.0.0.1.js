function CheckName(sender, args) {
    $.ajaxSetup({ async: false }); 
    $.get("MyValid.ashx?name=" + args.Value, function (data) {
        args.IsValid = data;
    });
   
   
}