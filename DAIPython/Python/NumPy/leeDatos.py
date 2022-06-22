# -*- coding: utf-8 -*-
"""
Created on Tue Nov 26 12:15:01 2019

Biblioteca para almacenar métodos comunes de lectura/escrita con archivos.
@author: dai

Función que lee un conjunto de n datos desde el archivo indicado por el primer
parámetro.
Regresa una lista con los datos (de tipo str).
"""
def lee_datos(arch, n):
    lista =[]
    for i in range(n):
        dato = arch.readline()
        lista.append(dato)
    return lista


