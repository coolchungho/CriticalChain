FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 63755
EXPOSE 44398

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY CriticalChain/CriticalChain.csproj CriticalChain/
RUN dotnet restore CriticalChain/CriticalChain.csproj
COPY . .
WORKDIR /src/CriticalChain
RUN dotnet build CriticalChain.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish CriticalChain.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CriticalChain.dll"]
