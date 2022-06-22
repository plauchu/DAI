# -*- coding: utf-8 -*-
"""
Created on Thu Nov 14 12:20:52 2019

@author: dai
Ej. 1.1: Cálculo iterativo del factorial
"""
n = int(input("Dame el número: "))
fac = 1
i = 1
while i<=n:
    fac = fac*i
    i += 1
print("El factorial (con while) de ",n,"es: ",fac)

fac = 1
i = 1
for x in range(n):
    fac = fac*i
    i += 1
print("El factorial (con for) de ",n,"es: ",fac)
