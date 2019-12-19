

console.log("Hello Abdul Moiz");
var theForm =$("#theForm");
theForm.hide();

var button = $("buyButton");
button.on("click", function () {
    console.log("Thanks for Buying");
});

var productInfo = $(".product-props li");
productInfo.on("click", function () {
    console.log("You Clicked On " + $(this).text());
});

var $loginToggle = $("#loginToggle");
var $popupForm = $(".popup-form");

$loginToggle.on("click", function () {
    $popupForm.slideToggle()
});