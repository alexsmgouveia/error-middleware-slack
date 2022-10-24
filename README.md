# error-middleware-slack

Comunicação de Falhas de API para um canal no Slack.

## Projeto
Projeto WebAPI
Net Core 3.1.

## Inicializando
1. Criar um [novo APP no Slack](https://api.slack.com/apps/) selecionar "From scratch" e definir o workspace <br>
![image](https://user-images.githubusercontent.com/35737565/197643723-786f71c7-77a3-4a2d-8fe4-323d0f8eb9bd.png)
2. Criar um webhook <br>
![image](https://user-images.githubusercontent.com/35737565/197640384-3036e6a0-ffa8-44b5-823e-9b7061333095.png)
3. Definir canal e copiar URL <br>
![image](https://user-images.githubusercontent.com/35737565/197640730-6cfd5090-be6f-4e09-a77e-917e297a1864.png)
4. Configurar no appsettings.json e rodar o projeto <br>
![image](https://user-images.githubusercontent.com/35737565/197640913-d7990df3-77e1-4e4f-a016-b2b041284cad.png)
5. O Endpoint [GET] /erro está preparado para tomar uma exceção <br>
![image](https://user-images.githubusercontent.com/35737565/197641161-0370aeb0-43c7-4ed6-83ad-add460b0a265.png)
6. O erro será notificado via Slack no canal que definido na etapa 3 <br>
![image](https://user-images.githubusercontent.com/35737565/197642983-edc31204-3eff-4b6a-8115-1a17e35a2929.png)
