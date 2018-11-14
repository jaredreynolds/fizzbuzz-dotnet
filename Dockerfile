FROM microsoft/dotnet:2.1-runtime
WORKDIR /app

COPY dist/ ./
ENTRYPOINT ["dotnet", "fizzbuzz.dll"]
