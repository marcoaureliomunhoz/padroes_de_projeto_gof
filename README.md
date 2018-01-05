# Padrões de Projeto GOF (23)

Em Engenharia de Software, um padrão de projeto (design pattern) é uma solução geral para um problema que ocorre com frequência dentro de um determinado contexto no projeto de software. Um padrão de projeto não é um projeto finalizado que pode ser diretamente transformado em código fonte ou de máquina, ele é uma descrição ou modelo (template) de como resolver um problema que pode ser usado em muitas situações diferentes. Padrões são boas práticas formalizadas que o programador pode usar para resolver problemas comuns ao projetar uma aplicação ou sistema **e principalmente promover o fraco acoplamento e a reutilização de código**. Um padrão de projeto define: seu nome, o problema, quando aplicar esta solução e suas consequências.
  
- Classificação por Finalidade
    - **Padrões de Criação**: tratam da definição de classes criadoras de objetos com o objetivo de abstrair a complexidade da criação ou de adiar o processo de criação.
        - Singleton
        - Abstracty Factory
        - Factory Method
        - Builder
        - Prototype

**Singleton**  

> **Intenção**: garantir que uma classe tenha somente uma instância e forneça somente um ponto global de acesso para a mesma.  

Para isso devemos definir uma classe com o construtor privado, um atributo estático privado e somente leitura do mesmo tipo da classe para guardar a instância e um método estático público que retorna a única instância da classe.

<img src="img/singleton1.jpg">



--- 
**Fontes** 
- https://pt.wikipedia.org/wiki/Padr%C3%A3o_de_projeto_de_software
- https://brizeno.wordpress.com/category/padroes-de-projeto/
- https://www.youtube.com/watch?v=8vyfyPFhRUE (Giovanni Bassi)
- https://www.youtube.com/watch?v=gEGLVMY-ifA&list=PLc3ShgoNmIijcDnXTnQtdHAQMwn_t7aM1 (IFES - Colatina ES) 
- https://www.youtube.com/watch?v=iuavQrvKOO8&list=PLDm7BSK-M5YnGCOqOO9NEMEx4VHHOQZLY  