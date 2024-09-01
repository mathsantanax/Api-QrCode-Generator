
# QR Code API

Esta é uma API simples para gerar QR Codes usando ASP.NET Core e a biblioteca QRCoder.

## Visão Geral

A API fornece um endpoint para gerar QR Codes em formato PNG com base em um texto fornecido e um tamanho especificado.

## Endpoints

### Gerar QR Code em PNG

- **URL**: `/QrCodeGenerator/GerarComPNG/{texto}&{tamanho}/`
- **Método**: `GET`
- **Parâmetros**:
  - `texto` (string): O texto que será codificado no QR Code.
  - `tamanho` (int): O tamanho do QR Code gerado.
- **Resposta**: Uma imagem PNG contendo o QR Code.

## Como Baixar e Executar

1. **Clone o Repositório**: Clone este repositório em sua máquina local usando o comando:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   ```

2. **Navegue até o Diretório do Projeto**: 
   ```bash
   cd seu-repositorio
   ```

3. **Instale as Dependências**: Certifique-se de ter o .NET 6.0 SDK instalado. Caso a biblioteca QRCoder não esteja incluída no projeto, adicione-a usando o comando:
   ```bash
   dotnet add package QRCoder
   ```

4. **Compile e Execute a Aplicação**: Execute o seguinte comando para iniciar a aplicação:
   ```bash
   dotnet run
   ```

5. **Acesse o Swagger UI**: Para interagir com a API e testar os endpoints, abra o navegador e acesse:
   ```plaintext
   https://localhost:{porta}/swagger
   ```

## Estrutura do Projeto

- **Controllers/QrCodeGeneratorController.cs**: Contém a lógica para geração de QR Codes.
- **Program.cs**: Configurações principais da aplicação, incluindo serviços e middlewares.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para construção da API.
- **QRCoder**: Biblioteca utilizada para geração de QR Codes.
- **Swagger/OpenAPI**: Para documentação e testes da API.

## Licença

Este projeto é licenciado sob os termos da licença MIT.
