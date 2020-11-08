insert into NoteTypes (NoteTypeId, Name) values(1, N'Lista');
insert into NoteTypes (NoteTypeId, Name) values(2, N'Texto');

insert into FrequencyTypes (FrequencyTypeId, Name) values(1, N'Diariamente');
insert into FrequencyTypes (FrequencyTypeId, Name) values(2, N'Semanalmente');
insert into FrequencyTypes (FrequencyTypeId, Name) values(3, N'Mensalmente');

insert into ReminderTypes (ReminderTypeId, Name) values(1, N'Alarme');
insert into ReminderTypes (ReminderTypeId, Name) values(2, N'Notificação');
insert into ReminderTypes (ReminderTypeId, Name) values(3, N'E-mail');

insert into Notes (NoteTypeId, Title) values (2, 'fazer teste')
insert into Notes (NoteTypeId, Title) values (2, 'enviar email')
