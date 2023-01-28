

-- В данном задании мы работаем с типом "Многие ко многим"
--Допустим у нас есть две таблицы Goods и Categories
--Таблица Goods имеет поля 'good', 'category_ID', good_ID(Ключевое поле), number(Количество товара)
--Таблица Categories имеет поля 'category_ID'(ключевое поле), 'category' и 'good'
--Нам необходимо взять из первой таблицы Товары и вывести к каждому его 
--соответствующую категорию, а если такой категории нет - просто вывести товар
--Для этого мы создаем прмоежуточную (связующую) таблицу, при помощи которой и будем их связывать



CREATE TABLE Goods( --таблица с нашими товарами
	good_ID int NOT NULL,
	category_ID int, --тут мы не указываем "NOT NULL", так как в контексте запроса она может быть нулевой
	good varchar NOT NULL,
	number int NOT NULL,
	primary key(good_ID),
);
CREATE TABLE Categories(--Таблица с категориями
	category_ID int NOT NULL,
	category varchar NOT NULL,
	good varchar NOT NULL,
	primary key(category_ID),
);
