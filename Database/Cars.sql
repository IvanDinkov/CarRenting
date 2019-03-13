insert into CarRenting.dbo.cars(brand, model, car_type, price_per_day, fuel_consumption, transmission, door_count, seat_count, picture)
values ('Toyota', 'Yaris', 'Compact', 20.15, '7/100', 'automatic', 2, 5, (SELECT * FROM OPENROWSET  
(BULK 'C:\Users\kinib\Desktop\cars\yaris.png',SINGLE_CLOB)rs));

insert into CarRenting.dbo.cars(brand, model, car_type, price_per_day, fuel_consumption, transmission, door_count, seat_count, picture)
values ('Ford', 'Fiesta', 'Compact', 19.87, '6.4/100', 'automatic', 2, 5, (SELECT * FROM OPENROWSET  
(BULK 'C:\Users\kinib\Desktop\cars\fiesta.png',SINGLE_CLOB)rs));

insert into CarRenting.dbo.cars (brand, model, car_type, price_per_day, fuel_consumption, transmission, door_count, seat_count, picture)
values ('Dacia', 'Duster', 'SUV', 29.99, '12/100', 'automatic', 4, 5, (SELECT * FROM OPENROWSET  
(BULK 'C:\Users\kinib\Desktop\cars\duster.png',SINGLE_CLOB)rs));

insert into CarRenting.dbo.cars (brand, model, car_type, price_per_day, fuel_consumption, transmission, door_count, seat_count, picture)
values ('Hyundai', 'Santa Fe', 'SUV', 32.52, '14/100', 'automatic', 4, 5, (SELECT * FROM OPENROWSET  
(BULK 'C:\Users\kinib\Desktop\cars\santa fe.png',SINGLE_CLOB)rs));

insert into CarRenting.dbo.cars (brand, model, car_type, price_per_day, fuel_consumption, transmission, door_count, seat_count, picture)
values ('MINI', 'Cooper', 'Compact', 19.99, '6.8/100', 'automatic', 2, 5, (SELECT * FROM OPENROWSET  
(BULK 'C:\Users\kinib\Desktop\cars\cooper.png',SINGLE_CLOB)rs));

insert into CarRenting.dbo.cars (brand, model, car_type, price_per_day, fuel_consumption, transmission, door_count, seat_count, picture)
values ('Renault', 'Kwid', 'SUV', 25.64, '10.2/100', 'automatic', 4, 5, (SELECT * FROM OPENROWSET  
(BULK 'C:\Users\kinib\Desktop\cars\kwid.png',SINGLE_CLOB)rs));

insert into CarRenting.dbo.cars (brand, model, car_type, price_per_day, fuel_consumption, transmission, door_count, seat_count, picture)
values ('Nissan', 'Versa', 'Sedan', 33.66, '13.4/100', 'automatic', 4, 5, (SELECT * FROM OPENROWSET  
(BULK 'C:\Users\kinib\Desktop\cars\versa.png',SINGLE_CLOB)rs));

insert into CarRenting.dbo.cars (brand, model, car_type, price_per_day, fuel_consumption, transmission, door_count, seat_count, picture)
values ('Honda', 'Odyssey', 'Minivan', 40.73, '16/100', 'automatic', 4, 5, (SELECT * FROM OPENROWSET  
(BULK 'C:\Users\kinib\Desktop\cars\odyssey.png',SINGLE_CLOB)rs));

insert into CarRenting.dbo.cars (brand, model, car_type, price_per_day, fuel_consumption, transmission, door_count, seat_count, picture)
values ('Volkswagen', 'Passat', 'Sedan', 45.87, '10/100', 'automatic', 4, 5, (SELECT * FROM OPENROWSET  
(BULK 'C:\Users\kinib\Desktop\cars\passat.png',SINGLE_CLOB)rs));

insert into CarRenting.dbo.cars (brand, model, car_type, price_per_day, fuel_consumption, transmission, door_count, seat_count, picture)
values ('Kia', 'Ceed', 'Combi', 44.63, '12/100', 'automatic', 4, 5, (SELECT * FROM OPENROWSET  
(BULK 'C:\Users\kinib\Desktop\cars\ceed.png',SINGLE_CLOB)rs));

select * from CarRenting.dbo.cars;
