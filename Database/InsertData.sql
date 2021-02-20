use SpringProject;


/*----------------------------------------------------------------------------*/
/*INSERT DATA*/
/*----------------------------------------------------------------------------*/

/* Policy Table */

insert into Policy values (10001, 'Regular Member');
insert into Policy values (10002, 'Gold Member');

/* Branches Table */

insert into Branches values (101, 'Alberta', 'Calgary Downtown', 4037807800, 4037807809);
insert into Branches values (102, 'Alberta', 'Calgary West', 4034564566, 4034564567);
insert into Branches values (103, 'Alberta', 'Edmonton Downtown', 7803193499, 7802493450);
insert into Branches values (104, 'Alberta', 'Edmonton South', 7804638230, 7804638233);
insert into Branches values (105, 'Alberta', 'Red Deer', 7803743924, 7803743922);
insert into Branches values (106, 'Alberta', 'Lethbridge', 7809235969, 7809235963);
insert into Branches values (107, 'Alberta', 'Banff', 7804324398, 7804324391);
insert into Branches values (108, 'Alberta', 'Jasper', 7808432021, 7808432024);
insert into Branches values (109, 'Alberta', 'Medicine Hat', 7807439023, 7807439026);

/* Login Table */

insert into LoginInformation values (11111,'admin','admin','Admin');
insert into LoginInformation values (11112,'admin2','admin2','Admin');

insert into LoginInformation values (32343,'El_Said_Gold','El_Said_Gold','Employee');
insert into LoginInformation values (45565,'Katz_Califieri','Katz_Califieri','Employee');
insert into LoginInformation values (33456,'Mohammed_Elmorsy','Mohammed_Elmorsy','Employee');

insert into LoginInformation values (76543,'Cricket_Singh','Cricket_Singh','Employee');
insert into LoginInformation values (98345,'Kim_Brandt','Kim_Brandt','Employee');
insert into LoginInformation values (10902,'Patel_Bhai','Patel_Bhai','Employee');

insert into LoginInformation values (10101,'Akhil_Patel','Akhil_Patel','Employee');
insert into LoginInformation values (12121,'Erwin_Pascual','Erwin_Pascual','Employee');
insert into LoginInformation values (15151,'Abraar_Palitana','Abraar_Palitana','Employee');
insert into LoginInformation values (22222,'Hassan_Iftikhar','Hassan_Einstein','Employee');

/* Employees Table */

insert into Employees values (11111, 'Bill', 'Gates II', 'male', '1965-09-15',1234567890, 12345, 'Rich Boy Avenue SW', null, null, 'Edmonton', 'Alberta', 'T5Y0N0', 101, 2000000);
insert into Employees values (11112, 'Bill', 'Gates III', 'male', '1995-09-15',1234567899, 12345, 'Rich Boy Avenue SW', null, null, 'Edmonton', 'Alberta', 'T5Y0N0', 101, 500000);

insert into Employees values (32343, 'El Said', 'Gold', 'male', '2000-09-14', 4034638734, 1403, 'Heyboi Avenue NW', 1404, 2, 'Calgary', 'Alberta', 'T1X0L3', 102, 30000);
insert into Employees values (45565, 'Katz', 'Califieri', 'male', '1990-04-07', 4035463972, 19467, 'Dingleberry Avenue', 1032, 6, 'Calgary', 'Alberta', 'T1X0R9', 102, 35000);
insert into Employees values (33456, 'Mohammed', 'Elmorsy', 'male', '1985-08-31', 4034756943, 10432, 'Freshboi Blvd.', null, null, 'Calgary', 'Alberta', 'T1X0S4', 103, 100000);

insert into Employees values (76543, 'Cricket', 'Singh', 'female', '1964-03-21', 4034639324, 4032, 'Nugget Street NW', 1504, 1, 'Calgary', 'Alberta', 'T1X4F3', 104, 35000);
insert into Employees values (98345, 'Kim', 'Brandt', 'female', '1952-02-03', 4036953598, 101, 'Bigballa Court NW', null, null, 'Calgary', 'Alberta', 'T4X5G7', 105, 32000);
insert into Employees values (10902, 'Patel', 'Bhai', 'female', '1964-03-21', 4033728432, 9456, 'Hellnaw Avenue NW', 157, 5, 'Calgary', 'Alberta', 'T1X4F3', 104, 30000);

insert into Employees values (10101, 'Akhil', 'Patel', 'male', '1997-11-11', 5879911910, 240, 'Hollister Avenue', null, null, 'Edmonton', 'Alberta', 'T6X2A6', 106, 45000);
insert into Employees values (12121, 'Erwin', 'Pascual', 'male', '1998-03-21', 7802334803, 14030, '137 Avenue NW', 303, 3, 'Edmonton', 'Alberta', 'T3R2R9', 107, 40000);
insert into Employees values (15151, 'Abraar', 'Palitana', 'male', '1994-01-31', 7806487309, 13078, '146 Street NW', 4, null, 'Edmonton', 'Alberta', 'T7X2S8', 108, 20000);
insert into Employees values (22222, 'Hassan', 'Iftikhar', 'male', '1995-02-08', 7808028123, 10410, 'Jasper Avenue NW', null, null, 'Edmonton', 'Alberta', 'T4T3G5', 109, 45000);

/* Customers Table */

insert into Customers values (162961243, 'Erwine', 'Cradle', 'male', '1993-02-04', 7803759364, 1409, 'Weidle Way SW', null, null, 'Edmonton', 'AB', 'T6X2A6', 7439740927492745, 10001);
insert into Customers values (122819668, 'Manpreet', 'Singh', 'male', '1994-05-23', 5875643890, 1322, 'Crabby Way SW', 103, 4, 'Edmonton', 'AB', 'T6R6S2', 6473890432761489, 10002);
insert into Customers values (194331019, 'Wamiq', 'Hussain', 'male', '1996-07-13', 7806753290, 10325, 'Whyte Avenue NW', 304, 1, 'Edmonton', 'AB', 'T6K4W1', 8643902634890213, 10001);



insert into Customers values (499692774, 'Katarina', 'Oneill', 'female', '1948-08-31', 7807170099, 677, 'Bank St. ', null, null, 'Richibucto', 'NB', 'E4WJ7T', 5492383116130265, 10001);
insert into Customers values (808935815, 'Cindy', 'Joseph', 'female', '1951-07-17', 7808278687, 5, 'Cottage Street', null, null, 'Simcoe', 'ON', 'N3YY3M', 5292112348695726, 10001);
insert into Customers values (340459371, 'Marcia', 'Lowry', 'female', '1952-07-08', 7807640999, 9765, 'Johnson Street', 401,3, 'Labrador City', 'LB', 'A2VK5T', 6011211695408515, 10001);
insert into Customers values (462757695, 'Tilly', 'Vaughan', 'male', '1996-07-13', 7809131102, 609, 'S.Clinton Street', 409,7, 'Fourchu', 'NS', 'B2JV3T', 4134860435576283, 10001);
insert into Customers values (403824246, 'Franklyn', 'Blackburn', 'male', '1953-12-17', 7802250515, 811, 'South Road', 515,44, 'Port Colborne', 'ON', 'L3KS3J', 6457377811560371, 10001);

insert into Customers values (876787672, 'Natalia', 'Gibson', 'female', '1954-03-05', 7808554230, 784, 'Lakewood St', null, null, 'Middlesex', 'ON', 'N0MP1G', 4545496997566645, 10001);
insert into Customers values (974759932, 'Bogdan', 'Waters', 'male', '1955-03-01', 7800764142, 7821, 'Roosevelt Street', 40,9, 'Canterbury', 'NB', 'E6HK2M', 4184082227498456, 10001);
insert into Customers values (397216367, 'Maureen', 'Guest', 'female', '1962-02-20', 7801837472, 3, 'W. Surrey Drive', null, null, 'Delhi', 'ON', 'N4BV5M', 4090457265758875, 10001);
insert into Customers values (251169703, 'Patience', 'Benton', 'male', '1967-02-03', 7809253324, 57, 'Union Ave', 101,7, 'Kingsville', 'ON', 'N9YJ4P', 4030604815394320, 10001);
insert into Customers values (765537310, 'Georgia', 'Carey', 'male', '1967-08-15', 7804253260, 155, 'Stonybrook Drive', 331,9, 'Wetaskiwin', 'AB', 'T9AV6X', 4588993902793353, 10001);

insert into Customers values (429692746, 'Gavin', 'Johnson', 'male', '1967-09-03', 7806550692, 713, 'West Myrtle Lane', 951,1, 'Deer Lake', 'LB', 'A8AC6M', 4085075335678498, 10001);
insert into Customers values (847859824, 'Lucia', 'Whitney', 'male', '1971-02-08', 7805424150, 521, 'Squaw Creek Ave', null, null, 'Metchosin', 'BC', 'V9CS8A', 4040915322433817, 10001);

insert into Customers values (523666846, 'Alexandre', 'Turnbull', 'male', '1973-10-14', 7804969301, 612, 'Gartner St', 751,1, 'Amherstburg', 'ON', 'N0MP1G', 5140069225885255, 10001);

insert into Customers values (575597284, 'Emeli', 'Velazquez', 'female', '1974-06-04', 7809801300, 123, 'Richardson St', null, null, 'Glace Bay', 'NS', 'B1AH7P', 4092384420323452, 10001);
insert into Customers values (330282285, 'Ammaar', 'Mustafa', 'male', '1975-02-22', 7808825402, 9592, 'South Highland Street', 751,8, 'London', 'ON', 'N5VC1K', 4071529718612421, 10001);

insert into Customers values (809807009, 'Ariyan', 'Callahan', 'male', '1975-12-12', 7808098891, 175, 'Glenholme Ave', null, null, 'Manan Island', 'NB', 'E5GP7G', 4095577767910859, 10001);
insert into Customers values (464310603, 'Toby', 'Hayes', 'male', '1977-11-03', 7802587567, 481, 'High Avenue', 901,55,'Acton', 'ON', 'L7JV6V', 4095628921551228, 10001);
insert into Customers values (861181254, 'Aaisha', 'Trejo', 'female', '1979-08-15', 7802321116, 98, 'Airport St', 759,8, 'Hillsborough', 'NB', 'E4HS0Y', 4038180834898924, 10001);
insert into Customers values (136892730, 'Alima', 'Mcgee', 'female', '1979-10-23', 7800644924, 635, 'Trusel Rd', null, null, 'Val-des-Monts', 'QC', 'J8NR6X', 4540891329802301, 10001);
insert into Customers values (548593847, 'Marta', 'Mccoy', 'female', '1981-01-24', 7804804505, 7845, 'Fulton St', 754,8, 'Neguac', 'NB', 'E9GY9G', 5137306953319205, 10001);

insert into Customers values (382500971, 'Dave', 'Conroy', 'male', '1983-10-24', 7806202848, 75, 'Thomas Circle', null, null, 'Cedar', 'BC', 'V9XY7E', 5498999084863654, 10001);
insert into Customers values (799336175, 'Georgina', 'Shah', 'male', '1984-04-16', 7808309197, 265, 'Mountainview Street', 529,7, 'Tecumseh ', 'ON', 'N8NS8B', 4548577197138785, 10001);
insert into Customers values (571367010, 'Zackary', 'Forster', 'male', '1989-04-22', 7802964975, 7722, 'Heather Street', null, null, 'Cobourg', 'ON', 'K9AR8G', 5301958314860820, 10001);
insert into Customers values (668885270, 'Chyna', 'Clarke', 'male', '1989-11-22', 7809793474, 243, 'Arrowhead Road', null, null, 'Saint-Pierre', 'QC', 'H8RE8P', 4557936876572755, 10001);
insert into Customers values (378569428, 'Aisha', 'Tanner', 'female', '1991-12-02', 7804501292, 5, 'West High Noon Ave', null, null, 'Petitcodiac', 'NB', 'E4ZP3K', 5300159927868745, 10001);

/* Car Types */

insert into CarTypes values ('hypercar', 1500, 250, 500);
insert into CarTypes values ('supercar', 1300, 200, 400);
insert into CarTypes values ('sedan', 1000, 150, 400);
insert into CarTypes values ('pickup', 1500, 250, 500);

/* Cars Table */

insert into Cars values ('1FTNW21F21EA19317', 'VLMGHM', 'hypercar', 'Mclaren Senna', 'premium unleaded', 2018, 101, 'available');
insert into Cars values ('1FUPARYB0PL456099', 'DYKAGN', 'hypercar', 'Koenigsegg One:1', 'premium unleaded', 2018, 101, 'available');
insert into Cars values ('JYARN17Y49A078987', 'LNLCAE', 'hypercar', 'Aston Martin Vulcan', 'premium unleaded', 2018, 101, 'available');
insert into Cars values ('1C3BC56D1GF274827', 'IOQRBJ', 'supercar', 'Lamborghini Huracan Performante', 'premium unleaded', 2018, 101, 'available');
insert into Cars values ('2D4RN4DG9BR726796', 'FYJMJO', 'supercar', 'Lamborghini Aventador SVJ', 'premium unleaded', 2018, 101, 'available');
insert into Cars values ('1G1JC81W9HJ287740', 'KYWUYH', 'supercar', 'Ferrari 488', 'premium unleaded', 2018, 101, 'available');
insert into Cars values ('1GBJC39U47E120646', 'DTFYWE', 'sedan', 'Mercedes-Benz S65', 'premium unleaded', 2018, 101, 'available');
insert into Cars values ('JW6DEJ1E83M061001', 'VTCLDR', 'sedan', 'BMW M5', 'premium unleaded', 2018, 101, 'available');
insert into Cars values ('1FTNF20FX3EA85103', 'OWBVTN', 'sedan', 'Audi RS7', 'premium unleaded', 2018, 101, 'available');
insert into Cars values ('4V4MC9GG61N270164', 'NQAGOC', 'pickup', 'Mercedes-Benz G63 6x6', 'premium unleaded', 2018, 101, 'rented');

insert into Cars values ('1FTEF14Y1JKB07428', 'FROUEC', 'hypercar', 'Bugatti Chiron', 'premium unleaded', 2018, 102, 'available');
insert into Cars values ('1MEFM59S71G654372', 'UAGQAP', 'hypercar', 'Pagani Huayra', 'premium unleaded', 2018, 102, 'available');
insert into Cars values ('2GCEK14C6F1125608', 'QDPWES', 'hypercar', 'Lamborghini Centenario', 'premium unleaded', 2018, 102, 'available');
insert into Cars values ('1FTRX14W26NA45315', 'MVGXLX', 'supercar', 'Lamborghini Huracan Performante', 'premium unleaded', 2018, 102, 'available');
insert into Cars values ('4S4BRCFC4C3217941', 'LGITHW', 'supercar', 'Lamborghini Aventador SVJ', 'premium unleaded', 2018, 102, 'available');
insert into Cars values ('1GKEC16K4SJ729115', 'GGQCNG', 'supercar', 'Ferrari 488', 'premium unleaded', 2018, 102, 'available');
insert into Cars values ('1XP9D29X3HD276781', 'XEKLAE', 'sedan', 'Mercedes-Benz S65', 'premium unleaded', 2018, 102, 'available');
insert into Cars values ('1M1AN09Y3CM094774', 'XGTLBJ', 'sedan', 'BMW M5', 'premium unleaded', 2018, 102, 'rented');
insert into Cars values ('WB1053502L6391212', 'GKVMFP', 'sedan', 'Audi RS7', 'premium unleaded', 2018, 102, 'available');
insert into Cars values ('JM3TB3CV7D0404863', 'NQQJLL', 'pickup', 'Mercedes-Benz G63 6x6', 'premium unleaded', 2018, 102, 'available');

insert into Cars values ('1FDES14H6MHB97510', 'XLYJYL', 'hypercar', 'Ferrari LaFerrari', 'premium unleaded', 2018, 103, 'rented');
insert into Cars values ('2MHHM79V84X676087', 'LGIIEP', 'hypercar', 'Porsche 918 Spyder', 'premium unleaded', 2018, 103, 'available');
insert into Cars values ('1GDKH37N6P3555639', 'BCHAUB', 'hypercar', 'Mclaren P1', 'premium unleaded', 2018, 103, 'available');
insert into Cars values ('3C6TD5CT4CG369732', 'IOQRBJ', 'supercar', 'Lamborghini Huracan Performante', 'premium unleaded', 2018, 103, 'available');
insert into Cars values ('1FDAW46Y69EA65731', 'FYJMJO', 'supercar', 'Lamborghini Aventador SVJ', 'premium unleaded', 2018, 103, 'available');
insert into Cars values ('1G8AW18F06Z171329', 'KYWUYH', 'supercar', 'Ferrari 488', 'premium unleaded', 2018, 103, 'available');
insert into Cars values ('1HGEJ6635WL044821', 'JLFRQV', 'sedan', 'Mercedes-Benz S65', 'premium unleaded', 2018, 103, 'available');
insert into Cars values ('JL6AAC1H23K099735', 'KYFTGV', 'sedan', 'BMW M5', 'premium unleaded', 2018, 103, 'available');
insert into Cars values ('5FNYF4H50CB022692', 'WKDEKR', 'sedan', 'Audi RS7', 'premium unleaded', 2018, 103, 'available');
insert into Cars values ('4V4MC9GH09N290401', 'EAYLEK', 'pickup', 'Mercedes-Benz G63 6x6', 'premium unleaded', 2018, 103, 'available');

insert into Cars values ('7JAEXDF37LTYCWF0X', 'SVRTL8', 'hypercar', 'Mclaren Senna', 'premium unleaded', 2018, 104, 'available');
insert into Cars values ('EZ2AWSS1EWBQ9BGFE', 'J21CLK', 'hypercar', 'Koenigsegg One:1', 'premium unleaded', 2018, 104, 'available');
insert into Cars values ('WBIOW0PF6ZYQXRWS5', '5Q3PWW', 'hypercar', 'Aston Martin Vulcan', 'premium unleaded', 2018, 104, 'available');
insert into Cars values ('UUG5FVRYEUHIZ3IDM', '0O0W6N', 'supercar', 'Lamborghini Huracan Performante', 'premium unleaded', 2018, 104, 'available');
insert into Cars values ('Y03IEU9UPWQ78E3FY', 'ENLPNU', 'supercar', 'Lamborghini Aventador SVJ', 'premium unleaded', 2018, 104, 'available');
insert into Cars values ('NGET18YS9XKOEIUQ2', 'M96813', 'supercar', 'Ferrari 488', 'premium unleaded', 2018, 104, 'available');
insert into Cars values ('PXJ4EC9SQFZ5SS2F5', 'BLYO7N', 'sedan', 'Mercedes-Benz S65', 'premium unleaded', 2018, 104, 'available');
insert into Cars values ('HZYN23DR4I1K0GO47', 'JOKHX7', 'sedan', 'BMW M5', 'premium unleaded', 2018, 104, 'available');
insert into Cars values ('7BWSTPIWNDN442YM1', '0W8OPJ', 'sedan', 'Audi RS7', 'premium unleaded', 2018, 104, 'available');
insert into Cars values ('6OH7V49SQERDPZ0M4', 'W3WC5K', 'pickup', 'Mercedes-Benz G63 6x6', 'premium unleaded', 2018, 104, 'available');

insert into Cars values ('K2YS09Z617EBTJUQ8', '8V3RDY', 'hypercar', 'Bugatti Chiron', 'premium unleaded', 2018, 105, 'available');
insert into Cars values ('MKGBENFD2FTTIZ2X6', '8370OK', 'hypercar', 'Pagani Huayra', 'premium unleaded', 2018, 105, 'available');
insert into Cars values ('XK3ZJSUHINIQ3W1D7', 'PEZELZ', 'hypercar', 'Lamborghini Centenario', 'premium unleaded', 2018, 105, 'available');
insert into Cars values ('9BRYQM1GWPYCE1DDI', 'Y38HVA', 'supercar', 'Lamborghini Huracan Performante', 'premium unleaded', 2018, 105, 'available');
insert into Cars values ('9QRA1U4UVWD9XD0LQ', 'WA3HWZ', 'supercar', 'Lamborghini Aventador SVJ', 'premium unleaded', 2018, 105, 'available');
insert into Cars values ('PDX514VCWIYF1NNYG', 'DL2U1D', 'supercar', 'Ferrari 488', 'premium unleaded', 2018, 105, 'available');
insert into Cars values ('5TNG56ZBCD2RRMT4T', '0Z2KJX', 'sedan', 'Mercedes-Benz S65', 'premium unleaded', 2018, 105, 'available');
insert into Cars values ('33PTAK4Y305IQXG0Q', '8HIZIT', 'sedan', 'BMW M5', 'premium unleaded', 2018, 105, 'available');
insert into Cars values ('Y3LHGQVTEVCGOWKBF', 'C1T23C', 'sedan', 'Audi RS7', 'premium unleaded', 2018, 105, 'available');
insert into Cars values ('G35JP6PC8HUP7T3FO', 'TOWK2Z', 'pickup', 'Mercedes-Benz G63 6x6', 'premium unleaded', 2018, 105, 'available');

insert into Cars values ('8V4AEJGN6ORD3QVVZ', 'GGKH9D', 'hypercar', 'Ferrari LaFerrari', 'premium unleaded', 2018, 106, 'available');
insert into Cars values ('DUAXDADP5ZLK0TM7Y', 'EGBSL6', 'hypercar', 'Porsche 918 Spyder', 'premium unleaded', 2018, 106, 'available');
insert into Cars values ('RX2T7DL29LIX635HT', 'VCDBS5', 'hypercar', 'Aston Martin Vulcan', 'premium unleaded', 2018, 106, 'available');
insert into Cars values ('VHRXXRL6NKEPPII7X', 'P62K81', 'supercar', 'Lamborghini Huracan Performante', 'premium unleaded', 2018, 106, 'available');
insert into Cars values ('VZU39M1JDISJKOGUT', 'BL1FTP', 'supercar', 'Lamborghini Aventador SVJ', 'premium unleaded', 2018, 106, 'available');
insert into Cars values ('XPONBD0OB65GOUF7J', 'AKMQ94', 'supercar', 'Ferrari 488', 'premium unleaded', 2018, 106, 'available');
insert into Cars values ('L48I5VT2ZQDDI4MCE', '10MV4P', 'sedan', 'Mercedes-Benz S65', 'premium unleaded', 2018, 106, 'available');
insert into Cars values ('3EQJH1ES95DGSNFJS', 'XA73FV', 'sedan', 'BMW M5', 'premium unleaded', 2018, 106, 'available');
insert into Cars values ('EWPX5L5AQW8AZV3MX', 'YAU6X4', 'sedan', 'Audi RS7', 'premium unleaded', 2018, 106, 'available');
insert into Cars values ('V63IKDHK6JIHGFY72', 'JZR8V4', 'pickup', 'Mercedes-Benz G63 6x6', 'premium unleaded', 2018, 106, 'available');

insert into Cars values ('AWQDCI6IXJIWOH0BZ', '22R6OP', 'hypercar', 'Mclaren Senna', 'premium unleaded', 2018, 107, 'available');
insert into Cars values ('MTTPII7GS7LFPRHZJ', 'DTLMBL', 'hypercar', 'Koenigsegg One:1', 'premium unleaded', 2018, 107, 'available');
insert into Cars values ('O0NHCF7RZLWT7U3OK', 'VBH47T', 'hypercar', 'Aston Martin Vulcan', 'premium unleaded', 2018, 107, 'available');
insert into Cars values ('XELJJIBTSGISJR06D', '3XL0SZ', 'supercar', 'Lamborghini Huracan Performante', 'premium unleaded', 2018, 107, 'available');
insert into Cars values ('4HTVJ9ARDTCCYB3Q6', 'MK0WT0', 'supercar', 'Lamborghini Aventador SVJ', 'premium unleaded', 2018, 107, 'available');
insert into Cars values ('4OTIQL9VCHB1GS4T1', 'HOG1IL', 'supercar', 'Ferrari 488', 'premium unleaded', 2018, 107, 'available');
insert into Cars values ('2EMAQKV4TTADHPAPR', 'YM2HHT', 'sedan', 'Mercedes-Benz S65', 'premium unleaded', 2018, 107, 'available');
insert into Cars values ('TBNLF008DSVLZ5U8S', 'L8QYUP', 'sedan', 'BMW M5', 'premium unleaded', 2018, 107, 'available');
insert into Cars values ('24S8PRNQF2E3Z50EM', '44RXG6', 'sedan', 'Audi RS7', 'premium unleaded', 2018, 107, 'available');
insert into Cars values ('2KZ2UH1JGVRXNL8WD', '1KIIC6', 'pickup', 'Mercedes-Benz G63 6x6', 'premium unleaded', 2018, 107, 'available');

insert into Cars values ('M5RNUIJQEKNWDOCBB', '9JV1TZ', 'hypercar', 'Bugatti Chiron', 'premium unleaded', 2018, 108, 'available');
insert into Cars values ('VEJZCDRD75CCLCKKG', 'R4B47P', 'hypercar', 'Pagani Huayra', 'premium unleaded', 2018, 108, 'available');
insert into Cars values ('NYXUWCRK6WGORGOTN', 'ZW8PB8', 'hypercar', 'Lamborghini Centenario', 'premium unleaded', 2018, 108, 'available');
insert into Cars values ('3TYMDZXVCY4593JFL', 'V9GC4J', 'supercar', 'Lamborghini Huracan Performante', 'premium unleaded', 2018, 108, 'available');
insert into Cars values ('6KU4A7BM8P6T8HJP9', 'QN8R7H', 'supercar', 'Lamborghini Aventador SVJ', 'premium unleaded', 2018, 108, 'available');
insert into Cars values ('HM9RXHCUCBTSK4FPD', 'Y4VRJC', 'supercar', 'Ferrari 488', 'premium unleaded', 2018, 108, 'available');
insert into Cars values ('W0BCLE79F34QHZ209', 'N2ATYA', 'sedan', 'Mercedes-Benz S65', 'premium unleaded', 2018, 108, 'available');
insert into Cars values ('MDVB6H7WV0Q2TML27', '4D38HP', 'sedan', 'BMW M5', 'premium unleaded', 2018, 108, 'available');
insert into Cars values ('LK7UTBPETRRAU0K7M', '9JDC1J', 'sedan', 'Audi RS7', 'premium unleaded', 2018, 108, 'available');
insert into Cars values ('69PW1N69RVDAE44ST', 'PM6KGS', 'pickup', 'Mercedes-Benz G63 6x6', 'premium unleaded', 2018, 108, 'available');

insert into Cars values ('G6LO589CVZATR1HUQ', 'BOONB1', 'hypercar', 'Ferrari LaFerrari', 'premium unleaded', 2018, 109, 'available');
insert into Cars values ('J0FH5GBZFMDHV5126', '6WW581', 'hypercar', 'Porsche 918 Spyder', 'premium unleaded', 2018, 109, 'available');
insert into Cars values ('U0J5ZYTV3WZ8WK8XF', 'H7NRRS', 'hypercar', 'Mclaren P1', 'premium unleaded', 2018, 109, 'available');
insert into Cars values ('XH0AINF7IFJSSV0J9', 'I70AHS', 'supercar', 'Lamborghini Huracan Performante', 'premium unleaded', 2018, 109, 'available');
insert into Cars values ('SVMVS6S2JDMLNQ7JF', 'BKPNLJ', 'supercar', 'Lamborghini Aventador SVJ', 'premium unleaded', 2018, 109, 'available');
insert into Cars values ('ZKZI1QWG1UNET5D4F', '65M3P8', 'supercar', 'Ferrari 488', 'premium unleaded', 2018, 109, 'available');
insert into Cars values ('YUWF9KP5Q7JYIQS1Z', '1VDRMA', 'sedan', 'Mercedes-Benz S65', 'premium unleaded', 2018, 109, 'available');
insert into Cars values ('73ZXHHS73CLNLBBLZ', 'GR8EJU', 'sedan', 'BMW M5', 'premium unleaded', 2018, 109, 'available');
insert into Cars values ('00WPQ2QMGJVGUKWXT', 'V9AM5F', 'sedan', 'Audi RS7', 'premium unleaded', 2018, 109, 'available');
insert into Cars values ('LMYXN8ECD4FZ5KT5V', '58G8JL', 'pickup', 'Mercedes-Benz G63 6x6', 'premium unleaded', 2018, 109, 'available');

/* RentalTransactions Table */

insert into RentalTransactions values (90001, 15151, 103, '2019-01-01', '2019-01-01', '2019-01-04', '1FDES14H6MHB97510', 162961243);
insert into RentalTransactions values (90002, 11111, 101, '2019-02-13', '2019-02-13', '2019-02-24', '1FTNW21F21EA19317', 162961243);
insert into RentalTransactions values (90003, 10101, 106, '2019-04-03', '2019-04-03', '2019-04-15', '8V4AEJGN6ORD3QVVZ', 162961243);
insert into RentalTransactions values (90004, 98345, 102, '2019-05-20', '2019-05-20', '2019-05-25', '1M1AN09Y3CM094774', 194331019);
insert into RentalTransactions values (90005, 33456, 101, '2019-05-14', '2019-05-20', '2019-06-04', '4V4MC9GG61N270164', 122819668);

/* Returning Table */

insert into Returning values (90001, 103, 15151, '2019-06-03');
insert into Returning values (90002, 102, 98345, '2019-05-25');
insert into Returning values (90003, 101, 33456, '2019-06-04');


