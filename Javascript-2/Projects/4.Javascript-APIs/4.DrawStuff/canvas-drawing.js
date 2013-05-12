var canvasDoc = document.getElementById('canvas');

var canvas = canvasDoc.getContext('2d');
var black = "#000";

function drawHouse(houseColor) {

    canvas.fillStyle = houseColor;
    // Main body
    drawRect(400, 150, 200, 200);

    // Roof 
    canvas.beginPath();
    canvas.moveTo(600, 150);
    canvas.lineTo(500, 50);
    canvas.lineTo(400, 150);
    canvas.closePath();
    canvas.fill();
    canvas.stroke();

    // Chimney
    canvas.beginPath();
    canvas.moveTo(560, 120);
    canvas.lineTo(560, 70);
    canvas.lineTo(540, 70);
    canvas.lineTo(540, 120);
    canvas.stroke();
    canvas.fill();
    canvas.closePath();

    canvas.strokeStyle = black;
    canvas.lineWidth = 1;
    drawEllipse(540, 65, 20, 7);

    // Windows
    canvas.strokeStyle = houseColor;
    canvas.fillStyle = black;
    drawWindow(415, 170, 70, 50);
    drawWindow(515, 170, 70, 50);
    drawWindow(515, 240, 70, 50);

    // Door
    canvas.strokeStyle = black;
    canvas.fillStyle = houseColor;
    drawRect(415, 270, 70, 80);
    canvas.moveTo(415, 270);
    canvas.arc(450, 270, 35, 0, Math.PI, true);
    canvas.moveTo(450, 270);
    canvas.lineTo(450, 350);
    canvas.moveTo(440, 310);
    canvas.arc(440, 310, 4, 0, Math.PI * 2, true);
    canvas.moveTo(460, 310);
    canvas.arc(460, 310, 4, 0, Math.PI * 2, true);
    canvas.stroke();
    canvas.fill();
}

function drawHead(innerColor, outterColor, hatColor) {
    canvas.fillStyle = innerColor;
    canvas.strokeStyle = outterColor;
    canvas.lineWidth = 4;
    // Head
    drawEllipse(100, 300, 100, 90);
    // Eyes
    drawEllipse(120, 320, 20, 10);
    canvas.fillStyle = outterColor;
    drawEllipse(125, 320, 4, 10);
    canvas.fill();
    canvas.fillStyle = innerColor;
    drawEllipse(160, 320, 20, 10);
    canvas.fillStyle = outterColor;
    drawEllipse(165, 320, 4, 10);
    canvas.fill();
    // Nose
    canvas.moveTo(150, 335);
    canvas.lineTo(135, 360);
    canvas.moveTo(135, 360);
    canvas.lineTo(150, 360);
    canvas.stroke();
    // Mouth
    canvas.fillStyle = innerColor;
    drawEllipse(130, 370, 30, 10);
    // Hat
    canvas.fillStyle = hatColor;
    drawEllipse(80, 288, 120, 20);
    drawRect(125, 230, 50, 60);
    drawEllipse(125, 288, 50, 10);
    canvas.strokeStyle = hatColor;
    drawRect(128, 288, 44, 5);
    canvas.strokeStyle = outterColor;
    drawEllipse(125, 220, 50, 15);
}

function drawBike(frameColor, tiresColor) {

    canvas.fillStyle = frameColor;
    canvas.strokeStyle = tiresColor;
    canvas.lineWidth = 2;
    // Tires
    drawEllipse(90, 550, 100, 100);
    drawEllipse(290, 550, 100, 100);
    // Frame
    canvas.moveTo(140, 600);
    canvas.lineTo(200, 530);
    canvas.lineTo(325, 530);
    canvas.lineTo(225, 600);
    canvas.lineTo(140, 600);
    // Chain wheel
    canvas.moveTo(240, 600);
    canvas.arc(228, 600, 10, 0, Math.PI * 2, true);
    // Pedals
    canvas.moveTo(225, 593);
    canvas.lineTo(210, 580);
    canvas.moveTo(233, 608);
    canvas.lineTo(245, 617);
    // Bike Seat
    canvas.moveTo(230, 600);
    canvas.lineTo(190, 500);
    canvas.moveTo(170, 500);
    canvas.lineTo(210, 500);
    // Steering wheel
    canvas.moveTo(340, 600);
    canvas.lineTo(320, 490);
    canvas.lineTo(290, 500);
    canvas.moveTo(320, 490);
    canvas.lineTo(340, 470);
    canvas.stroke();
}

function drawLine(from, to) {
    canvas.moveTo(from.left, from.top);
    canvas.lineTo(to.left, to.top);
}

function drawRect(left, top, width, height) {
    canvas.strokeRect(left, top, width, height);
    canvas.fillRect(left + 1, top + 1, width - 2, height - 2);
}

function drawWindow(left, top, width, height) {
    drawRect(left, top, width, height);
    canvas.moveTo(left, top + height / 2);
    canvas.lineTo(left + width, top + height / 2);
    canvas.moveTo(left + width / 2, top);
    canvas.lineTo(left + width / 2, top + height);
    canvas.stroke();
}

function drawEllipse(x, y, w, h) {
    var kappa = .5522848,
        ox = (w / 2) * kappa, // control point offset horizontal
        oy = (h / 2) * kappa, // control point offset vertical
        xe = x + w, // x-end
        ye = y + h, // y-end
        xm = x + w / 2, // x-middle
        ym = y + h / 2; // y-middle

    canvas.beginPath();
    canvas.moveTo(x, ym);
    canvas.bezierCurveTo(x, ym - oy, xm - ox, y, xm, y);
    canvas.bezierCurveTo(xm + ox, y, xe, ym - oy, xe, ym);
    canvas.bezierCurveTo(xe, ym + oy, xm + ox, ye, xm, ye);
    canvas.bezierCurveTo(xm - ox, ye, x, ym + oy, x, ym);
    canvas.stroke();
    canvas.fill();
    canvas.closePath();
}

drawHouse("#975C60");
drawHead("#90CAD7", "#22545F", "#396693");
drawBike("#90CAD7", "#22545F");