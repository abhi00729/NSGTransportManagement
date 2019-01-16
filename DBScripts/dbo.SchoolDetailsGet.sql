USE NSGTransportManagement
GO

IF EXISTS(SELECT 1 FROM sys.procedures P WHERE P.name = 'SchoolDetailsGet')
BEGIN
    DROP PROCEDURE dbo.SchoolDetailsGet
END
GO

CREATE PROCEDURE dbo.SchoolDetailsGet
(
	@SchoolName VARCHAR(250),
	@RouteNumber VARCHAR(10)
)
AS
BEGIN
	SELECT 
		CS.SchoolID,
		CS.SchoolName,
		CS.WinterTimingFrom,
		CS.WinterTimingTo,
		CS.SummerTimingFrom,
		CS.SummerTimingTo,
		CS.DistanceFromGarage,
		CS.AdminContactNumbers,
		CS.SchoolAddress,
		CS2.StateName,
		CC.CityName
	FROM dbo.CoreSchool (NOLOCK) CS
	LEFT JOIN dbo.CoreBusRouteSchool (NOLOCK) CBRS
		INNER JOIN dbo.CoreBusRoute (NOLOCK) CBR ON CBR.BusRouteID = CBRS.BusRouteID
		ON CBRS.SchoolID = CS.SchoolID
	INNER JOIN dbo.CoreState (NOLOCK) CS2 ON CS2.StateID = CS.StateID
	INNER JOIN dbo.CoreCity (NOLOCK) CC ON CC.CityID = CS.CityID
	WHERE CS.SchoolName LIKE '%' + @SchoolName + '%'
		AND (CBR.RouteNo LIKE '%' + @RouteNumber + '%' OR CBR.RouteNo IS NULL)
	GROUP BY CS.SchoolID,
		CS.SchoolName,
		CS.WinterTimingFrom,
		CS.WinterTimingTo,
		CS.SummerTimingFrom,
		CS.SummerTimingTo,
		CS.DistanceFromGarage,
		CS.AdminContactNumbers,
		CS.SchoolAddress,
		CS2.StateName,
		CC.CityName
	ORDER BY CS.SchoolName
END
GO
