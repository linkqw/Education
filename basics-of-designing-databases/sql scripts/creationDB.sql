use olympiadDB;

create table transportType(
	typeId int
		primary key
        not null
        auto_increment,
	typeName nvarchar(20)
		not null
);

create table carrier(
	carrierId int 
		primary key
        not null
        auto_increment,
	carrierName nvarchar(50)
		not null
);

create table employee(
	employeeId int
		primary key
        not null
        auto_increment,
	carrierId int
		not null,
    employeeName nvarchar(30)
		not null,
    employeeSurname nvarchar(30)
		not null,
	employeePost nvarchar(30)
		not null,
    employeeSalary int
		not null,
    
    foreign key (carrierId) references carrier(carrierId)
);

create table route(
	routeId int
		primary key
        not null
        auto_increment,
	startPoint nvarchar(30)
		not null,
    endPoint nvarchar(30)
		not null,
    travelTime time,
    transportTypeId int
		not null,
	carrierId int
		not null,
	
    foreign key (transportTypeId) references transportType(typeId),
    foreign key (carrierId) references carrier(carrierId)
);

create table trip(
	tripId int
		primary key
        not null
        auto_increment,
	routeId int
		not null,
    departureTime time
		not null,
    departureDate date
		not null,
    
    foreign key (routeId) references route(routeId)
);

create table changesInTrip(
	changeId int
		primary key
        not null
        auto_increment,
	tripId int
		not null,
    changedDate date
		not null,
    changedTime time
		not null,
    changeReason nvarchar(50),
    
    foreign key (tripId) references trip(tripId)
);

create table routeStop(
	stopId int
		primary key
        not null
        auto_increment,
	stopName nvarchar(30),
    stopLocation nvarchar(30),
    pavilionPresence bool
);

create table routeStopList(
	id int
		primary key
        not null
        auto_increment,
	routeId int
		not null,
    stopId int
		not null,
    stopNumberInRoute int
		not null,
    timeToNextStop time,
    distanceToNextStop int,
    
    foreign key(routeId) references route(routeId),
    foreign key(stopId) references routeStop(stopId)
);

create table employeeSchedule(
	id int 
		primary key
        not null
        auto_increment,
	employeeId int,
    routeId int,
    
    foreign key (employeeId) references employee(employeeId),
    foreign key (routeId) references route(routeId)
);

