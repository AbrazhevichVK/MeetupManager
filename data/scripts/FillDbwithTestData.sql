USE [DbMeetups]
GO

INSERT INTO [dbo].[Meetups]
           ([Title]
           ,[Theme]
           ,[Description]
           ,[Plan]
           ,[Organizar]
           ,[Speaker]
           ,[MeetupTime]
           ,[MeetupPlace])
     VALUES
           ('Sweet Kingdom',
		    'Baby sweets',
            'An interesting event for childrens leisure',
            '1) Meeting, 2) Cartoons, 3) Games',          
			'Baby Corp',
			'Mr. Baby Boss',
			'2022-09-20T11:00:00',
			'Goretsky street 15À, Minsk'),
			('Cinema fan night',
		    'Action, thriller, horror films',
            'Watch films all night with pleasure!',
            '1) Gray Man(Action), 2)Emergency call(thriller), 3)Jaws(horror)',          
			'Belarusfilm',
			'U.U. Ivanov',
			'2022-09-25T23:00:00',
			'Kupalovskaya street 7, Minsk'),
			('Steel monsters',
		    'WW2 Armored tech',
            'An interesting place for people to communicate with a love for military equipment',
            '1) Meeting, 2) concert, 3) dinner',          
			'Jackson Corp',
			'S.W. Jackson',
			'2022-09-15T15:00:00',
			'Gerasimenko street 50, Minsk')

          
GO


