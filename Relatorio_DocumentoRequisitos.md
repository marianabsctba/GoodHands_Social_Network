<h1 align="center">
<a href="#" alt="link da rede"> RELATÓRIO, DOCUMENTO DE REQUISITOS E DIAGRAMAS </a>
</h1>

<h2 align="center">
      <a href="#" alt="link da rede"> GoodHands (Rede Social de doações/trocas)
</h2>

<h3 align="center">
    Doe, troque, contribua.
</h3>
      
      
      
<p align="center">
  <img src="goodhands.jpeg" alt="image" width="200"/>
</p>
      
      
      
      Link Azure, contendo as alterações requeridas pelo Feedback dos TP's 8 e 9: https://app-goodhands.azurewebsites.net/

  
## Histórico de revisão
|Data   | Versão  | Modificação  | Autor  |
|---|---|---|---|
| 17/05/2021  | 01 | Criação  | Mariana Buhrer Sukevicz  |
| 13/06/2021  | 02  | Complementação Requisitos de Usuário  |  Mariana Buhrer Sukevicz    |
| 13/06/2021  | 03  | Complementação Requisitos de Sistema     | Mariana Buhrer Sukevicz |
| 13/06/2021  | 04  | Complementação do Documento | Mariana Buhrer Sukevicz |
| 01/07/2021  | 05  | Inclusão de diagramas | Mariana Buhrer Sukevicz |
| 17/07/2021  | 06  | Retificações no documento e nos diagramas | Mariana Buhrer Sukevicz |
| 11/08/2021  | 07 | Início da implantação do projeto | Mariana Buhrer Sukevicz |
| 30/08/2021  | 08  | Tentativa de publicação de projeto parcial no Azure | Mariana Buhrer Sukevicz |
| 13/09/2021  | 09  | Entrega parcial de versão minimalista do projeto | Mariana Buhrer Sukevicz |
| 20/09/2021  | 09  | Correções requeridas nos TPs 8 e 9 - perfil | Mariana Buhrer Sukevicz |



*******
## Índice Analítico
* 1. [Good Hands](#1-good-hands)
* 1.1 [Propósito do documento](#11-propósito-do-documento)
* 1.2 [Escopo do Projeto](#12-escopo-do-projeto)
* 1.3 [Público-alvo](#13-público-alvo)
* 1.4 [Siglas e nomenclaturas](#14-siglas-e-nomenclaturas)

*******

* 2. [Requisitos de usuário](#2-requisitos-de-usuário)

 *******  
  
* 3. [Requisitos de sistema e casos de uso](#3-requisitos-de-sistema-e-casos-de-uso)
* 3.1 [Requisitos funcionais de sistema](#31-requisitos-funcionais-de-sistema)
* 3.2 [Requisitos não-funcionais de sistema](#32-requisitos-não-funcionais-de-sistema)
* 3.3 [Regras de negócio](#33-regras-de-negócio)

 *******
  
 * 4. [Matriz de rastreabilidade](#4-matriz-de-rastreabilidade)
 * 4.1 [RFS X RFS](#41-rfs-x-rfs)
 * 4.2 [RFS X RU](#42-rfs-x-ru)
 * 4.3 [RFS X RN](#43-rfs-x-rn)
 * 4.4 [RFS X RNFS](#44-rfs-x-rnfs)
  
*******
 * 5. [Diagramas](#5-diagramas)   
 * 5.1 [Diagrama de classes](#51-diagrama-de-classes)
 * 5.2 [Diagramas de componentes](#51-diagramas-de-componentes)
   
      
*******

 * 6. [Relatório - modelo Waterfall](#6-relatório-modelo-Waterfall)   

      
*******
      
 * 7. [Críticas](#7-críticas)   

      
*******
 * 8. [Referências](#-referências)
  
*******
*******

## 1. Good Hands

### 1.1 Propósito do documento
  
Por intermédio do presente, pretende-se traçar parâmetros gerais, descritivos e objetivos sobre as funcionalidades que baseiam o desenvolvimento da rede social, a fim de que se possa realizar planejamento prévio e execução adequada do projeto em todas as suas fases, sem olvidar de eventuais e futuras adequações quando possíveis e necessárias. Além disso, objetiva definir uso de ferramentas e tecnologias, a fim de que o que for aqui proposto com relação às funcionalidades contemple a versão final do projeto.  

---

### 1.2 Escopo do projeto
  
O projeto visa a criação e a implementação da rede social "Good Hands", a qual tem por escopo a arrecadação de doações e possibilitará a  permuta ("troca" de bens). A aplicação será realizada no modelo waterfall (cascata). Serão considerados como usuários pessoas físicas e jurídicas interessadas em doar ou trocar bens entre si. 

Os pilares da aplicação são, em suma, fomentar responsabilidade social, sustentabilidade e economia. Embora a redução do consumo seja a melhor saída para diversos tipos de problemas que enfrentamos na sociedade, a rede social objetiva aproximar pessoas que  têm interesse em receber uma doação ou em trocar produtos. Muitas vezes,  devido à insificiente conhecimento ou em virtude de omissões do poder público nesta seara, bens que poderiam ser reutilizados por outras pessoas são descartados em locais inadequados, como rios e terrenos abandonados, trazendo diversos transtornos para a coletividade, como poluição e proliferação de doenças. 

Assim, por intermédio da GoodHands será possível unificar doações e permutas de bens, atraindo interessados no tema, que podem ser pessoas físicas ou jurídicas. Tendo em vista o momento de crise atual, a rede social objetiva apoiar a comunidade (não visa o lucro). Os usuários poderão receber e enviar mensagens, postar conteúdos e mídias, organizar eventos, discutir pautas, cadastrar e pesquisar produtos para doação e  troca, entre outros. 

---

### 1.3 Público-alvo (stakeholders)
  
Este documento foi desenvolvido com foco no **desenvolvedor**, bem como nos **usuários** que utilizarão do sistema, pois explicitará quais requisitos deverão ser desenvolvidos bem como as interações entre os próprios requisitos, a fim de auxiliar em seu uso, manutenção e aprimoramento futuro. 
      
---

### 1.4 Siglas e Nomenclaturas
  
* **RU**: Requisitos de Usuário
* **RFS**: Requisitos Funcionais de Sistema
* **RNFS**: Requisitos Não-Funcionais de Sistema
* **RN**: Requisitos de Negócio
* **ID**: Identificador de requisito
* **PF**: Pessoa Física
* **PJ**: Pessoa Jurídica
* **CPF**: Cadastro de Pessoa Física
* **CNPJ**: Cadastro de Pessoa Jurídica
* **DDD**: Discagem Direta a Distância

---

## 2. Requisitos de usuário

  
| ID - Requisito de usuário | Descrição  |
|:-:|:-:|
|RU1 - Criar cadastro de usuário   |   O usuário poderá realizar o cadastramento na rede social, disponibilizando dados como CPF ou CNPJ, nome completo ou nome jurídico ou fantasia, endereço com CEP, telefone celular e e-mail, apenas para citar exemplos, haja vista se tratar de rede que possibilita o envio e recebimento de bens.  |
|RU2 - Criar login de usuário   |   O usuário deverá poder realizar a autenticação na rede social, utilizando-se de login (CPF ou CNPJ do usuário) e senha. Caso a senha seja extraviada, poderá ser realizada recuperação por mecanismo como e-mail cadastrado, por exemplo. |
|RU3 - Criar perfil de usuário  |O perfil deverá ser personalizável pelo usuário, no qual poderá conter informações básicas de identificação, como nome, foto ou logomarca, endereço, se é pessoa física ou jurídica e área de interesse na rede social (trocas, doações ou ambas).   |
|RU4 - Adicionar e remover amigos do usuário   |O perfil deverá conter campo para que o usuário possa criar rede de amigos, adicionando-os, removendo-os ou os bloqueando, bem como convidando pessoas ainda não cadastradas na rede.|
|RU5 - Cadastrar bens para doação ou permuta   | O cadastro de bens para doações ou permuta poderá ser realizado pelos próprios usuários. Deverá haver a opção de cadastramento para permuta ou para doação, em campo a ser escolhido no momento do preenchimento de breve formulário. Poderão ser anexadas fotografias ou mídias para mostrar os produtos.   |
|RU6 - Criar filtro para bens e usuários de interesse   | O cadastramento dos bens proporcionará que os interessados em determinado produto ou usuário possam pesquisá-los com o uso de palavra-chave e em campo próprio. |
|RU7 - Criar convites para eventos privados e públicos   |O espaço para organização de eventos tem como objetivo a comunicação estrita (eventos apenas para amigos) ou ampla (quando houver necessidade de maior divulgação) para os usuários da rede, no qual deverá conter campo para preenchimento do horário de início e fim do evento, endereço físico ou link para lives em ambientes externos, podendo-se estipular número  de participantes, por exemplo.   |
|RU8 - Criar e moderar grupos públicos ou privados   |A criação de grupos temáticos possibilitará o debate e a criação de redes de apoio na rede social. Poderão ser debatidos temas pertinentes às áreas de interesse da rede, como sustentabilidade, economia sustentável e assistência social. Os usuários poderão manifestar-se nos grupos, enviando ou recebendo mensagens. O usuário poderá moderar o grupo ou eleger moderador.   |
|RU9 - Enviar mensagens em grupos e perfis   |Usuários adicionados como amigos poderão comentar e classificar postagens, considerando o contexto da rede social. O usuário poderá optar por aceitar ou não a comunicação de outros cadastrados que não tenham sido adicionados como amigos em seu perfil.    |
|RU10 - Criar postagens em grupos e perfis   |O usuário poderá criar postagens em grupos e perfis, utilizando mídias, fotografias e links, por exemplo, os quais serão acessíveis, compartilhados, respondídos e comentados por toda a comunidade.   |
|RU11 - Criar convite de usuários cadastrados para grupos   |O usuário poderá convidar outros cadastrados que não são seus amigos para participar de grupos privados, a fim de abranger seu networking e divulgar ações, apenas para citar exemplo.    |
|RU12 - Criar campanha de arrecadação de recursos    |O usuário poderá iniciar campanhas de arrecadação públicas (com oferta para toda a comunidade) ou privadas (para grupo restrito que poderá ser criado), como crowdfundings ("vaquinhas"), preenchendo formulário no qual constará, por exemplo, o objetivo da arrecadação, a conta de depósito, o valor a ser alcançado, podendo fazer upload de documentos comprobatórios acessíveis pela comunidade. Após o prazo, o valor será disponibilizado na conta bancária apontada. Será necessário prestar contas à comunidade enviando documentos comprobatórios.   |
|RU13 - Criar e compartilhar formulários para solicitações    | O usuário poderá criar abaixo assinados a serem ratificados pela comunidade (caso haja interesse), preenchendo dados como objetivo, prazo, metas e destinação dos dados, podendo compartilhá-los em sua rede.   |
|RU14 - Criar procedimento de troca ou doação com usuários   |Ao encontrar o bem de interesse, o usuário poderá iniciar procedimento de troca ou doação a ser disponibilizado no perfil. O procedimento envolverá outros requisitos como "início", "cancelamento" e "fim" do processo de doação ou permuta. O campo deverá conter a possibilidade demonstrar interesse público no bem cadastrado, uma saudação para o usuário cadastrante e o prazo mínimo e máximo para envio ou retirada das doações ou trocas.
|RU15 - Criar classificação para doações e trocas   |A classificação é importante, pois é por meio dela que as transações de troca e de doação serão avaliadas (como números entre 0 a 10). Como exemplo, se um perfil tiver determinado número de avaliações de satisfação menores do que 6 (o equivalente a 60%), o perfil poderá sofrer penalidades. Poderão haver critérios adicionais para o cálculo da avaliação, como assiduidade na remessa do bem, estado do bem, entre outros.    |
|RU16- Criar formulário de prestação de contas   |O usuário deverá criar formulários para prestação de contas, disponibilizando-o até o período máximo a ser definido no momento da campanha de arrecadação de recursos. Caso não cumpra com a obrigação, poderá sofrer penalidades na rede. |

---

## 3. Requisitos de sistema e casos de uso
  
  
### 3.1 Requisitos funcionais de sistema

|   |   |
|:-:|:-:|
|**ID**   | RFS1  |
|**Requisito**   | Criar cadastro de usuário  |
|**Atores**   | Pessoa física ou jurídica  |
|**Pré-condição**   | Não ter cadastro/perfil na rede, ter e-mail e CPF/CNPJ. |
|**Fluxo Básico**  |- A pessoa acessa a interface para criar perfil na rede social <br /> - A pessoa preenche seu nome natural (pessoa física) ou nome jurídico (pessoa jurídica) <br /> - A pessoa informa um e-mail <br /> - A pessoa informa uma senha <br /> - A pessoa informa se é pessoa jurídica ou física (booleano) <br />  - A pessoa informa  sua data de nascimento (pessoa física) ou data de constituição (pessoa jurídica) <br /> - A pessoa informa um endereço <br /> - A pessoa preenche o documento de interesse. <br /> - A pessoa preenche nome de perfil <br /> - A pessoa preenche breve descrição no perfil <br /> - A pessoa faz upload de foto de perfil (avatar). <br /> - A pessoa executa funcionalidade que cria o perfil|
|**Pós-condição** |Um perfil é criado com os dados informados pela pessoa física ou jurídica com acesso às funcionalidades do sistema|
|**Fluxo alternativo**   |- A pessoa não informa um dos dados solicitados na interface de criação de perfil, mas executa a criação do perfil. Neste caso, a mensagem “O preenchimento do(a) campo {campo} é obrigatório”. O {campo} deve ser substituído pelo nome do campo não preenchido. Exemplo: “O preenchimento do campo nome é obrigatório” <br /> - A pessoa informa CPF/CNPJ ou e-mail já associado a algum perfil. Quando houver a tentativa de execução da criação do perfil, deve ser exibida a mensagem “O {campo} já está associado a um perfil”, onde "campo" poderá ser substituído por e-mail ou CPF/CNPJ. <br /> - A pessoa insere arquivo no avatar maior do que o permitido e recebe mensagem: "O avatar ultrapassou o limite permitido. Escolha outra fotografia e tente novamente." <br />
|**Dados** | - Nome: Texto, máximo de 150 caracteres. <br /> - Descrição: Texto, máximo de 300 caracteres. <br /> - Senha: 6 caracteres, sendo obrigatório incluir letras e números. <br />  - CPF/CNPJ: deverá ser preenchido apenas com números, sem caracteres especiais como pontos ou traços. <br /> - Data de nascimento ou da constituição da pessoa jurídica: Data válida. Para pessoas físicas, a idade mínima é de 18 anos, para as jurídicas não há restrição. <br /> - Endereço: Rua ou o equivalente, número, complemento, bairro, CEP, cidade  e estado. Todos os dados do tipo texto.  <br /> - Telefone celular: no formato (DDD) + número de celular  <br /> - Foto: avatar com no máximo 5MB. <br /> - Documento de interesse: a pessoa escolhe a opção em campo booleano de se gostaria de visualizar dados na rede relativos a doações, trocas(permutas) ou de ambos. |
|**Requisitos relacionados** | RFS2, RFS3, RFS4, RFS5, RFS6, RN1, RN2 |
     
---
  
|   |   |
|:-:|:-:|
|**ID**   | RFS2  |
|**Requisito**   | Criar login de usuário em conta já existente  |
|**Atores**   | Usuário cadastrado e sistema |
|**Pré-condições**   | O usuário deve estar cadastrado no sistema|
|**Fluxo Básico**  |- O usuário acessa a interface de autenticação <br /> - O usuário clica em "logar".<br />  - O usuário fornece seu CPF ou CNPJ para login. <br /> - O usuário fornece a sua senha.  <br /> - O usuário executa a funcionalidade que faz a autenticação. <br /> - O sistema autentica os dados fornecidos.  <br /> - O sistema reencaminha para a página de postagem. <br />  - O usuário receberá mensagem de boas-vindas após a autenticação. Exemplo: "{nomeDoUsuario}, bem-vindo(a) à Good Hands!|
|**Pós-condição** |O usuário deverá poder realizar ações em áreas restritas à pessoa não cadastrada ou à pessoa bloqueada do sistema |
|**Fluxo alternativo**   |- O usuário não informa um dos dados solicitados na interface de autenticação do perfil, mas executa a tentativa de autenticação. Neste caso, a mensagem "Login ou senha incorretos, tente novamente!" <br /> - O usuário realiza mais de 03 (três tentativas) de login mal sucedidas, quando o sistema o reencaminha para a interface de recuperação de senha. Nesta hipótese, o usuário poderá recuperar por meio sde instruções encaminhadas ao e-mail cadastrado. <br /> - O usuário está bloqueado do sistema por violação às regras da comunidade, mas executa a tentativa de autenticação. Nesta hipótese, em vez da mensagem de boas-vindas, o sistema emitirá mensagem de bloqueio, impossibilitando ações no sistema. Exemplo: "Infelizmente você violou regras da nossa comunidade. Perfil temporariamente bloqueado." |
|**Dados** | - Login: CPF ou CNPJ <br /> - Senha: a mesma senha registrada na criação do cadastro. <br />|
|**Requisitos relacionados** | RFS1, RFS3, RFS4, RFS5, RFS6 |
      
---
  
|   |   |
|:-:|:-:|
|**ID**   | RFS3 |
|**Requisito**   | Cadastrar bens para doação ou permutas  |
|**Atores**   |  Usuário logado e sistema  |
|**Pré-condição**   | O usuário deve estar logado e não bloqueado  |
|**Fluxo Básico**  |- O usuário acessará o link de acesso à interface de cadastro de bens para doação e permutas. <br /> - O usuário clica em "cadastrar bens para doação ou troca". <br /> - O usuário preencherá documento de descrição de bem <br />  - O usuário poderá inserir fotografias do bem.  <br /> - O usuário deverá confirmar se os dados e imagem  estão corretos. <br />  - O usuário poderá desistir do cadastro antes de finalizá-lo. Exemplo: botão "cancelar" <br /> - O usuário poderá executar o cadastro do bem. Exemplo: botão "concluir cadastro".|
|**Pós-condição** |O cadastro do bem é realizado e será listado e armazenado em banco de dados, podendo ser visualizado pelos demais usuários logados.  |
|**Fluxo alternativo**   |- A pessoa não informa um dos dados solicitados na interface de cadastro de bem e então executa o cadastro. Quando isso ocorrer, a mensagem “{campo} é obrigatório(a)”. {campo} deve ser substituído pelo nome do campo não preenchido. Exemplos: “Assinalar o campo {campo} é obrigatório(a)”, “Data de uso ou de compra do bem é obrigatória” <br />  - O usuário poderá editar os dados ou as fotos caso não confirme que os dados e imagem estão corretos.Exemplo: mensagem com "Os dados estão corretos? Sim/Não". No caso do "Não", o sistema retorna para a interface de edição dos dados do bem cadastrado. <br />  - O usuário poderá excluir o cadastro. Exemplo: disponibilidade de botão "deletar cadastro". Nesta hipótese, receberá a mensagem: "deseja mesmo excluir o cadastro? Caso opte por sim, receberá "Cadastro excluído com sucesso". Caso decida não excluir o cadastro o sistema retorna para a interface de edição. <br />  - O usuário insere dados inválidos e tenta cadastrar o bem. Neste caso, o sistema não realiza o cadastro e emite mensagem "Preenchimento do campo {campo} inválido", quando "campo" deve ser substituído pelo nome do campo não preenchido. Exemplo" Preenchimento do campo data inválido. <br /> - O usuário insere arquivo maior do que o permitido e recebe mensagem: "O arquivo ultrapassou o limite permitido. Escolha outro e tente novamente." <br />  |
|**Dados** | Documento de descrição de bem: trata-se de documento que contêm campos como descrição do bem (no máximo de 300 caracteres), bem como ao menos 02 (duas) opções booleanas para que se informe se o bem é "novo ou usado" e se refere à "permuta ou doação". Além disso, haverá necessidade de preenchimento da data de aquisição ou de uso do bem no formato "ddMMyy". <br /> - Arquivos (fotografias): No máximo 02 (duas), com no máximo 5MB cada. <br /> Data de uso ou de compra: Data válida. Todos os dados do tipo texto. <br /> - Os dados deverão poder ser salvos em estrutura de banco de dados e listados para todos os usuários.|
|**Requisitos relacionados** | RFS1, RFS2, RFS5, RFS6, RN1, RN2 |

---
  
|   |   |
|:-:|:-:|
|**ID**   | RFS4 |
|**Requisito**   | Criar postagens em grupos ou perfis |
|**Atores**   | Usuário logado e sistema|
|**Pré-condição**   | Usuário deve estar logado e não bloqueado no sistema |
|**Fluxo Básico**  |- O usuário acessa funcionalidade responsavél pela criação de postagens, que poderá estar em seu perfil ou em grupos criados pela comunidade. Exemplo: "criar postagem".  <br /> - O usuário seleciona "enviar arquivos". <br /> - O sistema mostra a janela de envio de arquivos. <br /> - O usuário escolhe o arquivo em sua galeria.  <br /> - O usuário clica em "fazer upload". <br />  - O sistema informa que o upload foi realizado com sucesso. Exemplo: "Tudo certo com o arquivo!" <br /> - O usuário prenche campo da descrição da postagem com conteúdo em texto.<br /> - O usuário deverá poder postar links externos de mídia de outras redes sociais. Exemplo: YouTube, Instagram, Twitter. <br /> - O usuário executa a funcionalidade de criar nova postagem. Exemplo: "postar".|
|**Pós-condição** |Uma postagem é criada com os dados e mídia inseridos pelo usuário  |
|**Fluxo alternativo**   |- O usuário dexa o campo de texto em branco. Quando isso ocorrer, a mensagem “O campo de texto é obrigatório(a)” e o sistema não submete a postagem. <br /> - Usuário seleciona um arquivo maior que o limite suportado. Neste caso, o sistema não carrega o arquivo e emite a mensagem "Arquivo fora dos padrões permitidos. Escolha outra e tente novamente". O sistema não submete a postagem e retorna para a interface de edição. |
|**Dados** | - Descrição: Texto, máximo de 300 caracteres. <br />  - Arquivo: 02 (dois), com o máximo de 5MB.|
|**Requisitos relacionados** |RFS1, RFS2, RFS5, RFS6, RN1, RN2 |

      
---

|   |   |
|:-:|:-:|
|**ID**   | RFS5|
|**Requisito**   | Iniciar procedimento de troca ou de doação com usuários  |
|**Atores**   | Usuário logado e sistema  |
|**Pré-condição**   | Usuário logado e não bloqueado|
|**Fluxo Básico**  |- O usuário acessa a interface contendo a lista de bens registrados para doação ou permuta ou acessa o resultado da pesquisa. Exemplo: clica no botão "visualizar lista de bens cadastrados". <br /> - O usuário acessa algum dos bens da lista. Exemplo: clica em "ver detalhes do bem". <br /> - O usuário poderá iniciar procedimento de transação. Exemplo: botão "iniciar transação". <br /> - O sistema redireciona o usuário à interface de transação. <br /> - O usuário preenche o documento de transação.  <br /> - O  usuário executa o início da transação. |
|**Pós-condição** |Uma transação é iniciada com um usuário cadastrante. |
|**Fluxo alternativo**   |- O usuário não informa um dos dados solicitados na interface de criação de procedimento de transação e então executa o início da transação. Quando isso ocorrer, a mensagem “{campo} é obrigatório(a)” é emitida, onde {campo} deve ser substituído pelo nome do campo não preenchido. Exemplos: “Saudação é obrigatória”, “Escolha por retirada ou envio do produto é obrigatória”  <br /> - O usuário informa o prazo incorretamente. Nesta hipótese, haverá a mensagem de que "O campo {campoPrazo} deverá ser preenchido em dias. Tente novamente!" |
|**Dados** | Documento de transação: é composto por saudação (texto, máximo de 200 caracteres), campo "Retirada ou Envio" (booleano onde o usuário opta por retirar o bem no endereço do  usuário cadastrante ou combinar o envio) e por prazo mínimo e máximo de interesse (computado em dias).|
|**Requisitos relacionados** | RFS1, RFS2, RFS3, RFS4, RFS6, RN1, RN2  |

---
      
|   |   |
|:-:|:-:|
|**ID**   | RFS6|
|**Requisito**   | Criar filtro para bens e usuários de interesse |
|**Atores**   | Usuário cadastrado, pessoa não cadastrada e sistema  |
|**Pré-condição**   | Usuário deve possuir acesso ao sistema|
|**Fluxo Básico**  |-  A pessoa deve acessar o site. <br /> - A pessoa deve buscar um bem por meio de uma palavra chave. <br /> - O usuário acessa a interface contendo o campo de pesquisa. <br /> - O usuário preenche a opção de pesquisa. <br /> - O usuário insere o texto no espaço da barra de busca. <br /> - O usuário deverá poder executar o início da pesquisa. Exemplo: aperta a tecla "enter" ou clica no botão "iniciar pesquisa". <br /> - O sistema retorna os bens e usuários relacionados a(s) palavras buscadas. |
|**Pós-condição** |Listar bens e usuários que se relacionam de alguma forma com a palavra chave buscada.  |
|**Fluxo alternativo**   |- O usuário deixa o campo de pesquisa em branco. Quando isso ocorrer, a mensagem “Preenchimento do campo {campo} é obrigatório(a)” é emitida, onde {campo} deve ser substituído pelo nome do campo não preenchido. Exemplos: “Preenchimento do campo pesquisa é obrigatório". <br /> - O sistema não retorna nenhuma pesquisa, quando será retornada mensagem "Desculpe! Nenhum post encontrado. Utilize outro termo e tente novamente!" |
|**Dados** | Termo de pesquisa: máximo de 200 caracteres do tipo texto. <br /> Opção de pesquisa: campo no qual o usuário pode optar por pesquisar itens para doação, itens para troca(permuta) informa se deseja pesquisar usuário (campo booleano). <br />|
|**Requisitos relacionados** | RFS1, RFS2, RFS3, RFS4, RFS5 |
---

      
### 3.2 Requisitos não-funcionais de sistema
      
|ID   |Descrição   |Uso   |Prioridade  |  
|---|---|---|---|
|RNFS1  |Interface simples| A interface do sistema deve ser intuitiva e atrativa. Exemplo: "criar post", "criar postagem", "iniciar pesquisa", "fazer login". Nos campos de ação devem ser usadas cores fortes. |Média| 
|RNFS2 |Impedir acesso aos usuários bloqueados| Os usuários cadastrados, mas eventualmente bloqueados não poderão acessar as funcionalidades destinadas aos usuários não bloqueados. Em vez de serem redirecionados ao sistema receberão mensagem "Infelizmente você violou regras da nossa comunidade. Perfil temporariamente bloqueado". | Alta  | 
      
---
      
### 3.3 Regras de negócio
      
| ID  |Descrição   | Uso  | Obrigatoriedade  | 
|---|---|---|---|
|  RN1 |O tamanho limite para upload de arquivos é 5MB   | GIF, PNG ou JPEG  | Obrigatório |  
|  RN2 |Campos de descrição devem ser preenchidos   | Texto  | Obrigatório  | 

---
  
## 4. Matriz de rastreabilidade

### 4.1 RFS X RFS
  
|   |RFS1  |RFS2   |RFS3   |RFS4   |RFS5   |RFS6   |
|---|---|---|---|---|---|---|
|RFS1   |   | X  |  X |  X |  X |  X |
|RFS2  |  X |   |  X |  X | X  |  X |
|RFS3   | X |  X |   |   |  X |  X |
|RFS4   | X  |  X |   |   |  X |  X |
|RFS5   | X  |  X |  X |   X|   |  X |
|RFS6   | X  |  X |  X |  X | X  |  |
 

---

### 4.2 RFS X RU
  
| ID  |RU1  |RU2   |RU3   |RU4   |RU5   |RU6   |RU7   |RU8   |RU9   |RU10   |RU11   |RU12   |RU13  |RU14   |RU15  |RU16   |
|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|---|
|RFS1  | X  |X   |  X | X  | X  | X  | X  | X  | X  | X  |  X | X  |  X |  X | X  |  X |
|RFS2   | X  |  X |  X |  X |  X |  X |X   |  X |  X | X  |  X |  X |  X |  X |  X | X  |
|RFS3   |   |   |   |   |  X | X  |   |   |   |   |   |   |   | X  |   |   |
|RFS4   |   |   |   |   |   |   |  X | X  |  X | X  |  X |   | X  | X  | X  | X  |
|RFS5   | X  |  X |  X | X  | X  | X  | X  | X  |  X |  X |  X | X  |  X |  X |X   | X  |
|RFS6   |  X |   |   |   |   | X  |   |   |   |   |   |   |   | X  |X |   |
  
---

### 4.3 RFS X RN
      
|   |RFS1  |RFS2   |RFS3   |RFS4   |RFS5   |RFS6   |
|---|---|---|---|---|---|---|
|RN1   | x  | X  |  X |  X |  X |  X |
|RN2  |  X |  x |  X |  X | X  |  X |


---

### 4.4 RFS X RNFS
      
|   |RFS1  |RFS2   |RFS3   |RFS4   |RFS5   |RFS6   |
|---|---|---|---|---|---|---|
|RNFS1   | x  | X  |  X |  X |  X |  X |
|RNFS2  |  X |  x |  X |  X | X  |   |

---
  
## 5. Diagramas
      
### 5.1 Diagrama de classes
A rede social Good Hands será baseada, a princípio, nas principais classes abaixo relacionadas, consoante regramento na Unified Modeling Language - UML  (as classes poderão sofrer alterações durante o deslinde do projeto, o que será devidamente certificado na pasta HELPERS, incluído neste repositório.
      
* *Member*: será o principal componente da rede social, já que cada membro (usuário cadastrado) possui perfil contendo dados como nome, CPF/CNPJ etc. Com base nisso, os membros poderão se conectar a outros membros ou a grupos. 
* *Search*: será possível realizar pesquisa no banco de dados por meio de interface, seja por membros, grupos ou postagens.
* *Message*: membros podem enviar mensagen de texto a outros membros, seja em postagens, grupos ou durante o procedimento de transação.
* *Post:* membros podem criar postagens contendo texto e foto, bem como curtir uma postagem de outro membro.
* *Comments*: membros podem adicionar comentários em postagens, grupos ou durante a transação.
* *Transaction*: membros poderão, quando houver interesse, iniciar transações de troca ou doações de bens com outros membros.
* *Group*: será possível criar e ingressar em grupos.
* *Invitation*: membros poderão convidar outros membros para serem amigos. 
* *RegisterProduct*: membros poderão registrar bens para troca ou doações com outros membros.
      
---      
 
### 5.2 Diagramas de componentes

Veja alguns diagramas de componentes, os quais se prestam a apenas parametrizar o funcionamento da futura aplicação, podendo, entretanto, sofrer alterações ao longo do projeto (ver pasta HELPERS). 
      
      
 ---    
 
# 6. Relatório - Modelo Waterfall 
      
      
* Etapa 1 – levantamento de requisitos
Foi realizado levantamento de requisitos básicos de rede social,porém,com base em expectativas do próprio aluno, algumas das quais infelizmente não poderão se concretizar no projeto final, pois ou exigiriam mais tempo, recursos e até mesmo um pouco mais de experiência, como o chat (desenvolvimento de RSignal  no Azure  etc), apenas para citar um exemplo. Assim sendo, o levantamento de requisitos deve ser, de fato, realizado com muito cuidado e dentro das possibilidades, tendo em vista que os projetos dessa natureza podem ser flexíveis e possuir extremas alterações, o que deve ser extremamente comum no ambiente profissional/empresarial, apenas para citar o que se acredita se tratar de exemplo prático. 
      
      
* Etapa2 – projeto
      
Com relação ao projeto, embora se tenha utilizado outros nomes de classes afora aquelas “planejadas” com base em expectativa, algumas das quais se tornaram mais propícias durante o desenvolvimento dos trabalhos. Ainda, houve mudanças em virtude do que foi relatado acima, na Etapa 1. Inicialmente, o projeto já foi  pensado com o uso de camadas que se assemelham ao DDD, tentando-se respeitar ao máximo o conceito da waterfall. 
Críticas: como a autora do projeto nunca tinha entrado em contato com a arquitetura em camadas, com conceitos de engenharia de software e muito menos com .NET, asp.net e c# foi um pouco complexo visualizar as limitações pessoais e de tempo que deveriam ter sido analisadas durante a elaboração do planejamento ou talvez, à  época, não tivesse dimensão sobre como funcionava uma arquitetura. Mais um aprendizado.
Etapa 3 – implementação

      
* Etapa 3 - implementação (codificação e design)
      
Durante a implementação foi, de fato, utilizado o modelo de camadas, com uma linearidade traçada por múltiplos exemplos, a fim de que se pudesse implementar a rede social temática, a fim de trazer planejamento e até mesmo “simplificar” o processo de gerenciamento de software, mas dentro de uma abordagem tradicional e sequencial de construção do software, a qual não se permite ser pulada, sob pena de não funcionar conforme o esperado. Aqui, foram sendo implementadas outras camadas, como apresentação, aplicação, domínio (entidades e interfaces), infraestrutura (dados e serviços) e, por fim, com a utilização da WebApi, bem como sendo desenvolvidas outras classes, a fim de que se pudesse caracterizar a rede social temática. 
É possível observar, assim, que todos os requisitos do modelo são necessários e não podem ser considerados perda de tempo. À época até me perguntei o porquê se deu tanta ênfase à documentação. Hoje eu percebo que era sim extremamente necessário pensar e refletir antes de agir, a fim de que o projeto seja estruturado, o que tinha total ligação com o design, arquitetura e, claro, como isso seria feito pensando em codifcação (c#, .NET, Asp.net e front-end variado). 

* Etapa 4 – Testes
      
A aplicação foi testada dentro das possibilidades e realizadas pequenas alterações, tendo a fase onde já se encontrava. Entretanto, algumas das falhas puderam ser diagnosticadas e alteradas para que se pudesse prosseguir de fase.  Em casos extremos, foi reaplicado o modelo em cascata por mais de uma vez para que se pudesse fazer alterações mais drásticas e obter melhor resultado. Nos teste, porém, a aplicação passou a apresentar problemas em virtude da falha na estrutura física e, portanto, espera-se melhorá-la até a "implementação final". 
      
* Etapa 5 – Manutenção
      
Futuramente, deseja-se melhorar drasticamente a rede para que, quem sabe, possa ter uma função efetiva na sociedade.     
                  
 ---           

## 7. Criticas

Em que pese seja um projeto muito simples, trouxe-se valiosos ensinamentos e lições. 

* Nem tudo o que se espera acontece. Isso pode ser frustrante, mas é um exemplo sobre como deve funcionar a vida profissional, especialmente quando se lida com equipes, gerencias e clientes. Há essa flexibilidade,mas considerando o conceito do waterfall, às vezes as alterações podem ser complexas. Porém, o modelo waterfall visa justamente o “PENSAR” antes de fazer – essa é uma lição valiosa para os aprendizes. Em verdade, a ordem lógica deveria ter sido requerimento — projeto — construção — integração — testes — implantação — manutenção.

      
* Todas as fases do projeto são igualmente importantes e tudo o que o modelo exige é, de fato, necessário, mas isso era um pouco mais difícil de enxergar no começo. 
O fato de cumprir projetos considerados extensos em pouco tempo pode ser uma desvantagem dentro desse modelo não suscetível a falhas. 
Como se mencionou, a dificuldade de enxergar algum resultado final. 
      
* A compreensão exagerada ou equivocada do próprio projeto pode ser ruim, especialmente quando vum futuro cliente, por exemplo, nada compreende sobre o modelo.
      
* Ausência de feeback contínuo, tendo em vista as premissas do próprio modelo.
 
* As fases precisam ser previamente pensadas – e bem pensadas – o que pode ser um problema em um mundo tão flexível, até porque, em regra, o modelo não permitiria falhas;
      
* O modelo pode não funcionar em virtude de sua má-implantação, o que foi visualizado no caso concreto, embora o projeto seja simples. 

* A dificuldade em ter mais produtividade com relação ao próprio projeto, já que era necessário cumprir uma fase para passar para a próxima. Ex.: model e interface (isso pode ser resolvido com migrations, às vezes, mas ainda assim pode se tornar um pouco trabalho se usado um scaffolding do Entity Framework, apenas para ilustrar, o que foi visualizado por algumas vezes. Em outras, até a própria inexperiência com relação ao estilo desse tipo de modelo pode fazer com que o projeto seja refeito. Ainda, outras questões como tempo, expectativas exageradas ou alterações com relação àquilo que havia sido planejado – até mesmo uma ideia nova – pode ser dificultada. Eu teria alterado a documentação certamente se tivesse tido essa experiência anteriormente. Por conta de todos esses pontos, provavelmente não conseguirei entregar os requisitos básicos, o que é um problema com relação ao conceito do modelo cascata.

**Mas há vantagens: o modelo visa o planejamento e à mitigação de falhas justamente por isso, distiguindo-se aí de uma metodologia ágil, só para fazer uma comparação. 



## 8. Referências

https://learning.oreilly.com/library/view/essentials-of-software/9781284106077/xhtml/33_Chapter17.xhtml
https://learning.oreilly.com/library/view/essentials-of-software/9781284106077/xhtml/16_Chapter07.xhtml
http://www.etsmtl.ca/Professeurs/claporte/documents/publications/Swice_Trip_Laporte_Pre_Publication-(1).pdf
https://www.oreilly.com/library/view/applying-uml-and/0131489062/
https://stock.adobe.com/br/images/community-hands-with-world-planet-earth/262901600?prev_url=detail (imagem com licença grátis)
