drop table if exists Devise cascade;

/*==============================================================*/
/* Table : Devise                                               */
/*==============================================================*/
CREATE TABLE Devise (
   ID               serial					 primary key,
   NOM           	varchar(20)          	not null,
   TAUX         	numeric(8,2)	         not null
);

INSERT INTO Devise(NOM, TAUX) VALUES ('Dollar', 1.08);
INSERT INTO Devise(NOM, TAUX) VALUES ('Franc Suisse', 1.07);
INSERT INTO Devise(NOM, TAUX) VALUES ('Yen', 120);

/*==============================================================*/
/* Vue : vDevises                                               */
/*==============================================================*/

drop view if exists vDevises cascade;
CREATE VIEW vDevises AS SELECT * FROM devise;