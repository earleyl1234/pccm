//
//          Affix
//=================================
$("#navbar").affix({
    offset: {
        top: $(".top-banner").height()
    }
});
//
//      Mini Smoothscroll
//=================================

//
//          Home Page
//
$(".top-banner .scrolldown").on('click', function (e) {

    e.preventDefault();

    $('html, body').animate({
        scrollTop: $(this.hash).offset().top
    }, 450, function () {

        window.location.hash = this.hash;
    });

});

//
//          Footer Links
//
$("footer ul li a").on('click', function (e) {

    var hash = this.hash;

    $('html, body').animate({
        scrollTop: $(hash).offset().top
    }, 450, function () {
        window.location.hash = hash;
    });

});