# Sistema Funerario

## Status Do Projeto 

Em Desenvolvimento 

## Introdução

O sistema é voltado para o atendimento ao cliente de uma funerária, onde são registrados dados do falecido, como nome, gênero, idade, data de nascimento e data de falecimento. Essas informações são posteriormente utilizadas na lápide. O cliente também escolhe o tipo de madeira, cor e estilo do caixão, confirma as escolhas e pode adicionar uma frase personalizada para a lápide. O sistema solicita o local do falecido, o local e a data/hora do enterro, e, ao final, apresenta o valor total.

## Linguagem Utilizada

Todo o projeto foi desenvolvimento em C#

## Sobre o Código



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
