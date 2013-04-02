//var args = ["8", "1", "6", "-9", "4", "4", "-2", "10", "-1"];
var args = ["1", "-1"];

console.log(Solve(args));



function Solve(args) {

	Array.prototype.clean = function(deleteValue) {
		for (var i = 0; i < this.length; i++) {
			if (this[i] == deleteValue) {
				this.splice(i, 1);
				i--;
			}
		}
		return this;
	};
	var numberOfItems = parseInt(args[0]);

	//Parse logic
	var numbers = [];
	var i = 0
	for (i = 1; i <= numberOfItems; i++) {
		numbers[i] = parseInt(args[i]);

	}
	numbers.clean();

	return test2(numbers);


	/*function SubSequence(a) {
		var now = 0;
		var prev = 0;
		var first = Math.max(-999999999999999, a[0]);
		for (i = 0; i < a.length; i++) {
			prev = Math.max(0, (prev + a[i]));

			now = Math.max(prev, now);
		}
		return now;
	}
*/
	function test2(a) {
		var max_so_far = a[0];
		var max_ending_here = 0;
		var max_element = a[0];
		for (var i = 0; i < a.length; i++) {
			max_ending_here = Math.max(max_ending_here + a[i], 0);
			max_so_far = Math.max(max_ending_here, max_so_far);
			max_element = Math.max(max_element, a[i]);
		}

		if (max_so_far == 0) max_so_far = max_element;

		return max_so_far; // body...
	}
}
//Other stuff