/**External Javascript File for Responsively Designed - Project Portfolio */
/**
 * Function 1/2 - Function to open and close the menu bar whilst in full screen mode 
 * Dev note: work around due to getElementById bug in ASP.NET core. seems to note like overloaded function
 */
 function openNav() {
    document.getElementById("nav_wrapper").style.opacity = "1";
    document.getElementById("nav_wrapper").style.width = "27%";
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
