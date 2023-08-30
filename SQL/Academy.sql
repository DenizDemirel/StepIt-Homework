
create table Students(
	[Name] nvarchar(50),
	[Surname] nvarchar(50),
	[Age] int,

	[GroupName] nvarchar(50),
	[Direction] nvarchar(100),
)

create table Teachers(
	[Name] nvarchar(50),
	[Surname] nvarchar(50),
	[Age] int,

	[GroupName] nvarchar(50),
	[Direction] nvarchar(100),
)

create table Groups(
	[GroupName] nvarchar(50),

	[NumberOfStudents] int,
)

insert into Students	
	values('Hallsy', 'Storry', 57, 'FBES_1229_ru', 'Full-stack development'),
	('Bernita', 'McNamara', 52, 'FBES_2_22_5_ru', 'Design'),
	('Urbain', 'Munnings', 76, 'FBAS_1222_ru', 'IT'),
	('Donal', 'Bowshire', 67, 'FBAS_1222_ru', 'IT'),
	('Nadean', 'Ingleton', 78, 'FBES_1229_ru', 'Full-stack development'),
	('Boyce', 'Slark', 47, 'FBAS_1222_ru', 'IT'),
	('Cyndy', 'Guy', 74, 'FBES_2_22_5_ru', 'Design'),
	('Elston', 'Bambrick', 79, 'FBES_1229_ru', 'Full-stack development'),
	('Galina', 'Pearle', 37, 'FBES_2_22_5_ru', 'Design')

insert into Teachers
	values ('Anastasia', 'Vaszoly', 70, 'FBAS_1222_ru', 'IT'),
	('Jamey', 'Shooter', 64, 'FBES_2_22_5_ru', 'Design'),
	('Piotr', 'Coad', 18, 'FBES_1229_ru', 'Full-stack development')

insert into Groups(GroupName, NumberOfStudents)
	values ('FBES_1229_ru',  3),
    ('FBAS_1222_ru',  3),
    ('FBES_2_22_5_ru',  3)

select *
from Students

select *
from Teachers

select * 
from Groups