(function() {
	function each(elements, callback) {
		for (var i = 0; i < elements.length; i++) {
			callback.call(elements[i], i)
		}
	}

	each(document.querySelectorAll('.carousel'), function() {
		var panels = this.querySelector('.carousel-panels'),
			totalPanels = panels.querySelectorAll('.carousel-panel').length,
			currentPanel = 0;

		function change(delta) {
			currentPanel = (currentPanel + delta + totalPanels) % totalPanels;

			panels.style.left = -(currentPanel * 100) + '%';
		}

		this.querySelector('.arrow-left').addEventListener('click', function() {
			change(-1);
		})

		this.querySelector('.arrow-right').addEventListener('click', function() {
			change(1);
		})
	})
}());