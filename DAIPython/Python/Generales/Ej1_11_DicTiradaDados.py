# -*- coding: utf-8 -*-
"""
Ej. 1_11: función que cuenta la cantidad de veces que aparece cada valor de
tiradas de dos dados. 
"""

import random

def dados(n):
  dic={}
  for i in range(n):
    #Genera la tupla con la tirada de cada dado.
    tupla=(random.randint(1,6),random.randint(1,6))

    #La agrega al diccionario o incrementa su cuenta.    
    if tupla in dic:
      dic[tupla] += 1
    else:
      dic[tupla]= 1
         
  return dic

#Prog. principal.
n=int(input("¿Cuántas tiradas harás? "))
result=dados(n)

#Genera una lista con las claves del diccionario ordenadas ascendentemente.
#for clave in result:
listaClavesOrd= sorted(result.keys())
for clave in listaClavesOrd:
  print(clave,result[clave])
