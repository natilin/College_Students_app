CREATE TABLE Students(
	Student_ID int primary key identity,
	NatID varchar(10) UNIQUE NOT NULL,
	First_Name varchar(25) NOT NULL,
	Last_Name varchar(25) NOT NULL,
	Total_Price INT,
	Password varchar(255) NOT NULL
	);

CREATE TABLE Lecturers(
	Lecturer_ID int primary key identity,
	NatID varchar(10) UNIQUE NOT NULL,
	First_Name varchar(25) NOT NULL,
	Last_Name varchar(25) NOT NULL,
	Price_Per_Hour INT NOT NULL
	);

CREATE TABLE Courses(
	Course_ID int primary key identity,
	Name VARCHAR(255) NOT NULL,
	);

CREATE TABLE Cycles(
	Cycle_ID int primary key identity,
	Name VARCHAR(255) NOT NULL,
	Course_ID int FOREIGN KEY REFERENCES Courses(Course_ID),
	Start_Day date,
	End_Day date,
	Start_Hour time,
	End_Hour time,
	Price INT NOT NULL,
	In_Registration bit
	);

CREATE TABLE Activity_days(
	Course_ID int FOREIGN KEY REFERENCES Courses(Course_ID),
	Sunday bit,
	Monday bit,
	Tuesday bit,
	Wednesday bit,
	Thursday bit,
	Friday bit
	);

CREATE TABLE Cycles_Student(
	Student_ID int FOREIGN KEY REFERENCES Students(Student_ID),
	Cycle_ID int FOREIGN KEY REFERENCES Cycles(Cycle_ID),
	CONSTRAINT UC_Student_ID_Cycle_ID UNIQUE (Student_ID,Cycle_ID)

	);

CREATE TABLE Subjects(
	Subject_ID int primary key identity,
	Subject_Name VARCHAR(255) NOT NULL,
	Course_ID int FOREIGN KEY REFERENCES Courses(Course_ID),
	Number_of_hours int,
	Lecturer_ID int FOREIGN KEY REFERENCES Lecturers(Lecturer_ID),
	);

CREATE TABLE Payments(
	Payment_ID int primary key identity,
	Student_ID int FOREIGN KEY REFERENCES Students(Student_ID) NOT NULL,
	Amount int NOT NULL,
	Day_of_payment DATETIME
	);


