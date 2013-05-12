var ball = document.getElementById('ball');
//Box 
var rightBound = 680;
var bottomBound = 380;

var leftBound = 10;
var topBound = 10;
var steps = 10;

var speed = 25;
//Directions
var direction = 'botLeft';
var ballLeftPos = leftBound;
var ballTopPos = topBound;

function moveBall() {
	switch (direction) {
		case 'botRight':
			{
				if (ballLeftPos >= rightBound) {
					direction = 'botLeft';
					botLeft();
				} else if (ballTopPos >= bottomBound) {
					direction = 'topRight';
					topRight();
				} else {
					botRight();
				}
			}
			break;
		case 'botLeft':
			{
				if (ballLeftPos <= leftBound) {
					direction = 'botRight';
					botRight();
				} else if (ballTopPos >= bottomBound) {
					direction = 'topLeft';
					topLeft();
				} else {
					botLeft();
				}
			}
			break;
		case 'topRight':
			{
				if (ballLeftPos >= rightBound) {
					direction = 'topLeft';
					topLeft();
				} else if (ballTopPos <= topBound) {
					direction = 'botRight';
					botRight();
				} else {
					topRight();
				}
			}
			break;
		case 'topLeft':
			{
				if (ballLeftPos <= leftBound) {
					direction = 'topRight';
					topRight();
				} else if (ballTopPos <= topBound) {
					direction = 'botLeft';
					botLeft();
				} else {
					topLeft();
				}
			}
			break;
	}

	ball.style.left = ballLeftPos + 'px';
	ball.style.top = ballTopPos + 'px';
	setTimeout(moveBall, speed);
}

function botRight() {
	ballLeftPos += steps + 1;
	ballTopPos += steps;
}

function botLeft() {
	ballLeftPos -= steps + 1;
	ballTopPos += steps;
}

function topRight() {
	ballLeftPos += steps + 1;
	ballTopPos -= steps;
}

function topLeft() {
	ballLeftPos -= steps + 1;
	ballTopPos -= steps;
}

moveBall();