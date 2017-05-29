CREATE TABLE [dbo].[EmployeeInfo]
(
	[EmpNo] INT identity PRIMARY KEY,
	[EmpName] varchar(50) Not Null,
	[Salary] int Not Null,
	[DeptName] varchar (50) Not Null,
	[Designation] varchar(50) Not Null,
	[HRA] as [Salary] * 0.2,
	[TA] as [Salary] * 0.15,
	[DA] as [Salary] * 0.18,
	[GrossSalary]  as [Salary] + ([Salary]*0.2) + ([Salary] *0.15) + ([Salary]*0.18),
	[TDS] as ([Salary] + ([Salary]*0.2) + ([Salary] *0.15) + ([Salary]*0.18)) * 0.25,
	[NetSalary]  as ([Salary] + ([Salary]*0.2) + ([Salary] *0.15) + ([Salary]*0.18))-([Salary] + ([Salary]*0.2) + ([Salary] *0.15) + ([Salary]*0.18)) * 0.25
)
