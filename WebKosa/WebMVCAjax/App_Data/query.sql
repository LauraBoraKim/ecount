use KosaDB

create table employee(
	employeeID int identity(1,1) not null,
	Name nvarchar(50),
	Age int,
	State nvarchar(50),
	Country nvarchar(50),
	constraint pk_employee_id primary key(employeeID) 
)

create proc selectEmployee
as
	begin
		select * from employee;
	end

exec selectEmployee

create proc InsertUPdateEmployee
(
	@id int,
	@Name nvarchar(50),
	@Age int,
	@State nvarchar(50),
	@Country nvarchar(50),
	@Action varchar(10)
)
as
	begin
		if @Action = 'Insert'
		begin
			insert into employee(name,age,state,Country)
			values(@name,@age,@state,@Country)
		end
		if @Action = 'update'
		begin
			update employee set name=@name,age=@age, State=@State , Country=@Country
			where employeeID = @id	 
		end
	end




