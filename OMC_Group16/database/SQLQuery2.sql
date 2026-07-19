CREATE TABLE EmergencyContacts
(
    EmergencyContactID INT IDENTITY(1,1) PRIMARY KEY,

    PatientID INT NOT NULL,

    ContactName NVARCHAR(100) NOT NULL,

    Relationship NVARCHAR(50) NOT NULL,

    PhoneNumber VARCHAR(20) NOT NULL,

    Address NVARCHAR(255) NULL,

    FOREIGN KEY (PatientID)
        REFERENCES Seniors(PatientID)
);