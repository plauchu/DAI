# -*- coding: utf-8 -*-
"""
Created on Tue Nov 26 11:28:04 2019

Ej. 2.1: ejemplo del manejo básico de NumPy
@author: dai
"""
import numpy as np

#Prog. principal 

#Lectura de datos.
flec = open("Ej2_1_VentasMes.txt", "r")
linea = flec.readline()
flec.close()
listaVentas = linea.split()
print("Lista de ventas: ",listaVentas)
ventas = np.array(listaVentas,dtype='int')
print("Arreglo de ventas: ",ventas)

#b: venta máxima
ventaMax=ventas.max();
print("Venta máxima: ",ventaMax)

#a: Mes(es) con venta máxima
print("Mes(es) con venta máxima: ")
for i in range(len(ventas)):
    if ventaMax == ventas[i]:
        print("Mes: ",i+1)

#c: Total de ventas
print("Total de ventas: ",ventas.sum())

#d: promedio de ventas
print("Promedio de ventas: ",ventas.mean())
