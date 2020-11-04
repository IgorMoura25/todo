create table NoteTypes
(
	NoteTypeId bigint constraint PK_NoteTypes primary key not null,
	Name varchar(15) not null
)

create table Notes
(
	NoteId bigint identity constraint PK_Notes primary key not null,
	NoteTypeId bigint constraint FK_Notes_NoteTypes references NoteTypes not null,
	Title varchar(50) null
)

create table NoteItems
(
	NoteItemId bigint identity constraint PK_NoteItems primary key not null,
	NoteId bigint constraint FK_NoteItems_Notes references Notes not null,
	Description varchar(50) null,
	IsDone bit not null
)

create table FrequencyTypes
(
	FrequencyTypeId bigint constraint PK_FrequencyTypes primary key not null,
	Name varchar(15) not null
)

create table ReminderTypes
(
	ReminderTypeId bigint constraint PK_ReminderTypes primary key not null,
	Name varchar(15) not null
)

create table Reminders
(
	ReminderId bigint identity constraint PK_Reminders primary key not null,
	NoteId bigint constraint FK_Reminders_Notes references Notes null,
	Title varchar(50) null,
	Description varchar(50) null,
	ReminderTypeId bigint constraint FK_Reminders_ReminderTypes references ReminderTypes not null,
	FrequencyTypeId bigint constraint FK_Reminders_FrequencyTypes references FrequencyTypes null,
	DeadLine datetime not null
)