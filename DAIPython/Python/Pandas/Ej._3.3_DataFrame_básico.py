# -*- coding: utf-8 -*-
"""
Created on Tue Dec  3 11:22:47 2019

Ej. 3.3: básicos DataFrame's

@author: dai
"""

import pandas as pd

#Prog. principal

#a) y b): creación del DataFrame.
datos={'Estado':['EdoMex','CDMX','Veracruz','Jalisco'], 
       'Pob':[17363,8811,8163,8110]}
índices=[15,9,30,14]
estados=pd.DataFrame(datos,índices)
print("Estados:\n",estados,'\n')

#c): agrega filas de datos al DataFrame.
datosMenorP={'Estado':['BCS','Colima'],'Pob':[809,747]}
indsMenorP=[3,6]
menorP= pd.DataFrame(datosMenorP,indsMenorP)
estados=estados.append(menorP)
print("Estados:\n",estados,'\n')

#d):
estados['PIB']=[2.9,4.6,1.6,4.7,2.2,5.7]
print("Estados:\n",estados,'\n')

#e):
estadosAsc = estados.sort_index()
print("Estados en órden ascendente:\n",estadosAsc,'\n')


