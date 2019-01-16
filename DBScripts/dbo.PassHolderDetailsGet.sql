USE NSGTransportManagement
GO


IF EXISTS(SELECT 1 FROM sys.procedures (NOLOCK) WHERE name = 'PassHolderDetailsGet')
BEGIN
	DROP PROCEDURE dbo.PassHolderDetailsGet
END
GO

CREATE PROCEDURE dbo.PassHolderDetailsGet
(
	@IssueDate DATETIME = NULL,
	@ExpiryDate DATETIME = NULL,
	@StudenPassID BIGINT = NULL,
	@StudentName VARCHAR(500) = NULL,
	@SchoolName VARCHAR(1000) = NULL,
	@ActiveOnly BIT = 1
)
AS
BEGIN
	SET NOCOUNT ON
    
	SET @StudentName = '%' + ISNULL(@StudentName, '') + '%'
	
	SET @SchoolName = '%' + ISNULL(@SchoolName, '') + '%'
	
	IF(@IssueDate IS NOT NULL)
	BEGIN
		SET @IssueDate = DATEADD(SECOND, -1, CAST(CAST(@IssueDate + 1 AS DATE) AS DATETIME))
	END

	IF(@ExpiryDate IS NOT NULL)
	BEGIN
		SET @ExpiryDate = DATEADD(SECOND, -1, CAST(CAST(@ExpiryDate + 1 AS DATE) AS DATETIME))
	END

	SELECT
		NS.NSGStudentID,
		NS.FirstName,
		NS.LastName,
		NS.GuardianName,
		NS.Class,
		CS.SchoolName + ' - ' + St.StateName + ' - ' + CC.CityName AS SchoolName,
		CBR.RouteNo,
		CBRD.BusStopName,
		NS.IssueDate,
		NS.ExpiryDate,
		CASE NS.IsActive WHEN 1 THEN 'Yes' ELSE 'No' END AS IsActive,
		CUREN.FirstName + ' ' + CUREN.LastName AS EntryBy
	FROM dbo.NSGStudent (NOLOCK) NS
	INNER JOIN dbo.CoreSchool (NOLOCK) CS ON CS.SchoolID = NS.SchoolID
	INNER JOIN dbo.CoreState (NOLOCK) St ON St.StateID = CS.StateID
	INNER JOIN dbo.CoreCity (NOLOCK) CC ON CS.CityID = CC.CityID
	INNER JOIN dbo.CoreBusRoute (NOLOCK) CBR ON NS.BusRouteID = CBR.BusRouteID
	INNER JOIN dbo.CoreBusRouteDetail (NOLOCK) CBRD ON NS.BusRouteDetailID = CBRD.BusRouteDetailID
	INNER JOIN dbo.CoreUser (NOLOCK) CUREN ON CUREN.CoreUserID = NS.EntryUserID
	WHERE (NS.IssueDate >= @IssueDate OR @IssueDate IS NULL)
		AND (NS.ExpiryDate <= @ExpiryDate OR @ExpiryDate IS NULL)
		AND (NS.NSGStudentID = @StudenPassID OR @StudenPassID IS NULL)
		AND (NS.FirstName LIKE @StudentName OR NS.LastName LIKE @StudentName)
		AND (CS.SchoolName LIKE @SchoolName)
		AND NS.IsActive >= @ActiveOnly
	ORDER BY NS.NSGStudentID DESC

	SET NOCOUNT OFF
END
GO

