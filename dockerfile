FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
COPY . .
Workdir proj
RUN chmod 777 .
RUN mkdir ./out
RUN dotnet restore 
RUN dotnet build --no-restore -c Release -o ./out

Workdir ./out
RUN ls -la

FROM build AS publish
COPY . .
Workdir proj
RUN ls -la
RUN chmod 777 .
RUN mkdir ./release
RUN ls -la
RUN dotnet restore 
RUN dotnet publish --no-restore -c Release -o ./release

Workdir ./release
RUN ls -la

EXPOSE 30000

ENTRYPOINT ["dotnet", "ali_k8s_img_test.dll", "--server.urls", "http://0.0.0.0:30000"]