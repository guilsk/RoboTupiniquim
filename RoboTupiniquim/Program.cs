namespace RoboTupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            int[] grid = new int[2], posRobo1 = new int[2], posRobo2 = new int[2];
            char[] ch_grid, ch_posInicialRobo1, ch_instRobo1, ch_posInicialRobo2, ch_instRobo2;
            string str_grid, str_posInicialRobo1, str_instRobo1, str_posInicialRobo2, str_instRobo2;
            Console.WriteLine("Digite o tamanho do grid: ");
            str_grid = Console.ReadLine();
            ch_grid = str_grid.ToCharArray();
            grid[0] = (int)Char.GetNumericValue(ch_grid[0]);
            grid[1] = (int)Char.GetNumericValue(ch_grid[2]);

            Console.WriteLine("Digite a posição do Robo 1: ");
            str_posInicialRobo1 = Console.ReadLine();
            Console.WriteLine("Digite as instruções do Robo 1: ");
            str_instRobo1 = Console.ReadLine();
            Console.WriteLine("Digite a posição do Robo 2: ");
            str_posInicialRobo2 = Console.ReadLine();
            Console.WriteLine("Digite as instruções do Robo 2: ");
            str_instRobo2 = Console.ReadLine();

            ch_posInicialRobo1 = str_posInicialRobo1.ToCharArray();
            ch_instRobo1 = str_instRobo1.ToCharArray();
            ch_posInicialRobo2 = str_posInicialRobo2.ToCharArray();
            ch_instRobo2 = str_instRobo2.ToCharArray();

            //Converte posição em vetor int
            posRobo1[0] = (int)Char.GetNumericValue(ch_posInicialRobo1[0]);
            posRobo1[1] = (int)Char.GetNumericValue(ch_posInicialRobo1[2]);
            posRobo2[0] = (int)Char.GetNumericValue(ch_posInicialRobo2[0]);
            posRobo2[1] = (int)Char.GetNumericValue(ch_posInicialRobo2[2]);

            //Analisa instruções do Robo 1
            Console.WriteLine("\n\n\tRob01 começa a se mover!");
            for (int i = 0; i < str_instRobo1.Length; i++)
            {
                if (ch_instRobo1[i] == 'M')
                {
                    if (ch_posInicialRobo1[4] == 'N')
                    {
                        if (posRobo1[1] < grid[1])
                        {
                            posRobo1[1] += 1;
                            Console.WriteLine("Rob01 move!");
                        }
                        else
                        {
                            Console.WriteLine("Rob01 bateu na parede!");
                        }
                    }
                    else if (ch_posInicialRobo1[4] == 'L')
                    {
                        if (posRobo1[0] < grid[0]) 
                        { 
                            posRobo1[0] += 1;
                            Console.WriteLine("Rob01 move!");
                        }
                        else
                        {
                            Console.WriteLine("Rob01 bateu na parede!");
                        }
                    }
                    else if (ch_posInicialRobo1[4] == 'S')
                    {
                        if (posRobo1[1] > 0)
                        {
                            posRobo1[1] -= 1;
                            Console.WriteLine("Rob01 move!");
                        }
                        else
                        {
                            Console.WriteLine("Rob01 bateu na parede!");
                        }
                    }
                    else if (ch_posInicialRobo1[4] == 'O')
                    {
                        if (posRobo1[0] > 0) 
                        { 
                            posRobo1[0] -= 1;
                            Console.WriteLine("Rob01 move!");
                        }
                        else
                        {
                            Console.WriteLine("Rob01 bateu na parede!");
                        }
                    }
                }
                else if (ch_instRobo1[i] == 'D')
                {
                    if (ch_posInicialRobo1[4] == 'N')
                    {
                        ch_posInicialRobo1[4] = 'L';
                        Console.WriteLine("\nRob01 girando 90º a direita!");
                        Console.WriteLine($"Apontando para o Leste!");
                    }
                    else if (ch_posInicialRobo1[4] == 'L')
                    {
                        ch_posInicialRobo1[4] = 'S';
                        Console.WriteLine("\nRob01 girando 90º a direita!");
                        Console.WriteLine($"Apontando para o Sul!");
                    }
                    else if (ch_posInicialRobo1[4] == 'S')
                    {
                        ch_posInicialRobo1[4] = 'O';
                        Console.WriteLine("\nRob01 girando 90º a direita!");
                        Console.WriteLine($"Apontando para o Oeste!");
                    }
                    else if (ch_posInicialRobo1[4] == 'O')
                    {
                        ch_posInicialRobo1[4] = 'N';
                        Console.WriteLine("\nRob01 girando 90º a direita!");
                        Console.WriteLine($"Apontando para o Norte!");
                    }
                }
                else if (ch_instRobo1[i] == 'E')
                {
                    if (ch_posInicialRobo1[4] == 'N')
                    {
                        ch_posInicialRobo1[4] = 'O';
                        Console.WriteLine("\nRob01 girando 90º a esquerda!");
                        Console.WriteLine($"Apontando para o Oeste!");
                    }
                    else if (ch_posInicialRobo1[4] == 'L')
                    {
                        ch_posInicialRobo1[4] = 'N';
                        Console.WriteLine("\nRob01 girando 90º a esquerda!");
                        Console.WriteLine($"Apontando para o Norte!");
                    }
                    else if (ch_posInicialRobo1[4] == 'S')
                    {
                        ch_posInicialRobo1[4] = 'L';
                        Console.WriteLine("\nRob01 girando 90º a esquerda!");
                        Console.WriteLine($"Apontando para o Leste!");
                    }
                    else if (ch_posInicialRobo1[4] == 'O')
                    {
                        ch_posInicialRobo1[4] = 'S';
                        Console.WriteLine("\nRob01 girando 90º a esquerda!");
                        Console.WriteLine($"Apontando para o Sul!");
                    }
                }
                Console.WriteLine($"{posRobo1[0]} {posRobo1[1]} {ch_posInicialRobo1[4]}");
            }

            Console.WriteLine("\n\n\tRob02 começa a se mover!");
            for (int i = 0; i < str_instRobo2.Length; i++)
            {
                if (ch_instRobo2[i] == 'M')
                {
                    if (ch_posInicialRobo2[4] == 'N')
                    {
                        if (posRobo2[1] < grid[1])
                        {
                            posRobo2[1] += 1;
                            Console.WriteLine("Rob02 move!");
                        }
                        else
                        {
                            Console.WriteLine("Rob02 bateu na parede!");
                        }
                    }
                    else if (ch_posInicialRobo2[4] == 'L')
                    {
                        if (posRobo2[0] < grid[0]) 
                        {
                            posRobo2[0] += 1;
                            Console.WriteLine("Rob02 move!");
                        }
                        else
                        {
                            Console.WriteLine("Rob02 bateu na parede!");
                        }
                    }
                    else if (ch_posInicialRobo2[4] == 'S')
                    {
                        if (posRobo2[1] > 0)
                        {
                            posRobo2[1] -= 1;
                            Console.WriteLine("Rob02 move!");
                        }
                        else
                        {
                            Console.WriteLine("Rob02 bateu na parede!");
                        }
                    }
                    else if (ch_posInicialRobo2[4] == 'O')
                    {
                        if (posRobo2[0] > 0)
                        {
                            posRobo2[0] -= 1;
                            Console.WriteLine("Rob02 move!");
                        }
                        else
                        {
                            Console.WriteLine("Rob02 bateu na parede!");
                        }
                    }
                }
                else if (ch_instRobo2[i] == 'D')
                {
                    if (ch_posInicialRobo2[4] == 'N')
                    {
                        ch_posInicialRobo2[4] = 'L';
                        Console.WriteLine("\nRob02 girando 90º a direita!");
                        Console.WriteLine($"Apontando para o Leste!");
                    }
                    else if (ch_posInicialRobo2[4] == 'L')
                    {
                        ch_posInicialRobo2[4] = 'S';
                        Console.WriteLine("\nRob02 girando 90º a direita!");
                        Console.WriteLine($"Apontando para o Sul!");
                    }
                    else if (ch_posInicialRobo2[4] == 'S')
                    {
                        ch_posInicialRobo2[4] = 'O';
                        Console.WriteLine("\nRob02 girando 90º a direita!");
                        Console.WriteLine($"Apontando para o Oeste!");
                    }
                    else if (ch_posInicialRobo2[4] == 'O')
                    {
                        ch_posInicialRobo2[4] = 'N';
                        Console.WriteLine("\nRob02 girando 90º a direita!");
                        Console.WriteLine($"Apontando para o Norte!");
                    }
                }
                else if (ch_instRobo2[i] == 'E')
                {
                    if (ch_posInicialRobo2[4] == 'N')
                    {
                        ch_posInicialRobo2[4] = 'O';
                        Console.WriteLine("\nRob02 girando 90º a esquerda!");
                        Console.WriteLine($"Apontando para o Oeste!");
                    }
                    else if (ch_posInicialRobo2[4] == 'L')
                    {
                        ch_posInicialRobo2[4] = 'N';
                        Console.WriteLine("\nRob02 girando 90º a esquerda!");
                        Console.WriteLine($"Apontando para o Norte!");
                    }
                    else if (ch_posInicialRobo2[4] == 'S')
                    {
                        ch_posInicialRobo2[4] = 'L';
                        Console.WriteLine("\nRob02 girando 90º a esquerda!");
                        Console.WriteLine($"Apontando para o Leste!");
                    }
                    else if (ch_posInicialRobo2[4] == 'O')
                    {
                        ch_posInicialRobo2[4] = 'S';
                        Console.WriteLine("\nRob02 girando 90º a esquerda!");
                        Console.WriteLine($"Apontando para o Sul!");
                    }
                }
                Console.WriteLine($"{posRobo2[0]} {posRobo2[1]} {ch_posInicialRobo2[4]}");
            }
            
        }
    }
}