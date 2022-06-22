# -*- coding: utf-8 -*-
"""
Created on Tue Nov 19 12:47:42 2019

Ej. 1.7: manejo básido de tuplas.
@author: dai

Función que recibe una tupla como parámetro y regresa una tupla con los 
elementos pares de la misma
"""

def tupla_pares(t):
    resul = ()
    for i in range (0 ,len(t), 2):
        resul += (t[i],)
    
    return resul

def tupla_pares2(t):
    return t[::2]

#Programa principal.
print("Tupla pares: ",tupla_pares(('Yo', 'mi', 'a', 'prueba', 'tupla')))
print("Tupla pares: ",tupla_pares2(('Yo', 'mi', 'a', 'prueba', 'tupla')))