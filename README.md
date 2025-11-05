
## **Avaliação Prática: Implementação de um NPC Inteligente com Aprendizado de Máquina no UNITY**

**Tema:**
*Aprendizado de Máquina aplicado à Inteligência Artificial de Personagens Não Jogáveis (NPCs)*

**Descrição:**
Nesta avaliação, o(a) aluno(a) deverá criar uma **cena interativa no UNITY** que simule o comportamento adaptativo de um NPC utilizando conceitos de **aprendizado de máquina com redes neurais artificiais (RNA)**.

A cena será composta por dois personagens:

* 🐶 **Player (controlado pelo jogador):** um cachorro.
* 🐱 **NPC (controlado pela IA):** um gato.

**Objetivo da Simulação:**
O jogador controlará o cachorro com o teclado e deverá tentar encostar no gato.

* Cada vez que o cachorro **tocar no gato**, o jogador **perde uma vida**.
* O gato, inicialmente, **movimenta-se de forma aleatória**, mas, ao longo do tempo, **aprende os padrões de movimento do cachorro** e começa a **escapar com mais eficiência**.
* Esse aprendizado deverá ser realizado através de um **modelo de rede neural treinado**, capaz de **classificar e prever o comportamento do player**.

---

###  **Requisitos Técnicos:**

1. **Cenário UNITY:**

   * Ambiente simples (2D).
   * Inclusão de colisões, contadores de vidas e interface mínima.

2. **Player (Cachorro):**

   * Controlado pelo teclado (WASD ou setas).
   * Sistema de movimentação fluido e com detecção de colisão com o NPC.

3. **NPC (Gato):**

   * Movimento inicial aleatório.
   * Deve utilizar um modelo de aprendizado (rede neural) que, ao ser treinado com dados de movimento do player, aprenda a prever sua trajetória e **ajuste seu comportamento para fugir**.

4. **Aprendizado de Máquina:**

   * Pode ser implementado de forma simplificada (ex: treinamento supervisionado com dados simulados).
   * A rede deve identificar padrões (como direção, velocidade, distância média entre os personagens) e melhorar sua estratégia de fuga.

5. **Feedback Visual:**

   * Indicar quando o gato "aprendeu" (mudança perceptível no comportamento).

---

### **Critérios de Avaliação:**

| Critério                             | Descrição                                            | Peso |
| ------------------------------------ | ---------------------------------------------------- | ---- |
| **Funcionamento Básico**             | Cena funcional com player e NPC interativos.         | 2,0  |
| **Colisão e Sistema de Vidas**       | Implementação correta da perda de vida ao contato.   | 2,0  |
| **Comportamento Inteligente do NPC** | NPC ajusta sua movimentação com base no aprendizado. | 3,0  |
| **Uso de Rede Neural**               | Aplicação coerente de aprendizado de máquina.        | 2,0  |
| **Apresentação e Clareza do Código** | Organização, comentários e explicações do código.    | 1,0  |

**Total:** 10,0 pontos.

---

### 🧩 **Entrega:**

* Projeto UNITY apresentado no 
  * GitHUB
  * PlayUNITY

* Apresentação descrevendo:
  * A lógica do aprendizado utilizado.
  * Principais desafios.
  * Resultados observados após o treinamento.


