create database assignment03;

use assignment03

create table teacher(id int, Name varchar(50), Address varchar(50),salary int);

select * from teacher;

create table student(id int, Name varchar(50), Address varchar(50),credits int);

select * from student;

create table course(id int, Name varchar(50), credits int);

select * from course;

CREATE TABLE UserLogins(  
id int IDENTITY(1,1) NOT NULL,  
UserName [varchar](100) NULL,  
Password [varchar](50) NULL,  
CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED  
(  
   [id] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]

-- Insert the first set of username and password
INSERT INTO UserLogins (UserName, Password)
VALUES ('Chethan', 'Kacham');

-- Insert the second set of username and password
INSERT INTO UserLogins (UserName, Password)
VALUES ('Sanjeev', 'Gaikwad');