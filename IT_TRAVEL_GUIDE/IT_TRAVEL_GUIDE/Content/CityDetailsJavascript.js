document.addEventListener('DOMContentLoaded', function () {

    $('.divStars').each(function () {
        $(this).find('span').slice($(this).data('default-value')).addClass("checkedStar");
    })

});

