/*Portfolio One - James Zimbulis*/

INSERT INTO  Portfolios DEFAULT VALUES;

INSERT INTO Veterans(FirstName, MiddleName, SurName, DOB, Fate, Death, EnlistedDate, ServiceNo, Unit, Parish, Address, Town, Country, ShortBio,Status, Fk_User_Id, Fk_Profile_Picture_Id, Fk_Portfolio_Id, Fk_Veteran_Queue_Id) VALUES
('James', 'Basel', 'Zimbulis', '01/01/1889', 'Effective Abroad (still overseas)', null, '19/07/1915', '1400', '32nd Battalion, D Company ', 'Church of England', '114 Beaufort Street, Perth, Western Australia', null, null, 
'James Basel Zimbulis, was a restaurant keeper and an Australian national who was born in Castellorifon an island off the coast of Greece. James lived in western Australia with his wife Mary Queenie Zimbulis. During his time in the war James was listed as ‘AWOL’ multiple times and court martialled resulting in 12 months imprisonment. In 1918 James was declared an ‘illegal Absentee’. In 1920 James as was discharged from the service and received no medals.',
null, 3, 1, 1, 1);

/*SECTION ONE*/
INSERT INTO  Sections(Id, Title, Approved, displayPosition, Fk_Portfolio_Id) VALUES
(1, '1912 Application to become a national', 0, 1, 1);

INSERT INTO MultiMedias(Media)
Select Convert(Varbinary(MAX),'In this document James basel Zimbulis is applying to become an Australian National. James states that he has been in the country for 9 years. James at the time is 23 years old. He states that his was born in Turkey and his current occupation is that of a waiter at a local café.')

INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id,Fk_Section_Id, FK_Portfolio_Id) VALUES
(1,'Applying to become a national in Australia', CURRENT_TIMESTAMP, 'text', null, 1, 1, 1, 1);

INSERT INTO  MultiMedias(Media)
SELECT BulkColumn
From openrowset ( Bulk 'C:\Users\WorkStation\source\repos\MSR_Spike_Test_DB\Images\ShowImage.jpg', Single_Blob) as Media;

INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id, Fk_Section_Id, FK_Portfolio_Id) VALUES
(2, 'Statutory Declaration', CURRENT_TIMESTAMP, 'image', 'https://recordsearch.naa.gov.au/SearchNRetrieve/NAAMedia/ShowImage.aspx?B=1498211&T=P&S=11', 2, 2, 1, 1);

/*SECTION TWO*/

INSERT INTO  Sections(Id, Title, Approved, displayPosition, Fk_Portfolio_Id) VALUES
(2, '1912 Evidence of existence', 0, 2, 1);

INSERT INTO MultiMedias(Media)
Select Convert(Varbinary(MAX),'In this document outlines the existence of James Basel Zimbulis. In the document it outlines that he worked in a café ‘Trocadero Café’ in western Australia. It states that he has been employed there for 18 months and has since displayed excellent character. ')

INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id, Fk_Section_Id, FK_Portfolio_Id) VALUES
(1, 'James Basel Zimbulis ', CURRENT_TIMESTAMP, 'text', null, 1, 3, 2, 1);

INSERT INTO  MultiMedias(Media)
SELECT BulkColumn
From openrowset ( Bulk 'C:\Users\WorkStation\source\repos\MSR_Spike_Test_DB\Images\Existence_01.jpg', Single_Blob) as Media;

INSERT INTO  Contents(Id, Title, Timestamp, type, source, DisplayPosition, Fk_MultiMedia_Id, Fk_Section_Id, FK_Portfolio_Id) VALUES
(2, 'Proof of Existence', CURRENT_TIMESTAMP, 'image', 'https://recordsearch.naa.gov.au/SearchNRetrieve/NAAMedia/ShowImage.aspx?B=1498211&T=P&S=7', 2, 4, 2, 1);

