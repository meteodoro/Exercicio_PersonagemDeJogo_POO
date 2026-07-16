namespace ExerciciosPOO;

class Program
{
    static void Main(string[] args)
    {
        bool gameover = false;
        PersonagemDeJogo p1 = new PersonagemDeJogo(1, "Kratos", "Deus da Guerra", 1000, 500);
        PersonagemDeJogo p2 = new PersonagemDeJogo(2, "Kitana", "Assassina", 500, 800);

        while (gameover == false)
        {
            Console.WriteLine("--- LUTA ---");
            Console.WriteLine("Selecione o personagem que irá atacar neste turno");
            Console.WriteLine($"1 - {p1.Name}");
            Console.WriteLine($"2 - {p2.Name}");
            Console.WriteLine($"3 - Mostrar status dos personagens");
            int p = int.Parse(Console.ReadLine());

            if (p == 1)
            {
                p1.Atacar();
                p2.ReceberDano();
                p2.ExibirStatus();
                if (p2.Vida <= 0)
                {
                    Console.WriteLine("GAME OVER");
                    gameover = true;
                    Console.ReadKey();
                    return;
                }
                Console.ReadKey();
                Console.Clear();

            }

            else if (p == 2)
            {
                p2.Atacar();
                p1.ReceberDano();
                p1.ExibirStatus();
                if (p1.Vida <= 0)
                {
                    Console.WriteLine("GAME OVER");
                    gameover = true;
                    Console.ReadKey();
                    return;
                }
                Console.ReadKey();
                Console.Clear();
            }

            else if (p == 3)
            {
                p1.ExibirStatus();
                p2.ExibirStatus();
                Console.ReadKey();
                Console.Clear();
            }

            else Console.WriteLine("Digite uma opção válida");
        }
    }
}