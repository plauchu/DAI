# -*- coding: utf-8 -*-
"""
Created on Tue Nov 26 12:15:01 2019

Biblioteca para almacenar métodos comunes de lectura/escrita con archivos.
@author: dai

Función que lee un conjunto de n datos desde el archivo indicado por el primer
parámetro.
Regresa una lista con los datos (de tipo str).
"""
import pandas as pd

def lee_datos(arch, n):
    lista =[]
    for i in range(n):
        dato = arch.readline()
        lista.append(dato)
    return lista

"""
Lee líneas de datos desde el archivo dado como parámetro.
Regresa más de una serie con los datos.
"""

def lee_varias_series(arch,tipo):
    inds = []   #Para los índices.
    vals1 = []   #Para los valores.
    vals2 = []
    
    #Lectura de los datos.
    for línea in arch:
        datos = línea.split(',')
        #Agrega a los índices y a los valores.
        inds.append(datos[0])
        vals1.append(datos[1])
        vals2.append(datos[2].rstrip('\n'))
        
    #Crea la serie.
    serie1 = pd.Series(vals1, inds,dtype=tipo)
    serie2 = pd.Series(vals2, inds,dtype=tipo)
    
    return [serie1,serie2]    #Regresa las series en una lista.

"""
Lee líneas de datos desde el archivo dado como parámetro
Regresa un DataFrame
"""

#def leeDatosDF(archivo):
    




















