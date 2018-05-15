$(document).ready(function () {
    //var url ="Categories/Index"
    //GetData(url);
});
$(document).on('click', '#btnSubmitt', function () {
    var CatName = $('#txtCatName').val();
    var AddedDate = $('#txtDate').val();
    var Data = { CatID: "0", CatName: CatName, AddedDate: AddedDate };
    alert(Data);
    var Url = "Categories/AddCategories";
    PostData(Data, Url);
})