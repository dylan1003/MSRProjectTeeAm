


function setCarouselActive(currentId) {
    var navList = document.getElementById(currentId).parentElement.children;
    for (var i = 0; i < navList.length; i++) {
        navList.item(i).classList.remove("highlightElement");
    }
    document.getElementById(currentId).classList.add("highlightElement");
};

$(function() {
    $(".map-modal-button").on('click', function () {
        $('#mapModal').modal('show');
    });
});


//$('#btnSubmit').click(function () {
//    var formData = $(mapForm).serialize();
    
//    $.ajax({
//        type: "POST",
//        url: "/UserVeteran/EditSectionMap",
//        data: formData,
//        success: function () {
//            $('#mapModal').modal('hide');
//        }
//    })
//})


/*
$(function () {
    $("#scrollmenu-nav").mousewheel(function (event, delta) {
        this.scrollLeft -= (delta * 50);
        this.scrollRight -= (delta * 50);
        this.style.transition = '1s';
        event.preventDefault();
    });
});
*/
/*
var isHovered;

$(function () {
    $("#scrollmenu-nav").mousedown(function (e) {
        
        ) 
    
    }); 

$(function () {
    $("#scrollmenu-nav").scroll(function (e) {
        if (e.originalEvent.wheelDelta > 0 || e.originalEvent.detail < 0) {
            $("#scrollmenu-nav").scrollLeft(300)
        }
        else {
            $("#scrollmenu-nav").scrollLeft(-300)
        }
    });
});*/

/*
function horizontalScrollWindow() {
    var scrollWindow = document.getElementById("scrollmenu-nav");
    var isMouseOver = true;

    $(scrollWindow).on('', function (e) {

    })

    while (isMouseOver) {
    }
} 
*/

$(function () {
    $('#inlineRadio4').on('click', function () {
        alert("Unfortunaly AIF search results currently does not support unit/battalion search");
    });
});

$(function () {
    $('#inlineRadio5').on('click', function () {
        alert("Unfortunaly AIF search results currently does not support pre-war occupation search");
    });
});