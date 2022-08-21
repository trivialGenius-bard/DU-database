/*•	учет детей, посещающих ДУ  всех типов (ФИО ребенка и его родителей, возраст /дата рождения, сведения о 
родителях, категория, адрес);*/
select Fullname, Date_brth, [Relative].Resembl as 'Родственник' ,min([Relative].[Name]) as 'Имя родственника' from [Child]
left outer join Family
on Family.Child = Id_Ch
left outer join [Relative]
on Family.[Relative] = [Relative].Id_Rel
left outer join Document
on Child.Id_Ch = Document.Id_Child
where Document.[Group] is not null
group by Fullname, Date_brth, [Relative].Resembl