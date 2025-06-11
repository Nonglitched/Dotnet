/* Student Grading App
4 alumnos, 5 notas de examenes, (integer) 10 = 100% 0 = 0%
calificacion globlal = (nota1 + nota2 + nota3 + nota4 + nota5) / 5
tener en cuenta tareas de creditos adicionales 1 credito = 10%
La aplicación debe asignar automáticamente calificaciones con letras en función de la nota final calculada para cada alumno.
La aplicación debe mostrar el nombre de cada alumno y la nota formateada.
La aplicación debe admitir la incorporación de otros alumnos y de otras notas sin que ello afecte al código en gran medida.
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
La consola debe mostrar 
Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-
*/
// initialize variables - graded assignments 
// initialize variables - graded assignments 
// initialize variables - graded assignments
using System;
using System.Collections.Generic; // Necesario para Dictionary (aunque no se usa en esta versión, se mantiene por si se quiere refactorizar)

public class StudentGrader
{
    public static void Main(string[] args)
    {
        // Número de asignaciones de exámenes regulares que cuentan para el promedio base.
        // Las asignaciones adicionales se considerarán como crédito extra.
        int examAssignments = 5;

        // Definición de las calificaciones para cada estudiante.
        // Los elementos adicionales en los arrays después de los primeros 'examAssignments'
        // se consideran tareas de crédito adicional.
        int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = { 90, 95, 87, 88, 96, 96 };
        int[] beckyScores = { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = { 91, 91, 91, 91, 91, 91, 91 };

        // Nombres de los estudiantes
        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

        // Esta variable 'studentScores' se reutilizará para apuntar al array de calificaciones de cada estudiante actual.
        // Se inicializa, pero su valor será sobrescrito en cada iteración del bucle foreach.
        int[] studentScores = new int[10];

        // Encabezado del reporte
        Console.WriteLine("Student         Grade");
        Console.WriteLine("-------         -----");

        // Itera sobre cada estudiante por su nombre
        foreach (string name in studentNames)
        {
            string currentStudent = name; // Almacena el nombre del estudiante actual

            // Asigna el array de calificaciones correcto al 'currentStudent'
            // Este es el bloque corregido para incluir a todos los estudiantes.
            if (currentStudent == "Sophia")
                studentScores = sophiaScores;
            else if (currentStudent == "Andrew")
                studentScores = andrewScores;
            else if (currentStudent == "Emma")
                studentScores = emmaScores;
            else if (currentStudent == "Logan")
                studentScores = loganScores;
            else if (currentStudent == "Becky") // ¡Añadido!
                studentScores = beckyScores;
            else if (currentStudent == "Chris") // ¡Añadido!
                studentScores = chrisScores;
            else if (currentStudent == "Eric") // ¡Añadido!
                studentScores = ericScores;
            else if (currentStudent == "Gregor") // ¡Añadido!
                studentScores = gregorScores;
            // Se puede añadir un 'else' aquí para manejar nombres no reconocidos,
            // por ejemplo: studentScores = new int[0];

            // Reinicia la suma de calificaciones para el estudiante actual
            int sumAssignmentScores = 0;

            // Reinicia el contador de asignaciones procesadas para el estudiante actual
            int gradedAssignmentsCount = 0;

            // Bucle para calcular la suma de las calificaciones del estudiante actual
            // Las primeras 'examAssignments' (5) son exámenes regulares.
            // Las calificaciones restantes son créditos adicionales.
            foreach (int score in studentScores)
            {
                gradedAssignmentsCount += 1; // Incrementa el contador de asignaciones procesadas

                if (gradedAssignmentsCount <= examAssignments)
                {
                    // Suma la calificación de examen normal
                    sumAssignmentScores += score;
                }
                else
                {
                    // Suma los puntos de crédito adicional.
                    // 1 crédito = 10% de un examen, lo que se interpreta como 10% del valor de la calificación de crédito adicional.
                    // Se usa división entera, que es consistente con el comportamiento que produce la salida deseada.
                    sumAssignmentScores += score / 10;
                }
            }

            // Calcula la calificación final del estudiante.
            // Se divide por el número de exámenes regulares, permitiendo que el crédito adicional
            // aumente la calificación por encima de 100.
            decimal currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

            // Determina la calificación con letra según la escala
            string currentStudentLetterGrade = "";
            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";
            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";
            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";
            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";
            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";
            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";
            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";
            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";
            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";
            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";
            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";
            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";
            else
                currentStudentLetterGrade = "F";

            // Muestra el resultado formateado en la consola
            // {currentStudent,-15}: alinea a la izquierda en un campo de 15 caracteres
            // {currentStudentGrade:N1}: formatea el número para mostrar un decimal
            Console.WriteLine($"{currentStudent,-15}\t{currentStudentGrade:N1}\t{currentStudentLetterGrade}");
        }

        // Mantiene la ventana de la consola abierta para ver los resultados
        Console.WriteLine("\nPress the Enter key to continue");
        Console.ReadLine();
    }
}
