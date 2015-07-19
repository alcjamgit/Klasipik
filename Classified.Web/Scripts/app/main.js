(function () {

    //#region Search Bar Popup
    //Hide search bar pop out on blur of the search box, except when the next focus is the popout
    //http://stackoverflow.com/questions/8973532/blur-vs-focusout-any-real-differences
    $(document).mouseup(function (e) {
        var container = $(".devsite-search-form");

        if (!container.is(e.target) // if the target of the click isn't the container...
            && container.has(e.target).length === 0) // ... nor a descendant of the container
        {
            $(".devsite-popout").addClass("devsite-popout-closed");
            $(".devsite-search-wrapper").removeClass("devsite-search-active");
            $(".devsite-search-image").removeClass("active");
            
        }
    });

    $(".devsite-search-query").bind("focus", function () {
        $(".devsite-search-wrapper").addClass("devsite-search-active");
        $(".devsite-popout").removeClass("devsite-popout-closed");
        $(".devsite-search-image").addClass("active");
        
    });

    //#endregion

    //#region Search Banner on small screens
    $("#search-sm").on("click", showSearchBar);
    $("#searchbar-close").on("click", hidSearchBar);
    //$("#search-sm").on("focusout", hidSearchBar);

    function showSearchBar() {
        var searchContainer = $("#searchbar").addClass("open");
        searchContainer.find("input:text:first").focus();
    }
    function hidSearchBar() {
        $("#searchbar").removeClass("open");
    }
    //#endregion

}());

