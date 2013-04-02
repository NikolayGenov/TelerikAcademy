var args = ["5 8",
	"0 0",
	"rrrrrrrd",
	"rludulrd",
	"drrrrrrd",
	"urrrrrrd",
	"ulllllll", ];
console.log(Solve(args));


function Solve(args) {
	//Split logic
	var dim = args[0].split(" ");
	var result = null;
	var position = args[1].split(" ");

	var sum = 0;
	var status = '';
	//Parse array
	var matrix = newMultiArray(parseInt(dim[0]), parseInt(dim[1]), args);
	return moveInArray(dim, position, matrix);


	function moveInArray(dim, position, matrix) {
		var curPosRow = parseInt(position[0]);

		var curPosCol = parseInt(position[1]);


		var counter = 0;
		var rows = parseInt(dim[0]),
			cols = parseInt(dim[1]);
		var status = '';
		var visitedArr = visited(rows, cols);
		var sum = 0;
		var value = '';

		while (true) {


			if (curPosCol == cols || curPosCol < 0 || curPosRow < 0 || curPosRow == rows) {
				status = "out";
				break;
			}
			if (visitedArr[curPosRow][curPosCol] == true) {

				return "lost " + counter;
				break;
			}
			value = matrix[curPosRow][curPosCol];

			visitedArr[curPosRow][curPosCol] = true;
			counter++;
			sum += (curPosCol + 1) + (curPosRow * cols);
			switch (value) {
				case "l":
					{
						curPosCol--;
					}
					break;

				case "r":
					{

						curPosCol++
					}
					break;

				case "u":
					{

						curPosRow--;
					}
					break;

				case "d":
					{

						curPosRow++;
					}
					break;
			}



		}

		return status + " " + sum;
	}

	function visited(rows, cols) {
		var matrix = [];
		var i = 0;
		var j = 0;

		for (i = 0; i < rows; i++) {

			matrix[i] = new Array(rows);

			for (j = 0; j < cols; j++) {
				matrix[i][j] = false;
			}
		}

		return matrix;
	}

	function newMultiArray(rows, cols, args) {
		var matrix = [];
		var i = 0;
		var j = 0;

		for (i = 0; i < rows; i++) {

			var row = args[i + 2].split("");
			matrix[i] = new Array(rows);

			for (j = 0; j < cols; j++) {
				matrix[i][j] = row[j];
			}
		}

		return matrix;
	}
	//Other stuff



	return result;
}