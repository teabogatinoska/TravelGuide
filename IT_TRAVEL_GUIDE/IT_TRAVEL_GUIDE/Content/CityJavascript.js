document.addEventListener('DOMContentLoaded', function () {

    // HIDE ALL DIVS EXCEPT SELECTED ONE------------------------

    $(".divMainAttractions, .divRestaurants, .divBeaches, .divNightlife, .divTips").hide();
    
    $('#li1').click(function () {
        $('.divMainAttractions').show();
        $(".divInfo, .divRestaurants, .divBeaches, .divNightlife, .divTips").hide();
    });

    $('#li2').click(function () {
        $('.divRestaurants').show();
        $(".divInfo, .divMainAttractions, .divBeaches, .divNightlife, .divTips").hide();
    });

    $('#li3').click(function () {
        $('.divBeaches').show();
        $(".divInfo, .divMainAttractions, .divRestaurants, .divNightlife, .divTips").hide();
    });

    $('#li5').click(function () {
        $('.divNightlife').show();
        $(".divInfo, .divMainAttractions, .divRestaurants, .divBeaches, .divTips").hide();
    });

    $('#li6').click(function () {
        $('.divTips').show();
        $(".divInfo, .divMainAttractions, .divRestaurants, .divBeaches, .divNightlife").hide();
    });

   

    //-------------------------------------------------------


    // SLIDER------------------------------------------------

    $('.nextArrow').on('click', function () {

        var currentDiv = $('.activeDiv')
        var nextDiv = currentDiv.next();

        if (nextDiv.length) {
            currentDiv.removeClass('activeDiv').css('z-index', -10);
            nextDiv.addClass('activeDiv').css('z-index', 10);
        }
    });

    $('.prevArrow').on('click', function () {

        var currentDiv = $('.activeDiv')
        var prevDiv = currentDiv.prev();

        if (prevDiv.length) {
            currentDiv.removeClass('activeDiv').css('z-index', -10);
            prevDiv.addClass('activeDiv').css('z-index', 10);
        }
    });
    // ---------------------------------------------------------

});
