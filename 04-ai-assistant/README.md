# Project 4: AI Documentation Assistant

Build an AI-powered tool that indexes a codebase and answers questions about it.

## Why This Project
Combines everything you've learned (API, database, deployment, security) with AI/LLM fundamentals. Also a genuine product idea.

## Milestones

- [ ] **M1:** Index a repo — read files, chunk content, generate embeddings
- [ ] **M2:** Store embeddings in vector database (Qdrant or pgvector in PostgreSQL)
- [ ] **M3:** RAG query pipeline — embed question > retrieve chunks > LLM > answer
- [ ] **M4:** ASP.NET Core API backend + React frontend
- [ ] **M5:** Add function calling — LLM can search code, read files, query git history
- [ ] **M6:** Deploy to Mac mini

## Learning Triggers

| Trigger | Concepts |
|---------|----------|
| "What are embeddings and why do they enable semantic search?" | Vector math, similarity, embedding models |
| "How do I choose chunk size and overlap?" | RAG architecture, retrieval quality |
| "How do I control cost?" | Token counting, caching, model selection |
| "What about hallucination?" | Evaluation, grounding, prompt engineering |
| "How does function calling work?" | Tool use, structured output, agent patterns |

## Deep Dives to Write
- `deep-dives/ai-fundamentals.md` — embeddings, RAG, prompting, evaluation

## Reference
- Andrej Karpathy "Intro to LLMs" (YouTube)
- Simon Willison's blog
- Anthropic/OpenAI API docs
