# Exercise_Collections_Set
<p>Exercício de fixação sobre a estrutura de dados Set (HashSet e SortedSet) do .NET C#.</p>

## Problema exemplo:
<p>Um site de internet registra um log de acessos dos usuários. Um registro de log consiste no nome de usuário e o instante em que o usuário acessou o site no padrão ISO 8601, separados por espaço, conforme exemplo. Fazer um programa que leia o log de acessos a partir de um arquivo, e daí informe quantos usuários distintos acessaram o site.</p>

<p>Arquivo teste:</p>
![image](https://user-images.githubusercontent.com/80121288/171869579-9e6fd9bc-f1e3-4fdd-869a-9c1819ea11da.png)

<p>Exemplo de execução: </p>
![image](https://user-images.githubusercontent.com/80121288/171869678-c495c884-a5df-4545-ba6b-dd968d206d2c.png)

<p>Solução: </p>
<p>Utilizar conjuntos para armazenar os dados do log, pois garante que não haverá repetição. Utilizar HasSet ao invés de SortedSet, pois não há necessidade de ordenação e oferece maior performance.</p>

<p>Código executado: </p>
![image](https://user-images.githubusercontent.com/80121288/171869905-05a7d611-8c98-4ec3-8959-e1fc15600971.png)
