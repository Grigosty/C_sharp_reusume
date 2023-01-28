

SELECT good, category
from Goods g
LEFT JOIN Categories c on Good_cat.category_ID = c.category
--при помощи данного запроса мы выводим поля good и category 
