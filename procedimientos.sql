select* from  Producto for xml path
select*from Producto

create procedure pa_ConsultarP
as 
begin
select *from Producto 
end  
go
create procedure pa_ConsultarN(
@codigo int
)
as 
begin
select *from Producto where CodCat=@codigo 
end  
go

create procedure pa_ConsultarC
as 
begin
select *from Categoria 
end  
go

