CREATE TABLE Good_cat( --Создаем смежную таблицу, при помощи которой будем связывать значения двух основных 
	good_ID int NOT NULL,
	category_ID int --тут мы не указываем "NOT NULL", так как в контексте запроса она может быть нулевой
	primary key(good_ID,  category_ID),
);
