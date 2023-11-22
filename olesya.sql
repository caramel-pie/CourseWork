CREATE TABLE `workers` (
  `first_name` varchar(20) NOT NULL,
  `second_name` varchar(20) NOT NULL,
  `date_of_birth` date NOT NULL,
  `identif_code` varchar(12) UNIQUE NOT NULL,
  `docnum` varchar(12) NOT NULL,
  `telephone` varchar(13) NOT NULL,
  `email` varchar(30) NOT NULL,
  `adress` varchar(100) NOT NULL,
  `cardnum` varchar(16) NOT NULL,
  `position_id` int(11) UNSIGNED NOT NULL,
  `system_password` varchar(30) NOT NULL,
  `department_id` int(11) UNSIGNED NOT NULL,
  `id` int(10) UNSIGNED PRIMARY KEY NOT NULL AUTO_INCREMENT
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `receipt` (
  `startdate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `finishdate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sum` int(10) UNSIGNED NOT NULL,
  `clientid` int(10) UNSIGNED NOT NULL,
  `itemid` int(10) UNSIGNED NOT NULL,
  `id` int(10) UNSIGNED PRIMARY KEY NOT NULL AUTO_INCREMENT
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `positions` (
  `title` varchar(20) NOT NULL,
  `access_rights` int(5) UNSIGNED NOT NULL,
  `id` int(10) UNSIGNED PRIMARY KEY NOT NULL AUTO_INCREMENT
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `items` (
  `type` varchar(12) NOT NULL,
  `title` varchar(30) NOT NULL,
  `condition` varchar(12) NOT NULL,
  `pledget` int(7) UNSIGNED NOT NULL,
  `material_id` int(10) UNSIGNED NOT NULL,
  `departments_id` int(10) UNSIGNED NOT NULL,
  `id` int(10) UNSIGNED PRIMARY KEY NOT NULL AUTO_INCREMENT
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `departments` (
  `opening_time` time NOT NULL,
  `closing_time` time NOT NULL,
  `adress` varchar(100) NOT NULL,
  `id` int(10) UNSIGNED PRIMARY KEY NOT NULL AUTO_INCREMENT
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `clients` (
  `name` varchar(20) NOT NULL,
  `surname` varchar(20) NOT NULL,
  `age` int(2) UNSIGNED NOT NULL,
  `adress` text NOT NULL,
  `doctype` varchar(30) NOT NULL,
  `docnum` int(12) UNSIGNED NOT NULL,
  `telephone` varchar(13) NOT NULL,
  `email` varchar(30) NOT NULL,
  `id` int(10) UNSIGNED PRIMARY KEY NOT NULL AUTO_INCREMENT
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `materials` (
  `material` varchar(20) NOT NULL,
  `cost` int(10) UNSIGNED NOT NULL,
  `id` int(10) UNSIGNED PRIMARY KEY NOT NULL AUTO_INCREMENT
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `receipt`
ADD CONSTRAINT `fk_receipt_client` FOREIGN KEY (`clientid`) REFERENCES `clients`(`id`);

ALTER TABLE `receipt`
ADD CONSTRAINT `fk_receipt_item` FOREIGN KEY (`itemid`) REFERENCES `items`(`id`) ON DELETE CASCADE;

ALTER TABLE `workers`
ADD CONSTRAINT `fk_worker_department` FOREIGN KEY (`department_id`) REFERENCES `departments`(`id`);

ALTER TABLE `workers`
ADD CONSTRAINT `fk_worker_position` FOREIGN KEY (`position_id`) REFERENCES `positions`(`id`);

ALTER TABLE `items`
ADD CONSTRAINT `fk_item_material` FOREIGN KEY (`material_id`) REFERENCES `materials` (`id`);

ALTER TABLE `items`
ADD CONSTRAINT `fk_item_department` FOREIGN KEY (`department_id`) REFERENCES `departments` (`id`);
