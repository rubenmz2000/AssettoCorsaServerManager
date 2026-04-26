# Assetto Corsa Server Manager

Web-based management tool for Assetto Corsa Dedicated Server. Allows easy configuration of cars, tracks, and server settings through a local UI.

---

```
AssettoCorsaServerManager/
├── src/
│   ├── Shared/
│   │   └── AssettoManager.Core/        # Shared models and logic
│   ├── LocalApi/
│   │   └── AssettoManager.LocalApi/    # Local API — reads AC server data
│   ├── ServerApi/
│   │   └── AssettoManager.ServerApi/   # Server API — manages server config
│   └── Front/
│       └── assetto-manager-front/      # React frontend (Vite)
├── AssettoManager.sln
└── README.md
```

---

## Projects
### AssettoManager.Library
Shared class library used by both APIs. Contains models, interfaces, and shared business logic.

### AssettoManager.LocalApi
.NET Web API that reads the local Assetto Corsa installation. Exposes endpoints to list available cars, tracks, and read configuration files.

### AssettoManager.ServerApi
.NET Web API that manages the server configuration. Handles reading and writing `.ini` files. config files (`sercer_cfg.ini`, `entry_list.ini`, etc.).

### assetto-manager-front
React + Vite frontend. Communicates with both APIs to provide a UI for configuring and managing the server.

---

## Tech Stack
| Layer | Technology |
| --- | --- |
| Backend | .NET (C#) |
| Frontend | React + Vite |
| Config format | INI (Assetto corsa native) |

---

## Getting Started
> WIP