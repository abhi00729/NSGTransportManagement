
IF EXISTS(SELECT 1 FROM sys.views (NOLOCK) WHERE name = 'StudentPassDetailView')
BEGIN
    DROP VIEW dbo.StudentPassDetailView
END
GO

CREATE VIEW dbo.StudentPassDetailView
AS
	SELECT
		NS.NSGStudentID AS PassId,
		CAST(YEAR(NS.IssueDate) AS VARCHAR) + '-' + RIGHT(CAST(YEAR(NS.IssueDate) + 1 AS VARCHAR), 2) AS Term,
		CB.RegistrationNumber AS RegNo,
		CBR.RouteNo,
		NS.FirstName + ' ' + NS.LastName AS FullName,
		NS.GuardianName,
		CU.UnitName,
		NS.Class,
		DATEDIFF(YEAR, NS.BirthDate, GETDATE()) AS Age,
		CS2.SchoolName,
		CBRD.BusStopName,
		NS.IssueDate,
		NS.ExpiryDate,
		NS.MobileNo,
		NS.PassHolderPhoto
	FROM dbo.NSGStudent (NOLOCK) NS
	INNER JOIN dbo.CoreBusRouteDetail CBRD ON CBRD.BusRouteDetailID = NS.BusRouteDetailID
	INNER JOIN dbo.CoreSchool CS2 ON CS2.SchoolID = NS.SchoolID
	INNER JOIN dbo.CoreBusRoute CBR ON CBR.BusRouteID = NS.BusRouteID
	INNER JOIN dbo.CoreBus CB ON CB.BusRouteID = CBR.BusRouteID
	INNER JOIN dbo.CoreUnit CU ON CU.UnitID = NS.UnitID
GO
