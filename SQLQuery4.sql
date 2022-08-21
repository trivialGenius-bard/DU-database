create procedure DU_Free_Age(@Age int)
as
select Number, Fullname, sum(Capacity) as 'Количество мест' from DU
inner join [Group]
on [Group].ID_DU = Number
where Age = @Age
group by Number, Fullname