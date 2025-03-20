# $${\color{#ffc1d5}Gerenciador\space de\space Tarefas}$$

## $${\color{#ffc1d5}O\space que\space foi\space utilizado?}$$

* Git Bash
* Vs Code
* Linguagem C#
* Chat Gpt

## $${\color{#ffc1d5}Etapas\space Implementadas:}$$

* Foi criado quatro arquivos individuais/metódos um para gerenciar tarefas, tarefas e layout.
* Gerenciar tarefas é responsável por armazenar as tarefas, dentro do programa esse código vai permitir que o usuário adicione as tarefas, liste as tarefas, concluir tarefas, remover tarefas, e a opção sair caso o usuário queira sair ou tenha terminado de adicionar as tarefas.
* Foi Declarado as propriedades(get; set;) da classe Tarefa para armazenar o ID, descrição e o status de conclusão da tarefa. Foi criada o método especial Tarefa(int id, string descricao) para inicializar os valores do ID e da descrição ao criar o objeto.
* Na aba Layout a classe formatação foi criada com métodos com as funções de alterar a cor da descrição exibida no código utilizando o método "Formatacao.Cor". Foi criado também um método para impressão de cabeçalho no caso o "public static void ImprimirCabecalho()"

## ${\color{#ffc1d5}{Backlog:}}$

* Tarefas administrativas
* Novas funcionalidades
* Melhores desempenhos 

## ${\color{#ffc1d5}{Conclusão:}}$
* É um gerenciador de tarefas que permite ao usuário adicionar,listar,concluir e remover tarefas.
* Caso o usuário for adicionar uma tarefa o programa vai dar a opção de salvar essa tarefa que ele adicionou e a tarefa vai aparecer automaticamente.
* Na hipótese do usuário escolher listar a tarefa o ID(Código da tarefa) vai ser colocado automaticamente pelo programa junto a descrição. 
* Se o usuário escolher concluir a tarefa ele vai precisar digitar o ID da função. 
* Para remover tarefa o usuário vai selecionar o ID da tarefa que ele deseja remover. 
* Quando o usuário escolher sair do programa ele so vai precisar selecionar a opção de sair.