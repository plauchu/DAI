# -*- coding: utf-8 -*-
"""
Created on Wed Dec 18 14:59:16 2019

@author: dai
"""
#a)
flec= open('frutas.csv','r')
lista = []
for i in flec:
    lista = lista + [(i).rstrip('\n')]
    
flec.close()
#print("Lista de tuplas: ",lista)

#b)
def palabras_cad(t):
    dic = {}
    #Separa cada palabra y las entrega como una lista.
    listaPalabras = t[::1]
    
    #Recorre la lista y cuenta cada palabra usando el diccionario.
    for palabra in listaPalabras:
        if palabra in dic:
            dic[palabra] += 1   #Si la palabra ya esta en las claves de dic
        else:                   #incrementa su cuenta
            dic[palabra] = 1    #La palabra es nueva
    return dic

#Prog. principal.

dicResul = palabras_cad(lista)
#print("Resultado: ",dicResul)

#c)
def mini_max (dic):
    return max(dic), min(dic)
print(mini_max(dicResul))
