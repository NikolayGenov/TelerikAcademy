function Vehicle() {
	var speed = 0;
	var propulsionUnits = [];

	this.addPropulsionUnit = function(unit) {
		propulsionUnits.push(unit);
	}
	this.calculateSpeed = function() {
		speed = 0;
		for (var i = 0; i < propulsionUnits.length; i++) {
			speed += propulsionUnits[i].getAcceleration();
		}
	}
	this.getSpeed = function() {
		return speed;
	}
}

function PropulsionUnit() {
	var acceleration = 0;

	this.setAcceleration = function(accel) {
		this.acceleration = accel;
	}

	this.getAcceleration = function() {
		return this.acceleration;
	}
}

function Wheel(radius) {
	PropulsionUnit.call(this);
	this.setAcceleration(2 * Math.PI * radius);

}
Wheel.prototype = Object.create(PropulsionUnit.prototype);

function PropellingNozzle(afterburnOn, power) {
	PropulsionUnit.call(this);
	if (afterburnOn) {
		this.setAcceleration(2 * power);

	} else {
		this.setAcceleration(power);
	}

}
PropellingNozzle.prototype = Object.create(PropulsionUnit.prototype);

function Propeller(numberOfFins, spinDirection) {
	PropulsionUnit.call(this);
	if (spinDirection) {
		this.setAcceleration(numberOfFins);
	} else {
		this.setAcceleration(-1 * numberOfFins);
	}
}
Propeller.prototype = Object.create(PropulsionUnit.prototype);

function LandVehicle(numberOfWheels, wheelRadius) {
	Vehicle.call(this);
	var wheel = new Wheel(wheelRadius);

	for (var i = 0; i < numberOfWheels; i++) {
		this.addPropulsionUnit(wheel);
	}
	this.calculateSpeed();
}


LandVehicle.prototype = Object.create(Vehicle.prototype);

function Aircraft() {
	Vehicle.call(this);
	this.addNozzle = function(afterburnOn, power) {
		this.addPropulsionUnit(new PropellingNozzle(afterburnOn, power));
		this.calculateSpeed();
	}
}

Aircraft.prototype = Object.create(Vehicle.prototype);

function WaterVehicle() {
	Vehicle.call(this);
	this.addPropeller = function(numberOfFins, spinDirection) {
		this.addPropulsionUnit(new Propeller(numberOfFins, spinDirection));
		this.calculateSpeed();
	}
}
WaterVehicle.prototype = Object.create(Vehicle.prototype);

function AmphibiousVehicle(mode) {
	Vehicle.call(this);
	switch (mode) {
		case 'land':
			LandVehicle.call(this, 4, 20);
			break;
		case 'water':
			WaterVehicle.call(this);
			break;
		case 'air':
			Aircraft.call(this);
			break;
	}
}
AmphibiousVehicle.prototype = Object.create(Vehicle.prototype);