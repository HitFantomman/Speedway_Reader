-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3307
-- Время создания: Мар 29 2018 г., 04:43
-- Версия сервера: 5.6.38
-- Версия PHP: 5.6.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `bdRFID`
--

-- --------------------------------------------------------

--
-- Структура таблицы `access_visit`
--

CREATE TABLE `access_visit` (
  `код` int(11) NOT NULL,
  `Доступ` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `access_visit`
--

INSERT INTO `access_visit` (`код`, `Доступ`) VALUES
(1, 'Разрешено'),
(2, 'Не разрешено');

-- --------------------------------------------------------

--
-- Структура таблицы `cars`
--

CREATE TABLE `cars` (
  `код` int(11) NOT NULL,
  `№_машины` varchar(6) NOT NULL,
  `Тип_машины` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `cars`
--

INSERT INTO `cars` (`код`, `№_машины`, `Тип_машины`) VALUES
(1, 'р206кв', 1),
(2, 'к543дл', 2);

-- --------------------------------------------------------

--
-- Структура таблицы `car_with_RFID`
--

CREATE TABLE `car_with_RFID` (
  `код` int(11) NOT NULL,
  `Дата_записи` date NOT NULL,
  `Epc` int(11) NOT NULL,
  `№_машины` int(11) NOT NULL,
  `Водитель` int(11) NOT NULL,
  `Доступ_въезда` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `car_with_RFID`
--

INSERT INTO `car_with_RFID` (`код`, `Дата_записи`, `Epc`, `№_машины`, `Водитель`, `Доступ_въезда`) VALUES
(1, '2018-03-28', 1, 2, 1, 1),
(2, '2018-03-28', 2, 1, 2, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `chauffeur`
--

CREATE TABLE `chauffeur` (
  `код` int(11) NOT NULL,
  `Фамилия` varchar(255) NOT NULL,
  `Имя` varchar(255) NOT NULL,
  `Отчество` varchar(255) NOT NULL,
  `№_водительских_прав` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `chauffeur`
--

INSERT INTO `chauffeur` (`код`, `Фамилия`, `Имя`, `Отчество`, `№_водительских_прав`) VALUES
(1, 'Иванов', 'Иван', 'Иванович', '2345235541'),
(2, 'Сидоров', 'Сидор', 'Сидорович', '2345124525');

-- --------------------------------------------------------

--
-- Структура таблицы `history_visit`
--

CREATE TABLE `history_visit` (
  `код` int(11) NOT NULL,
  `дата_проезда` datetime NOT NULL,
  `машина` int(11) NOT NULL,
  `тип_проезда` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `history_visit`
--

INSERT INTO `history_visit` (`код`, `дата_проезда`, `машина`, `тип_проезда`) VALUES
(1, '2018-03-29 00:00:00', 1, 1),
(2, '2018-03-28 00:00:00', 2, 1),
(3, '2018-03-28 00:00:00', 2, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `RFID_metka`
--

CREATE TABLE `RFID_metka` (
  `код` int(11) NOT NULL,
  `Epc` int(24) NOT NULL,
  `Дата_регистрации` date NOT NULL,
  `Статус_активности` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `RFID_metka`
--

INSERT INTO `RFID_metka` (`код`, `Epc`, `Дата_регистрации`, `Статус_активности`) VALUES
(1, 1203542541, '2018-03-28', 1),
(2, 1201254231, '2018-03-12', 2);

-- --------------------------------------------------------

--
-- Структура таблицы `status_active`
--

CREATE TABLE `status_active` (
  `код` int(11) NOT NULL,
  `Статус` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `status_active`
--

INSERT INTO `status_active` (`код`, `Статус`) VALUES
(1, 'Активен'),
(2, 'Не активен');

-- --------------------------------------------------------

--
-- Структура таблицы `type_car`
--

CREATE TABLE `type_car` (
  `код` int(11) NOT NULL,
  `тип_машины` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `type_car`
--

INSERT INTO `type_car` (`код`, `тип_машины`) VALUES
(1, 'Грузовой'),
(2, 'Легкий');

-- --------------------------------------------------------

--
-- Структура таблицы `visit_type`
--

CREATE TABLE `visit_type` (
  `код` int(11) NOT NULL,
  `тип_проезда` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `visit_type`
--

INSERT INTO `visit_type` (`код`, `тип_проезда`) VALUES
(1, 'Въезд'),
(2, 'Выезд');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `access_visit`
--
ALTER TABLE `access_visit`
  ADD PRIMARY KEY (`код`);

--
-- Индексы таблицы `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`код`),
  ADD KEY `Тип_машины` (`Тип_машины`);

--
-- Индексы таблицы `car_with_RFID`
--
ALTER TABLE `car_with_RFID`
  ADD PRIMARY KEY (`код`),
  ADD KEY `Epc` (`Epc`,`№_машины`,`Водитель`,`Доступ_въезда`),
  ADD KEY `Водитель` (`Водитель`),
  ADD KEY `№_машины` (`№_машины`),
  ADD KEY `Доступ_въезда` (`Доступ_въезда`);

--
-- Индексы таблицы `chauffeur`
--
ALTER TABLE `chauffeur`
  ADD PRIMARY KEY (`код`);

--
-- Индексы таблицы `history_visit`
--
ALTER TABLE `history_visit`
  ADD PRIMARY KEY (`код`),
  ADD KEY `машина` (`машина`,`тип_проезда`),
  ADD KEY `тип_проезда` (`тип_проезда`);

--
-- Индексы таблицы `RFID_metka`
--
ALTER TABLE `RFID_metka`
  ADD PRIMARY KEY (`код`),
  ADD KEY `Статус_активности` (`Статус_активности`);

--
-- Индексы таблицы `status_active`
--
ALTER TABLE `status_active`
  ADD PRIMARY KEY (`код`);

--
-- Индексы таблицы `type_car`
--
ALTER TABLE `type_car`
  ADD PRIMARY KEY (`код`);

--
-- Индексы таблицы `visit_type`
--
ALTER TABLE `visit_type`
  ADD PRIMARY KEY (`код`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `access_visit`
--
ALTER TABLE `access_visit`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `cars`
--
ALTER TABLE `cars`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `car_with_RFID`
--
ALTER TABLE `car_with_RFID`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `chauffeur`
--
ALTER TABLE `chauffeur`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `history_visit`
--
ALTER TABLE `history_visit`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `RFID_metka`
--
ALTER TABLE `RFID_metka`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `status_active`
--
ALTER TABLE `status_active`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `type_car`
--
ALTER TABLE `type_car`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `visit_type`
--
ALTER TABLE `visit_type`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `cars`
--
ALTER TABLE `cars`
  ADD CONSTRAINT `cars_ibfk_1` FOREIGN KEY (`Тип_машины`) REFERENCES `type_car` (`код`) ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `car_with_RFID`
--
ALTER TABLE `car_with_RFID`
  ADD CONSTRAINT `car_with_rfid_ibfk_1` FOREIGN KEY (`Epc`) REFERENCES `RFID_metka` (`код`) ON UPDATE CASCADE,
  ADD CONSTRAINT `car_with_rfid_ibfk_2` FOREIGN KEY (`Водитель`) REFERENCES `chauffeur` (`код`) ON UPDATE CASCADE,
  ADD CONSTRAINT `car_with_rfid_ibfk_3` FOREIGN KEY (`№_машины`) REFERENCES `cars` (`код`) ON UPDATE CASCADE,
  ADD CONSTRAINT `car_with_rfid_ibfk_4` FOREIGN KEY (`Доступ_въезда`) REFERENCES `access_visit` (`код`) ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `history_visit`
--
ALTER TABLE `history_visit`
  ADD CONSTRAINT `history_visit_ibfk_1` FOREIGN KEY (`тип_проезда`) REFERENCES `visit_type` (`код`) ON UPDATE CASCADE,
  ADD CONSTRAINT `history_visit_ibfk_2` FOREIGN KEY (`машина`) REFERENCES `car_with_RFID` (`код`) ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `RFID_metka`
--
ALTER TABLE `RFID_metka`
  ADD CONSTRAINT `rfid_metka_ibfk_1` FOREIGN KEY (`Статус_активности`) REFERENCES `status_active` (`код`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
