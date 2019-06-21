SELECT * FROM Vehicletypes
SELECT * FROM VehicleMakes
SELECT * FROM VehicleModels
SELECT * FROM VehicleBodyTypes

INSERT INTO VehicleTypes (Type)
SELECT 'Car'

INSERT INTO VehicleMakes (Make)
SELECT 'Toyota' UNION
SELECT 'Hyundai' UNION
SELECT 'Mitsubishi' UNION
SELECT 'Land Rover' UNION
SELECT 'Chevrolet'

INSERT INTO VehicleModels (model, VehicleMakeId, VehicleBodyTypeId)
SELECT 'Camry',1,5 UNION
SELECT 'Camry',1,7 UNION
SELECT 'Alphard',1,4 UNION
SELECT 'Rav 4',1,6 UNION
SELECT 'Accent',2,3 UNION
SELECT 'Accent',2,5 UNION
SELECT 'Kona', 2,6 UNION
SELECT 'Genesis',2,5 UNION
SELECT 'Elantra', 2,3 UNION
SELECT 'Elantra', 2,5 UNION
SELECT 'Lancer', 3,2 UNION
SELECT 'Lancer', 3,3 UNION
SELECT 'Lancer', 3,5 UNION
SELECT 'Lancer', 3,7 UNION
SELECT 'Mirage',3,3 UNION
SELECT 'Mirage',3,5 UNION
SELECT 'Pajero Sport', 3,6 UNION
SELECT 'Discovery 4', 4,6 UNION
SELECT 'Range Rover Sport',4,6 UNION
SELECT 'Camaro', 5,1 UNION
SELECT 'Camaro', 5,2 UNION
SELECT 'Corvette', 5,1 UNION
SELECT 'Corvette', 5,2

INSERT INTO VehicleBodyTypes (BodyType)
SELECT 'Sedan' UNION
SELECT 'Wagon' UNION
SELECT 'People Mover' UNION
SELECT 'SUV' UNION
SELECT 'Hatch'UNION
SELECT 'Coupe' UNION
SELECT 'Convertible'
