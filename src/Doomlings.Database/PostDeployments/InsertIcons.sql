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

INSERT INTO [icons].[Icons] ([Name], [Type], [Image])
VALUES
    ('None', 0, NULL),
    ('Star', 1, NULL),
    ('Triangle', 2, NULL),
    ('Drop Of Life', 4, NULL),
    ('Action', 8, NULL),
    ('Wings', 16, NULL),
    ('Dino Egg', 32, NULL),
    ('Exotic Dragon', 64, NULL),
    ('Cog and Gears', 128, NULL);