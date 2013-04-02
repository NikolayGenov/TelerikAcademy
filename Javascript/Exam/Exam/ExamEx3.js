var args = ["def func sum [5, 3, 7, 2, 6,3]",
	"def func2 [5, 3, 7, 2, 6,3]",
	"def func3 min [func2]",
	"def func4 max [5, 3, 7, 2, 6,3]",
	"def func5 avg [5, 3, 7, 2, 6,3]",
	"def func6 sum [func2,func3,func4]", , , ,
	"sum [func6,func4]"];
console.log(Solve(args));


function Solve(args) {
	//Split logic

	Object.prototype.getKeyByValue = function(value) {
		for (var prop in this) {
			if (this.hasOwnProperty(prop)) {
				if (this[prop] === value) return prop;
			}
		}
	}

	Array.prototype.clean = function(deleteValue) {
		for (var i = 0; i < this.length; i++) {
			if (this[i] == deleteValue) {
				this.splice(i, 1);
				i--;
			}
		}
		return this;
	};

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

	function readInput(args) {
		var comands = [];
		var i = 0
		for (i = 0; i < args.length; i++) {
			comands[i] = args[i];
		}
		comands.clean();
		return comands;
		//Check for minus TODO 
	}
	//console.log(readInput(args))
	var inputStrings = readInput(args);

	processCom(inputStrings);

	function processCom(inputString) {
		var vars = [];
		var varCount = 0;
		var curValues;
		var cmds = [];

		var lines;
		//console.log(inputString.length);
		for (i = 0; i < inputString.length; i++) {
			var input = inputString[i];
			var OneVar = "";
			//get variables names
			if (input.indexOf("def") != -1) {
				input = getVarName(input, vars);

				var OneVar = vars[varCount];

				if (input.indexOf("[") != 0) {
					input = getComand(input, cmds);
					OneVar = getArrValues(input);
					varCount++;


				} else {
					return
				}

			} else {
				input = getComand(input, cmds);
				//logic here..
			}

			if (vars) {
				lines = doCalculation(vars, cmds, OneVar, i);
			} else return doCalculationOne(OneVar);
			console.log(OneVar);

		};
		//get comands

	}

	function doCalculation(vars, cmds, curValues) {

		switch (cmds[0]) {
			case "sum":
				{
					var sum = 0;
					for (var i = 0; i < curValues.length; i++) {
						sum += parseInt(curValues[i]);
					};

					return sum;

				}
				break;
			case "min":
				{
					return curValues.min();
				}
				break;
			case "max":
				{
					return curValues.max();
				}
				break;
			case "avg":
				{
					return Math.floor(curValues.avg);
				}
				break;
		}
	}

	function getVarName(input, vars) {
		input = input.replace("def", "");
		input = input.trimLeft();
		var keyValue = input.substring(0, input.indexOf(" "));

		input = input.replace(keyValue, "")
		input = input.trimLeft();
		vars.push(keyValue);
		return input;
	}

	function getComand(input, cmds) {

		var cmd = input.substring(0, input.indexOf("["));
		cmd = cmd.trim();
		input = input.replace(cmd, "");
		input = input.trimLeft();
		cmds.push(cmd);
		return input;
	}

	function getArrValues(input) {

		var allValues = [];
		input = input.replace("]", "");
		input = input.replace("[", "");
		input = input.replace(/ /g, '')
		allValues = input.split(',');


		return allValues;
		//console.log(values);

	}

	function doCalculationOne(curValues) {
		return curValues;
	}


	/*var obj = {
		key1: value1,
		key2: value2
	};
	object["property"] = value;
	//Other stuff
	*/



	return;

}