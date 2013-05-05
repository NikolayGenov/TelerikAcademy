var textArea = document.getElementsByTagName("textarea")[0];

function getColorValue(id) {
	return document.getElementById(id).value;
}

function changeFontColor() {
	textArea.style.color = getColorValue("first");
}

function changeBackgroundColor() {
	textArea.style.backgroundColor = getColorValue("second");
}