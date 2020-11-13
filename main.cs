using System;

class MainClass {
  public static void Main (string[] args) {
		//1 dinamica
		string[] vehiculos = new string[4];
		vehiculos[0] = "barco";
		vehiculos[1] = "automóvil";
		vehiculos[2] = "avión";
		vehiculos[3] = "helicóptero";
		Console.WriteLine(vehiculos[0] + ", " + vehiculos[1]);
		Console.WriteLine(vehiculos[3]);

		//2 datos fijos
		double[] datos = {1,2,3,4,5.6,6.7,8.4};
		Console.WriteLine(datos[4]);
  
		//array implicito con datos fijos
		var nombre = new []{"Vernita", "Valentino", "Francisco"};
		Console.WriteLine(nombre[2]);

		//foreach no permite manipular datos del arrar, para ello se debe utilizar el for
		foreach(var n in nombre){
			Console.WriteLine(n);
		}
	
		//instancia del array de objetos
		Animales [] arrAnimales = new Animales[4];
    arrAnimales[0] = new Animales("perro", 4, "mamíferos");
    arrAnimales[1] = new Animales("loro", 2, "ave");
    arrAnimales[2] = new Animales("ballena", 0, "pez");
		arrAnimales[3] = new Animales("iguana", 4, "reptil");

		//recorrer array de objeto con for
    //for(int i = 0; i < arrAnimales.Length; i++){
    //  Console.WriteLine(arrAnimales[i].getAnimales());
    //}

		//recorrer array de objeto con foreach
    foreach(Animales e in arrAnimales){
      Console.WriteLine(e.getAnimales());
    }		

		//array anonimo
		var Colores = new []{
			new {Nombre = "Rojo", Codigo = 001},
			new {Nombre = "Blanco", Codigo = 002},
			new {Nombre = "Verde", Codigo = 003},
		};
			Console.WriteLine(Colores[1]);

			foreach(var c in Colores){
				Console.WriteLine(c);
			}
		
		//array valores dinámicos
     String [] paises = new String[2];
     paises[0] = "Perú";
     paises[1] = "Brasil";
     Console.WriteLine(paises[0] + "-" + paises[1]);
    
    //array valores fijos
    double [] cifras = new double[4];
    cifras[0] = 1;
    cifras[1] = 3.5;
    cifras[2] = 40;
    cifras[3] = 3.56;    
    Console.WriteLine(cifras[3]);

    //array anónimo
    var nombres = new []{
      new {Nombre = "Oscar", Edad = 40},
      new {Nombre = "Francisco", Edad = 2},
      new {Nombre = "Vernita", Edad = 6}
    };
    Console.WriteLine(nombres[2]);

    //array implícito
    var letras = new []{"A","B","C"};
    Console.WriteLine(letras[0]);

		//array implicito
    var arrImplicito = new[]{"Perú", "Brasil", "Mexico"};
    Console.WriteLine("Array implícito: " + arrImplicito[2]);

    //array de objeto con for 
    ObjetoFor[] arrObjetoFor = new ObjetoFor[3];
    arrObjetoFor[0] = new ObjetoFor("Perú", "Lima", 230);
    arrObjetoFor[1] = new ObjetoFor("Brasil", "Brasilia", 231);
    arrObjetoFor[2] = new ObjetoFor("Mexico", "Mexico", 232);
    for(int p = 0; p < arrObjetoFor.Length; p++){
      Console.WriteLine("Array de objeto con for: " + arrObjetoFor[p].getObjetoFor());
    }
    
    //array valores fijos
    string [] arrValorFijo = new string[]{"Perú", "Brasil", "Mexico"};
    Console.WriteLine("Array valores fijos: " + arrValorFijo[0] + ", " + arrValorFijo[1], ", " + arrValorFijo[2]);

    //array de objeto con foreach
    Automoviles[] arrAutomoviles = new Automoviles[2];
    arrAutomoviles[0] = new Automoviles("Bus", 4);
    arrAutomoviles[1] = new Automoviles("Tren", 80);
    foreach(var auto in arrAutomoviles){
      Console.WriteLine("Array de objeto con foreach: " + auto.getAutomoviles());
    }
    //array valores dinamicos
    string [] arrPaises = new string[3];
    arrPaises[0] = "Perú";
    arrPaises[1] = "Brasil";
    arrPaises[2] = "Mexico";
    Console.WriteLine("Array con valores dinámicos: " + arrPaises[0] + ", " + arrPaises[1] + ", " + arrPaises[2]);

    for(int ps = 0; ps < arrPaises.Length; ps++){
      Console.WriteLine("Array valores dinámicos con llamada for: " + arrPaises[ps]);
    }
    foreach(var pa in arrPaises){
      Console.WriteLine("Array valores dinámicos con llamada foreach: " + pa);
    }

  }

	//array de objetos
  class Animales{
    private string tipo;
    private int patas;
    private string especie;

  public string getAnimales(){
    return "Tipo: " + tipo + " Patas: " + patas + " Especie: " + especie;
  }

    public Animales(string tipo, int patas, string especie){
      this.tipo = tipo;
      this.patas = patas;
      this.especie = especie;
    }
  }

	  class ObjetoFor{
    private string pais;
    private string capital;
    private int codigo;

    public ObjetoFor(string pais, string capital, int codigo){
      this.pais = pais;
      this.capital = capital;
      this.codigo = codigo;
    }

    public string getObjetoFor(){
      return "País: " + pais + " Capital: " + capital + " Código: " + codigo;
    }
  }

  class Automoviles{
    private string tipo;
    private int ruedas;

    public Automoviles(string tipo, int ruedas){
      this.ruedas = ruedas;
      this.tipo = tipo;
    }

    public string getAutomoviles(){
      return "Tipo: " + tipo + " Ruedas: " + ruedas;
    }
  }
		
}