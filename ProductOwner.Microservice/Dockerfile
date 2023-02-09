#извлечение образа
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build 
#установка каталога в качестве рабочего каталога в образе
WORKDIR /app 

EXPOSE 443
EXPOSE 80

# копирование локального файла в рабочий каталог образа
COPY ./*.csproj ./
#восстанавливает зависимости и средства проекта.
RUN dotnet restore 

# клонирование всего содержимого локального каталога в образ
COPY . .
#публикует приложение и его зависимости в папке для развертывания на размещающей системе
RUN dotnet publish -c Release -o out 
# Build runtime final image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
 # создание рабочего каталолга в образе
WORKDIR /app
# копирование всего содержимого из катлога образа build в катлог прилодения этого образа
COPY --from=build /app/out . 
# установка dotnet в качестве точки входа этого образа
ENTRYPOINT ["dotnet", "ProductOwner.Microservice.dll"]