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
	div.style.width = generate(100, 20) + "px";
	div.style.height = generate(100, 20) + "px";
	div.style.color = generateColor();
	div.style.border = generate(20) + "px solid";
	div.style.borderColor = generateColor();
	div.style.borderRadius = generate(100) + 'px';
	div.style.left = generate(window.innerWidth - 150) + 'px';
	div.style.top = generate(window.innerHeight - 150) + 'px';
	document.body.appendChild(div);
}

function generateDivs() {

	for (var i = 0; i < generate(1000); i++) {
		onAddDiv();
	};
}
generateDivs();