-- a)
--select nombre, tipo
--from cliente c
--where nombre  between 'F' and 'M' and tipo = 'aseg' or tipo = 'cont'

-- b)
--select nombre
--from servicio
--where deducible between 10000 and 30000
--order by deducible desc, nombre 

-- c)
--select p.folio, prima, idP, fecha, monto
--from p�liza p, pago a
--order by p.folio desc, a.fecha 

-- d)
--select c.nombre, p.folio, e.descrip, e.fechaIni
--from asegurado a, p�liza p, cliente c, evento e
--where c.idcli = a.idcli 
--order by fechaIni desc

-- e)
--select p.folio, s.nombre 
--from p�liza p, canal c, servicio s
--where c.tipo = 'Agente' and FechaIniVig >= '04-01-2019'
--order by fechainivig desc 

-- f)
--select c.nombre, p.folio, a.fecha, a.monto
--from p�liza p, cliente c, contratante o, pago a
--where c.idcli = c.idcli and a.fecha between '12-01-2018' and '03-31-2019'

-- g) 

--select distinct c.nombre
--from p�liza p, canal c
--where (p.FechaIniVig > '03-31-2019' or p.fechainivig < '01-01-2019')
--and p.idC = c.idC
--order by c.nombre

-- h)
--select p.folio, fechaIniVig
--from p�liza p, servicio s
--where nombre <> 'Deportes peligrosos'

-- i)
--select p.folio, fechaIniVig
--from p�liza p, servicio s, Tiene t
--where nombre ='Premier 100' 
--and t.idS = s.ids and p.folio = t.folio
--and p.folio in
--	(select p.folio
--	from servicio s, p�liza p, tiene t
--	where nombre = 'M�dica m�vil'
--	and t.idS = s.ids and p.folio = t.folio)

-- j)

--select distinct c.idCli, c.nombre
--from cliente c, evento e, asegurado a 
--where c.idcli = a.idcli and a.idcli = e.idCli 
--or c.idcli in
--	(select c.idCli
--	from cliente c, p�liza p, servicio s, tiene t, contratante con
--	where c.idcli = con.idcli and con.idcli =p.idcli 
--	and p.folio = t.folio and t.ids = s.ids and s.nombre = 'Acceso cl�nicas')

-- k)

--select p.folio, count(*), sum(pa.monto)
--from p�liza p, pago pa
--where p.folio = pa.folio 
--group by p.folio

-- l)

--select avg(p.prima) "Promedio primas asegurados con eventos"
--from  asegurado a, p�liza p, evento e
--where a.idcli = e.idcli and p.folio = a.folio 

-- m)

--select c.nombre
--from cliente c, contratante con, p�liza p
--where c.idcli=con.idcli and con.idcli = p.idcli
--and p.folio in
--	(select p.folio
--	from asegurado a, p�liza p
--	where p.folio = a.folio
--	group by p.folio
--	having count(*) >= 2)

-- n)

--select distinct s.nombre
--from  p�liza p, servicio s, tiene t
--where p.folio = t. folio and t.ids = s.ids
--and s.ids in
--	(select s.ids
--	from  tiene t, servicio s 
--	where s.ids = t.ids 
--	group by s.ids
--	having count(*) > 2)
