create database ServiciosAgropecuarios
GO
use ServiciosAgropecuarios
GO
--Crear tabla
create table Transportistas(
    id int identity primary key,
    nombre varchar(120) not null,
    cuit varchar(120) not null,
    patente varchar(120) not null,
    toneladas bigint not null,
    tipoGrano int not null,
    fechaIngreso dateTime not null,
    fechaDescarga dateTime
)
--Inserta datos
insert into Transportistas (nombre, cuit, patente, toneladas, tipoGrano, fechaIngreso) values 
('Spock', '29170001239', 'ABC123', 18, 2, '06/19/2022 12:38'),
('James Kirk', '30171111239', 'AAA123', 19, 2, '06/19/2022 12:08'),
('Mr Sulu', '31172221239', 'VVV123', 15, 1, '06/19/2022 12:18'),
('Mc Coy', '32173331239', 'AA123BC', 12, 3, '06/19/2022 12:28');