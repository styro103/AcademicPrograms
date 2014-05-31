/*
	Final Queries
	Shaun Mbateng
	CS 433
	December 16th, 2013
*/

/*
Q1: Which console has the highest percentage of mature rated games available?
A1: Xbox 360
*/
--A1 SQL:
with TQ1 as (
	select Platform, (count(Platform) * 100 / (select count(G_ID) from dbo.Game)) as CP
	from dbo.Game as G
	inner join dbo.Label as L
		on G.G_ID = L.G_ID
	where L.Rating = 'Mature'
	group by Platform)
select Platform 
from TQ1 
where CP = (select max(CP) from TQ1);

/*
Q2: For each year in which members have joined, which region has had the most VIP members join?
A2: 2013	CA
	2012	CA
*/ 
--A2 SQL:
with TQ2 as (
	select Region, YEAR(E_Date) as EY, count(VIP) as VC
	from dbo.Enter as E
	inner join dbo.Membership as Mem
		on E.M_ID = Mem.M_ID
	inner join dbo.Member as M
		on M.M_ID = Mem.M_ID
	where VIP = 1
	group by Region, Year(E_Date))
select EY, Region
from TQ2
where VC = (select max(VC) from TQ2);
/*
Q3: Which platform has the most games available?
A3: Playstation 2
*/
/*
	A3 SQL: Note, this determines the most games available by 
			counting the number of G_IDs with the same platform. I wasn't sure if the count of 
			distinct G_Names was desired or G_IDs. To count the number of distinct game names with 
			the same platform, replace every "G_ID" with "distinct(G_Name)". 
			The answer doesn't change regardless.
*/
with TQ3 as (
	select Platform, count(G_ID) as GC
	from dbo.Game
	group by Platform)
select Platform 
from TQ3 
where GC = (select max(GC) from TQ3);

/*
Q4: For any one of these three queries, propose an index and explain how it would 
	potentially help performance.
A4: For the first query, I would propose an index on "Rating" of the dbo.Label table 
	(CREATE INDEX Rat_Mat on dbo.Label(Rating)). The first
	reason why is because that is not a table where indexing should be avoided on.
	It is a good size table (has 2500 entries), its data would rarely (if not never)
	get changed/updated/inserted (since the information of a video game doesn't really change).
	And all of its rows are not allowed to have null inputs, so there are none in the table.
	
	This would create an index on each type of rating (Everyone, Teen, Mature), so then only the
	game id's of the mature rated games would be searched, thus reducing the number of items searched
	and reducing the time.	
*/

/*
Q5: Create a stored procedure to do anything you'd like as long as it updates two tables.  
	These two updates should be in a single transaction.  
	Explain three ways why this transaction might fail.
*/
--A5: Create a procedure that begins a transaction that updates all members to VIP, and requires an
--	  age/ID check with all "Teen" rated games

create procedure Q5 as
	begin
		begin transaction T1
			update dbo.Membership
			set VIP = 1
			where VIP = 0
			update dbo.Label
			set Check_Age = 1
			where Rating = 'Teen'
		rollback
	end;

/*
A5 (Continued): Transaction Failures 
	1.	There is another transaction named T2, both T1 and T2 rely on each other to complete, 
		thus resulting in deadlock.
	2.	Transaction T1 is made in a way that causes a system crash (like updating a table that no longer exists).
	3.	During the transaction, a hardware failure occurs because the underlying server died.
*/
				

