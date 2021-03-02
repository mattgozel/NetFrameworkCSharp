use Dvds
go

delete from Dvd
go

set identity_insert Dvd on

insert into Dvd (DvdID, Title, ReleaseYear, Director, Rating, Notes)
values (1, 'Sideways', 2005, 'Alexander Payne', 'R', 'We are not drinking any fucking merlot!'),
		(2, 'When Harry Met Sally...', 1989, 'Rob Reiner', 'R', 'I''ll have what she''s having.')

set identity_insert Dvd off