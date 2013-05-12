var item = document.getElementById('nameItem');
var addButton = document.getElementById('addItem');
var showButton = document.getElementById('showItems');
var hideButton = document.getElementById('hideItems');
var taskList = document.getElementById('tasks');

addButton.addEventListener('click', addItem);
showButton.addEventListener('click', showList);
hideButton.addEventListener('click', hideList);

function addItem() {
	if (item.value) {
		var li = document.createElement('li');
		var p = document.createElement('p');
		var remove = document.createElement('button');
		remove.innerHTML = '\u2714';
		remove.id = 'remove';
		remove.type = 'button';
		remove.addEventListener('click', removeItem);

		var content = document.createTextNode(item.value);
		p.appendChild(content);
		li.appendChild(p);
		li.appendChild(remove);
		taskList.appendChild(li);
	}
}

function removeItem(ev) {
	taskList.removeChild(this.parentNode);
}

function showList() {
	taskList.style.display = 'block';
}

function hideList() {
	taskList.style.display = 'none';
}