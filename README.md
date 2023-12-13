# Sistema Funerario

## Status Do Projeto 

Em Desenvolvimento 

## Introdução

O sistema é voltado para o atendimento ao cliente de uma funerária, onde são registrados dados do falecido, como nome, gênero, idade, data de nascimento e data de falecimento. Essas informações são posteriormente utilizadas na lápide. O cliente também escolhe o tipo de madeira, cor e estilo do caixão, confirma as escolhas e pode adicionar uma frase personalizada para a lápide. O sistema solicita o local do falecido, o local e a data/hora do enterro, e, ao final, apresenta o valor total.

## Linguagem Utilizada

Todo o projeto foi desenvolvimento em C#

## Sobre o Código

### Classe Abstrata: Corpo

A classe Corpo é declarado como classe abstrata por isso não pode ser instanciada diretamente,essa classe só serve como base para outras classes.

#### Atributos: 

nome(string) - e utilizado para armazenar o nome do defunto.

idade(Double) - e utilizado para armazenar a idade do defunto.

Dnasci(string) - e utilizado para armazenar a data de nascimento do defunto.

Dfaleci(string) - e utilizado para armazenar a data de falecimento do defunto.

gênero(string) - e utilizado para armazenar o gênero do defunto.

testo(string) - e utilizado para armazenar o texto que a pessoa vai querer colocar na lápide.

conf(string) - e utilizado para armazenar a confirmação de informação.

dia(string) - e utilizado para armazenar o dia tanto de Dnasci como também de Dfaleci.

mes(string) - e utilizado para armazenar o mês tanto de Dnasci como também de Dfaleci.

ano(string) - e utilizado para armazenar o ano tanto de Dnasci como também de Dfaleci.

#### Métodos:

laudo(abstract) - método abstrato que deve ser usado por classes derivadas,serve para mostrar as informaçoes do corpo para confirmação.

lapide(abstract) - metodo abstrato que deve ser utilizado por classes derivadas,serve para gerar um molde de como será a lápide.

lapidect(abstract) - método abstrato que deve ser ulilezado por classes derivadas,serve para gerar uma prévia dé como será a lápide com o texto escrito.

execucao1(abstract) - método abstrato que deve ser usado por classes derivadas,e um método utilizado para a execução da 1° parte do programa.

### Classe: Mulher (Herda de corpo)

A classe Mulher herda todos os atributos e métodos da classe abstrata corpo.

#### Métodos:

laudo(override) - Método sobrescrito da classe base corpo,ele serve para mostrar na tela todas as informações sobre o corpo para confirmação destes dados.

lapide(override) - método sobrescrito da classe base corpo,ele serve para mostrar na tela uma prévia de como irá ficar a lápide.

lapide(override) - método sobrescrito da classe base corpo,ele serve para mostrar na tela uma prévia de como irá ficar a lápide com o texto escrito pelo cliente.

execucao1(override) - método sobrescrito da classe base corpo,ele faz toda a execução da parte do programa relacionada a classe Mulher.

### Classe: Homem (Herda de corpo)

A classe Homem herda todos os atributos e métodos da classe abstrata corpo.

#### Métodos:

laudo(override) - Método sobrescrito da classe base corpo,ele serve para mostrar na tela todas as informações sobre o corpo para confirmação destes dados.

lapide(override) - método sobrescrito da classe base corpo,ele serve para mostrar na tela uma prévia de como irá ficar a lápide.

lapide(override) - método sobrescrito da classe base corpo,ele serve para mostrar na tela uma prévia de como irá ficar a lápide com o texto escrito pelo cliente.

execucao1(override) - método sobrescrito da classe base corpo,ele faz toda a execução da parte do programa relacionada a classe Homem.

### Classe: Caixao 

#### Atributos:

tmadeira(string) - e utilizado para armazenar o tipo de madeira escolhido pelo cliente.

vtmadeira(Double) - e utilizado para armazenar o valor do tipo de madeira escolhido pelo cliente.

estilo(string) - e utilizado para armazenar o estilo de caixão escolhido pelo cliente.

vestido(Double) - e utilizado para armazenar o valor do estilo de caixão escolhido pelo cliente.

cor(string) - e utilizado para armazenar a cor do caixão escolhido pelo cliente.

vcor(Double) - e utilizado para armazenar o valor da cor escolhida pelo cliente.

maquiagem(string) - e utilizado para armazenar a escolha do cliente no uso ou não de maquiagem no corpo.

vmaquiagem(Double) - e utilizado para armazenar o valor da maquiagem.

vlapide(Double) - e utilizado para armazenar o valor da lápide.

total(Double) - e utilizado para armazenar a soma de todos os valor que o cliente escolheu.

troco(Double) - e utilizado para armazenar o troco do cliente se necessário.

pagamento(Double) - e utilizado para armazenar o valor que o cliente estará pagando.

opcaoPagamento(Double) - e utilizado para armazenar a opção de pagamento escolhida pelo cliente.

teste(Double) - e utilizado para uma estrutura de reptiçao condicional de pagar.

opcao(string) - e utilizado para armazenar a escolha do cliente e é utilizado em uma estrutura de escolha em exercicio1.

conf(string) - e utilizado para armazenar a confirmação das informações.

#### Métodos:

execucao1() - e utilizado para executar toda a parte de escolhas com relação ao caixão.

execucao2() - e utilizado para executar toda a parte de escolha referente a maquiagem.

execucao3() - e utilizado para fazer a confirmação dos dados que o cliente tem a pagar.

coninf() - e utilizado para fazer a confirmação dos dados do caixão.

vapagar() - e utilizado para fazer o cálculo e guardar as informações dos valores que o cliente tem a pagar.

pagar() - e utilizado para exercitar toda a parte de pagamento do cliente.

### Classe: local

#### Atributos:

hospi(string) - e utilizado para armazenar o hospital onde está localizado o corpo.

lsepul(string) - e utilizado para armazenar o local onde será realizado o sepultamento.

data(string) - e utilizado para armazenar a data do sepultamento.

hora(string) - e utilizado para armazenar a hora do sepultamento.

#### Métodos:

inflocal() - e utilizado para executar toda a parte de local.

## Requisitos Funcionais 

Requisitos funcionais são especificações detalhadas das funcionalidades que um sistema ou software deve oferecer. Eles descrevem as ações específicas que o sistema deve executar em resposta a entradas específicas do usuário ou de outros sistemas. Esses requisitos definem o que o sistema deve fazer para atender às necessidades e expectativas dos usuários.

<table>
<tr>
<td>Número</td>
<td>Nome</td>
<td>Descrição</td>
</tr>
<tr>
<td>RF01</td>
<td>Cadastro de Pessoa</td>
<td> O sistema permite o cadastro de informações sobre uma pessoa falecida, incluindo nome, gênero, data de nascimento e data de falecimento</td>
</tr>
<tr>
<td>RF02</td>
<td>Escolha do Gênero</td>
<td>O usuário pode escolher o gênero da pessoa falecida (Masculino ou Feminino)</td>
</tr>
<tr>
<td>RF03</td>
<td>Escolha do Tipo de Caixão</td>
<td>O sistema oferece opções para o usuário escolher o tipo de madeira, estilo e cor do caixão</td>
</tr>
<tr>
<td>RF04</td>
<td>Escolha de Serviços Adicionais</td>
<td>O usuário pode optar por serviços adicionais, como maquiagem no defunto</td>
</tr>
<tr>
<td>RF05</td>
<td>Confirmação de Informações</td>
<td>O sistema exibe as informações inseridas e solicita confirmação do usuário</td>
</tr>
<tr>
<td>RF06</td>
<td>Geração de Recibo</td>
<td>Após a confirmação, o sistema gera um recibo com o resumo das escolhas e o valor total a ser pago</td>
</tr>
<tr>
<td>RF07</td>
<td>Escolha de Forma de Pagamento</td>
<td>O usuário pode escolher entre débito, crédito ou pagamento à vista</td>
</tr>
<tr>
<td>RF08</td>
<td>Processamento de Pagamento</td>
<td>O sistema processa o pagamento, calcula o troco (se aplicável) e confirma a transação</td>
</tr>
<tr>
<td>RF09</td>
<td>Registro Local</td>
<td>O sistema solicita informações sobre o hospital, local de sepultamento, data e hora do sepultamento</td>
</tr>
<tr>
<td>RF10</td>
<td>Geração de Documentos</td>
<td>O sistema gera documentos como laudo, lapide e informações do caixão</td>
</tr>
</table>

## Requisitos Não Funcionais

Requisitos não funcionais referem-se a características do sistema que não estão relacionadas diretamente às funcionalidades específicas, mas sim a atributos que impactam seu desempenho, usabilidade, segurança, entre outros. Exemplos incluem requisitos de desempenho, como tempo de resposta, requisitos de segurança, como controle de acesso, e requisitos de usabilidade, como a interface do usuário. Esses requisitos abordam aspectos globais do sistema, garantindo que ele atenda a critérios além das funcionalidades específicas.

<table>
<tr>
<td>Número</td>
<td>Nome</td>
<td>Descrição</td>
</tr>
<tr>
<td>RNF01</td>
<td>Interface de Console</td>
<td>O sistema utiliza uma interface de console para interação com o usuário</td>
</tr>
<tr>
<td>RNF02</td>
<td>Validação de Entrada</td>
<td>O sistema valida as entradas do usuário, garantindo que campos obrigatórios não fiquem vazios e que as escolhas sejam válidas</td>
</tr>
<tr>
<td>RNF03</td>
<td>Tratamento de Exceções</td>
<td>O código inclui tratamento de exceções para lidar com possíveis erros durante a execução</td>
</tr>
<tr>
<td>RNF04</td>
<td>Multiplataforma</td>
<td>O código pode ser executado em qualquer plataforma que suporte a execução de aplicativos .NET</td>
</tr>
<tr>
<td>RNF05</td>
<td>Eficiência</td>
<td>O código busca eficiência ao realizar cálculos e processos, como o cálculo do troco</td>
</tr>
</table>
