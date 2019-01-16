USE NSGTransportManagement
GO

IF EXISTS(SELECT 1 FROM sys.procedures P WHERE P.name = 'BusPickupPointsGet')
BEGIN
    DROP PROCEDURE dbo.BusPickupPointsGet
END
GO

CREATE PROCEDURE dbo.BusPickupPointsGet
AS
BEGIN
	SELECT DISTINCT
		CBRD.BusRouteID,
		CAST(CBRD.BusStopNumber AS VARCHAR) + ' - ' + CBRD.BusStopName AS PickupPoint
	FROM dbo.CoreBusRouteDetail CBRD
	INNER JOIN dbo.CoreBusRoute CBR ON CBR.BusRouteID = CBRD.BusRouteID
END
GO
