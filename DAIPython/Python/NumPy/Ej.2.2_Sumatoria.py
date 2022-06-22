# -*- coding: utf-8 -*-
"""
Created on Tue Nov 26 12:20:30 2019

Ej. 2.2: sumatoria de números.

@author: dai
"""
import leeDatos as ld
import numpy as np

#Prog. principal.
flec = open("Ej2_2_Sumatorias.txt", "r")
n= int(flec.readline()) #Cant. de valores para los arreglos.

#Lee los datos de los arreglos.
listaA= ld.lee_datos(flec,n)
a = np.array(listaA, dtype = 'float')
print("A: ",a)

listaB= ld.lee_datos(flec,n)
b = np.array(listaB, dtype = 'float')
print("B: ",b)
flec.close()

#Calcula la 1a. sumatoria
c = a * b
print("c: ",c)
print("1ra. sumatoria: ",c.sum())

#Calcula la 2nda. sumatoria
d= np.flip(b)   #Invierte el arreglo b
e = a*d
print ("d: ",d)
print("e: ",e)
print("2nda. sumatoria: ",e.sum())
