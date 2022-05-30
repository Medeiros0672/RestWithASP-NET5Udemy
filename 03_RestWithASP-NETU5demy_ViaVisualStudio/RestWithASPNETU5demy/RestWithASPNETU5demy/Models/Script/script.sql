create table PERSON
( PRS_ID               NUMBER(9)       NOT NULL,
  PRS_ADDRESS          VARCHAR2(100)   NOT NULL,
  PRS_FIRST_NAME       VARCHAR2(80)    NOT NULL,
  PRS_LAST_NAME        VARCHAR2(80)    NOT NULL,
  PRS_GENDER           VARCHAR2(6)     NOT NULL
) tablespace &&TS_RMS_D;

alter table PERSON
  add constraint PK_PERSON primary key 
( PRS_ID
) using index 
  tablespace &&TS_RMS_I;