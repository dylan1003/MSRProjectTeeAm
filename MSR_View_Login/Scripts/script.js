
$(function () {
    $('img').on('click', function () {
        $('.enlargeImageModalSource').attr('src', $(this).attr('src'));
        $('#enlargeImageModal').modal('show');
    });
});

function setCarouselActive(currentId) {
    var navList = document.getElementById(currentId).parentElement.childNodes;
    var navArray = Array.from(navList);
    for (i = 0; i <= navArray.length; i++) {
        navArray[i].classList.remove('highlightElement');
    }
    document.getElementById(currentId).classList.add('highlightElement');
}


