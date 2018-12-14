function calcHeight() {
    var the_height =
        document.getElementById("iframes").contentWindow.
            document.body.scrollHeight;
    document.getElementById("iframes").height =
        parseInt(the_height) + 10;
}