# -*- coding: utf-8 -*-
"""
Este programa muestra las instrucciones básicas para apertura, lectura y
escritura de archivos de texto.
"""

# Lee datos desde un archivo, los multiplica por 2 y
# los escribe en otro archivo.
print('Inicié lectura y escritura de archivos')

# Apertura de los archivos.
flec= open('Datos.csv','r')         #Con 'r' el arch. se abre para lectura.
fesc= open('Resultados.csv','w')    #Con 'w' se abre para escritura.

#Escritura en el archivo de salida.
fesc.write('Los números multiplicados por 2 son: \n')

# Lectura desde archivo (cada línea se lee como cadena):
for línea in flec:
	listaNums = línea.split(',')   	# Se crea una lista con los números leídos.
	
	for num in listaNums:					#Multiplica por 2 cada número.
		num2= float(num) * 2
		salida= num.rstrip('\n') + '\t' + str(num2) + '\n'
		fesc.write(salida)   		 #Escritura en el archivo de salida.
      
# Cierra archivos.
flec.close()
fesc.close()
print('Terminé lectura y escritura de archivos')

