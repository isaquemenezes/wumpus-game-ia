# wumpus-game-ia
## Mundo de Wumpus
<strong>� um exemplo do mundo simplificado,criado por Gregory Yob, 1973, para ilustrar o valor de um agente baseado em conhecimento e a 
representa��o do conhecimento</strong>
- � uma caverna formada por uma matriz 4x4, isto � 16 salas conectadas
- A caverna tem uma sala habitada por um monstro , o �Wumpus, que devora quem entrar na sala.
- Temos um �agente que avan�ar� neste mundo;
- H� salas ue cont�m �po�os, sem fundo, e se o agente cair neles, ficar� preso para sempre;
- O Wumpus pode ser morto pelo �agente, mas o agente possui uma �nica �flecha;
- Em uma das salas existe a possibilidade de o agente encontrar uma barra de �ouro;
- Objetivo do agente � encontrar o ouro e sair da caverna sem cair no poco ou ser comido por Wumpus;
- O agente receber� uma �recompensa se sair com ouro e receber� uma �penalidade se for comido por Wumpus ou cair no poco
- Nas casas adjacentes a do Wumpus tem �fedor
- Nas casas adjacentes ao do po�� tem �brisa
- O Wumpus pode ser morto pelo agente, se o agente estiver de frente para ele e atirar a flecha
- O Wumpus, ao ser atingido, emitir� um grito que ser� ouvido por toda a caverna.

## Ambiente:
- O agente come�a sempre na sala [1,1];
- A barra de ouro e do Wumpus sao posicionados aleatoriamente,exceto na posicao[1,1];
- Os po�os s�o posicionados aleatoriamente, exceto na posi��o [1,1], e nas salas da barra de ouro e do Wumpus

## Atuadores (do agente):
- Movimenta��o para norte, sul, leste, oeste;
- Pegar a barra de ouro
- Atirar a flecha
- # Observa��es: 
- As a��es jamais ocorrem na diagonal;
- As a��es impactam apenas uma �nica casa

## Sensores (do agente):
- Sentir 'fedor', se estiver em salas adjacentes ao Wumpus:
- Sentir 'brisa', se estiver em salas adjacentes aos pocos;
- Sentir 'impacto' ao bater em uma parede;
- Quando o Wumpus � atingido pela flecha, ele emite um 'grito' que � percebido em toda a caverna
- # Observa��o:
- As percep��es jamais ocorrem na diagonal

## Imagens 
<img src="./images/exemplificacao01.png">


### Desenvolver o jogo "Mundo de Wumpus" � uma �tima maneira de explorar conceitos fundamentais de intelig�ncia artificial, como busca em espa�os de estado, planejamento, tomada de decis�o e aprendizado. Aqui est�o algumas ideias de como voc� pode usar esses conceitos para resolver ou mensurar problemas da vida real:

<p> 1 - Planejamento de rotas: Use algoritmos de busca para encontrar a rota mais eficiente para um ve�culo aut�nomo se locomover em uma cidade. O agente pode evitar �reas congestionadas, ruas bloqueadas e outras condi��es adversas, similar � navega��o do jogador no labirinto do "Mundo de Wumpus".</p>

<p> 2 - Otimiza��o de cadeia de suprimentos: Aplique algoritmos de planejamento para otimizar a cadeia de suprimentos de uma empresa, minimizando os custos de transporte, tempo de entrega e armazenamento de mercadorias.</p>

<p> 3 - Controle de rob�s em ambientes perigosos: Desenvolva algoritmos de controle para orientar rob�s em ambientes perigosos, como locais de desastres naturais ou zonas contaminadas, garantindo que evitem obst�culos e perigos, assim como o jogador deve evitar o Wumpus no jogo.</p>

<p> 4 - Otimiza��o de recursos em redes de energia: Utilize t�cnicas de planejamento para otimizar a distribui��o de energia em uma rede el�trica, garantindo que a demanda seja atendida de forma eficiente e minimizando os custos operacionais.</p>

<p> 5 - Planejamento de tratamento m�dico: Desenvolva sistemas que ajudem os m�dicos a planejar tratamentos personalizados para pacientes, considerando fatores como hist�rico m�dico, condi��es atuais e melhores pr�ticas cl�nicas.</p>

<p> 6 - Design de jogos educativos: Al�m de desenvolver o "Mundo de Wumpus", voc� pode criar outros jogos educativos que ensinem conceitos importantes de intelig�ncia artificial, como aprendizado de m�quina, redes neurais e algoritmos de busca.</p>

<p> Essas s�o apenas algumas ideias para aplicar os conceitos aprendidos com o desenvolvimento do jogo "Mundo de Wumpus" em problemas da vida real. A intelig�ncia artificial tem uma ampla gama de aplica��es, e sua imagina��o � o �nico limite!</p>







