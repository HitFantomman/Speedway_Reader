-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3307
-- Время создания: Апр 13 2018 г., 18:40
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
-- База данных: `SystemRFID`
--

-- --------------------------------------------------------

--
-- Структура таблицы `access_visit`
--

CREATE TABLE `access_visit` (
  `код` int(11) NOT NULL,
  `доступ` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `access_visit`
--

INSERT INTO `access_visit` (`код`, `доступ`) VALUES
(1, 'Разрешено'),
(2, 'Запрещено');

-- --------------------------------------------------------

--
-- Структура таблицы `cars`
--

CREATE TABLE `cars` (
  `код` int(11) NOT NULL,
  `№_машины` varchar(256) NOT NULL,
  `тип_машины` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `cars`
--

INSERT INTO `cars` (`код`, `№_машины`, `тип_машины`) VALUES
(1, 'в256ву', 2),
(2, 'а132ка', 1),
(3, 'о723ао', 3);

-- --------------------------------------------------------

--
-- Структура таблицы `cars_with_RFID`
--

CREATE TABLE `cars_with_RFID` (
  `код` int(11) NOT NULL,
  `дата_записи` date NOT NULL,
  `epc` int(11) NOT NULL,
  `№_машины` int(11) NOT NULL,
  `водитель` int(11) NOT NULL,
  `доступ_проезда` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `chauffeur`
--

CREATE TABLE `chauffeur` (
  `код` int(11) NOT NULL,
  `фамилия` varchar(256) NOT NULL,
  `имя` varchar(256) NOT NULL,
  `отчество` varchar(256) NOT NULL,
  `№_водительских_прав` bigint(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `chauffeur`
--

INSERT INTO `chauffeur` (`код`, `фамилия`, `имя`, `отчество`, `№_водительских_прав`) VALUES
(1, 'Петров', 'Енакентий', 'Федорович', 1245325412),
(2, 'Срок', 'Евгений', 'Петрович', 3254621542),
(3, 'Тельбет', 'Антон', 'Сидорович', 4512458563);

-- --------------------------------------------------------

--
-- Структура таблицы `history_visit`
--

CREATE TABLE `history_visit` (
  `код` int(11) NOT NULL,
  `дата_проезда` date NOT NULL,
  `машина` int(11) NOT NULL,
  `тип_проезда` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `RFID_metka`
--

CREATE TABLE `RFID_metka` (
  `код` int(11) NOT NULL,
  `epc` varchar(15) NOT NULL,
  `дата_регистрации` date NOT NULL,
  `статус_активности` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `RFID_metka`
--

INSERT INTO `RFID_metka` (`код`, `epc`, `дата_регистрации`, `статус_активности`) VALUES
(1, '1245124512', '2018-09-23', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `status_active`
--

CREATE TABLE `status_active` (
  `код` int(11) NOT NULL,
  `статус` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `status_active`
--

INSERT INTO `status_active` (`код`, `статус`) VALUES
(1, 'Активен'),
(2, 'Не активен');

-- --------------------------------------------------------

--
-- Структура таблицы `type_car`
--

CREATE TABLE `type_car` (
  `код` int(11) NOT NULL,
  `тип` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `type_car`
--

INSERT INTO `type_car` (`код`, `тип`) VALUES
(1, 'Легкий'),
(2, 'Грузовой'),
(3, 'Пассажирский');

-- --------------------------------------------------------

--
-- Структура таблицы `type_visit`
--

CREATE TABLE `type_visit` (
  `код` int(11) NOT NULL,
  `тип` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `type_visit`
--

INSERT INTO `type_visit` (`код`, `тип`) VALUES
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
  ADD KEY `тип_машины` (`тип_машины`);

--
-- Индексы таблицы `cars_with_RFID`
--
ALTER TABLE `cars_with_RFID`
  ADD PRIMARY KEY (`код`),
  ADD KEY `epc` (`epc`),
  ADD KEY `№_машины` (`№_машины`),
  ADD KEY `водитель` (`водитель`),
  ADD KEY `доступ_проезда` (`доступ_проезда`);

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
  ADD KEY `машина` (`машина`),
  ADD KEY `тип_проезда` (`тип_проезда`);

--
-- Индексы таблицы `RFID_metka`
--
ALTER TABLE `RFID_metka`
  ADD PRIMARY KEY (`код`),
  ADD KEY `статус_активности` (`статус_активности`);

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
-- Индексы таблицы `type_visit`
--
ALTER TABLE `type_visit`
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
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `cars_with_RFID`
--
ALTER TABLE `cars_with_RFID`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `chauffeur`
--
ALTER TABLE `chauffeur`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `history_visit`
--
ALTER TABLE `history_visit`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `RFID_metka`
--
ALTER TABLE `RFID_metka`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `status_active`
--
ALTER TABLE `status_active`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `type_car`
--
ALTER TABLE `type_car`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `type_visit`
--
ALTER TABLE `type_visit`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `cars`
--
ALTER TABLE `cars`
  ADD CONSTRAINT `cars_ibfk_1` FOREIGN KEY (`тип_машины`) REFERENCES `type_car` (`код`) ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `cars_with_RFID`
--
ALTER TABLE `cars_with_RFID`
  ADD CONSTRAINT `cars_with_rfid_ibfk_1` FOREIGN KEY (`№_машины`) REFERENCES `cars` (`код`) ON UPDATE CASCADE,
  ADD CONSTRAINT `cars_with_rfid_ibfk_2` FOREIGN KEY (`epc`) REFERENCES `RFID_metka` (`код`) ON UPDATE CASCADE,
  ADD CONSTRAINT `cars_with_rfid_ibfk_3` FOREIGN KEY (`доступ_проезда`) REFERENCES `access_visit` (`код`) ON UPDATE CASCADE,
  ADD CONSTRAINT `cars_with_rfid_ibfk_4` FOREIGN KEY (`водитель`) REFERENCES `chauffeur` (`код`) ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `history_visit`
--
ALTER TABLE `history_visit`
  ADD CONSTRAINT `history_visit_ibfk_1` FOREIGN KEY (`тип_проезда`) REFERENCES `type_visit` (`код`) ON UPDATE CASCADE,
  ADD CONSTRAINT `history_visit_ibfk_2` FOREIGN KEY (`машина`) REFERENCES `cars_with_RFID` (`код`) ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `RFID_metka`
--
ALTER TABLE `RFID_metka`
  ADD CONSTRAINT `rfid_metka_ibfk_1` FOREIGN KEY (`статус_активности`) REFERENCES `status_active` (`код`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
