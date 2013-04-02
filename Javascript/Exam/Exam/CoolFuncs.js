function newString(char, times) {
	var outString = "";
	var i = 0;

	for (i = 0; i < times; i++) {
		outString += char;
	}

	return outString;
}


String.prototype.isNumeric = function() {
	return parseFloat(this) == this;
}

//another
Array.prototype.max = function() {
	return Math.max.apply(null, this)
}

Array.prototype.min = function() {
	return Math.min.apply(null, this)
}
String.prototype.endsWith = function(suffix) {
	return this.indexOf(suffix, this.length - suffix.length) !== -1;
};
}


function newArr(length) {
	var arr = new Array(length);
	for (var i = 0; i < length; i++) {
		arr[i] = 0;
	}
	return arr;
}

function newMultiArray(rows, cols) {
	var matrix = [];
	var i = 0;
	var j = 0;

	for (i = 0; i < rows; i++) {

		matrix[i] = new Array(rows);

		for (j = 0; j < cols; j++) {
			matrix[i][j] = 0;
		}
	}

	return matrix;
}

function reverse(s) {
	return s.split("").reverse().join("");
}

function buildStringBuilder() {
	return {
		strs: [],
		len: 0,
		append: function(str) {
			this.strs[this.len++] = str;
			return this;
		},
		toString: function() {
			return this.strs.join("");
		}
	}
};

function isDigit(aChar) {
	myCharCode = aChar.charCodeAt(0);

	if ((myCharCode > 47) && (myCharCode < 58)) {
		return true;
	}

	return false;
}

function isLetter(str) {
	return str.length === 1 && str.match(/[a-z]/i);
}