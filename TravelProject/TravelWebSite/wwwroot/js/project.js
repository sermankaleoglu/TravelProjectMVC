$(document).ready(function() {
    $('.nav-item.dropdown').hover(function() {
        $(this).find('.dropdown-menu').first().stop(true, true).slideDown(200);
    }, function() {
        $(this).find('.dropdown-menu').first().stop(true, true).slideUp(200);
    });
});






