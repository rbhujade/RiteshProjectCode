--select * from TB_Student

declare @id int,@name varchar(50),@email nvarchar(50)

declare @counter int
set @counter=1

declare student_crsr cursor
for
select ID,Name,Email from TB_Student

open student_crsr

fetch next from student_crsr
into
@id,@name,@email

while @@FETCH_STATUS = 0
begin
	if @counter = 1
	begin
		print 'Id' + char(9) +'Name' + char(9) + 'Email'
		print '------------------------------------------'
	end

	print cast(@id as nvarchar(9)) + char(9) + @name + char(9) + @email

	set @counter = @counter + 1

	fetch next from student_crsr into
	@id,@name,@email
end

close student_crsr
deallocate student_crsr
