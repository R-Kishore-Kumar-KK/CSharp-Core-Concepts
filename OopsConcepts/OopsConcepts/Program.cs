using OopsConcepts;

Car car = new Car();
car.speed = 120;
car.model = "Sedan";

car.showSpeed();
car.showModel();

ElectricCar ec = new ElectricCar();
ec.speed = 100;
ec.model = "Tesla";
ec.batteryLevel = 80;

ec.showSpeed();
ec.showModel();
ec.showBattery();

Car car1 = new Car();
car1.speed = 130;
car1.model = "Nexon";

Bike bike = new Bike();
bike.speed = 150;
bike.type = "Yamaha";

car1.showSpeed();
car1.showModel();

bike.showSpeed();
bike.showType();