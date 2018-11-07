
onLoad = function () {
    $('div section section form select').each(function () {

        var dropdownID = $(this).attr("id");
        var id = dropdownID.match(/\d+/g).map(Number);

        if ($(this).val() == "Text")
        {
            document.getElementById('sourceLabel-' + id).style.display = 'none';
            document.getElementById('sourceTextbox-' + id).style.display = 'none';

            document.getElementById('mediaLabel-' + id).style.display = 'block';
            document.getElementById('mediaTextArea-' + id).style.display = 'block';
        }
        else if ($(this).val() == "Image")
        {
            document.getElementById('mediaLabel-' + id).style.display = 'none';
            document.getElementById('mediaTextArea-' + id).style.display = 'none';

            document.getElementById('sourceLabel-' + id).style.display = 'block';
            document.getElementById('sourceTextbox-' + id).style.display = 'block';
        }
    });
}



$('div section section form select').each(function () {
    $(this).change(function () {

        var dropdownID = $(this).attr("id");

        var id = dropdownID.match(/\d+/g).map(Number);

        if ($(this).val() == "Text")
        {
            document.getElementById('sourceLabel-' + id).style.display = 'none';
            document.getElementById('sourceTextbox-' + id).style.display = 'none';

            document.getElementById('mediaLabel-' + id).style.display = 'block';
            document.getElementById('mediaTextArea-' + id).style.display = 'block';
        }
        else if ($(this).val() == "Image")
        {
            document.getElementById('mediaLabel-' + id).style.display = 'none';
            document.getElementById('mediaTextArea-' + id).style.display = 'none';

            document.getElementById('sourceLabel-' + id).style.display = 'block';
            document.getElementById('sourceTextbox-' + id).style.display = 'block';
        }
    })
});
