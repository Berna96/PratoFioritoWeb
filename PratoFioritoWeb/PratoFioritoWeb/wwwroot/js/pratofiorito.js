$(function () {


    $(".grid-element").each(function () {
        $(this).click(function () {
            var type = $(this).data("type");
            if (type === 0) {
                $(this).addClass("grid-element-bomb")
            } else if (type === 1) {
                $(this).addClass("grid-element-empty")
            }
        });


    })

})