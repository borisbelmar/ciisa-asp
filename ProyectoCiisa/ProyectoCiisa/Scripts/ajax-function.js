function loadDoc(doc, id) {
    var xhttp = new XMLHttpRequest();
    var doc;
    var id;
    // El constructor funciona colocando la dirección del archivo a invocar y la ID en donde se alojará en el DOM
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById(id).innerHTML =
                this.responseText;
        }
    };
    xhttp.open("GET", doc, true);
    xhttp.send();
}