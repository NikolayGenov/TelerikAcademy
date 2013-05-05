 var specialConsole = (function() {

 	function formatString(args) {
 		var msg = args[0];
 		var numberStr;
 		for (var i = 1; i < args.length; i++) {
 			numberStr = '{' + parseInt(i - 1) + '}';
 			msg = msg.replace(numberStr, args[i]);
 		}
 		return msg.toString();
 	}

 	function writeLine() {
 		var output = formatString(arguments);
 		console.log(output);
 	}

 	function writeError() {
 		var output = formatString(arguments);
 		console.error(output);
 	}

 	function writeWarning() {
 		var output = formatString(arguments);
 		console.warn(output);
 	}

 	return {
 		writeLine: writeLine,
 		writeError: writeError,
 		writeWarning: writeWarning
 	}
 })();