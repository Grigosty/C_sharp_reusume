

-- � ������ ������� �� �������� � ����� "������ �� ������"
--�������� � ��� ���� ��� ������� Goods � Categories
--������� Goods ����� ���� 'good', 'category_ID', good_ID(�������� ����), number(���������� ������)
--������� Categories ����� ���� 'category_ID'(�������� ����), 'category' � 'good'
--��� ���������� ����� �� ������ ������� ������ � ������� � ������� ��� 
--��������������� ���������, � ���� ����� ��������� ��� - ������ ������� �����
--��� ����� �� ������� ������������� (���������) �������, ��� ������ ������� � ����� �� ���������



CREATE TABLE Goods( --������� � ������ ��������
	good_ID int NOT NULL,
	category_ID int, --��� �� �� ��������� "NOT NULL", ��� ��� � ��������� ������� ��� ����� ���� �������
	good varchar NOT NULL,
	number int NOT NULL,
	primary key(good_ID),
);
CREATE TABLE Categories(--������� � �����������
	category_ID int NOT NULL,
	category varchar NOT NULL,
	good varchar NOT NULL,
	primary key(category_ID),
);
