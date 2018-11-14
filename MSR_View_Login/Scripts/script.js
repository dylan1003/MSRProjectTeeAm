


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

$(function (e) {
    $("#mapModalSaveButton").click(function () {
        bounds = map.getBounds();
        alert("zoom level: " + map._zoom);
        console.log(bounds._northEast);
        console.log(bounds._southWest);
    });
});

$(function (e) {
    $("#map-zoom").on('click', function () {
        map._zoom = e.value;        
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


//Adds placehorder text to search bar for format of search 
$(function () {
    $('.form-check').on('click', function () {
        if (this.childNodes[1].value === "Name") {
            $('#SearchField').attr("placeholder", "E.g John Monash");
        }
        else if (this.childNodes[1].value === "Regiment") {
            $('#SearchField').attr("placeholder", "E.g 1400");
        }
        else if (this.childNodes[1].value === "Address") {
            $('#SearchField').attr("placeholder", "E.g Birdwood Ave, Melbourne");
        }
        else if (this.childNodes[1].value === "Unit") {
            $('#SearchField').attr("placeholder", "E.g 13th Battalion, A Company");
        }
        else if (this.childNodes[1].value === "PreWarOccupation") {
            $('#SearchField').attr("placeholder", "E.g Clerk");
        }
    });
});


//Warning text for aif search
$(function () {
    $('.form-check').on('click', function () {
        if (this.childNodes[1].value === "Unit")
        {
            $('#info-warning').html("Unfortunately AIF search results currently does not support unit/battalion search");
        }
        else if(this.childNodes[1].value === "PreWarOccupation") {
            $('#info-warning').html("Unfortunately AIF search results currently does not support pre-war occupation search");
        }
        else
        {
            $('#info-warning').html("");
        }
    });
});


