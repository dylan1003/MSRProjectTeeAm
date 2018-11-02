$('div section section form #dropdown').each(function () {
    $(this).change(function () {
        alert($(this).val());
    })
});
