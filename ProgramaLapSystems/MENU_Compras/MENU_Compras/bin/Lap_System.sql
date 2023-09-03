			create database Lap_System

			use  Lap_System

            drop table Personas

			create table Personas 
			(
			id_persona int identity (1,1),
			CUIT NUMERIC ,
			nombre varchar(30),
			apellido varchar(30),
			tel varchar(13),
			email varchar(35),
			razon_social varchar(30),

			primary key (id_persona)
			)

			create table Tipo_Persona
			(
			id_tipo_persona int identity(1,1),
			tipo_persona varchar(5),
			fisica bit, 

			primary key (id_tipo_persona)
			)


			create table per_tipo
			(
			id_persona int,
			id_tipo_persona int,
			
			primary key (id_persona, id_tipo_persona),
			foreign key (id_persona) references Personas (id_persona),
			foreign key (id_tipo_persona) references Tipo_Persona (id_tipo_persona)
			)

drop table Usuarios

            
            select * from Usuarios
            
			create table Usuarios 
			(
			id_usuario int identity(1,1),
			usuario varchar (30),
			CUIT NUMERIC,
			activo bit,
			password varchar(20),

			primary key (id_usuario)
			)

			create table Modulo
			(
			id_grupo int identity(1,1),
			id_perfil int,
			ventas bit,
			compras bit, 
			RRHH bit,
			contable bit,

			primary key (id_grupo)
			)


			create table Usuario_modulo
			(
			id_usuario int,
			id_grupo int,
			)

			create table Permisos
			(
			id_perfil int identity(1,1),
			alta bit,
			baja bit,
			modificar bit,
			consulta bit,

			primary key (id_perfil)
			)

			create table modulo_permisos
			(
			id_perfil int,
			id_grupo int,
			)

			create table H_Movimientos
			(
			id_historico int identity (1,1),
			id_usuario int,
			tipo_movimiento int,
			reg_antes varchar,
			reg_despues varchar,
			fecha_hora date,

			primary key (id_historico)
			)

			create table In_Out_Varios
			(
			id_movimiento int identity(1,1),
			cod_usuario int,
			tipo varchar,
			detalle varchar,
			monto varchar,
			fecha varchar,

			primary key (id_movimiento)
			)

			create table H_Compras_Detalle
			(
			id_det_remito int identity(1,1),
			id_remito int,
			cod_art varchar,
			descr varchar,
			p_unit varchar,
			cant varchar,
			p_x_cant varchar,

			primary key( id_det_remito)
			)
			
			create table Proveedores
			(
			id_proveedor int identity(1,1),
			CUIT NUMERIC,
			razon_social varchar(30),
			activo bit,
			
			primary key (id_proveedor)
			)
			
			create table Clientes
			(
			id_cliente int identity(1,1),
			CUIT numeric,
			razon_social varchar,
			activo bit,
			
			primary key (id_cliente)
			)
			
			create table Articulos
			(
			id_articulo int identity(1,1),
			cod_articulo varchar, 
			art_desc varchar,
			cod_categoria int,
			cod_subcat int,
			id_proveedor int,
			
			primary key (id_articulo)
			)
			
			create table Stock
			(
			cod_articulo varchar,
			cantidad int,
			costo varchar,
			ganancia int,
			
			primary key (cod_articulo)
			)
			
			create table H_Ventas
			(
			id_remito int identity(1,1),
			cod_usuario int,
			fecha_hora varchar,
			id_cliente int,
			subtotal varchar,
			descu varchar,
			total varchar,
			
			primary key (id_remito)
			)
			
			create table H_Ventas_Detalle
			(
			id_det_remito int identity(1,1),
			id_remito int,
			cod_art varchar,
			descr varchar,
			p_unit varchar,
			cant varchar,
			p_x_cant varchar,
			
			primary key (id_det_remito)
			)
			
			create table Categoria
			(
			id_categoria int identity(1,1),
			categoria varchar,
			
			primary key (id_categoria)
			)
			
			create table Subcategoria
			(
			id_subcategoria int identity(1,1),
			subcategoria varchar,
			id_categoria int,
			
			primary key (id_subcategoria)
			)
			
			create table H_Compras
			(
			id_remito int identity(1,1),
			cod_usuario int,
			fecha_hora varchar,
			id_proveedor int,
			subtotal varchar,
			descu varchar,
			total varchar,
			 primary key (id_remito)
			 )
			 
			 create table Usuarios_Tipo
			 (
			 id_usuario_tipo int identity(1,1),
			 tipo int,
			 descripcion varchar,
			 
			 primary key (id_usuario_tipo)
			 )
			 select * from Personas
			select * from per_tipo
			select * from Proveedores
			select * from Tipo_Persona
			
			
			
						insert into Personas(CUIT, nombre,apellido, tel, email,razon_social)
			values (30395985966, 'ramitro','rojas','13231323','llldad@fsf','lolepito')
						insert into Tipo_Persona (tipo_persona, fisica)
			values ('U', 'True')
						INSERT into per_tipo (id_persona, id_tipo_persona)
			values (1,1)
			
			
			
			 update Tipo_Persona set tipo_persona = 'U P', fisica = 0 where id_tipo_persona = 1 
			 Update Tipo_Persona set tipo_persona = 'UP',  fisica = 'false' where id_tipo_persona = 1

			 
			 
			 select id_tipo_persona from Tipo_Persona where id_tipo_persona = (select MAX (id_tipo_persona) from Tipo_Persona)}
			 Select id_persona from Personas where CUIT = 27389636415
			 
			 select Tipo_Persona.tipo_persona as TipoP
			 from Tipo_Persona 
			 inner join per_tipo
			 on per_tipo.id_tipo_persona = Tipo_Persona.id_tipo_persona
			 inner join Personas
			 on Personas.id_persona = per_tipo.id_persona
			 where Personas.CUIT =20689564576
			 

			 drop table Personas
			 drop table Tipo_Persona
			 drop table Proveedores
			 drop table per_tipo
			 
			select * from Personas
			select * from Usuarios
			
			Insert Into Usuarios(CUIT, usuario, password, activo) values (303030308, 'pruebausu', 'pruebapass', 'true')
			
			UPDATE Usuarios SET activo='true' WHERE CUIT=2030278493;
			
			

			
			