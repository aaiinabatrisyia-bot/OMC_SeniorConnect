ALTER TABLE Appointments
ADD CONSTRAINT FK_Appointments_Patient
FOREIGN KEY (PatientID)
REFERENCES Patients(PatientID);

ALTER TABLE Appointments
ADD CONSTRAINT FK_Appointments_Doctor
FOREIGN KEY (DoctorID)
REFERENCES Doctors(DoctorID);