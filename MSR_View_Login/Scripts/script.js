
$(function () {
    $('img').on('click', function () {
        $('.enlargeImageModalSource').attr('src', $(this).attr('src'));
        $('#enlargeImageModal').modal('show');
    });
});

function setCarouselActive(currentId) {
    var navList = document.getElementById(currentId).parentElement.children;
    for (var i = 0; i < navList.length; i++) {
        navList.item(i).classList.remove("highlightElement");
    }
    document.getElementById(currentId).classList.add("highlightElement");
}


