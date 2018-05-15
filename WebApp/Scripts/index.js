$(document).ready(function () {
    GetDatatble();
});
function GetDatatble() {
    $("#resualt").DataTable({

        "processing": true, // for show progress bar  
        "serverSide": true, // for process server side  
        "filter": true, // this is for disable filter (search box)  
        "orderMulti": false, // for disable multiple column at once  
        "pageLength": 5,

        "ajax": {
            "url": "/Categories/GetCategories",
            "type": "POST",
            "datatype": "json"
        },

        "columnDefs":
            [{
                "targets": [0],
                "visible": true,
                "searchable": false
            },

            {
                "targets": [1],
                "searchable": false,
                "orderable": false
            }
            ],

        "columns": [

            { "data": "CatName", "name": "CategoriesName", "autoWidth": true },
            { "data": "DateAdded", "title": "Added date", "name": "Added date", "autoWidth": true },

            {
                "render": function (data, type, full, meta) { return '<a class="btn btn-info" href="/Demo/Edit/' + full.CustomerID + '">Edit</a>'; }
            },
            {
                data: null, render: function (data, type, row) {
                    return "<a href='#' class='btn btn-danger' onclick=DeleteData('" + row.CustomerID + "'); >Delete</a>";
                }
            },

        ]

    });
};
