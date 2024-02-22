--
-- Файл сгенерирован с помощью SQLiteStudio v3.4.4 в чт февр. 22 10:52:58 2024
--
-- Использованная кодировка текста: UTF-8
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Таблица: Пользователь
CREATE TABLE IF NOT EXISTS Пользователь (ID int PRIMARY KEY UNIQUE NOT NULL, Login TEXT (50) NOT NULL, "");
INSERT INTO Пользователь (ID, Login, "") VALUES (1, 'Stas', NULL);
INSERT INTO Пользователь (ID, Login, "") VALUES (2, 'Sasha', NULL);
INSERT INTO Пользователь (ID, Login, "") VALUES (3, 'Danila', NULL);

-- Таблица: Предмет
CREATE TABLE IF NOT EXISTS Предмет (ID int PRIMARY KEY UNIQUE NOT NULL, ID_Login int REFERENCES Пользователь (ID) NOT NULL, Predmet TEXT (50));
INSERT INTO Предмет (ID, ID_Login, Predmet) VALUES (3, 1, 'Каска');
INSERT INTO Предмет (ID, ID_Login, Predmet) VALUES (2, 3, 'Лопата');
INSERT INTO Предмет (ID, ID_Login, Predmet) VALUES (1, 2, 'Кирка');

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
