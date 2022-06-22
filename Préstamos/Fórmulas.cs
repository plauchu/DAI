using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Préstamos {

    class Fórmulas {

        //Cálculo de la mensualidad.
        //tasa: se recibe en porcentaje; plazo: se recibe en años.
        public decimal mensualidad (double tasa , int plazo , decimal monto) {
            double tasaMensual;
            decimal pagoMes;
            int plazoMeses;

            tasaMensual = tasa / 100 / 12;
            plazoMeses = plazo * 12;
            pagoMes = (decimal)Financial.Pmt(tasaMensual , plazoMeses , (double)-monto);
            return pagoMes;
            }
        }
    }
