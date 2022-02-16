insert into [dbo].[Appointments] 
([PatientName],[AppointmentDate],[PatientNetWorth],[DoctorName],[PainLevel],[Street],[City],[ZipCode],[Email],[Phone]) 
values 
('Ginna','2022-04-12',100,'Smith',10,'17, Hristo Kovachev','Sofia','1000','ginna@gmail.com','+3597778888')

insert into [dbo].[Appointments] 
([PatientName],[AppointmentDate],[PatientNetWorth],[DoctorName],[PainLevel],[Street],[City],[ZipCode],[Email],[Phone]) 
values 
('Jimmy','2022-05-12',100,'Smith',10,'32, Iskar','Sofia','1000','jimmy@gmail.com','+3599998888')

delete from [dbo].[Appointments] 
where [PatientName]='Jimmy' AND [AppointmentDate]='2022-04-12'

select * from [dbo].[Appointments]