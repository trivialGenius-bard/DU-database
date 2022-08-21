/*•	учет дошкольных  учреждений города (название, назначение, тип – муниципальное, коммерческое,  ведомственное, 
контактные данные, профили, количество мест, стоимость, адрес, директор, телефон);*/
select Number as 'Номер', sum(Capacity) as 'Количество мест', Fullname as 'Название', TypName as 'Тип', Adress as 'Адрес', Cont, Cost as 'Контакты' from DU
left outer join [Group]
on [Group].ID_DU = Number
left outer join [Type_DU]
on TypName = Type_DU.[Name]
group by Number, Fullname, TypName, Adress, Cont, Cost