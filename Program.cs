string nome;
int numero1, numero2, total;

    Console.WriteLine("Seja bem-vindo a minha Calculadora de Porcentagem!");

//Comeco da calculadora - Pt 1 Apresentação.

            Console.Write("Me diga como gostaria de ser chamdo: ");
        nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(nome + ", nossa lógica fucionará de forma bem simples.\n\n " +
                    "O primeiro número será o valor cheio e em seguida Digite o valor da porcentagem que desejar!\n\n " + "Mais simples que isso só beber água, não é?");
            Console.ReadKey();
            Console.Clear();

//Fim da apresentação

    //Começo dos calculo de porcentagem - Armazenando informações providas do usuário:


            Console.Write("Chega de papo furado, vamos ao nosso cálculo. \n\n Digite agora o número que deseja ver a sua porcentagem: ");
        numero1 = int.Parse(Console.ReadLine());

            Console.Write("Bacana, agora me diga, deseja ver quantos por cento de "+numero1+"? ");
        numero2 = int.Parse(Console.ReadLine());
            Console.Clear();

        total = (numero1 * numero2) / 100;
            Console.Write("Boa, "+nome+", "+numero2+"% de "+numero1+" deu um total de: "+total);


            Console.ReadKey();

//Fim de nossa calculadora de Porcentagem em C#

// Considerações do Autor

Console.WriteLine("Obrigado por testar meu mini projeto, caso queira ver mais entre no perfil https://github.com/HidekiKoyama, \n\nestou iniciando agora neste mundo da programação. \n\n " +
    "Se quiser dar alguma dica de Lógica de programação ou até mesmo de linguagens, \n\neste é meu instagram: https://www.instagram.com/hideki_oficial/");
Console.ReadKey();


