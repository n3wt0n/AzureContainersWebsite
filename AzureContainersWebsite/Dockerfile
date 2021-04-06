FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
#COPY AzureContainersWebsite.csproj AzureContainersWebsite/
#RUN dotnet restore AzureContainersWebsite/AzureContainersWebsite.csproj
COPY . AzureContainersWebsite/
WORKDIR /src/AzureContainersWebsite
RUN dotnet build AzureContainersWebsite.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AzureContainersWebsite.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AzureContainersWebsite.dll"]
