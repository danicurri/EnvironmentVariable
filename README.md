# EnvironmentVariables

Aplicación de consola que crea una variable de entorno con un script .bat. El script se llama en un evento anterior a la compilación.
La llamada al script se hace en la sección Eventos de compilación de las propiedades del proyecto. En concreto en la "Línea de comandos anterior a la compilación".
La llamada es la siguiente: CALL $(ProjectDir)Scripts\CreateVariables.bat

Para leer la variable se usa Environment.GetEnvironmentVariable(nombreVariable, EnvironmentVariableTarget.User)