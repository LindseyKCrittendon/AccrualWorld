// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//function to give user an error message if they don't upload
$(function () {

    $("#btnSubmit").on("click", function () {
        if ($("#inputGroupFile01").val() == "") {
            alert("Please select a file")
            return false;
        }
    })
})
