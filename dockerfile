FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
COPY . .
Workdir proj
RUN chmod 777 .
RUN mkdir ./build
RUN dotnet restore 
RUN dotnet build --no-restore -c Release -o ./build

RUN echo " ☆☆☆ build folder ☆☆☆ "
RUN ls -la ./build

FROM build AS publish
RUN mkdir ./publish
RUN dotnet restore 
RUN dotnet publish --no-restore -c Release -o ./publish

RUN echo " ☆☆☆ publish folder ☆☆☆ "
RUN ls -la ./publish

EXPOSE 30000

ENTRYPOINT ["dotnet", "./publish/ali_k8s_img_test.dll"]