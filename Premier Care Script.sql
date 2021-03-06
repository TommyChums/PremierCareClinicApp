DROP Database If Exists PremierCareClinic;
Create Database PremierCareClinic ;
use PremierCareClinic;

# Create Tables {

DROP Table If Exists Patient;
Create Table Patient (
	patient_id int auto_increment not null primary key,
    patient_name varchar(50) not null,
    contact_no varchar(50) not null,
    address varchar(255) not null,
    DOB varchar(50) not null,
    allergies varchar(255),
    blood_type varchar(50)
);

DROP Table If Exists Drug;
Create Table Drug (
	drug_id int auto_increment not null primary key,
    drug_name varchar(255) not null,
    cost double not null
);

DROP Table If Exists Service;
Create Table Service (
	service_id int auto_increment not null primary key,
    cost double not null,
    service_category varchar(50) not null
);

DROP Table If Exists Doctor;
Create Table Doctor (
	doctor_id int auto_increment not null primary key,
    doctor_name varchar(255) not null,
    doctor_contact_number varchar(50) not null,
    doctor_address varchar(255) not null,
    doctor_specialty varchar(255) not null
);

DROP Table If Exists Staff;
Create Table Staff (
	staff_id int auto_increment not null primary key,
    staff_name varchar(255) not null,
    staff_contact_number varchar(50) not null,
    staff_address varchar(255) not null,
    staff_type varchar(255) not null
);

DROP Table If Exists Csr_Login;
Create Table Csr_Login (
	login_password varchar(255) not null primary key,
    staff_id int unique,
    doctor_id int unique,
    foreign key(doctor_id) references Doctor(doctor_id),
	foreign key(staff_id) references Staff(staff_id)
);

DROP Table If Exists Appointment;
Create Table Appointment (
	appointment_id int auto_increment not null primary key,
    appointment_date varchar(50) not null,
    appointment_time varchar(50) not null,
    appointment_details varchar(255) not null,
    patient_id int not null,
    doctor_id int not null,
    staff_id int not null,
    service_id int not null,
    appointment_completed bool not null,
    foreign key (patient_id) references Patient(patient_id),
    foreign key (doctor_id) references Doctor(doctor_id),
    foreign key (staff_id) references Staff(staff_id),
    foreign key (service_id) references Service(service_id)
);

DROP Table If Exists Prescription;
Create Table Prescription (
	prescription_id int auto_increment not null primary key,
    dosage_per_day int not null,
    duration_in_days int not null,
    patient_id int not null,
	drug_id int not null,
    doctor_id int not null,
    foreign key (patient_id) references Patient(patient_id),
    foreign key (drug_id) references Drug(drug_id),
    foreign key (doctor_id) references Doctor(doctor_id)
);

DROP Table If Exists Prescription_Record;
Create Table Prescription_Record (
	prescription_id int auto_increment not null primary key,
    dosage_per_day int not null,
    duration_in_days int not null,
    patient_id int not null,
	drug_id int not null,
    doctor_id int not null,
    foreign key (patient_id) references Patient(patient_id),
    foreign key (drug_id) references Drug(drug_id),
    foreign key (doctor_id) references Doctor(doctor_id)
);

DROP Table If Exists Invoice;
Create Table Invoice (
	invoice_id int auto_increment not null primary key,
    invoice_date varchar(50) not null,
    patient_id int not null,
    service_id int not null,
    drug_names varchar(255),
    total_cost double not null,
    foreign key (patient_id) references Patient(patient_id),
    foreign key (service_id) references Service(service_id)
);

# } end of Tables

# Create Procedures {

DROP procedure IF EXISTS `GetAppointments`;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAppointments`(IN staff int)
BEGIN
SELECT appointment_id, patient_name, appointment_date, appointment_time, service_category, doctor_name , appointment_completed 
FROM Patient, Appointment, Service, Doctor
WHERE Patient.patient_id = Appointment.patient_id AND Service.service_id = Appointment.service_id 
AND Doctor.doctor_id = Appointment.doctor_id AND Appointment.staff_id = staff;
END$$
DELIMITER ;

DROP procedure IF EXISTS `GetPrescriptions`;

DELIMITER $$
USE `premiercareclinic`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetPrescriptions`(IN pID int)
BEGIN
	SELECT prescription_id AS PID, patient_name AS Patient, drug_name AS Medication, dosage_per_day AS Dosage, duration_in_days AS Duration, doctor_name AS Doctor
    FROM prescription_record, patient, drug, doctor
    WHERE prescription_record.patient_id = pID AND prescription_record.patient_id = patient.patient_id AND prescription_record.drug_id = drug.drug_id AND prescription_record.doctor_id = doctor.doctor_id;
END$$
DELIMITER ;

DROP procedure IF EXISTS `GetInvoices`;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetInvoices`(IN pID int)
BEGIN
	SELECT invoice_id AS InvID, invoice_date AS InvDate, patient_name AS Patient, service_category AS Service, drug_names AS Medications, total_cost AS Cost
    FROM invoice, patient, service
    WHERE invoice.patient_id = pID AND invoice.patient_id = patient.patient_id AND invoice.service_id = service.service_id;
END$$
DELIMITER ;

DROP procedure IF EXISTS `GetPatientAppointments`;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetPatientAppointments`(IN pID int)
BEGIN
	SELECT appointment_id AS AppID, appointment_date AS AppDate, appointment_time AS AppTime, appointment_details AS Details, patient_name AS Patient, doctor_name AS Doctor, staff_name AS CSR, service_category AS Service, appointment_completed AS Completed
    FROM appointment, patient, doctor, staff, service
    WHERE appointment.patient_id = pID AND appointment.patient_id = patient.patient_id AND appointment.doctor_id = doctor.doctor_id AND appointment.staff_id = staff.staff_id AND appointment.service_id = service.service_id;
END$$
DELIMITER ;

# } end of Procedures

# Create Triggers {
DELIMITER //
CREATE TRIGGER prescription_delete
BEFORE DELETE
	ON Prescription FOR EACH ROW
BEGIN
	INSERT INTO Prescription_Record(prescription_id, dosage_per_day, duration_in_days, patient_id, drug_id, doctor_id) 
    VALUES(OLD.prescription_id, OLD.dosage_per_day, OLD.duration_in_days, OLD.patient_id, OLD.drug_id, OLD.doctor_id);
END; //
DELIMITER ;    

# } end of Triggers