SELECT * FROM Vehicles
SELECT * FROM Vehicletypes
SELECT * FROM VehicleMakes
SELECT * FROM VehicleModels 
SELECT * FROM VehicleBodyTypes

INSERT INTO VehicleTypes (Type)
SELECT 'Car'

INSERT INTO VehicleMakes (Make, VehicleTypeId)
SELECT 'Toyota',1 UNION
SELECT 'Hyundai',1 UNION
SELECT 'Mitsubishi',1 UNION
SELECT 'Land Rover',1 UNION
SELECT 'Chevrolet',1

INSERT INTO VehicleBodyTypes (BodyType)
SELECT 'Sedan' UNION
SELECT 'Wagon' UNION
SELECT 'People Mover' UNION
SELECT 'SUV' UNION
SELECT 'Hatch'UNION
SELECT 'Coupe' UNION
SELECT 'Convertible'

INSERT INTO VehicleModels (model, VehicleMakeId, VehicleBodyTypeId)
SELECT 'Camry',5,5 UNION
SELECT 'Camry',5,7 UNION
SELECT 'Alphard',5,4 UNION
SELECT 'Rav 4',5,6 UNION
SELECT 'Accent',2,3 UNION
SELECT 'Accent',2,5 UNION
SELECT 'Kona', 2,6 UNION
SELECT 'Genesis',2,5 UNION
SELECT 'Elantra', 2,3 UNION
SELECT 'Elantra', 2,5 UNION
SELECT 'Lancer', 4,2 UNION
SELECT 'Lancer', 4,3 UNION
SELECT 'Lancer', 4,5 UNION
SELECT 'Lancer', 4,7 UNION
SELECT 'Mirage',4,3 UNION
SELECT 'Mirage',4,5 UNION
SELECT 'Pajero Sport', 4,6 UNION
SELECT 'Discovery 4', 3,6 UNION
SELECT 'Range Rover Sport',3,6 UNION
SELECT 'Camaro', 1,1 UNION
SELECT 'Camaro', 1,2 UNION
SELECT 'Corvette', 1,1 UNION
SELECT 'Corvette', 1,2


