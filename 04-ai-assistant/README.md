# Project 4: AI Documentation Assistant

Build an AI-powered tool that indexes a codebase and answers questions about it. Full C#/.NET 10 stack using Microsoft.Extensions.AI.

## Why This Project
Combines everything you've learned (API, database, deployment, security) with AI/LLM fundamentals. Also a genuine product idea. Uses the same stack as Projects 1-3 so every concept reinforces your professional skills.

## Tech Stack
- **Microsoft.Extensions.AI** — unified `IChatClient` and `IEmbeddingGenerator` abstractions (provider-agnostic)
- **Microsoft.Extensions.VectorData** — vector store abstractions
- **pgvector + EF Core** — vector storage in PostgreSQL (reuse from Project 3)
- **ASP.NET Core** — API backend
- **React** — frontend
- **OpenAI / Azure OpenAI / Ollama** — swap providers via `IChatClient` without code changes

## Milestones

- [ ] **M1:** Set up Microsoft.Extensions.AI with an LLM provider (OpenAI or Ollama for local dev)
- [ ] **M2:** Index a repo — read files, chunk content, generate embeddings via `IEmbeddingGenerator`
- [ ] **M3:** Store embeddings in PostgreSQL with pgvector (EF Core + pgvector-dotnet)
- [ ] **M4:** RAG query pipeline — embed question > vector similarity search > pass chunks to `IChatClient` > return answer
- [ ] **M5:** ASP.NET Core API backend + React frontend with streaming responses
- [ ] **M6:** Add function calling / tool use — LLM can search code, read files, query git history
- [ ] **M7:** Deploy to Mac mini

## Learning Triggers

| Trigger | Concepts |
|---------|----------|
| "What are embeddings and why do they enable semantic search?" | Vector math, cosine similarity, embedding models |
| "How do I choose chunk size and overlap?" | RAG architecture, retrieval quality, token limits |
| "What does `IChatClient` abstract over?" | Provider abstraction, dependency injection, middleware pipeline |
| "How do I control cost?" | Token counting, caching, model selection, prompt optimization |
| "What about hallucination?" | Evaluation, grounding, prompt engineering, retrieval quality |
| "How does function calling / tool use work?" | Tool definitions, structured output, agent patterns |
| "How is this different from Semantic Kernel?" | Microsoft.Extensions.AI vs Semantic Kernel vs Agent Framework — when to use each |

## Deep Dives to Write
- `deep-dives/ai-fundamentals.md` — embeddings, RAG, prompting, evaluation
- `deep-dives/architecture.md` — Microsoft.Extensions.AI abstraction design, provider pattern

## Reference
- [Microsoft.Extensions.AI docs](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai)
- [.NET AI ecosystem overview](https://learn.microsoft.com/en-us/dotnet/ai/dotnet-ai-ecosystem)
- [Build a .NET RAG app quickstart](https://learn.microsoft.com/en-us/dotnet/ai/quickstarts/build-vector-search-app)
- [pgvector-dotnet](https://github.com/pgvector/pgvector-dotnet) — pgvector with EF Core
- Andrej Karpathy "Intro to LLMs" (YouTube)
- Simon Willison's blog — practical LLM development
