// Calcular a média dos alunos e informar se foi aprovado, ficou em recuperação ou reprovado.
float nota1;
float nota2;
float nota3;
float media;

Console.WriteLine("Olá! Vamos descobrir se você foi aprovado, reprovado ou ficou de recuperação na nossa disciplina!");
Console.WriteLine("Digite a sua nota da primeira avaliação:");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua nota da segunda avaliação:");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua nota da terceira avaliação:");
nota3 = float.Parse(Console.ReadLine());
media = (nota1 + nota2 + nota3) / 3;
if (media >= 6){
    Console.WriteLine($"Parabéns! Você foi aprovado com média {media}!!");
}
else if(media < 6 && media >= 5){
    Console.WriteLine($"Poxa! Vi que você ficou em recuperação com média {media}!");
}
else {
    Console.WriteLine($"Infelizmente, você foi reprovado com média {media}, mas não desista! Estude!");
}