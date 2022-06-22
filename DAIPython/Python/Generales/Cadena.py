# -*- coding: utf-8 -*-
"""
Created on Thu Nov 14 12:42:03 2019

@author: dai
Eju. 1.2: imprime los caracteres pares de una cadena
"""

cad = input("Dame la cadena: ")

for i in range(0, len(cad), 2):
    print(cad[i])

# Serie de Fibonacci.
def fibo(cad):
    a = 0
    b = 1
    print("Letra: ",cad[a])
    print("Letra: ",cad[b])
    while b < len(cad) - 1:
        temp = a + b
        a = b
        b = temp
        print("Letra: ",cad[b])
    
print(fibo("Fibonacci"))