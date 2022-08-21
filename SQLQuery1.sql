create procedure Queue_DU(@DU int) as
select FullName as 'Имя ребенка', Document.Id_DU as 'Номер ДУ', Queue_pos as 'Номер в очереди' from Child inner join Document
on Id_Ch = Id_Child
where Document.Queue_pos is not null and Id_DU = @DU