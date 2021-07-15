FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
RUN ls -la
COPY . .
RUN ls -la
Workdir proj
RUN ls -la
RUN chmod 777 .
RUN mkdir ./out
RUN ls -la
RUN dotnet restore 
RUN dotnet build --no-restore -c Release -o ./out

Workdir /out
RUN ls -la

FROM build AS publish
RUN mkdir ./release
Workdir .
RUN dotnet publish --no-restore -c Release -o ./release

Workdir ./release
RUN ls -la

EXPOSE 5000

ENTRYPOINT ["dotnet", "ali_k8s_img_test.dll"]