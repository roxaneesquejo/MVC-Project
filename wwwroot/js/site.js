// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

window.onscroll = function () {
    const portfolioNavBar = document.getElementById("portfolio-navbar");
    if (window.scrollY > 100) {
        portfolioNavBar.style.display = "block";
    } else {
        portfolioNavBar.style.display = "none";
    }
};