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

MERGE INTO [dbo].[Students] AS TARGET
USING (VALUES 
	('Student AAA', 'A101', '99C2F1E8-87A3-4103-955B-EC728CE84F2F', 2000.56),
	('Student BBB', 'A102', '65CA4196-B519-493B-BF96-F881544BD9F4', 2000.56),
	('Student CCC', 'A103', '5EC797EC-DA0A-43DF-B3A3-3F9A04163656', 2000.56)
)
AS SOURCE ([Name], [RollNumber], [ProfessorId],[Fees])
ON TARGET.[Name] = SOURCE.[Name]
WHEN NOT MATCHED BY TARGET THEN
	INSERT ([Name], [RollNumber], [ProfessorId],[Fees])
	VALUES ([Name], [RollNumber], [ProfessorId],[Fees])
WHEN NOT MATCHED BY SOURCE THEN
	DELETE;

