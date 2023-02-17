PARA PROBARLO EJECUTAR LOS SIGUIENTES COMANDOS:
DESDE TERMINAL PUBLISHER: dapr run --app-id publisher --app-port 5007 --components-path ./components/ -- dotnet run
DESDE TERMINAL SUBSCRIBER:  dapr run --app-id subscriber --app-port 6007 --components-path ./components/ -- dotnet run
DESDE TERMINAL SUBSCRIBER1:  dapr run --app-id subscriber1 --app-port 7010 -- dotnet run


despues acceder a http://localhost:3501/swagger/
y mirar la terminal

NO OLVIDA TENER DOCKER ENCENDIDO Y EJECUTAR EL COMANDO (dapr init`)