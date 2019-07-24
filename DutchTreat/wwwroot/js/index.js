$(document).ready(function () { 
    var x = 0;
    var s = "";

    //alert("Hello Pluralsight");

    console.log("Hello Pluralsight");

    //var theform = document.getElementById("theform");
    //theform.hidden = true;

    //var button = document.getElementById("buybutton");
    //button.addEventListener("click", function () {
        //alert("Buying Item");
        //console.log("Buying Item"); //Mejor opción para ver los pasos, repeticiones y mostrar porconsola
    //});

    //function buyButton_Handler() { }

    //var productInfo = document.getElementsByClassName("product-props");
    //var listItems = productInfo.item[0].children;

    //sintaxys JQUERY

    var theform = $("#theform");
    theform.hide();

    var button = $("#buybutton");
    button.on("click", function () {
        console.log("Buying Item"); 
    });

    var productInfo = $(".product-props li"); //Aquí me traigo de la ul los hijo q son las li
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());    //this sería .product-props li y se trae el valor del texto 
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.toggle(1000);
    }); //tambien se puede hacer de otras formas con $popupForm.show(); ó $popupForm.css("display") == "none"; los 1000 es opcional para determinr el tiempo para mostrr
        // $popupForm.slideToggle(1000);
        // $popupForm.fadeToggle(1000);


});


