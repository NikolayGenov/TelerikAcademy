function onButtonClick(event, arguments) {
    var localWindow = window;
    var localBrowser = localWindow.navigator.appCodeName;
    var isMozila = (localBrowser == "Mozilla");
    if (isMozila) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}