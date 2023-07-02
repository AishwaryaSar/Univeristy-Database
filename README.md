# Univeristy-Database

#### Multi-tier object oriented application that maintains data related to students, instructors, and courses. 
* ##### The School Project solution handles the presentation layer, where requests are issued to create or modify records
* ##### The SchoolService solution does the necessary pre-processing, and routes the methods in the business layer
* ##### The Schoolbusiness solution further accesses the persistence layer and takes care of serialization, and deserialization of the business objects. 
* ##### The SchoolData handles the persistence of the objects created.

#### Data objects and persistence
* ##### The project utilizes a student table with the student's name and GPA, with the student id as the primary key. 
* ##### The instructor table has the instructor's names with the instructor id as the primary key. 
* ##### The course table contains details related to the course name and the credit hours, the instructor id as a foreign key, where course id is the primary key. 
* ##### Furthermore, a student course table utilizes the keys of the student table and the course table to maintain data related to the students enrolled for each course, and the score for each student in each course can be recorded.
