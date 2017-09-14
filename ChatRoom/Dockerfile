#基于microsoft/aspnetcore构建镜像
FROM microsoft/aspnetcore            

#拷贝项目websocket文件夹中的所有文件到docker容器中的websocket文件夹中 
COPY . /websocket           

#设置工作目录为websocket文件夹
WORKDIR /websocket      

#设置Docker容器对外暴露80端口
EXPOSE 80           

#使用dotnet ChatRoom.dll来运行应用程序
CMD ["dotnet", "ChatRoom.dll"]   