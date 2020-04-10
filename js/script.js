//One line comment
/*Multi line comments*/

//var myVariable = "Welcome to Javascript";
/*document.write(myVariable);
alert(myVariable); */
//$('h1').hide(2500).show(2500) ;
/*    |     | Preloader |   |   */
$(window).on('load', function () { // makes sure that whole site is loaded
    $('#status').fadeOut();
    $('#preloader').delay(1000).fadeOut('very slow');
});
/*==================================
            Owl Corousel
====================================*/
$(function(){
  $("#team-members").owlCarousel({
      items: 2,
      autoplay: true,
      smartSpeed: 500,
      loop: true,
      autoplayHoverPause: true,
      nav: true,
      dots: false
  });
});
/*==================================
            Progress BAr
====================================*/
$(function(){
    $(".progress-bar").each(function(){
        $(this).animate({
            width: $(this).attr("aria-valuenow") + "%"
                        }, 1000);
        
    })
})
