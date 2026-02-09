# Project 4: AI Documentation Assistant

Build an AI-powered tool that indexes a codebase and answers questions about it. Full C#/.NET 10 stack using Microsoft.Extensions.AI, with a worker service handling the background indexing pipeline.

## Why This Project
Combines everything you've learned (API, database, deployment, security) with AI/LLM fundamentals and production-grade background processing. The indexing pipeline is a real use case for worker services — generating embeddings is expensive, rate-limited, and shouldn't block HTTP requests.

## Tech Stack
- **Microsoft.Extensions.AI** — unified `IChatClient` and `IEmbeddingGenerator` abstractions (provider-agnostic)
- **Microsoft.Extensions.VectorData** — vector store abstractions
- **pgvector + EF Core** — vector storage in PostgreSQL (reuse from Project 3)
- **ASP.NET Core** — API backend (chat queries)
- **.NET Worker Service** — background indexing pipeline (`BackgroundService` / `IHostedService`)
- **RabbitMQ** — message queue between API and worker
- **React** — frontend
- **OpenAI / Azure OpenAI / Ollama** — swap providers via `IChatClient` without code changes

## Phase A: Core RAG (Weeks 21-24)
Build the AI chat pipeline — query a codebase and get answers.

- [ ] **M1:** Set up Microsoft.Extensions.AI with an LLM provider (OpenAI or Ollama for local dev)
- [ ] **M2:** Index a repo — read files, chunk content, generate embeddings via `IEmbeddingGenerator`
- [ ] **M3:** Store embeddings in PostgreSQL with pgvector (EF Core + pgvector-dotnet)
- [ ] **M4:** RAG query pipeline — embed question > vector similarity search > pass chunks to `IChatClient` > return answer
- [ ] **M5:** ASP.NET Core API backend + React frontend with streaming responses
- [ ] **M6:** Add function calling / tool use — LLM can search code, read files, query git history

## Phase B: Background Indexing Pipeline (Weeks 25-27)
Move the indexing work into a worker service. This is where you go deep on background processing.

- [ ] **M7:** Create a worker service with `BackgroundService`. Understand `IHost`, `IHostedService`, and the hosting model lifecycle.
- [ ] **M8:** Move embedding generation from the API into the worker. API publishes "index this repo" jobs to RabbitMQ, worker consumes and processes them.
- [ ] **M9:** Add CRON-scheduled re-indexing — worker watches for new commits and queues re-indexing jobs automatically (Cronos or Quartz.NET). Compare to OS-level `crontab`.
- [ ] **M10:** Retry and failure handling — embedding API rate limits, dead letter queues, exponential backoff, poison message detection.

## Phase C: Production Hardening (Weeks 28-29)
- [ ] **M11:** Structured logging and health checks for both API and worker (queue depth, indexing progress, last successful run)
- [ ] **M12:** Graceful shutdown — handle `CancellationToken` properly so in-flight embedding jobs complete before the worker exits. Understand SIGTERM and Docker stop signals.
- [ ] **M13:** Cost controls — concurrency limits on embedding requests, token budget tracking

## Phase D: Deploy (Weeks 30-32)
- [ ] **M14:** Docker Compose — API + worker + RabbitMQ + PostgreSQL running together
- [ ] **M15:** Deploy to Mac mini as a multi-service system

## Learning Triggers

| Trigger | Concepts |
|---------|----------|
| "What are embeddings and why do they enable semantic search?" | Vector math, cosine similarity, embedding models |
| "How do I choose chunk size and overlap?" | RAG architecture, retrieval quality, token limits |
| "What does `IChatClient` abstract over?" | Provider abstraction, dependency injection, middleware pipeline |
| "What does `IHost` actually do when it starts?" | .NET generic host, service lifetime, DI scope per execution |
| "How is `BackgroundService` different from `IHostedService`?" | Abstraction layers, ExecuteAsync vs StartAsync/StopAsync |
| "When should I use a worker service vs CRON vs Azure Functions vs Hangfire?" | Architecture patterns, tradeoffs, cost, complexity |
| "What happens if the worker crashes mid-embedding?" | At-least-once delivery, idempotency, dead letter queues |
| "Why a message queue instead of just calling the embedding API from the web app?" | Decoupling, backpressure, rate limiting, reliability |
| "What does graceful shutdown actually mean?" | CancellationToken, SIGTERM, Docker stop signals |
| "How does function calling / tool use work?" | Tool definitions, structured output, agent patterns |

## Deep Dives to Write
- `deep-dives/ai-fundamentals.md` — embeddings, RAG, prompting, evaluation
- `deep-dives/background-processing.md` — worker services, hosting model, lifecycle, cancellation
- `deep-dives/message-queues.md` — queues vs polling, at-least-once, dead letters, backpressure
- `deep-dives/architecture.md` — Microsoft.Extensions.AI abstraction design, multi-service patterns

## Reference
- [Microsoft.Extensions.AI docs](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai)
- [.NET AI ecosystem overview](https://learn.microsoft.com/en-us/dotnet/ai/dotnet-ai-ecosystem)
- [Build a .NET RAG app quickstart](https://learn.microsoft.com/en-us/dotnet/ai/quickstarts/build-vector-search-app)
- [pgvector-dotnet](https://github.com/pgvector/pgvector-dotnet) — pgvector with EF Core
- [.NET Worker Service docs](https://learn.microsoft.com/en-us/dotnet/core/extensions/workers)
- [.NET Generic Host docs](https://learn.microsoft.com/en-us/dotnet/core/extensions/generic-host)
- [RabbitMQ .NET tutorial](https://www.rabbitmq.com/tutorials)
- *Designing Data-Intensive Applications* by Kleppmann — Ch 11 (Stream Processing)
- Andrej Karpathy "Intro to LLMs" (YouTube)
- Simon Willison's blog — practical LLM development
