# Projeto de Estudos c#

## Visão Geral  
A opção de utilizar o vs code é para que as práticas de script seja mais flexiveis sem a utilização da criação de projetos .então a escolha foi para a utilização de arquivos simples cs para executar usando o code run 

## Tecnologias Utilizadas

- **c#:** 
- **.Net:** 

## Configuração

Para executar este projeto em sua máquina local, siga estas etapas:

1. Baixe o .Net sdk e o .Net runtime e após isso adicione a variável de ambiente no path referente ao caminho instalado o sdk
2. Baixe as extensões  c# DEv Kit e a c#
3. Para executar os arquivos cs precisa usar o code run caso a ide seja o vs code e adicionar  "code-runner.executorMap": {
    "csharp": "cd $dir && csc $fileName && $dir$fileNameWithoutExt"
}
 no settings.json 

