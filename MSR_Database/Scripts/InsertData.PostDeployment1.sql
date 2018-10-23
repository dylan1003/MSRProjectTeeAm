IF '$(loaddata)' = 'false'
begin
delete from Veterans;
delete from Contents;
delete from Sections;
delete from Portfolios;
delete from ProfilePictures;
delete from VeteranQueues;
delete from Users;
delete from MultiMedias;

DBCC CHECKIDENT (Users, RESEED, 0);
DBCC CHECKIDENT (VeteranQueues, RESEED, 0);
DBCC CHECKIDENT (Veterans, RESEED, 0);
DBCC CHECKIDENT (ProfilePictures, RESEED, 0);
DBCC CHECKIDENT (Portfolios, RESEED, 0);
DBCC CHECKIDENT (MultiMedias, RESEED, 0);
end

BEGIN

INSERT INTO  Users( UserName, Password, Permissions) VALUES
('1017614855', 'hashedpassword@sha2', '0'),
('important.teacher@school.edu.au','sha1','1'),
('JBZ1400', 'sha0', '2');

INSERT INTO  VeteranQueues(Fk_Teacher_Id) VALUES
(2);


INSERT INTO  ProfilePictures(Picture) 
SELECT BulkColumn
From openrowset ( Bulk 'C:\Users\STUDENT\source\repos\MSRProjectTeeAm2\Images\THE-POPPY.jpg', Single_Blob) as img;



/* Portfolio One*/
INSERT INTO  Portfolios DEFAULT VALUES;

INSERT INTO Veterans(FirstName, MiddleName, SurName, DOB, Fate, Death, EnlistedDate, ServiceNo, Unit, Parish, Address, Town, Country, ShortBio,Status, Fk_User_Id, Fk_Profile_Picture_Id, Fk_Portfolio_Id, Fk_Veteran_Queue_Id) VALUES
('James', 'Basel', 'Zimbulis', '01/01/1889', 'Effective Abroad (still overseas)', null, '19/07/1915', '1400', '32nd Battalion, D Company ', 'Church of England', '114 Beaufort Street, Perth, Western Australia', null, null, 
'James Basel Zimbulis, was a restaurant keeper and an Australian national who was born in Castellorifon an island off the coast of Greece. James lived in western Australia with his wife Mary Queenie Zimbulis. During his time in the war James was listed as ‘AWOL’ multiple times and court martialled resulting in 12 months imprisonment. In 1918 James was declared an ‘illegal Absentee’. In 1920 James as was discharged from the service and received no medals.',
null, 3, 1, 1, 1);

/*SECTION ONE*/
INSERT INTO  Sections(Id, Title, Approved, displayPosition, Fk_Portfolio_Id) VALUES
(1, '1912 Application to become a national', 0, 1, 1);

INSERT INTO MultiMedias(Media)
Select Convert(Varbinary(MAX),'In this document James basel Zimbulis is applying to become an Australian National. James states that he has been in the country for 9 years. James at the time is 23 years old. He states that his was born in Turkey and his current occupation is that of a waiter at a local cafe.')

INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id,Fk_Section_Id, FK_Portfolio_Id) VALUES
(1,'Applying to become a national in Australia', CURRENT_TIMESTAMP, 'text', null, 1, 1, 1, 1);



INSERT INTO  MultiMedias(Media)
SELECT BulkColumn
From openrowset ( Bulk 'C:\Users\STUDENT\source\repos\MSRProjectTeeAm2\Images\ShowImage.jpg', Single_Blob) as Media;


INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id, Fk_Section_Id, FK_Portfolio_Id) VALUES
(2, 'Statutory Declaration', CURRENT_TIMESTAMP, 'image', 'https://recordsearch.naa.gov.au/SearchNRetrieve/NAAMedia/ShowImage.aspx?B=1498211&T=P&S=11', 2, 2, 1, 1);

/*SECTION TWO*/

INSERT INTO  Sections(Id, Title, Approved, displayPosition, Fk_Portfolio_Id) VALUES
(2, '1912 Evidence of existence', 0, 2, 1);

INSERT INTO MultiMedias(Media)
Select Convert(Varbinary(MAX),'In this document outlines the existence of James Basel Zimbulis. In the document it outlines that he worked in a cafe "Trocadero Cafe" in western Australia. It states that he has been employed there for 18 months and has since displayed excellent character. ')

INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id, Fk_Section_Id, FK_Portfolio_Id) VALUES
(1, 'James Basel Zimbulis ', CURRENT_TIMESTAMP, 'text', null, 1, 3, 2, 1);


INSERT INTO  MultiMedias(Media)
SELECT BulkColumn
From openrowset ( Bulk 'C:\Users\STUDENT\source\repos\MSRProjectTeeAm2\Images\Existence_01.jpg', Single_Blob) as Media;

INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id, Fk_Section_Id, FK_Portfolio_Id) VALUES
(2, 'Proof of Existence', CURRENT_TIMESTAMP, 'image', 'https://recordsearch.naa.gov.au/SearchNRetrieve/NAAMedia/ShowImage.aspx?B=1498211&T=P&S=7', 2, 4, 2, 1);


/*Portfolio Two - Charles Lilley*/

INSERT INTO  Portfolios DEFAULT VALUES;

INSERT INTO Veterans(FirstName, MiddleName, SurName, DOB, Fate, Death, EnlistedDate, ServiceNo, Unit, Parish, Address, Town, Country, ShortBio, Status, Fk_User_Id, Fk_Profile_Picture_Id, Fk_Portfolio_Id, Fk_Veteran_Queue_Id) VALUES
('Charles', 'Harold', 'Lilley', '03/07/1892', 'Returned to Australia 1 November 1917', '16/06/1982', '20/07/1915', '19632', 'Field Artillery Brigade 8, Battery 29 ', null, 'Norton Street, Wangaratta, Victoria ', 'Wangaratta', 'Australia', 
'Charles ‘Charlie’ Harold Lilley was born in Armadale on 3 July, 1892. Charlie worked as a clerk and played for the Melbourne Football Club from 1913-1915 until he was enlisted into the Military. Charles embarked on 20 May 1916 and returned the following year on 1 November 1917. Lilley returned to the Melbourne Football Club in 1919 and played until 1925 as both a defender and a midfielder. Charles finished his career with 132 games played. Lilley died on 16 June 1982 at the age of 89.  He has a plaque in the Victorian Garden of Remembrance. ',
null, null, 1, 2, null);

/*SECTION ONE*/
INSERT INTO  Sections(Id, Title, Approved, displayPosition, Fk_Portfolio_Id) VALUES
(1, 'Football Career', 0, 1, 2);

INSERT INTO MultiMedias(Media)
Select Convert(Varbinary(MAX),'Charlie Lilley was a regular at the Melbourne Football Club before the war. He was known as a clever, pacy, and calm centreman. Unfortunately Charlies early career was at an uncompetitive Melbourne who finished 9th in his first season.  ')

INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id,Fk_Section_Id, FK_Portfolio_Id) VALUES
(1,'Football Career Before the War ', CURRENT_TIMESTAMP, 'text', null, 1, 5, 1, 2);


INSERT INTO  MultiMedias(Media)
SELECT BulkColumn
From openrowset ( Bulk 'C:\Users\STUDENT\source\repos\MSRProjectTeeAm2\Images\charlielilley.jpg', Single_Blob) as Media;


INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id, Fk_Section_Id, FK_Portfolio_Id) VALUES
(2, 'Headshot', CURRENT_TIMESTAMP, 'image', 'http://demonwiki.org/Charlie+Lilley ', 2, 6, 1, 2);

/*SECTION TWO*/

INSERT INTO  Sections(Id, Title, Approved, displayPosition, Fk_Portfolio_Id) VALUES
(2, 'Wartime', 0, 2, 2);

INSERT INTO MultiMedias(Media)
Select Convert(Varbinary(MAX),'Charlie was still able to play football during the war. In October 1916 he played in an Exhibition game for servicemen in London in front of the Prince of Whales, King Manuel of Portugal, and 8,000 other onlookers. Charlie played for the 3rd Division AIF taking on the Combined Training Units in London. The teams were made up of players from leagues around Australia. Gerald Brosnan of The Winner reported on the match and the local reactions. ')

INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id, Fk_Section_Id, FK_Portfolio_Id) VALUES
(1, 'At War', CURRENT_TIMESTAMP, 'text', 'http://demonwiki.org/Charlie+Lilley ', 1, 7, 2, 2);


INSERT INTO  MultiMedias(Media) 
SELECT BulkColumn
From openrowset ( Bulk 'C:\Users\STUDENT\source\repos\MSRProjectTeeAm2\Images\4007aAIFmatch.jpg', Single_Blob) as Media;


INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id, Fk_Section_Id, FK_Portfolio_Id) VALUES
(2, 'Squadron Photo', CURRENT_TIMESTAMP, 'image', 'https://australianfootball.com/articles/view/the%2Ba.i.f%2Bmatch%2Bin%2Blondon%252C%2B1916/1933', 2, 8, 2, 2);

END


