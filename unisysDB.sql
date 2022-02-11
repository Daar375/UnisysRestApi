-- --------------------------------------------------------
-- Host:                         DAAR375PC
-- Server version:               Microsoft SQL Server 2019 (RTM) - 15.0.2000.5
-- Server OS:                    Windows 10 Pro 10.0 <X64> (Build 19042: ) (Hypervisor)
-- --------------------------------------------------------



-- Dumping database structure for UNISYS_DB
CREATE DATABASE "UNISYS_DB";
USE "UNISYS_DB";

-- Dumping structure for table UNISYS_DB.client
CREATE TABLE  "client" (
	"id_card" INT NOT NULL ,
	"name" VARCHAR(15) NOT NULL ,
	"last_name" VARCHAR(15) NOT NULL ,
	PRIMARY KEY ("id_card")
);

CREATE TABLE "movie" (
	"id" INT NOT NULL IDENTITY(1,1),
	"name" VARCHAR(50) NOT NULL,
	PRIMARY KEY ("id")
);
-- Data exporting was unselected.

-- Dumping structure for table UNISYS_DB.favorite
CREATE TABLE "favorite" (
	"client_id" INT NOT NULL,
	"movie_id" INT NOT NULL,
	CONSTRAINT favorite_PK PRIMARY KEY ("client_id", "movie_id"),
	CONSTRAINT "client_id_FK" FOREIGN KEY ("client_id") REFERENCES "client" ("id_card"),
	CONSTRAINT "movie_id_FK" FOREIGN KEY ("movie_id") REFERENCES "movie" ("id")
);
