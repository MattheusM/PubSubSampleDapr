PARA PROBARLO EJECUTAR LOS SIGUIENTES COMANDOS:
PARA PUBSUB CON AZURE SERVICE BUS TOPIC
DESDE TERMINAL PUBLISHER: dapr run --app-id publisher --app-port 5007 --resources-path ./components/ -- dotnet run
DESDE TERMINAL SUBSCRIBER:  dapr run --app-id subscriber --app-port 6007 --resources-path ./components/ -- dotnet run
DESDE TERMINAL SUBSCRIBER1:  dapr run --app-id subscriber1 --app-port 7010  --resources-path ./components/ -- dotnet run

PARA PUBSUB CON RABBITMQ
DESDE TERMINAL PUBLISHER: dapr run --app-id publisher --app-port 5007 --resources-path ./rabbitmqcomponents/ -- dotnet run
DESDE TERMINAL SUBSCRIBER:  dapr run --app-id subscriber --app-port 6007 --resources-path ./rabbitmqcomponents/ -- dotnet run
DESDE TERMINAL SUBSCRIBER1:  dapr run --app-id subscriber1 --app-port 7010  --resources-path ./rabbitmqcomponents/ -- dotnet run

despues acceder a http://localhost:5007/swagger/
y mirar la terminal

NO OLVIDA TENER DOCKER ENCENDIDO Y EJECUTAR EL COMANDO (dapr init`)
