use SpringProject;


/*----------------------------------------------------------------------------*/
/*CREATE TABLES*/
/*----------------------------------------------------------------------------*/
drop table Returning;
drop table RentalTransactions;
drop table Policy;
drop table Customers;
drop table Employees;
drop table LoginInformation;
drop table Cars;
drop table CarTypes;
drop table Branches;

/*CREATE Policy TABLE*/
create table Policy (
	policyId int primary key,
	policyType varchar(40),
);
/*CREATE Branches TABLE*/
create table Branches (
	branchID int primary key,
	province varchar(15) not null,
	city varchar(25) not null,
	phone bigint not null,
	fax bigint
);

/*CREATE Login Information TABLE*/
create table LoginInformation (
	loginID int primary key,
	userName varchar(50) not null,
	password varchar(50) not null,
	usertype varchar(50) not null     
);

/*CREATE Employees TABLE*/
create table Employees (
	empID int primary key,
	fname varchar(15) not null,
	lname varchar(15) not null,
	gender varchar(6) not null,
	dob date not null,
	phoneNumber bigint not null,
	streetNumber int,
	streetName varchar(25),
	aptNumber int,
	bldgNumber int,
	city varchar(15) not null,
	province varchar(15),
	zip varchar(6) not null,
	branchID int not null,
	salary int not null,
	foreign key (branchID) references Branches (branchID),
	foreign key (empID) references LoginInformation (loginID)
);

/*CREATE Customers TABLE*/
create table Customers (
	driversLicense int primary key,
	fname varchar(15) not null,
	lname varchar(15) not null,
	gender varchar(6) not null,
	dob date not null,
	phoneNumber bigint not null,
	streetNumber int,
	streetName varchar(25),
	aptNumber int,
	bldgNumber int,
	city varchar(15) not null,
	province varchar(15) not null,
	zip varchar(6) not null,
	creditCard bigint not null,
	policyID int not null,
);

/*CREATE CarTypes TABLE*/
create table CarTypes (
	bodyType varchar(10) primary key,
	normalRate int not null,
	branchFees int not null,
	penaltyRate int not null
);

/*CREATE Cars TABLE*/
create table Cars (
	vin varchar(17) primary key,
	licensePlate varchar(7) not null,
	bodyType varchar(10) not null,
	model varchar(35),
	gasType varchar(20),
	[year] int,
	branchId int not null,
	rentStatus varchar(10),
	foreign key (branchId) references Branches(branchID),
	foreign key (bodyType) references CarTypes(bodyType)
);

/*CREATE RentalTransactions TABLE*/
create table RentalTransactions (
	transID int primary key,
	authorizingEmpID int not null,
	branchID int not null,
	datePaid date not null,
	datePicked date,
	dateDropped date,
	vin varchar(17),
	driversLicense int,
	foreign key (branchID) references Branches(branchID),
	foreign key (authorizingEmpID) references Employees(empID),
	foreign key (vin) references Cars(vin),
	foreign key (driversLicense) references Customers(driversLicense)
);

create table Returning (
	transID int primary key,
	destinationBranchID int,
	empID int,
	returnDate date,
	foreign key (destinationBranchID) references Branches(BranchID),
	foreign key (transID) references RentalTransactions(transID)
);

/*----------------------------------------------------------------------------*/
/*                      CREATE RELATIONSHIPS                                  */
/*----------------------------------------------------------------------------*/