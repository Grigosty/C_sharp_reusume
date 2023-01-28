
--привязываем 
INSERT INTO Good_cat
SELECT Goods.good_ID, Categories.category_ID
FROM Goods
	join Categories on Categories.category_ID = Goods.category_ID