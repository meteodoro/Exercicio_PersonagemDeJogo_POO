namespace ExerciciosPOO;

public class PersonagemDeJogo
{
    public int Id;
    public string Name;
    public string Classe;
    public double Vida;
    public double Forca;


    public PersonagemDeJogo(int id, string nome, string classe, double vida, double forca)
    {
        this.Id = id;
        this.Name = nome;
        this.Classe = classe;
        this.Vida = vida;
        this.Forca = forca;
    }

    public void Atacar()
    {
        Console.WriteLine("\nSelecione o tipo de ataque:");
        Console.WriteLine("1 - Soco");
        Console.WriteLine("2 - Chute");
        Console.WriteLine("3 - Especial");
        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Console.WriteLine("Você escolheu o tipo do ataque 1 - Soco");
            return;
        }
        else if (opcao == 2) 
        {
            Console.WriteLine("Você escolheu o tipo do ataque 2 - Chute");
            return;
        }
        else if (opcao == 3)
        {
            Console.WriteLine("Você escolheu o tipo do ataque 3 - Especial");
            return;
        }
        else { Console.WriteLine("Digite uma opção válida!"); }
    }

    public void ReceberDano()
    {
        Console.Write("\nDigite quanto dano o personagem vai receber: ");
        int dano = int.Parse(Console.ReadLine());
        this.Vida -= dano;
        Console.WriteLine($"Agora a vida de {this.Name} é {this.Vida}.");
        Console.ReadKey();
    }

    public void ExibirStatus()
    {
        Console.WriteLine("\n--- STATUS ---");
        Console.WriteLine("Personagem: " + this.Name);
        Console.WriteLine("Classe: " + this.Classe);
        Console.WriteLine("Vida atual: " + this.Vida);
        Console.WriteLine("Aperte qualquer tecla para continuar...");
    }
}