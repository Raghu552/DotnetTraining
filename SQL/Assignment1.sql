create database Assignment1

select * from Clients
select * from Departments
select * from Employees
select * from projects
select * from EmpProjectTasks

create table Clients (
    Client_ID int PRIMARY KEY,
    Cname varchar(40) NOT NULL,
    Address varchar(30),
    Email VARCHAR(30) UNIQUE,
    Phone varchar(10),
    Business VArchar(20) NOT NULL
)
insert into Clients values(1001, 'ACME Utilities', 'Noida', 'contact@acmeutil.com', 9567880032, 'Manufacturing'),
 (1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', 8734210090, 'Consultant'),
 (1003, 'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', 7799886655, 'Reseller'),
 (1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', 9210342219, 'Professional')

 
create table Departments (
    Deptno INT PRIMARY KEY,
    Dname VARCHAR(15) NOT NULL,
    Loc VARCHAR(20)
)

INSERT INTO Departments values(10, 'Design', 'Pune'),
 (20, 'Development', 'Pune'),
 (30, 'Testing', 'Mumbai'),
 (40, 'Document', 'Mumbai')

 create table Employees (
    Empno INT PRIMARY KEY,
    Ename VARCHAR(20) NOT NULL,
    Job VARCHAR(15),
    Salary INT CHECK (Salary > 0),
    Deptno INT,
    FOREIGN KEY (Deptno) REFERENCES Departments(Deptno)
)

insert into Employees values  (7001, 'Sandeep', 'Analyst', 25000, 10),
(7002, 'Rajesh', 'Designer', 30000, 10), (7003, 'Madhav', 'Developer', 40000, 20), (7004, 'Manoj', 'Developer', 40000, 20),
 (7005, 'Abhay', 'Designer', 35000, 10),
 (7006, 'Uma', 'Tester', 30000, 30),
(7007, 'Gita', 'Tech. Writer', 30000, 40),
 (7008, 'Priya', 'Tester', 35000, 30),
 (7009, 'Nutan', 'Developer', 45000, 20),
 (7010, 'Smita', 'Analyst', 20000, 10),
 (7011, 'Anand', 'Project Mgr', 65000, 10)

CREATE TABLE Projects (
    Project_ID INT PRIMARY KEY,
    Descr VARCHAR(30) NOT NULL,
    Start_Date DATE,
    Planned_End_Date DATE,
    Actual_End_Date DATE ,
    Budget INT CHECK (Budget > 0),
    Client_ID INT,
    FOREIGN KEY (Client_ID) REFERENCES Clients(Client_ID),
	CONSTRAINT chk_actual_end_date CHECK (Actual_End_Date IS NULL OR Actual_End_Date > Planned_End_Date)
)

insert into Projects values (401, 'Inventory', '01-Apr-11', '01-Oct-11',  '31-Oct-11', 150000, 1001)
insert into Projects (Project_ID, Descr, Start_Date, Planned_End_Date, Budget, Client_ID)
VALUES (402, 'Accounting', '2011-08-01', '2012-01-01', 500000, 1002)
insert into Projects (Project_ID, Descr, Start_Date, Planned_End_Date, Budget, Client_ID)
values(403, 'Payroll', '01-Oct-11', '31-Dec-11',75000, 1003)
insert into Projects (Project_ID, Descr, Start_Date, Planned_End_Date, Budget, Client_ID)
VALUES (404, 'Contact Mgmt', '01-Nov-11', '31-Dec-11', 50000, 1004)

CREATE TABLE EmpProjectTasks (
    Project_ID int,
    Empno int,
    Start_Date DATE,
    End_Date DATE,
    Task VARCHAR(25) NOT NULL,
    Status VARCHAR(15) NOT NULL,
    PRIMARY KEY (Project_ID, Empno),
    FOREIGN KEY (Project_ID) REFERENCES Projects(Project_ID),
    FOREIGN KEY (Empno) REFERENCES Employees(Empno)
)

INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (401, 7001, '2011-04-01', '2011-04-20', 'System Analysis', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (401, 7002, '2011-04-21', '2011-05-30', 'System Design', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (401, 7003, '2011-06-01', '2011-07-15', 'Coding', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (401, 7004, '2011-07-18', '2011-09-01', 'Coding', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (401, 7006, '2011-09-03', '2011-09-15', 'Testing', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (401, 7009, '2011-09-18', '2011-10-05', 'Code Change', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (401, 7008, '2011-10-06', '2011-10-16', 'Testing', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (401, 7007, '2011-10-06', '2011-10-22', 'Documentation', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (401, 7011, '2011-10-22', '2011-10-31', 'Sign off', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (402, 7010, '2011-08-01', '2011-08-20', 'System Analysis', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES (402, 7002, '2011-08-22', '2011-09-30', 'System Design', 'Completed')
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, Task, Status)
VALUES (402, 7004, '2011-10-01', 'Coding', 'In Progress')



