# JSON File

TODO: Combine TimingData and TimingAppData?

```json
{
  "driverInfo": [
    {
      "RacingNumber": "",
      "BroadcastName": "",
      "FullName": "",
      "Tla": "",
      "Line": "",
      "TeamName": "",
      "TeamColour": "",
      "FirstName": "",
      "LastName": "",
      "Reference": "",
      "HeadshotUrl": ""
    }
  ],
  "weatherData": [
    {
      "time": 0,
      "airTemp": 0,
      "humidity": 0,
      "pressure": 0,
      "rainfall": false,
      "trackTemp": 0,
      "windDirection": 0,
      "windSpeed": 0
    }
  ],
  "positionData": {
  },
  "carData": {
  },
  "timingData": [
    {
      "driver": 0,
      "time": 0,
      "lapTime": 0,
      "laps": 0,
      "pitStops": 0,
      "pitOutTime": 0,
      "pitInTime": 0,
      "s1": 0,
      "s2": 0,
      "s3": 0,
      "spI1": 0,
      "spI2": 0,
      "spFL": 0,
      "spST": 0,
      "personalBest": 0,
      "sectors": {
        "1": "segment: status"
      }
    }
  ],
  "timingAppData": [
    {
      "driver": 0,
      "time": 0,
      "lapTime": 0,
      "stint": 0,
      "totalLapsOnTyre": 0,
      "typeCompound": 0,
      "newTyre": false
    }
  ],
  "sessionStatus": {
  },
  "raceControlMessages": {
  },
  "trackStatus": {
  },
  "lapCount": [
    {
      "time": 0
    }
  ]
}
```
