using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n1_inmobilaria.source.Mundo
{
    public class Inmobilaria
        //ATRIBUTOS DE RELACION // y el tipo es mansion, porque de proviene de la clase mansion
    {
        private Mansion mansion1;
        private Mansion mansion2;
        private Mansion mansion3;

        //METODO CONSTRUCTOR //crear una instancia con la palabra reservada new y la calse a la que pertenece y luegpo invocarlo con el metodo constructor de la clase mansion
        public void inicializar()
        {
            mansion1 = new Mansion();
            mansion1.inicializar();

            mansion2 = new Mansion();
            mansion2.inicializar();

            mansion3 = new Mansion();
            mansion3.inicializar();
        }

        //METODO PARA DAR MANSION 1
        public Mansion darMansio1()
        {
            return mansion1;
        }

        //METODO PARA DAR MANSION 2
        public Mansion darMansion2()
        {
            return mansion2;
        }

        //METODO PARA DAR MANSION 3
        public Mansion darMansion3()
        {
            return mansion3;
        }

        //METODO PARA ACTUALIZAR DATOS DE LA MANSION 1
        public void actualizarDatosMansion1(int habitantes, int numParqueaderos, int numEmpleados, int precio, int tamanio)
        {
            mansion1.modificarHabitantes(habitantes);
            mansion1.modificarNumeroParqueaderos(numParqueaderos);
            mansion1.modificarNumeroEmpleados(numEmpleados);
            mansion1.modificarPrecio(precio);
            mansion1.modificarTamanio(tamanio);
        }

        //METODO PARA ACTUALIZAR DATOS DE LA MANSION 2
        public void actualizarDatosMansion2(int habitantes, int numParqueaderos, int numEmpleados, int precio, int tamanio)
        {
            mansion2.modificarHabitantes(habitantes);
            mansion2.modificarNumeroParqueaderos(numParqueaderos);
            mansion2.modificarNumeroEmpleados(numEmpleados);
            mansion2.modificarPrecio(precio);
            mansion2.modificarTamanio(tamanio);
        }

        //METODO PARA ACTUALIZAR DATOS DE LA MANSION 3
        public void actualizarDatosMansion3(int habitantes, int numParqueaderos, int numEmpleados, int precio, int tamanio)
        {
            mansion3.modificarHabitantes(habitantes);
            mansion3.modificarNumeroParqueaderos(numParqueaderos);
            mansion3.modificarNumeroEmpleados(numEmpleados);
            mansion3.modificarPrecio(precio);
            mansion3.modificarTamanio(tamanio);
        }

        //METODO PARA CALCULAR COSTO DE ADMINISTRACION
        public double calcularCostoAdministracion()
        {
            double costoDeLimpieza = ((mansion1.calcularCostoLimpieza()+ mansion2.calcularCostoLimpieza()+mansion3.calcularCostoLimpieza())*25)/100;
            double costoDeSeguridad = ((mansion1.calcularCostoSeguridad() + mansion2.calcularCostoSeguridad() + mansion3.calcularCostoSeguridad()) * 10) / 100;
            double costoAdministracion = costoDeLimpieza + costoDeSeguridad;
            return costoAdministracion;
        }

        //METODO PARA CALCULAR COSTO PROMEDIO DE SERVICIOS
        public double calcularCostoPromedioServicios()
        {
            double promedioServicios = ((mansion1.calcularCostoLimpieza()+mansion2.calcularCostoLimpieza()+mansion3.calcularCostoLimpieza())/3);
            return promedioServicios;
        }

         //METODO 1
         public string metodo1()
        {

        }

        //METODO 2
        public string metodo2()
        {

        }
    }
}
