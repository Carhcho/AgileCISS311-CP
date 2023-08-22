USE master;

 

IF DB_ID(N'CollegeDB') IS NOT NULL DROP DATABASE CollegeDB;

CREATE DATABASE CollegeDB;

GO

 

USE CollegeDB;

GO

CREATE TABLE student

(

           studentId         INT NOT NULL,

           studentName NVARCHAR(100) NOT NULL,

           CONSTRAINT pk_student PRIMARY KEY (studentId)

);

CREATE TABLE course

(

           courseId INT NOT NULL,

           courseTitle NVARCHAR(100) NOT NULL,

           CONSTRAINT pk_course PRIMARY KEY (courseId),

);

CREATE TABLE classStudentRelation

(
           studentId        INT NOT NULL,
           courseId         INT,
           FOREIGN KEY (studentId) REFERENCES student(studentId),
           FOREIGN KEY (courseId) REFERENCES course(courseId),
           UNIQUE (studentId, courseId)
);

--SET IDENTITY_INSERT student ON


INSERT INTO student (studentName, studentId) VALUES ('Cesar Roncancio', 111);

INSERT INTO student (studentName, studentId) VALUES ('Caley Cooper', 222);

INSERT INTO student (studentName, studentId) VALUES ('Kayla Crowley', 333);

INSERT INTO student (studentName, studentId) VALUES ('Daron Roncancio', 444);

INSERT INTO student (studentName, studentId) VALUES ('Emily Siemons', 555);

INSERT INTO student (studentName, studentId) VALUES ('Wanda Striff', 666);


--SET IDENTITY_INSERT student OFF
--SET IDENTITY_INSERT course ON


INSERT INTO course (courseTitle, courseId) VALUES ('Counters and blue', 1);

INSERT INTO course (courseTitle, courseId) VALUES ('Green and Growth', 2);

INSERT INTO course (courseTitle, courseId) VALUES ('Black and Discard', 3);



INSERT INTO classStudentRelation (studentId, courseId) VALUES (111, 1);
INSERT INTO classStudentRelation (studentId, courseId) VALUES (111, 2);
INSERT INTO classStudentRelation (studentId, courseId) VALUES (111, 3);

INSERT INTO classStudentRelation (studentId, courseId) VALUES (222, 1);
INSERT INTO classStudentRelation (studentId, courseId) VALUES (222, 3);

INSERT INTO classStudentRelation (studentId, courseId) VALUES (333, 3);

INSERT INTO classStudentRelation (studentId, courseId) VALUES (444, 1);
INSERT INTO classStudentRelation (studentId, courseId) VALUES (444, 2);

INSERT INTO classStudentRelation (studentId, courseId) VALUES (555, 2);
INSERT INTO classStudentRelation (studentId, courseId) VALUES (555, 3);

INSERT INTO classStudentRelation (studentId, courseId) VALUES (666, 1);
INSERT INTO classStudentRelation (studentId, courseId) VALUES (666, 2);
INSERT INTO classStudentRelation (studentId, courseId) VALUES (666, 3);

--SET IDENTITY_INSERT student ON


 SELECT * FROM student
 SELECT * FROM course
 SELECT * FROM classStudentRelation
