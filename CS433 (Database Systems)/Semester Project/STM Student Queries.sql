/* 
	Student Queries
	Shaun Mbateng
	CS 433
	November 15, 2013
*/

--While only the first 7 are purely select, 4 and 5 each contain a subselect
--	which in itself I each considered a select statement (it fits the requirements)

--1. List the members and their membership type in ascending order of names.
select * 
from dbo.Member left outer join dbo.Membership 
on dbo.Member.M_ID = dbo.Membership.M_ID
order by 'M_Name' ASC;

--2. List the members and their join date in descending order of dates.
select * 
from dbo.Enter right outer join dbo.Member 
on dbo.Member.M_ID = dbo.Enter.M_ID
order by 'E_Date' DESC;

--3. List the consoles product id's that there is a game in the system for that platform
select * 
from dbo.Console, dbo.Product, dbo.Enter, dbo.Game 
where dbo.Console.P_ID = dbo.Product.P_ID and dbo.Product.P_ID  = dbo.Enter.P_ID and dbo.Game.Platform = dbo.Console.Platform;

--4. List the entries of members whose ID is less than 2500 and the entry is not of a console.
select * 
from dbo.Enter left outer join dbo.Member
on dbo.Enter.E_ID = dbo.Member.M_ID 
where dbo.Enter.E_ID in (select E_ID from dbo.Enter, dbo.Console where E_ID<= 2500 and E_ID<>dbo.Console.P_ID);

--5. List the entry dates of products that were entered before 2013
select E_Date
from dbo.Enter left outer join dbo.Product
on dbo.Enter.E_ID = dbo.Product.E_ID
where E_Date in (select E_Date from dbo.Enter, dbo.Product where E_Date < '20130101');

--6. List the game names and each the count of each distinct game released before 2010
select  G_Name, count(G_Name) 
from dbo.Game, dbo.Product
where dbo.Game.P_ID = dbo.Product.P_ID and Release < '20100101'
group by G_Name
order by 'G_Name' ASC;

--7. List the new platforms and the distinct count of each of all that have less than 100 in the system in ascending order.
select Platform, count(Platform)
from dbo.Console, dbo.Product
where dbo.Console.P_ID = dbo.Product.P_ID and New = 1
group by Platform
having count(Platform) < 100
order by 'Platform' ASC;

--8. Update all members in the database who were entered before 2013 and make upgrade them to VIP (if not already)
update dbo.Membership
set VIP = 1
where VIP = 0 and M_ID in (select M_ID 
	from dbo.Membership, dbo.Enter 
	where E_Date < '20130101' and M_ID = dbo.Enter.M_ID);

--9. Delete all Mature rated games from the dbo.Game table
 delete from dbo.Game
 where G_ID in (select G_ID 
	from dbo.Game, dbo.Label 
	where dbo.Game.G_ID = dbo.Label.G_ID and Rating = 'Mature');