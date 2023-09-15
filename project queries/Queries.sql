SELECT * FROM Users
SELECT * FROM Project
SELECT * FROM ProjectMembers
SELECT * FROM Events
SELECT * FROM UsersEvents
SELECT * FROM KeyMilestones
SELECT * FROM Review
SELECT * FROM Document


--ANY operator
	--Return user's nickname if it finds ANY records in Project table with project status 'In progress'
SELECT Nickname from Users
WHERE id = ANY
	(SELECT id FROM Project
	 WHERE projectStatus='In progress'
	);

--ALL operator
SELECT ALL projectName FROM Project
WHERE id = ALL
	(SELECT id FROM Users
	WHERE projectStatus = 'In progress'
	);

--EXISTS operator
SELECT id, teamManagerId FROM Project as p
WHERE EXISTS (
	SELECT userId FROM ProjectMembers as pm
	WHERE pm.id = p.id
	);

--CASE syntax
	-- retrieve projects with their status details and project manager name
SELECT p.Id, projectStatus, p.ProjectName,u.Nickname AS 'Project Manager',
CASE	
	WHEN projectStatus = 'In progress' THEN 'Project is still in progress.'
	WHEN projectStatus = 'Completed' THEN 'Project is ready.'
	ELSE 'Project on hold'
END AS ProjectDetails
FROM Project AS p
JOIN Users as u
ON p.ProjectManagerId = u.Id



--JOIN Users WITH Project
SELECT * FROM Users as us
inner join Project as p
ON us.id = p.id

--INLINE QUERIES
SELECT outerTable.Nickname, outerTable.Levels from
( 
	SELECT Nickname, Levels, City from Users as us
	inner join Project as p
	on us.id = p.id
	WHERE City = 'Cluj'
) as outerTable

--CORRELATED QUERIES
SELECT nickname,
	(SELECT client FROM Project AS p
	WHERE p.id = us.id
	)
FROM Users as us


-- Retrieve projects where the project status is 'In progress'
SELECT * FROM Project WHERE ProjectStatus = 'In progress';

-- Retrieve projects where the project manager ID is 2 ordered by status
SELECT * FROM Project WHERE ProjectManagerId = 2 ORDER BY ProjectStatus;

-- Count the number of project members for each project and show only projects with more than 1 member
SELECT ProjectId, COUNT(*) AS MemberCount
FROM ProjectMembers
GROUP BY ProjectId
HAVING COUNT(*) > 1;

-- Retrieve project details along with the team manager's nickname and email
SELECT
    p.*,
    u.Nickname AS TeamManagerNickname,
    u.Email AS TeamManagerEmail
FROM
    Project p
JOIN
    ProjectMembers pm ON p.TeamManagerId = pm.UserId
JOIN
    Users u ON pm.UserId = u.Id;



--  query 
SELECT
    p.Id AS ProjectId,
    p.ProjectName,
    u1.Nickname AS TeamManager,
    u2.Nickname AS ProjectManager
FROM Project as p
JOIN
    Users u1 ON p.TeamManagerId = u1.Id
JOIN
    Users u2 ON p.ProjectManagerId = u2.Id
LEFT JOIN
    ProjectMembers pm ON p.Id = pm.ProjectId
GROUP BY
    p.Id,
    p.ProjectName,
    u1.Nickname,
    u2.Nickname;



