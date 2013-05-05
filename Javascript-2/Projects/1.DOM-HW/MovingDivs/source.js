function generate(to, from) {
	if (!from) {
		from = 0;
	}
	return Math.floor(Math.random() * (to - from + 1) + from);
}

function generateColor() {
	var blue = generate(255);
	var red = generate(255);
	var green = generate(255);
	var rgb = "rgb(" + red + "," + green + "," + blue + ")";
	return rgb;
}

function onAddDiv() {

	var div = document.createElement('div');
	div.innerHTML = "div";
	div.style.position = 'absolute';
	div.style.backgroundColor = generateColor();
	div.style.width = 50 + "px";
	div.style.height = 50 + "px";
	div.style.margin = (window.innerWidth / 2) + 'px';
	div.style.marginLeft = (window.innerWidth / 2 - 25) + 'px';
	div.style.marginTop = (window.innerHeight / 2 - 25) + 'px';
	div.style.borderRadius = '100px';
	document.body.appendChild(div);
}

function generateDivs() {

	for (var i = 0; i < 5; i++) {
		onAddDiv();
	};
}
generateDivs();
var angle = 0;
var radius = 50;

function rotateDivs() {
	var selectedDivs = document.querySelectorAll('div');
	for (var i = 0, len = selectedDivs.length; i < len; i++) {
		selectedDivs[i].style.top = (Math.sin(angle + 2 * Math.PI / len * i) / radius * 5000) + 'px';
		selectedDivs[i].style.left = (Math.cos(angle + 2 * Math.PI / len * i) / radius * 5000) + 'px';
	};
	angle += 0.2;
	setTimeout(rotateDivs, 80);
}

rotateDivs();