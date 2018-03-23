-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Мар 21 2018 г., 19:10
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
  `id` int(11) NOT NULL,
  `Доступ` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `cars`
--

CREATE TABLE `cars` (
  `id` int(11) NOT NULL,
  `№_машины` varchar(6) NOT NULL,
  `Тип_машины` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `car_with_RFID`
--

CREATE TABLE `car_with_RFID` (
  `id` int(11) NOT NULL,
  `Дата_записи` date NOT NULL,
  `Epc` int(11) NOT NULL,
  `№_машины` int(11) NOT NULL,
  `Водитель` int(11) NOT NULL,
  `Доступ_въезда` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `chauffeur`
--

CREATE TABLE `chauffeur` (
  `id` int(11) NOT NULL,
  `Фамилия` varchar(255) NOT NULL,
  `Имя` varchar(255) NOT NULL,
  `Отчество` varchar(255) NOT NULL,
  `№_водительских_прав` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
  `id` int(11) NOT NULL,
  `Epc` int(24) NOT NULL,
  `Дата_регистрации` date NOT NULL,
  `Статус_активности` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `status_active`
--

CREATE TABLE `status_active` (
  `id` int(11) NOT NULL,
  `Статус` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `type_car`
--

CREATE TABLE `type_car` (
  `id` int(11) NOT NULL,
  `type` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `visit_type`
--

CREATE TABLE `visit_type` (
  `код` int(11) NOT NULL,
  `тип` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `access_visit`
--
ALTER TABLE `access_visit`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Тип_машины` (`Тип_машины`);

--
-- Индексы таблицы `car_with_RFID`
--
ALTER TABLE `car_with_RFID`
  ADD PRIMARY KEY (`id`),
  ADD KEY `Epc` (`Epc`,`№_машины`,`Водитель`,`Доступ_въезда`),
  ADD KEY `Водитель` (`Водитель`),
  ADD KEY `№_машины` (`№_машины`),
  ADD KEY `Доступ_въезда` (`Доступ_въезда`);

--
-- Индексы таблицы `chauffeur`
--
ALTER TABLE `chauffeur`
  ADD PRIMARY KEY (`id`);

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
  ADD PRIMARY KEY (`id`),
  ADD KEY `Статус_активности` (`Статус_активности`);

--
-- Индексы таблицы `status_active`
--
ALTER TABLE `status_active`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `type_car`
--
ALTER TABLE `type_car`
  ADD PRIMARY KEY (`id`);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `cars`
--
ALTER TABLE `cars`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `car_with_RFID`
--
ALTER TABLE `car_with_RFID`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `chauffeur`
--
ALTER TABLE `chauffeur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `history_visit`
--
ALTER TABLE `history_visit`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `RFID_metka`
--
ALTER TABLE `RFID_metka`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `status_active`
--
ALTER TABLE `status_active`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `type_car`
--
ALTER TABLE `type_car`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `visit_type`
--
ALTER TABLE `visit_type`
  MODIFY `код` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `cars`
--
ALTER TABLE `cars`
  ADD CONSTRAINT `cars_ibfk_1` FOREIGN KEY (`Тип_машины`) REFERENCES `type_car` (`id`) ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `car_with_RFID`
--
ALTER TABLE `car_with_RFID`
  ADD CONSTRAINT `car_with_rfid_ibfk_1` FOREIGN KEY (`Epc`) REFERENCES `RFID_metka` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `car_with_rfid_ibfk_2` FOREIGN KEY (`Водитель`) REFERENCES `chauffeur` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `car_with_rfid_ibfk_3` FOREIGN KEY (`№_машины`) REFERENCES `cars` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `car_with_rfid_ibfk_4` FOREIGN KEY (`Доступ_въезда`) REFERENCES `access_visit` (`id`) ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `history_visit`
--
ALTER TABLE `history_visit`
  ADD CONSTRAINT `history_visit_ibfk_1` FOREIGN KEY (`тип_проезда`) REFERENCES `visit_type` (`код`) ON UPDATE CASCADE,
  ADD CONSTRAINT `history_visit_ibfk_2` FOREIGN KEY (`машина`) REFERENCES `car_with_RFID` (`id`) ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `RFID_metka`
--
ALTER TABLE `RFID_metka`
  ADD CONSTRAINT `rfid_metka_ibfk_1` FOREIGN KEY (`Статус_активности`) REFERENCES `status_active` (`id`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
