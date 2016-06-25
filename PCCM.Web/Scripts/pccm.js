//          Affix
//=================================
$("#navbar").affix({
    offset: {
        top: $(".top-banner").height()
    }
});

//      Mini Smoothscroll
//=================================
$(".top-banner .scrolldown").on('click', function (e) {

    // prevent default anchor click behavior
    e.preventDefault();

    // animate
    $('html, body').animate({
        scrollTop: $(this.hash).offset().top
    }, 450, function () {

        window.location.hash = this.hash;
    });

});
