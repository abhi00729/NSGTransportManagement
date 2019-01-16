USE NSGTransportManagement
GO

IF EXISTS(SELECT 1 FROM sys.procedures P WHERE P.name = 'BusRouteDetailsGet')
BEGIN
    DROP PROCEDURE dbo.BusRouteDetailsGet
END
GO

CREATE PROCEDURE dbo.BusRouteDetailsGet
(
	@RegistrationNumber VARCHAR(10),
	@RouteNumber VARCHAR(10),
	@SchoolName VARCHAR(500),
	@RouteID INT = 0
)
AS
BEGIN
	SELECT DISTINCT
		CBR.BusRouteID,
		CBR.RouteNo,
		CB.RegistrationNumber,
		CB.TotalSeatCount,
		CB.MaxPassengerAllowed,
		CB.KilometerRun,
		CB.DriverName,
		CB.DriverContactNumber,
		CB.CoDriverName,
		CB.CoDriverContactNumber,
		CS.SchoolName
	FROM dbo.CoreBusRoute CBR
	LEFT JOIN dbo.CoreBus CB ON CB.BusRouteID = CBR.BusRouteID
	LEFT JOIN dbo.CoreBusRouteSchool CBRS 
		INNER JOIN dbo.CoreSchool CS ON CS.SchoolID = CBRS.SchoolID
		ON CBRS.BusRouteID = CBR.BusRouteID
	WHERE (CB.RegistrationNumber LIKE '%' + @RegistrationNumber + '%' OR CB.RegistrationNumber IS NULL)
		AND CBR.RouteNo LIKE '%' + @RouteNumber + '%'
		AND (CS.SchoolName LIKE '%' + @SchoolName + '%' OR CS.SchoolName IS NULL)
		AND (CBR.BusRouteID = @RouteID OR @RouteID = 0)
END
GO
