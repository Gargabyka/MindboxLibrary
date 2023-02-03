# Вопрос №1
Разместите код на Github и приложите ссылку. Если в задании что-то непонятно, опишите возникшие вопросы и сделанные предположения. Например, в комментариях в коде.
Задание: Напишите на С# библиотеку для поставки внешним клиентам. которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
-  [Юнит-тесты](https://github.com/Gargabyka/MindboxLibrary/tree/master/MindboxLibraryTest)
-  Легкость добавления других фигур
-  Вычиспение плошади фигуры без знания типа фигуры в compile-time
-  Проверку на то, является ли треугольник прямоугольным

# Задача на SQL

### Структура БД
```
CREATE TABLE Products (
Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(255) NOT NULL);

CREATE TABLE Category (
Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(255) NOT NULL);

CREATE TABLE Products_Category (
Product_id INT NOT NULL,
Category_id INT NOT NULL,
FOREIGN KEY (Product_id) REFERENCES Products (Id) ON DELETE CASCADE,
FOREIGN KEY (Category_id) REFERENCES Category (Id) ON DELETE CASCADE);
```
### Данные
```
INSERT INTO Products VALUES ('Монитор LG'), ('Мужская рубашка'), ('Телескоп'), ('Хлеб');
INSERT INTO Category VALUES('Компьютерная переферия'), ('Электронника'),('Одежда'),('Оптические приборы');
INSERT INTO Products_Category VALUES(1, 1), (1, 2), (2, 3), (3,4);
```

### Запрос
```
SELECT 
	p.name AS "Наименование продукта",
	c.name AS "Наименование категории"
FROM Products p
LEFT JOIN Products_Category pc 	ON  pc.Product_id = p.Id
LEFT JOIN Category 	    c 	ON c.Id = pc.Category_id
ORDER BY p.name
```
