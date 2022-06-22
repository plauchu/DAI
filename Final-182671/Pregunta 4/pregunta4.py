# -*- coding: utf-8 -*-
"""
Created on Wed Dec 18 15:30:59 2019

@author: dai
"""

import pandas as pd
#a)
bib = pd.read_csv("biblioteca.csv",encoding = "Latin-1", sep = ',')
#print("Bibloteca: \n", bib, '\n')

#b)
libros = bib['title']
#print("Libros: \n", libros, '\n')

#c) 
#print("Autor y título: \n",bib.loc[300:310][['author','title']],'\n')

#d)
número = bib[bib['transaction']=='RENW'].count()
#print(número)

#d)
prestados =  bib[bib['transaction']=='ISSU'].iloc[:,[0,2]]
print(prestados)