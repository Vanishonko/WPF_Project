CREATE TABLE Train (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TrainName VARCHAR(50) NOT NULL,
    DepartureStation VARCHAR(50) NOT NULL,
    ArrivalStation VARCHAR(50) NOT NULL,
    DepartureTime DATETIME NOT NULL,
    ArrivalTime DATETIME NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    SeatsAvailable INT NOT NULL
);
