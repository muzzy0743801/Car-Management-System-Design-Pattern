create database DPCMS
use DPCMS

create table c_login(login_id int primary key identity,username varchar(255) unique,pword varchar(255),designation varchar(255))


insert into c_login values ('HafizAli','123','User')
insert into c_login values ('ali','123','Cabi')
insert into c_login values ('tanveer','123','Staff')

create table c_user(c_user_id int primary key identity,f_name varchar(255),l_name varchar(255),phone varchar(255))

insert into c_user values ('Hanif','Hasan','03052510374')
insert into c_user values ('Adil','Hasan','03053216544')

create table c_manager(c_manager_id int primary key identity,f_name varchar(255),l_name varchar(255),salary varchar(255))
insert into c_manager values ('Hanif','Hasan','50000')
insert into c_manager values ('Adil','Hasan','80000')


create table c_subordinate(c_subordinate_id int primary key identity,f_name varchar(255),l_name varchar(255),salary varchar(255))
insert into c_subordinate values ('Hanif','Hasan','50000')
insert into c_subordinate values ('Adil','Hasan','80000')


delete from c_login where login_id=1

select * from c_login
select * from c_user
select * from c_manager
select * from c_subordinate