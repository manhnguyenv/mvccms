function MenuDropdownMobile(){
        if ($('.main-menu').length) {
        $('.main-menu nav ul li.dropdown-holder').append(function() {
            return '<i class="fa fa-angle-down" aria-hidden="true"></i>';
        });
        $('.main-menu nav ul li.dropdown-holder .fa').on('click', function() {
            $(this).parent('li').children('ul').slideToggle();
        });
    }
   }




function stickyHeader(){
    if ($('.main-menu').length) {
        var sticky = $('.main-menu'),
            scroll = $(window).scrollTop();
        if (scroll >= 190) sticky.addClass('fixed');
        else sticky.removeClass('fixed');
    };
}


function BannerSliderTwo() {
    if ($("#main-banner-slider-two").length) {
        $("#main-banner-slider-two").revolution({
            sliderType: "standard",
            sliderLayout: "auto",
            loops: false,
            delay: 7000,
            navigation: {
                arrows: {
                    style: "hermes",
                    enable: true,
                    hide_onmobile: false,
                    hide_onleave: false,
                    tmp: '<div class="tp-arr-allwrapper"> <div class="tp-arr-imgholder"></div>  <div class="tp-arr-titleholder">{{title}}</div> </div>',
                    left: {
                        h_align: "left",
                        v_align: "center",
                        h_offset: 0,
                        v_offset: 60
                    },
                    right: {
                        h_align: "right",
                        v_align: "center",
                        h_offset: 0,
                        v_offset: 60
                    }
                },
                bullets: {
                    enable: true,
                    hide_onmobile: false,
                    style: "uranus",
                    hide_onleave: false,
                    direction: "horizontal",
                    h_align: "center",
                    v_align: "bottom",
                    h_offset: -15,
                    v_offset: 30,
                    space: 10,
                    tmp: '<span class="tp-bullet-inner"></span>'
                }
            },
            responsiveLevels: [2220, 1183, 975, 751],
            gridwidth: [1170, 970, 770, 350],
            gridheight: [920, 920, 920, 700],
            shadow: 0,
            spinner: "off",
            autoHeight: "off",
            disableProgressBar: "on",
            hideThumbsOnMobile: "off",
            hideSliderAtLimit: 0,
            hideCaptionAtLimit: 0,
            hideAllCaptionAtLilmit: 0,
            debugMode: false,
            fallbacks: {
                simplifyAll: "off",
                disableFocusListener: false,
            }
        });
    };
}

function scrollToTop() {
    if ($('.scroll-top').length) {
        $(window).on('scroll', function() {
            if ($(this).scrollTop() > 200) {
                $('.scroll-top').fadeIn();
            } else {
                $('.scroll-top').fadeOut(1000);
            }
        });
        $('.scroll-top').on('click', function() {
            $('html, body').animate({
                scrollTop: 0
            }, 1500);
            return false;
        });
    }
}


jQuery(document).on('ready', function() {
    MenuDropdownMobile();
    BannerSliderTwo();
    scrollToTop();
});





jQuery(window).on('scroll', function() {
    (function($) {
        stickyHeader();
    })(jQuery);
});