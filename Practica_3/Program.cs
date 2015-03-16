using System;
using System.Collections;

	namespace Practica_3
	{

		class Persona
		{
			static Hashtable tabla = new Hashtable();

			public string nombre;
			public string codigo;

			public static void Main(string[] args)
			{
			Console.Title = "Practica_3";
			Console.SetWindowSize(15, 10);
			Console.BackgroundColor = ConsoleColor.Gray;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Clear ();
			int opcion;
			bool bandera = false;
			do{
				Console.Clear();
			Console.WriteLine ("selecciona accion a realizar?\n\n 1) agregar nuevo alumno\n 2) eliminar alumno \n 3) ver alumnos registrados\n 4) salir");
			opcion = int.Parse(Console.ReadLine());	


			

			switch (opcion) {
			case 1:

				Console.WriteLine ("cuantos alumnos registraras?");
				int alum = int.Parse (Console.ReadLine ());	

				for (int i=0; i<alum; i++) 
				{
					Persona p = new Persona ();
					Console.WriteLine ("Nombre: ");
					p.nombre = Console.ReadLine ();
					Console.WriteLine ("Codigo: ");
					p.codigo = Console.ReadLine ();
					tabla.Add (p.codigo, p.nombre);
				}
				bandera = true;
				break; 
			
			case 2:
				if (bandera == false)
					Console.WriteLine ("\t\"ERROR\" no existe ningun alumno");
				else{
								
						Console.WriteLine ("codigo de alumno a eliminar");
						string CodElim = Console.ReadLine ();
						if (tabla.Contains (CodElim)) {
							
							Console.WriteLine ("\n Alumno a eliminar: ");
							Console.WriteLine ("\n Codigo: " + CodElim);
							Console.WriteLine (" Nombre: " + tabla [CodElim].ToString ());
							Console.WriteLine (" Desea seguir elminando los datos \"s\" o \"n\"?");
							char answ2 = char.Parse (Console.ReadLine ());
							if (answ2 == 's') {
								tabla.Remove (CodElim);
								Console.WriteLine ("\n Alumno eliminado");
							
						} else
							Console.WriteLine ("\n NO existe el codigo que ingreso");
					} else
						Console.WriteLine ("\n Intentelo de nuevo mas tarde!!!");
				}
				break;
			case 3:
					if (bandera == false)
						Console.WriteLine ("\t\"ERROR\" no existe ningun alumno");
					else {
				
				Console.WriteLine ("\n Alumnos registrados: ");
				Console.WriteLine ("\n\t Codigo \t Nombre ");
				foreach (DictionaryEntry de in tabla)
					Console.WriteLine ("\t  {0}\t\t{1}", de.Key, de.Value);
				Console.WriteLine ();
					}
				break;

			case 4:
				Console.WriteLine ("Gracias por utilizar el programa!!!");
				break; 
			
				default:
					Console.WriteLine("\t\"ERROR\" opcion no valida!!!");
					break;
						}

				Console.ReadLine();
					}
				while(opcion !=4);

			Console.ReadKey (true);
				}

		}
	}