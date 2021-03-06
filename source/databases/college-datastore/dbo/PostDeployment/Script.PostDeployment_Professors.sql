/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

MERGE INTO [dbo].[Professors] AS TARGET
USING (VALUES 
	('5EC797EC-DA0A-43DF-B3A3-3F9A04163656', 'Shiva Sai', '01-Jan-2010', 'C Sharp; EF Core', 1234.56, 1, 3.5 ),
	('99C2F1E8-87A3-4103-955B-EC728CE84F2F', 'Mathew Philips', '01-Feb-2010', 'Java; Python', 2345.67, 1, 4.2 ),
	('65CA4196-B519-493B-BF96-F881544BD9F4', 'Mohd Azim', '01-Mar-2010', 'F Sharp; ML; AI', 3456.78, 0, 4.6 )
)
AS SOURCE ([ProfessorId], [Name], [Doj], [Teaches], [Salary], [IsPhd], [Rating])
ON TARGET.[ProfessorId] = SOURCE.[ProfessorId]
WHEN NOT MATCHED BY TARGET THEN
	INSERT ([ProfessorId], [Name], [Doj], [Teaches], [Salary], [IsPhd], [Rating])
	VALUES ([ProfessorId], [Name], [Doj], [Teaches], [Salary], [IsPhd], [Rating])
WHEN NOT MATCHED BY SOURCE THEN
	DELETE;
