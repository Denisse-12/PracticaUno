using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno _alumno = new Alumno();
            Profesor _profesor = new Profesor();
            _alumno.Edad = 17;
            _alumno.Nombre = "Denisse";
            _alumno.NoControl = 1234;

            _profesor.Edad = 23;
            _profesor.Nombre = "Erick";
            _profesor.Sueldo = 1;

            Console.Write("La edad del alumno es :{0} su nombre es :{1} y su no de contro : {2}",_alumno.Edad,_alumno.Nombre,_alumno.NoControl);

            Console.ReadKey();

        }

    

    }
}
