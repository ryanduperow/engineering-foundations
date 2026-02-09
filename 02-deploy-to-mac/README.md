# Project 2: Deploy to Your Mac Mini

Take your HTTP server (or a real ASP.NET Core app) and deploy it to your Mac mini as a real server.

## Why This Project
Real ops experience beats any tutorial. You'll SSH in, manage processes, containerize, configure DNS, and secure it with HTTPS. Every deployment decision at work will make more sense after this.

## Milestones

- [ ] **M1:** SSH into Mac mini, explore the OS (processes, file system, users)
- [ ] **M2:** Install .NET runtime, manually copy and run your app
- [ ] **M3:** Set up as a background service (launchd) that survives reboots
- [ ] **M4:** Dockerize the app, run via Docker on the Mac
- [ ] **M5:** Put Nginx or Caddy in front as reverse proxy
- [ ] **M6:** Get a domain, point DNS to your Mac, add HTTPS
- [ ] **M7:** Write a bash deploy script (build > copy > restart)

## Learning Triggers

| Trigger | Concepts |
|---------|----------|
| "What is SSH actually doing?" | Public key crypto, tunneling, agent forwarding |
| "Why can't I bind to port 80?" | Unix permissions, privileged ports |
| "What does Docker actually do under the hood?" | Namespaces, cgroups, images vs containers |
| "How does HTTPS work?" | TLS, certificates, certificate authorities |
| "How do I keep this running when I close my terminal?" | Process management, services, signals |

## Deep Dives to Write
- `deep-dives/os-fundamentals.md` — processes, memory, file systems
- `deep-dives/terminal-and-shell.md` — bash, SSH, scripting
- `deep-dives/deployment.md` — Docker, services, reverse proxies

## Reference
- *The Linux Command Line* by Shotts
- *Docker Deep Dive* by Poulton
- MIT Missing Semester
