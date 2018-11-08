insert into Sections (Id, EventTitle, Approved, DisplayPosition, CoordY, CoordX, Message, CameraZoom, Veteran_Id) VALUES 
/*lat = y, long = x*/
(1,'Birth', 1, 1, '-37.8092193','144.9524607', null, 14, 211722),
(2,'Early Life', 1, 2, '-35.3596404','145.7347999', null, 8, 211722),
(3,'Teen Years', 1, 3, '-37.83514045','145.02929762217073', null, 12, 211722),
(4,'Early Adulthood', 1, 4, '-37.801125799999994','144.96761415', null, 14, 211722),
(5,'Early Adulthood Sacrifice', 1, 5, '-37.819220349999995', '144.96825627211973', null, 14, 211722),
(6,'Early Careeer', 1, 6, '-37.8142176', '144.9631608', null, 8, 211722),
(7,'Starting A Family', 1, 7, '-37.8142176', '144.9631608', null, 8, 211722),
(8,'Business Endeavours', 1, 8, '-30.5343665', '135.6301212', null, 6, 211722),
(9,'Start Of The War', 1, 9, '40.414025', '26.6695125', null, 6, 211722),
(10,'War Years', 1, 10, '50.6886109', '2.8839607', null, 6, 211722),
(11,'After The War', 1, 11, '51.5073219', '-0.1276474', null, 12, 211722),
(12,'Returing To Australia', 1, 12, '-37.81314075', '144.92427612816653', null, 12, 211722),
(13,'Career Changes', 1, 13, '-37.818002', '144.958978', null, 16, 211722),
(14,'Notable Achievements ', 1, 14, '-37.801125799999994', '144.96761415', null, 14, 211722),
(15,'Death', 1, 15, '-37.899569', '145.02138600229168', null, 14, 211722),
(16,'Student Reflections', 1, 16, '-37.8206176', '145.03862087720475', null, 16, 211722);

insert into Contents(Id, Title, Timestamp, MediaType, Source, DisplayPosition, Media, Section_Id, Veteran_Id) values 
/*Section 1*/
(1, '1865', null, 'Text', null, 1, 
'John Monash was born on the 27th of June 1865 in West Melbourne to Luis Monash & Bertha, née Manasse. Monash was the eldest of the three children & the only son in the family. Both parents were of Jewish decent and spoke German as their native language (John was raised bilingually).', 
1, 211722),
(2, '1865', null, 'Image', 'https://c1.staticflickr.com/3/2893/12199143986_c704716d54_b.jpg', 2, null, 1, 211722),
/*Section 2*/
(1, '1874', null, 'Text', null, 1, 
'Due to John’s father suffering terrible losses, the family moved to Jerilderie, NSW, where his father opened a store. John attended the public school there & was taught by Willian Elliot, where he learned mathematics. He studied at the public school until 1877, when his mother moved the children back to Melbourne.', 
2, 211722),
(2, '1874', null, 'Image', 'https://s3-ap-southeast-2.amazonaws.com/nswsa-content/images/15051_a047_006913.jpg', 2, null, 2, 211722),
(3, '1874', null, 'Image', 'https://collections.museumvictoria.com.au/content/media/11/45861-small.jpg', 3, null, 2, 211722),
/*Section 3*/
(1, '1879', null, 'Text', null,1,
'Monash attended Scotch College where he was educated under Alexander Morrison. Here, John achieved a few accomplishments such as coming second in mathematics & logic, writing a prized essay on Macbeth, and was even dux in 1881. In the public examinations, he won the mathematics exhibition and came fourth in the class list in French & German.',
3, 211722),
(2, '1879', null, 'Image', 'https://www.scotch.vic.edu.au/media/12395/greatscot_dec2011_08a_497x275.jpg', 2, null, 3, 211722),
(3, '1879', null, 'Image', 'https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/John_Monash_as_a_boy.jpg/800px-John_Monash_as_a_boy.jpg', 3, null, 3, 211722),
/*Section 4*/
(1, '1882', null, 'Text', null, 1, 
'John attended the University of Melbourne where he studied Arts & Engineering. In the first-year, he failed his examinations due to commitments outside of University. However, in his second & third year, Monash passed with third- and second-class honours respectively. Due to his passion for student politics, Monash also co-founded the Melbourne University Union. He even joined the university company of the militia in 1884.',
4, 211722),
(2, '1882', null, 'Image', 'http://bespoke-production.s3.amazonaws.com/engineering/assets/9c/adefa0680811e5a753d3f3e672f3f3/history-1880-uni-buildings.jpg', 2, null, 4, 211722),
/*Section 5*/
(1, '1885', null, 'Text', null, 1, 
'Due to his mother’s long fatal illness, John abandoned his course. To assist with family finances, John ended up finding work through a friend at the Princes Bridge over the Yarra. In the next two years after, Monash was able to complete his third year of University as a part-time student.',
5, 211722),
(2, '1885', null, 'Image', 'https://www.omegastereo.com/wp-content/uploads/2015/08/Melbourne.jpg', 2, null, 5, 211722),
/*Section 6*/
(1, '1887', null, 'Text', null, 1, 
'After an unsuccessful application for a commission in the Engineers, Monash joined the North Melbourne Battery of the Metropolitan Brigade of the Garrison Artillery and was appointed probationary lieutenant. At this point, Monash begun to be more fascinated with military theory.
Before the First World War, he was promoted several times to lieutenant, captain, major, lieutenant-colonel & colonel.
',
6, 211722),
/*Section 7*/
(1, '1889', null, 'Text', null, 1, 
'Monash was involved in an affair with Annie Gabriel, who was a wife of one of his colleagues. However, this was ended as Monash engaged a 20-year-old Hannah Victoria Moss, whom he married on the 8th of April 1891. They both had a child together named Bertha – born on 22nd of January 1893.', 
7, 211722),
(2, '1889', null, 'Image', 'https://files.monash.edu/records-archives/exhibitions/sirjohn/man/img/in001428.jpg ', 2, null, 7, 211722),
/*Section 8*/
(1, '1905', null, 'Text', null, 1, 
'After many years of hardships and poverty from his previous failed business, thanks to his experiences and back business associates, Monash formed the Reinforced Concrete & Monier Pipe Construction Co. Ltd. The success of his company made him able to pay off his debts at fast pace. His company monopolized the concrete construction industry and ended up forming a South Australian subsidiary.',
8, 211722),
(2, '1905', null, 'Image', 'https://gallery.its.unimelb.edu.au/imu/imu.php?request=multimedia&irn=101093', 2, null, 8, 211722),
/*Section 9*/
(1, 'August 1914', null, 'Text', null, 1, 
'Not long after being appointed as the commander of the 4th Infantry Brigade, Monash and his Brigade embarked to Gallipoli for the First World War. At Gallipoli, Monash’s Brigade was involved with the campaign against the Turks. During the campaign, Monash built his reputation on his decision-making and organisational ability, and was promoted to brigadier general the following year.', 
9, 211722),
(2, 'August 1914', null, 'Image', 'https://upload.wikimedia.org/wikipedia/commons/e/e1/John_Monash_2.jpg', 2, null, 9, 211722),
/*Section 10*/
(1, 'June 1916', null, 'Text', null, 1, 
'Monash & his command were transferred over to the Western Front. Here, Monash was involved in many battles including Messines, Broodseinde & the First Battle of Passchendaele. The display of his abilities and involvement impressed The British High Command, he was later promoted to lieutenant general & made commander of the Australian Corps in May 1918.',
10, 211722),
(2, 'June 1916', null, 'Image', 'http://www.jwire.com.au/wp-content/uploads/SirJohnmonash.jpg ', 2, null, 10, 211722),
/*Section 11*/
(1, '1918', null, 'Text', null, 1, 
'Shortly after the war Monash was appointed as the Director-General of Repatriation & Demobilisation, responsible for the repatriation of 160,000 Australian soldiers in Europe. During his time in London, Monash also wrote a book titled ‘The Australian Victories in France in 1918’.', 
11, 211722),
(2, '1918', null, 'Image', 'http://regimental-books.com.au/images/RB07982.JPG ', 2, null, 11, 211722),
/*Section 12*/
(1, 'December 1919', null, 'Text', null, 1, 
'Monash returned to Australia with a massive welcome, however, this was short lived due to the illness of his wife due to cervical cancer. She later died on the 27th of February 1920.',
12, 211722),
/*Section 13*/
(1, '1920', null, 'Text', null, 1, 
'Uncertain about his future, Monash went through different career paths. He first tried standing for the Senate and for a position as the head of the Institute of Science & Industry, but those fell through. Monash then became director of Hume Pipe Co. & other directorships. This was only for a short time, until he accepted the offer as being the head/founder of the State Electricity Commission of Victoria (SECV).', 
13, 211722),
(2, '1920', null, 'Image', 'https://www.victorianplaces.com.au/sites/default/files/styles/watermarked/public/exhibits/JYB0813.jpg?itok=mslIwImp', 2, null, 13, 211722),
/*Section 14*/
(1, '1923', null, 'Text', null, 1, 
'Monash became the vice-chancellor of the University of Melbourne (where he studied) and continued for the next eight years until his death. During this time, he also became the president of Australasian Association for the Advancement of Science in 1924-1926.', 
14, 211722),
(2, '1923', null, 'Image', 'https://upload.wikimedia.org/wikipedia/commons/5/5d/John_Monash_1.jpg', 2, null, 14, 211722),
/*Section 15*/
(1, '8 October 1931', null, 'Text', null, 1, 
'Since 1927, Monash was troubled with high blood-pressure, however, he persisted to work. In August 1931, his health deteriorated and ended up dying from heart attack on the 8 October. His state funeral had crowds of at least 250,000 which was the largest in Australia at the time. Monash’s body was buried in Brighton cemetery with Jewish rites.',
15, 211722),
(2, '8 October 1931', null, 'Image', 'https://www.nationalanzaccentre.com.au/sites/default/files/styles/character_bite_images/public/Monash-%26-wife-gravestone.jpg?itok=brClwftk ', 2, null, 15, 211722),
/*Section 16*/
(1, 'Reflections On The My School Remebers Project', null, 'Text', null, 1, 
'This is a short reflection on my experiences from completing the My School Remembers project',
16, 211722),
(2, 'What did you learn?', null, 'Text', null, 2, 
'During my research of John Monash, I learned that his life did not follow a straight line as he had several career paths. John Monash had many interests in his life which influenced many of his career choices and enjoyed pursuing challenging tasks.',
16, 211722),
(3, 'What did you enjoy about this?', null, 'Text', null, 3, 
'The time I spent researching about John Monash was what I enjoyed about this experience, as I was able to learn about an individual in a different point in time. I was able to immerse myself in another person’s World and learn a lot about the past.',
16, 211722),
(4, 'Has this experience changed your outlook?', null, 'Text', null, 4, 
'My research into John Monash has helped me realise that the veterans that served The First World War were just regular people like us, who happened to join the war under circumstance. It just shows that regular people can make an impact to shape the World we live in today.',
16, 211722);