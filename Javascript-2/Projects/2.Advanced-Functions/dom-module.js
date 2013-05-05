 var domModule = (function() {
 	var elementBuffer = {};

 	var MaxBufferSize = 100;

 	function addHandler(selector, eventType, eventHandler) {

 		var element = getElement(selector);
 		if (element.addEventListener) {
 			element.addEventListener(eventType, eventHandler, false);
 		} else {
 			element.attachEvent("on" + eventType, eventHandler);
 		}
 	}

 	function appendToBuffer(parentSelector, tag, innerHTML) {
 		if (!elementBuffer[parentSelector]) {
 			elementBuffer[parentSelector] = document.createDocumentFragment();
 		}
 		var element = createElement(tag, innerHTML);
 		elementBuffer[parentSelector].appendChild(element);
 		if (elementBuffer[parentSelector].childNodes.length === MaxBufferSize) {
 			var parent = getElement(parentSelector);
 			parent.appendChild(elementBuffer[parentSelector]);
 			elementBuffer[parentSelector] = null;
 		}
 	}

 	function createElement(tag, innerHTML) {

 		var child = document.createElement(tag);
 		child.innerHTML = innerHTML;
 		return child;
 	}

 	function getElement(selector) {
 		return document.querySelector(selector);
 	}

 	function getAllElements(selector) {
 		return document.querySelectorAll(selector);
 	}

 	function addElement(parentSelector, tag, innerHTML) {

 		var parent = getElement(parentSelector);
 		var newChild = createElement(tag, innerHTML);
 		parent.appendChild(newChild);
 	}

 	function removeElements(parentSelector, childSelector) {
 		var elementsToRemove = getAllElements(parentSelector + " " + childSelector);
 		for (var i = 0; i < elementsToRemove.length; i++) {
 			elementsToRemove[i].parentNode.removeChild(elementsToRemove[i]);
 		}
 	}
 	return {
 		addElement: addElement,
 		getElement: getElement,
 		getAllElements: getAllElements,
 		removeElements: removeElements,
 		addHandler: addHandler,
 		appendToBuffer: appendToBuffer
 	}
 })();