# Exercise_Collections_Set
<p>Exercício de fixação sobre a estrutura de dados Set (HashSet e SortedSet) do .NET C#.</p>

## Problema exemplo:
<p>Um site de internet registra um log de acessos dos usuários. Um registro de log consiste no nome de usuário e o instante em que o usuário acessou o site no padrão ISO 8601, separados por espaço, conforme exemplo. Fazer um programa que leia o log de acessos a partir de um arquivo, e daí informe quantos usuários distintos acessaram o site.</p>

<p>Arquivo teste:</p>
![image](https://user-images.githubusercontent.com/80121288/171871078-1911d8b2-aefb-4bf4-937e-eb352b63dced.png)


<p>Exemplo de execução: </p>
![image](https://user-images.githubusercontent.com/80121288/171871114-1e359af6-b7cd-4875-8abf-c4e059d61920.png)

<p>Solução: </p>
<p>Utilizar conjuntos para armazenar os dados do log, pois garante que não haverá repetição. Utilizar HasSet ao invés de SortedSet, pois não há necessidade de ordenação e oferece maior performance.</p>
<p>O problema foi resolvido utilizando uma classe UserLog, responsável por abstrair os dados do log de um usuário. Para receber os dados do arquivo que contém os logs, foi utilizada uma HashSet do tipo UserLog na qual seus elementos foram adicionados ao percorrer as linhas do arquivo.</p>

<p>Código executado: </p>
![image](https://user-images.githubusercontent.com/80121288/171871158-1bfdde44-673c-4e47-91ec-1d7fd96eea39.png)
