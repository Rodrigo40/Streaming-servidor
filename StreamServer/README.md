# StreamServer

Servidor básico em ASP.NET Core para stream de áudio e vídeo.

## 🚀 Executar o projeto

1. Instale o [.NET 8 SDK](https://dotnet.microsoft.com/download)
2. No terminal, navegue até a pasta do projeto:
   ```bash
   cd StreamServer
   dotnet run
   ```
3. Acesse [http://localhost:5000](http://localhost:5000) no navegador.
4. Coloque seus arquivos de vídeo e áudio na pasta `Media` com os nomes:
   - `video.mp4`
   - `audio.mp3`

## 📂 Estrutura

```
StreamServer/
├── Media/           # Coloque seus arquivos aqui
├── Program.cs       # Código principal do servidor
├── StreamServer.csproj
└── README.md
```

Desenvolvido por Rafael Rodrigo | rafael@itprati.ao