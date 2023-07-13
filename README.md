# $$\boxed{\sf Controle \space de \space Horas}$$

![Last Commit](https://img.shields.io/github/last-commit/F4NT0/Controle_Horas?color=orange)
![Language](https://img.shields.io/badge/Language-C%23-purple)
![Version](https://img.shields.io/badge/.NET%20versionn-6.0-blue)

---

### Definição do projeto

Programa de controle de horas trabalhadas, onde recebe o horário inicial de trabalho e apresenta o valor esperado de saída (completando 8 horas e 48 minutos por dia) e o valor máximo de trabalho para não ultrapassar 10 horas de trabalho por dia.

### Cálculos

---

#### $$\boxed{Saída \space Esperada}$$

Temos como entrada um horário em `horas:minutos` onde é feito os seguintes cálculos:

- Pegamos o tempo de intervalo por dia, sendo 1 hora de intervalo.
- Pegamos o tempo esperado de trabalho do dia, sendo 8 horas e 48 minutos.
- Somamos os valores para identificarmos o horário de saída esperado do dia

Exemplo: entrada as 7:51 (7 horas e 51 minutos da manhã)
$$(7:51+1:00)+8:48 = \color{lightblue}8\color{white}:\color{lightgreen}51 + \color{lightblue}8\color{white}:\color{lightgreen}48$$

Como 51 mais 48 são 99 minutos, deve ser subtraído 60 minutos porque 60 minutos são uma hora, restando somente o valor em minutos.

$$\color{lightgreen}51 \color{white}+ \color{lightgreen}48 = \color{lightgreen}99 \newline \color{white}99 - 60 = 39 \space minutos$$

Como pegamos 60 minutos, sendo uma hora, devemos somar mais um ao valor das horas.

$$\color{lightblue}8 \color{white}+ \color{lightblue}8 \color{white}+ \color{orange}1 \space \color{white} = 17 \space horas$$

O resultado:

$$8:51 + 8:48 = 17:39$$



---

#### $$\boxed{Saída \space Máxima}$$

Temos como entrada um horário em `horas:minutos` onde é feito os seguintes cálculos:

- Pegamos o tempo de intervalo por dia, sendo 1 hora de trabalho.
- pegamos o tempo máximo por dia, sendo de 10 horas no dia.
- somamos os valores para identificarmos o horário de saída máximo do dia.

Exemplo: entrada de 7:51 (7 horas e 51 minutos da manhã)

$$(7:51 + 1:00) + 10:00 = 8:51 + 10:00$$

A soma dos valores é mais simples, ficando o seguinte resultado:

$$8:51 + 10:00 = 18:51$$

Portando o tempo máximo de trabalho é até as `18:51`

---

### Programa

Para rodar o programa é simplesmente ativar o arquivo $\color{orange}run.bat$.

Este arquivo ativa um powershell e roda o comando `dotnet run` no projeto.

```bat
@echo off
cd ControleHoras
powershell -noexit -command "dotnet run"
```

#### $$\boxed{Códigos}$$

- Foram definidos os valores globais padrões do sistema, sendo eles o tempo de intervalo de uma hora, o tempo de trabalho padrão de cada dia e o tempo máximo de trabalho.

![variaveisglobais](https://github.com/F4NT0/Controle_Horas/assets/18719295/a3c862e6-b80a-452c-b832-7e9e846e9239)

- Criamos um sistema de recebimento de um valor de tempo e é feito a transformação desse valor de entrada para timestamp.

![entradavalor](https://github.com/F4NT0/Controle_Horas/assets/18719295/3aadf5fb-a1a1-4d8a-9ec6-40dbcdfc1b8e)

- Temos o cálculo de horas como foi explicado na parte do cálculo, mas como o tipo de dado é o Timestamp ele já faz esse cálculo automático.

![calculos de horas](https://github.com/F4NT0/Controle_Horas/assets/18719295/8bef513b-6f64-4009-94d0-09d08ebb3950)

- Para ficar bonito, criei um quadro unicode com o código para criar quadros com os valores e com informação com cores.

![quadro](https://github.com/F4NT0/Controle_Horas/assets/18719295/b78d32d0-2041-4878-bfe0-801d6efc489c)

- para colocar cores, foi usado os métodos do Console para colocar cores.

![Cores](https://github.com/F4NT0/Controle_Horas/assets/18719295/6dd291c2-57b3-4866-a740-0c4c8572062e)

- O resultado final no console é da seguinte forma:

<img alt="Resultado" src="https://github.com/F4NT0/Controle_Horas/assets/18719295/6372b130-923a-46ff-8ef0-99a69d56d8af">






