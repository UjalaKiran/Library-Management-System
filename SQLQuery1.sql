CREATE TABLE Books (
    BookId INT,
    Title VARCHAR(100),
    Author VARCHAR(100),
    Price DECIMAL(10, 2),
    Publisher VARCHAR(100),
    Status VARCHAR(1)
);


INSERT INTO Books (BookId, Title, Author, Price, Publisher, Status)
VALUES
    (1122, 'A WINDOW TO THE SKY', 'Sana Mehmood', 1800, 'Velvet Press', 'A'),
    (1123, 'BETWEEN THE LINES', 'Daniyal Shah', 2200, 'Moonlight Publications', 'A'),
    (1124, 'THE LOST DIARY', 'Aleena Fayyaz', 2500, 'Inkspire House', 'A'),
    (1125, 'WHEN AUTUMN SPEAKS', 'Usman Tariq', 1900, 'Harbor Books', 'A'),
    (1126, 'BEYOND THE CLOUDS', 'Areeba Khalid', 2100, 'Sunrise Reads', 'A'),
    (1127, 'ECHOES OF SILENCE', 'Fahad Aslam', 2300, 'Paper Trail', 'A'),
    (1128, 'THE NIGHT WE REMEMBER', 'Zoya Irfan', 2000, 'Starlit Books', 'A'),
    (1129, 'THE FRAGILE THREAD', 'Hasan Raza', 2400, 'Nimbus Publications', 'A'),
    (1130, 'WANDERLUST AND WORDS', 'Mehak Qureshi', 2600, 'River & Rain', 'A'),
    (1131, 'UNTOLD TALES OF US', 'Yasir Adeel', 2700, 'Eloquent House', 'A');


CREATE TABLE Students (
    RollNo INT,
    Name VARCHAR(255),
    Class VARCHAR(10),
    Session CHAR(1),
    Address VARCHAR(255)
);


INSERT INTO Students (RollNo, Name, Class, Session, Address)
VALUES
    (1, 'UJALA KIRAN', 'CE-44', 'A', 'RAWALPINDI'),
    (2, 'NOSHEEN FATIMA', 'CE-44', 'A', 'KARACHI'),
    (3, 'RAO SHAHZEB', 'CE-44', 'A', 'MULTAN'),
    (4, 'ZUBAIR AHMED', 'CE-44', 'A', 'FAISALABAD'),
    (5, 'UMAR SARFARAZ', 'CE-44', 'A', 'HYDERABAD'),
    (6, 'SABA KALSOOM', 'CE-44', 'A', 'LAHORE');

CREATE TABLE BookIssue (
    BookIssueId INT,
    RollNo INT,
    BookId INT,
    IssueDate DATE
);

INSERT INTO BookIssue (BookIssueId, RollNo, BookId, IssueDate)
VALUES
    (2, 340772, 1122, '2025-04-02'),
	(3, 2, 1125, '2025-04-05'),
    (4, 5, 1130, '2025-04-07');

	SELECT name FROM sys.databases;
	SELECT @@VERSION;
