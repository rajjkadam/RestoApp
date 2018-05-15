function GetData(path) {
    var data = '';
    $.ajax({
        url: path,  
        type: 'get',
        data: {},
        dataType: 'json',
        success: function (response) {
            //Do Something
            return data = response;
        },
        error: function (xhr) {
            //Do Something to handle error
            console.log(xhr);
        }
    });   
};
function PostData(data, url) {
  
    $.ajax({
        type: 'POST',
        url: url,
        data: JSON.stringify(data),
        contentType: "application/json; charset=utf-8",
        datatype:'json',
        success: function (d) {
            return d;
        }, error: function (d) {
            return d;

        }
    })
};