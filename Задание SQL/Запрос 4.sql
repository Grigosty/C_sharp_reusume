

SELECT good, category
from Goods g
LEFT JOIN Categories c on Good_cat.category_ID = c.category
--��� ������ ������� ������� �� ������� ���� good � category 
