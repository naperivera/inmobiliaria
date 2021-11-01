using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n1_inmobilaria.source.Mundo
{
   public class Mansion
        //ATRIBUTOS 1PASO
    {
        private int habitantes;
        private int numParqueaderos;
        private int numEmpleados;
        private int precio;
        private int tamanio;

        //METODO CONSTRUCTOR PARA DARLE UN VALOR INICIAL A  LOS ATIBUTOS 2PASO
        public void inicializar()
        {
            habitantes = 0;
            numParqueaderos = 0;
            numEmpleados = 0;
            precio = 0;
            tamanio = 0;
        }

        //METODO PARA DAR EL NUMERO DE HABITANTES
        public int darHabitantes()
        {
            return habitantes;
        }

        //METODO PARA DAR NUMERO DE EMPLEADOS
        public int darEmpleados()
        {
            return numEmpleados;
        }

        //METODO PARA DAR NUMERO DE PARQUEADEROS
        public int darParqueaderos()
        {
            return numParqueaderos;
        }

        //METODO PARA DAR PRECIO
        public int darPrecio()
        {
            return precio;
        }

        //METODO PARA DAR TAMAÑO
        public int darTamanio()
        {
            return tamanio;
        }

        //METODO PARA MODIFICAR HABITANTES
        public void modificarHabitantes(int pHabitantes)
        {
            habitantes = pHabitantes;
        }

        //METODO PARA MODIFICAR NUMERO DE EMPLEADOS
        public void modificarNumeroEmpleados(int pNumEmpleados)
        {
            numEmpleados = pNumEmpleados;
        }

        //METODO PARA MODIFICAR NUMERO DE PARQUEADEROS
        public void modificarNumeroParqueaderos(int pNumParqueaderos)
        {
            numParqueaderos = pNumParqueaderos;
        }

        //METODO PARA MODIFICAR PRECIO
        public void modificarPrecio(int pPrecio)
        {
            precio = pPrecio;
        }

        //METODO PARA MODIFICAR TAMAÑO
        public void modificarTamanio(int pTamanio)
        {
            tamanio = pTamanio;
        }

        //METODO PARA CALCULAR COSTO DE LIMPIEZA
        public int calcularCostoLimpieza() //almacenar en una variable, para poder retornar el valor del costo de la limpieza
        {
           int costoLimpieza= (habitantes * 250) + (numEmpleados * 3000) + (tamanio * 500);
            return costoLimpieza;
        }

        //METODO PARA CALCULAR COSTO DE LOS SERVICIOS
        public double calcularCostoServicios()
        {
            double costoServicios = (habitantes * 5000) + (precio * 2 / 100);
            return costoServicios;
        }

        //METODO PARA CALCULAR COSTO DE SEGURIDAD

        public int calcularCostoSeguridad()
        {
            int costoSeguridad = (numParqueaderos * 450) + (tamanio + 500);
            return costoSeguridad;
        }
    }


}
