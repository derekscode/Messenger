"use strict";

$(function () {

    var clickHandler = function () {
        alert("This is silly");
    };

    $("div").click(clickHandler);
});