use premiercareclinic;
#Insert for Drug
INSERT INTO Drug(drug_name, cost) VALUES("Panadol Ultra", 5);
INSERT INTO Drug(drug_name, cost) VALUES("Panadol Multisymptom", 5);
INSERT INTO Drug(drug_name, cost) VALUES("Gravol", 30);
INSERT INTO Drug(drug_name, cost) VALUES("Panadine", 20);
INSERT INTO Drug(drug_name, cost) VALUES("Advil", 50);

#Insert for Service
INSERT INTO Service(cost, service_category) VALUES(250, "pediatrics");
INSERT INTO Service(cost, service_category) VALUES(350, "general practice");
INSERT INTO Service(cost, service_category) VALUES(300, "specialist");
INSERT INTO Service(cost, service_category) VALUES(400, "laboratory");
INSERT INTO Service(cost, service_category) VALUES(350, "therapy");
INSERT INTO Service(cost, service_category) VALUES(150, "x-ray");

#Insert for Doctor
INSERT INTO Doctor(doctor_name, doctor_contact_number, doctor_address, doctor_specialty) VALUES("David Maharaj", "868-334-5544", "Maraval", "Padiatrician");
INSERT INTO Doctor(doctor_name, doctor_contact_number, doctor_address, doctor_specialty) VALUES("Jutram Sinnanan", "868-628-6745", "Barataria", "Therapist");
INSERT INTO Doctor(doctor_name, doctor_contact_number, doctor_address, doctor_specialty) VALUES("Trisha Rampersad", "868-466-4352", "Rio Claro", "General Doctor");
INSERT INTO Doctor(doctor_name, doctor_contact_number, doctor_address, doctor_specialty) VALUES("John Bennet", "868-764-2376", "Arima", "Specialist");

#Insert for Staff
INSERT INTO Staff(staff_name, staff_contact_number, staff_address, staff_type) VALUES("John Smith", "868-368-6831", "Bon-Air", "x-ray technician");
INSERT INTO Staff(staff_name, staff_contact_number, staff_address, staff_type) VALUES("Ricardo Perez", "868-423-4353", "Lopinot", "lab technician"); 
INSERT INTO Staff(staff_name, staff_contact_number, staff_address, staff_type) VALUES("Jane Doe", "868-653-5353", "Rio Claro", "nurse");
INSERT INTO Staff(staff_name, staff_contact_number, staff_address, staff_type) VALUES("Jaina Proudmore", "868-363-2623", "Rio Claro", "nurse");
INSERT INTO Staff(staff_name, staff_contact_number, staff_address, staff_type) VALUES("Khadgar Rosal", "868-745-5342", "Rio Claro", "csr");
INSERT INTO Staff(staff_name, staff_contact_number, staff_address, staff_type) VALUES("Jaqueline Harper", "868-364-6264", "Deigo Martin", "csr");

#Insert for Csr_Login
INSERT INTO Csr_Login(login_password, staff_id) VALUES("admin1", 5);
INSERT INTO Csr_Login(login_password, staff_id) VALUES("admin2", 6);

#Insert for Doctor_Login
INSERT INTO Csr_Login(login_password, doctor_id) VALUES("doctor1", 1);
INSERT INTO Csr_Login(login_password, doctor_id) VALUES("doctor2", 2);
INSERT INTO Csr_Login(login_password, doctor_id) VALUES("doctor3", 3);
INSERT INTO Csr_Login(login_password, doctor_id) VALUES("doctor4", 4);