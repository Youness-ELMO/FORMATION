create database FORMATION
use FORMATION

create table academie(IdAcademi int primary key,
						nomAcademie varchar(20))

create table delegation(IdDelegation int primary key,
						nomDelegation varchar(20), 
						IdAcademi int foreign key references academie(IdAcademi))

create table lycee(IdLycee int primary key,
					nomLycee varchar(20),
					villeLycee varchar(30),
					IdDelegation int foreign key references delegation(IdDelegation))

create table professeur(Idprofesseur int primary key ,
						nomProfesseur varchar(20),
						Email varchar(20) check(Email like('%@%.%')),
						Etatcivil varchar(20),nbrEnfants int,
						IdLycee int foreign key references lycee (IdLycee))

drop table professeur

select*from professeur
insert into delegation values (1,'amani',1),(2,'amani',2),(3,'amani',3),(4,'amani',4)
insert into lycee values (1,'amani','rabat',1),(2,'mohamed V','casa',2),(3,'zarafa','fes',3),(4,'cherkaoui','casa',4)