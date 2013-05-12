var allTrash = document.getElementsByClassName('trash');
var trashCounter = allTrash.length;
var timer,
startTime,
endTime,
elapsedTime;

var trashCan = document.getElementById('conn'),
	startButton = document.getElementById('startButton'),
	newGameButton = document.getElementById('newGameButton'),
	i;

var saveScoreBox = document.getElementById('nick'),
	submitScoreButton = document.getElementById('submitScore');

var statistic = document.getElementById('statistic'),
	list = statistic.querySelectorAll('.user');

trashCan.addEventListener('mouseout', onMouseOut);
startButton.addEventListener('click', onStartClick);
newGameButton.addEventListener('click', onNewGameClick);
submitScoreButton.addEventListener('click', onClickSubmitScore);

for (i = 0; i < allTrash.length; i += 1) {
	allTrash[i].style.top = generateNumber() + 'px';
	allTrash[i].style.left = generateNumber() + 350 + 'px';
}

function allowDrop(ev) {
	ev.target.src = 'images/trash-open.jpg';
	ev.preventDefault();
}

function drag(ev) {
	ev.dataTransfer.setData("Text", ev.target.id);
}

function drop(ev) {
	ev.preventDefault();
	var data = ev.dataTransfer.getData("Text");
	ev.target.appendChild(document.getElementById(data));

	trashCounter--;

	if (trashCounter == 0) {
		calcElapsedTime();
		saveScoreBox.style.display = 'block';
		displayResult();
	}
}

function displayResult() {
	var score = document.getElementById("score");
	var scoreTime = document.createElement('p');
	scoreTime.innerHTML = elapsedTime;
	while (scoreTime.firstChild) {
		score.appendChild(scoreTime.firstChild);
	}
}

function onStartClick(ev) {
	ev.target.style.display = 'none';
	statistic.style.display = 'none';
	makeDraggable();
	timer = new Date();
	startTime = timer.getTime();
}

function makeDraggable() {
	for (i = 0; i < allTrash.length; i++) {
		allTrash[i].draggable = true;
	}
}

function onMouseOut(ev) {
	ev.target.src = 'images/trash-closed.jpg';
}

function calcElapsedTime() {
	timer = new Date();
	endTime = timer.getTime();
	elapsedTime = (endTime - startTime) / 1000;
}

function saveResult(scoreBoard) {
	for (i = 0; i < 5; i++) {
		sessionStorage.setItem(scoreBoard[i].nick, scoreBoard[i].score);
	}
}

function generateNumber() {
	return Math.floor(Math.random() * 666);
}

function getNick() {
	return document.getElementById('name').value;
}

function getLength(obj) {
	return obj.length <= 5 ? obj.length : 5;
}

function getscoreBoard() {
	var scoreBoard = [];
	var scoreBoardLength = getLength(sessionStorage);

	for (i = 0; i < scoreBoardLength; i++) {
		var nick = sessionStorage.key(i);
		var score = sessionStorage.getItem(nick);

		scoreBoard.push({
			nick: nick,
			score: parseFloat(score)
		});

		scoreBoard.sort(function(firstScore, secondScore) {
			return firstScore.score - secondScore.score;
		});
	}
	return scoreBoard;
}

function updatescoreBoard(scoreBoard) {
	var pushed = false;
	var userCount = getLength(scoreBoard);

	for (i = userCount - 1; i >= 0; i--) {
		if (parseFloat(scoreBoard[i].score) > elapsedTime) {
			scoreBoard.splice(i, 0, {
				nick: getNick(),
				score: elapsedTime
			});
			pushed = true;
			break;
		}
	}

	if (!pushed && userCount < 5) {
		scoreBoard.push({
			nick: getNick(),
			score: elapsedTime
		});
	}

	if (scoreBoard.length > 5) scoreBoard.pop();

	return scoreBoard;
}

function updateStatistics() {
	var scoreBoard = [];

	if (sessionStorage.length == 0) {
		scoreBoard.push({
			nick: getNick(),
			score: elapsedTime
		});
	} else {
		scoreBoard = getscoreBoard();
		scoreBoard = updatescoreBoard(scoreBoard);
	}
	sessionStorage.clear();
	return scoreBoard;
}

function onClickSubmitScore() {
	var scoreBoard = updateStatistics();
	statistic.style.display = 'block';
	saveScoreBox.style.display = 'none';
	newGameButton.style.display = 'block';

	for (i = 0; i < scoreBoard.length; i++) {
		var userContent = scoreBoard[i].nick + ': ' + scoreBoard[i].score
		list[i].innerHTML = userContent;
	}
	saveResult(scoreBoard);
}

function onNewGameClick() {
	location.reload();
}