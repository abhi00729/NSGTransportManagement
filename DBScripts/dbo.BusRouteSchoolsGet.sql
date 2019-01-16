USE NSGTransportManagement
GO

IF EXISTS(SELECT 1 FROM sys.procedures P WHERE P.name = 'BusRouteSchoolsGet')
BEGIN
    DROP PROCEDURE dbo.BusRouteSchoolsGet
END
GO

CREATE PROCEDURE dbo.BusRouteSchoolsGet
(
	@RouteID INT
)
AS
BEGIN
	
	SELECT
		CS.SchoolID,
		CS.SchoolName + ' - ' + CC.CityName AS SchoolName,
		CAST(CASE WHEN CBRS.BusRouteID = @RouteID THEN 1 ELSE 0 END AS BIT) AS Selected
	FROM dbo.CoreSchool CS
	INNER JOIN dbo.CoreCity CC ON CC.CityID = CS.CityID
	LEFT JOIN dbo.CoreBusRouteSchool CBRS ON CBRS.SchoolID = CS.SchoolID
	
END
GO
