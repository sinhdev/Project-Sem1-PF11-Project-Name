drop database if exists LoginDemo;

create database LoginDemo;

use LoginDemo;

create table Users(
	user_id int auto_increment primary key,
    user_account varchar(100) not null unique,
    user_pass varchar(200) not null,
    user_name varchar(100) not null,
    user_address varchar(200)
);

create user if not exists 'vtca'@'localhost' identified by 'vtcacademy';
grant all on LoginDemo.* to 'vtca'@'localhost';

insert into Users(user_account, user_pass, user_name) values
	('pf11', '8e40de2a1f7d41b7eb05866ac0faeedd', 'pf11 class');
-- pf11VTCAcademy
select * from Users;