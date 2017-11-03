/**External Javascript File for Responsively Designed - Project Portfolio */
/**
 * Function 1 - openNav() Function to open the menu bar whilst in full screen or responsive mode 
 * Function 2 - closeNav() Function to close the menu bar whilst in full screen mode or responsive mode
 * Function 3 - slider() Listener function is a btn_expand class event listener for click events to expand project details 
 * Function 4 - JQuery / JavaScript function to allow auto scroll back to top of view
 * Function 5 - scrollUp() Scroll back to top of page when clicked
 * Function 6 - swapImage(id,imageList) Swaps Image out from list supplied as an argument
 * Function 7 -loadImages() Loads up images for slideshows on view
 * Dev note: work around due to getElementById bug in ASP.NET core. seems to note like overloaded function
 */
 function openNav() {
    document.getElementById("nav_wrapper").style.opacity = "1";
    document.getElementById("nav_wrapper").style.width = "22%";
    document.getElementById("nav_wrapper").style.height = "auto";
    document.getElementById("navbar_tab").style.display = "none";
    document.getElementById("nav").style.display = "inline";
    document.getElementById("nav").style.width = "90%";
    document.getElementById("nav").style.height = "auto";
    document.getElementById("unrestricted_nav").style.width = "88%";
    document.getElementById("unrestricted_nav").style.height = "auto";
 }

function closeNav() {
    document.getElementById("nav_wrapper").style.width = "6%";
    document.getElementById("nav_wrapper").style.height = "13%";
    document.getElementById("nav_wrapper").style.opacity = "0.5";
    document.getElementById("nav").style.display = "none";
    document.getElementById("navbar_tab").style.display = "inline";
 }

$(document).ready(function slider() {
    $(".portfolio_entry_detail").hide();
    $(".btn_expand").click(function() {
        $(this).next("div").slideToggle(500); 
    });
});

$(document).ready(function() {
    $("#back_to_top").hide();
    $(window).scroll(function() {
        if($(window).scrollTop() >= 200){
            $('#back_to_top').fadeIn();
        } else {
            $('#back_to_top').fadeOut();
        }
    });
});

function scrollUp() {
    window.scrollTo(5,5);
}

function swapImage(id, imageList) {
    var htmlSlideshowId = document.getElementById(id);
    htmlSlideshowId.count = (htmlSlideshowId.count < 3) ? htmlSlideshowId.count : 0;
    htmlSlideshowId.src = imageList[htmlSlideshowId.count];
    htmlSlideshowId.count = (htmlSlideshowId.count + 1); imageList.length;
}


function loadImages() {
    setInterval(function() {
        swapImage('slideshow_csharp', [
            "~/Images/imgLogoCSharpVS.jpg",
            "~/Images/imgLogoMicrosoftSQLServer.png",
            "~/Images/imgLogoJava8.png"
        ]);
        swapImage('slideshow_bash', [
            "~/Images/imgLogoBash.png",
            "~/Images/imgLogoDotNet.png",
            "~/Images/imgLogoPostgreSQL.png"
        ]);
        swapImage('slideshow_xml', [
            "~/Images/imgLogoXML.png",
            "~/Images/imgLogoASPNETMVC.png",
            "~/Images/imgLogoHtml5Css3Js.png" 
        ]);
        swapImage('slideshow_android', [
            "~/Images/imgLogoAndroid.png",
            "~/Images/imgLogoAngular4TS.png",
            "~/Images/imgLogoMySQL.png"    
        ]);
        swapImage('slideshow_python', [
            "~/Images/imgLogoPython.png",
            "~/Images/imgLogoLinux.png",
            "~/Images/imgLogoFirebase.jpg"
        ]);
    }, 3000);
}
