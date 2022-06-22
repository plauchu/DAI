# -*- coding: utf-8 -*-
"""
Created on Tue Nov 26 12:42:43 2019

Ej. 2.4: ejercicios de matrices.
@author: dai
"""
import numpy as np

#Función que regresa la transpuesta de matriz:
def transp(matriz):
    return np.transpose(matriz)





#Prog.principal
#Lectura de los datos.
matriz = np.loadtxt("Ej2_4_MatrizMN.txt",dtype='int')
print("Matriz: ")
print(matriz)
matrizT = transp(matriz)
print("Matriz transpuesta: ")
print(matrizT)