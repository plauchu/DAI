# -*- coding: utf-8 -*-
"""
Created on Thu Nov 28 11:16:27 2019

Ej. 3.1: básicos de las series.
@author: dai
"""
import pandas as pd
import numpy as np
import leeDatos as ld
"""
selMex = pd.read_csv("seleccionMexicana.csv",header=None, index_col=0)
print(selMex)
"""

#Prog. principal.
#Lectura de los datos.
flec = open("seleccionMexicana.csv", "r")
selMex =  ld.lee_serie(flec,int)
flec.close()
print("Selección: ")
print(selMex)

#a) jugador con el dorsal mayor.
print("Mayor dorsal", selMex[selMex == selMex.max()])

#b) SERIE CON LOS JUGADORES CON DORSAL < 15
selMenor15 = selMex[selMex < 15]
print("Jugadores con dorsal menor a 15")
print(selMenor15) 

#c) ordena la serie anterior.
selMenor15Inds = selMenor15.sort_index()
selMenor15Vals = selMenor15.sort_values()
print("Ordenados índices: ",selMenor15Inds)
print("Ordenados values: ",selMenor15Vals)

#d) crea un archivo con los jugadores que tienen dorsal < 15
