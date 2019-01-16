USE NSGTransportManagement
GO

IF EXISTS(SELECT 1 FROM sys.procedures P WHERE P.name = 'BusDetailsGet')
BEGIN
    DROP PROCEDURE dbo.BusDetailsGet
END
GO

CREATE PROCEDURE dbo.BusDetailsGet
(
	@RegistrationNumber VARCHAR(10),
	@RouteNumber VARCHAR(10),
	@SchoolName VARCHAR(500),
	@RouteID INT = 0
)
AS
BEGIN
	SELECT DISTINCT
		CB.BusID,
		CB.RegistrationNumber,
		CBR.RouteNo,
		CB.TotalSeatCount,
		CB.MaxPassengerAllowed,
		CB.KilometerRun,
		CB.DriverName,
		CB.DriverContactNumber,
		CB.CoDriverName,
		CB.CoDriverContactNumber,
		CS.SchoolName
	FROM dbo.CoreBus CB
	LEFT JOIN dbo.CoreBusRoute CBR ON CB.BusRouteID = CBR.BusRouteID
	LEFT JOIN dbo.CoreBusRouteSchool CBRS 
		INNER JOIN dbo.CoreSchool CS ON CS.SchoolID = CBRS.SchoolID
		ON CBRS.BusRouteID = CBR.BusRouteID
	WHERE (CB.RegistrationNumber LIKE '%' + @RegistrationNumber + '%' OR CB.RegistrationNumber IS NULL)
		AND CBR.RouteNo LIKE '%' + @RouteNumber + '%'
		AND (CS.SchoolName LIKE '%' + @SchoolName + '%' OR CS.SchoolName IS NULL)
		AND (CBR.BusRouteID = @RouteID OR @RouteID = 0)
END
GO
