use olympiaddb;

insert into transportType
values
	(1, "электропоезд"),
    (2, "автобус"),
    (3, "трамвай"),
    (4, "троллейбус"),
    (5, "маршрутное такси");
    
insert into carrier
values
	(1, 'ПАТП-4'),
    (2, 'РЖД'),
    (3, 'ПАТП-1'),
    (4, 'ПАТП-3'),
    (5, 'Энергия'),
    (6, 'Абсолют');
    
insert into employee
values
	(1, 1, 'Григорий', 'Степанов', 'Водитель', 26000),
    (2, 1, 'Александр', 'Цветков', 'Водитель', 26000),
	(3, 2, 'Михаил', 'Данилов', 'Водитель', 27000),
	(4, 3, 'Амелия', 'Александрова', 'Кондуктор', 20300),
    (5, 3, 'Даниил', 'Леонов', 'Водитель', 26000),
    (6, 3, 'Иван', 'Михайлов', 'Водитель', 26000),
    (7, 1, 'Василиса', 'Фомина', 'Кондуктор', 20300),
	(8, 2, 'Матвей', 'Грачев', 'Кондуктор', 21300),
	(9, 2, 'Демид', 'Новиков', 'Водитель', 27000),
    (10, 4, 'Алексей', 'Макаров', 'Водитель', 24000),
    (11, 5, 'Савелий', 'Блинов', 'Водитель', 26000),
	(12, 6, 'Ника', 'Куликова', 'Кондуктор', 20300),
    (13, 4, 'Полина', 'Русакова', 'Кондуктор', 19800),
    (14, 5, 'Андрей', 'Крылов', 'Водитель', 26000),
    (15, 6, 'Дмитрий', 'Гаврилов', 'Водитель', 26000),
	(16, 4, 'Анастасия', 'Маркова', 'Кондуктор', 17950),
	(17, 5, 'Ульяна', 'Черепанова', 'Кондуктор', 20300),
    (18, 6, 'Филипп', 'Сергеев', 'Водитель', 28000);

insert into route
values

	/*электрички*/
	(1, "Новосибирск-Главный", "Пригородный простор", '1:27', 1, 1),
    (2, "Новосибирск-Главный", "Сокур", '1:32', 1, 2),
    
    /*автобусы*/
    (3, "Новосибирск-Главный", "Болотная", '1:50', 2, 2),
    (4, "Инская", "Речной вокзал", '00:25', 2, 1),
    
    /*трамваи*/
    (5, "Цветущая плющиха", "Ботанический жилмассив", '2:30', 3, 3),
    (6, "Пригородный простор", "Улица Тюленина", '3:58', 3, 4),
    
    /*троллейбусы*/
    (7, "Цветущая плющиха", "Ботанический жилмассив", '1:59', 4, 4),
    (8, "Котельная", "Колыванская улица", '2:40', 4, 3),
    
    /*маршрутки*/
    (9, "Бугринская роща", "Бугринская роща", '1:15', 5, 5),
    (10, "Юго-Западный ж/м", "Бугринская роща", '1:47', 5, 6);
        
insert into trip
values
	
    /*рейсы*/
	(1, 1, '9:10', '2022-11-19'),
    (2, 1, '9:10', '2022-11-20'),
    (3, 2, '11:22', '2022-11-20'),
    (4, 3, '13:30', '2022-11-21'),
    (5, 4, '9:46', '2022-11-19'),
    (6, 4, '9:23', '2022-11-19'),
    (7, 5, '10:10', '2022-11-23'),
    (8, 7, '6:00', '2022-11-24'),
    (9, 8, '8:09', '2022-11-19'),
    (10, 9, '9:10', '2022-11-25'),
    (11, 10, '9:06', '2022-11-21'),
    (12, 10, '13:13', '2022-11-22'),
    (13, 6, '19:07', '2022-11-23'),
    (14, 6, '16:30', '2022-11-24'),
    (15, 7, '20:10', '2022-11-20');

insert into changesInTrip
values
	(1, 1, '2022-11-19', '10:10', 'Неподходящие погодные условия'),
    (2, 5, '2022-11-20', '9:46', 'Технические неполадки'),
    (3, 6, '2022-11-19', '10:10', 'Неподходящие погодные условия');

insert into routeStop
values
	(1, 'Лазурная Улица','Октябрьский р-н', true),
    (2, 'Пригородный простор','Объ', false),
    (3, 'Сокур', 'Мошково', false),
    (4, 'Болотная', 'Новосибирская обл.', true),
    (5, 'Инская', 'Первомайский р-н', true),
    (6, 'Речной вокзал', 'Новосибирская обл.', true),
    (7,'Цветущая плющиха', 'Октябрьский р-н', false),
    (8,'Ботанический жилмассив', 'Заельцовский р-н', false),
    (9,'Улица Тюленина', 'Новосибирская обл.', true),
    (10,'Котельная', 'Советский р-н', false),
    (11,'Колыванская улица', 'Новосибирская обл.', false),
    (12,'Бугринская роща', 'Новосибирская обл.', true),
    (13,'Юго-Западный ж/м', 'Ленинский р-н', true),
    (14,'Улица Петухова', 'Новосибирская обл.', false),
    (15,'Метро Площадь Маркса', 'Новосибирская обл.', true),
    (16,'Северо-Чемской ж/м', 'Кировский р-н', false),
    (17,'Затулинский ж/м', 'Кировский р-н', false),
    (18,'Ленинградская Улица', 'Новосибирская обл.', true),
    (19,'Завод медпрепоратов', 'Новосибирская обл.', false),
    (20,'Горный', 'Мошково', false),
    (21,'Белово', 'Искитимский р-н', true),
    (22,'ТЭЦ-5', 'Октябрьский р-н', false),
    (23,'Диагностический центр', 'Новосибирская обл.', false),
    (24,'ПКиО Заельцовский', 'Заельцовский р-н', false),
    (25, 'Новосибирск-Главный', 'Центральный р-н', true),
    (26, 'Метро Речной вокзал', 'Новосибирская обл.', true);

insert into routeStopList
values
	/* 1 */
	(1, 1, 25, 1, ':03', 233),
    (2, 1, 9, 2, ':05', 306),
    (3, 1, 2, 3, ':05', 306),
    
    /* 2 */
    (4, 2, 25, 1, ':10', 2654),
    (5, 2, 20, 2, ':02', 273),
    (6, 2, 3, 3, ':02', 273),
    
    /* 3 */
    (7, 3, 25, 1, ':10', 2654),
    (8, 3, 11, 2, ':02', 273),
    (9, 3, 4, 3, ':02', 273),
    
    /* 4 */
    (10, 4, 5, 1, ':9', 2120),
    (11, 4, 11, 2, ':08', 1965),
    (12, 4, 26, 3, ':02', 1965),
    
    /* 5 */
    (13, 5, 7, 1, ':6', 1233),
    (14, 5, 16, 2, ':03', 233),
    (15, 5, 8, 3, ':03', 233),
    
    /* 6 */
    (16, 6, 5, 1, ':4', 565),
    (17, 6, 11, 2, ':18', 2789),
    (18, 6, 26, 3, ':18', 2789),
    
    /* 7 */
    (19, 7, 7, 1, ':44', 10655),
    (20, 7, 9, 2, ':18', 2789),
    (21, 7, 8, 3, ':18', 2789),
    
    /* 8 */
    (22, 8, 7, 1, ':14', 1523),
    (23, 8, 9, 2, ':8', 512),
    (24, 8, 8, 3, ':8', 512),
    
    /* 9 */
    (25, 9, 7, 1, ':44', 10655),
    (26, 9, 9, 2, ':18', 2789),
    (27, 9, 8, 3, ':18', 2789),
    
    /* 10 */
    (28, 10, 12, 1, ':8', 512),
    (29, 10, 20, 2, ':8', 512),
    (30, 10, 12, 3, ':8', 512);

insert into employeeSchedule
values
	(1, 1, 1),
    (2, 7, 1),
    (3, 1, 2),
    (4, 7, 2),
    (5, 14, 3),
    (6, 17, 3),
    (7, 14, 4),
    (8, 17, 4),
    (9, 18, 5),
    (10, 12, 5),
    (11, 8, 6),
    (12, 9, 6),
    (13, 1, 7),
    (14, 7, 7),
    (15, 1, 8),
    (16, 7, 8),
    (17, 14, 9),
    (18, 17, 9),
    (19, 18, 10),
    (20, 12, 10),
    (21, 4, 1),
    (22, 5, 1),
    (23, 13, 2),
    (24, 10, 2),
    (25, 4, 3),
    (26, 5, 3),
    (27, 2, 4),
    (28, 7, 4),
    (29, 17, 5),
    (30, 14, 5);
 
 
 
 
 
 
 
    
    
    
    
    
    
    
