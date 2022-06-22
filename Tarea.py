#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Mon Dec  2 15:09:44 2019

@author: Plauchu
"""


def apariciones (cad1, cad2):
    res = -1
    if(cad1!=None and cad2 != None):
        res = cad1.count(cad2) #Para contar ocurrencias de cad2 en cad1
    return res
    
cad1='azcbobobegghakl'
cad2='bob'
print("# de aparicinones de la 2nda cadena en la 1ra cadena: ",apariciones(cad1,cad2))
      

def sub_cad_ord (cad):
    res=''
    aux=[]
    for i in cad:       #Para cada caracter en la cadena
        if(cad.find(i) < (len(cad)-1)): #Si sigue dentro de rango
            if(i <= cad[cad.find(i) + 1]):  #Compara si el caracter es menor o igual que el
                res = res + i   #Si si lo concatena
            else:
                res = res + i   #Concatena
                aux.append(res) #Agrega a la lista aux la subcadena
                res = '' #Reinicia la variable res
            cad = cad[1:] #Empieza desde el índice 1
        else:
            res= res + i    #Concatena
            aux.append(res) #Agrega a la lista aux la subcadena
    return(max(aux,key=len)) #Encuentra dentro de la lista la subcadena más 
                             #grande
            
            
cad = 'azcbobobegghakl'
cad2= 'abcdzrtxyz'
print("Cadena en orden más larga: ",sub_cad_ord(cad))
print("Cadena en orden más larga: ",sub_cad_ord(cad2))
            
            
            
            
            
                