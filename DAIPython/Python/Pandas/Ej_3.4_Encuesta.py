# -*- coding: utf-8 -*-
"""
Created on Tue Dec  3 12:18:01 2019

Ej. 3.4: manejo de DataFrame's

@author: dai
"""
import pandas as pd

#Prog. principal

#a): lectura de datos
columnas=['Nombre','Género','Edad','Ocupación','CP']
encuesta = pd.read_table("encuestaOcupacion.csv",header = None, sep = ',',
                          names = columnas)
print("Encuesta: \n", encuesta, '\n')

#b): crea una serie desde el DF.
ocupación=encuesta['Ocupación']
print("Ocupación: \n", ocupación, '\n')

#c) obtiene un subconjunto de las filas
renglones3= encuesta.iloc[3:6]
print("Filas 4-6: \n", renglones3, '\n')

#d): nombre del segundo encuestado
print("Segundo encuestado: \n", encuesta.iloc[1], '\n')

#f): nombres y ocupaciones.
print("Nombres y ocupaciones: \n",encuesta.loc[:][['Edad','Ocupación']],'\n')

#i): nombres de las columnas.
print("Columnas: \n", encuesta.columns, '\n') 

#k): aplicación de filtros.
mayores = encuesta[encuesta['Edad']>50].iloc[:,[0,2]]
print("Mayores a 50: \n", mayores, '\n')