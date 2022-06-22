# -*- coding: utf-8 -*-
"""
Created on Tue Nov 19 11:50:35 2019

@author: dai
"""
n = int(input("Dame el número: "))

if 3<= n <= 6:
    a=[0]*n
    b=[0]*n
    c=False
    
    #Lectura de datos
    print("Datos lista 1:")
    for i in range (n):
        a[i] = int(input())
    
    print("Datos lista 2:")
    for i in range (n):
        b[i] = int(input())
    
    #Determina si hay intersección
    for i in range(n):
        for j in range(n):
            if a[i] == b[j]:
                c=True
                break
    
    #imprime resultado
    if c== True:
        print("Hay intersección")
    else:
        print("No hay intersección")
else:
    print("Valores incorrectos")