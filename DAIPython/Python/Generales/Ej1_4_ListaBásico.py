# -*- coding: utf-8 -*-
"""
Editor de Spyder

Este es un archivo temporal.
Ej. 1.4: Ejemplo del manejo de listas
"""

import random

#GENERA LA LISTA DE CALIFS DE MANERA ALEATORIA
#LOS VALORES SE GUARDAN COMO FLOAT

n = 5
califs = []

for i in range (n):
    calif = float(random.randint(6, 10))
    califs = califs + [calif]
print("Califs: ",califs)

#Porcentajes para el promedio ponderado
porcents = [0.10, 0.20, 0.23, 0.30, 0.17]

#Calcula el promedio ponderado

prom = 0
for i in range (n):
    prom += califs[i]*porcents[i]
print("Promedio con decimales: ",prom)
print("Promedio redondeado: ",round(prom))

