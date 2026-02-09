# Project 3: URL Shortener — Full Product

Build a complete, production-grade URL shortener. This is the "learn everything" project.

## Why This Project
A URL shortener is small enough to finish but touches almost every engineering concern: API design, databases, testing, security, observability, caching, deployment, and performance.

## Phases

### Phase A: Core API (Weeks 9-12)
- [ ] ASP.NET Core Web API with PostgreSQL
- [ ] Proper REST: status codes, RFC 7807 errors, cursor-based pagination
- [ ] OpenAPI spec (design-first)

### Phase B: Testing & Quality (Weeks 13-14)
- [ ] Unit + integration tests (WebApplicationFactory + Testcontainers)
- [ ] GitHub Actions CI pipeline

### Phase C: Production Hardening (Weeks 15-18)
- [ ] Rate limiting, JWT authentication, input validation
- [ ] Structured logging (Serilog), OpenTelemetry tracing
- [ ] Health checks, error handling
- [ ] Security audit (OWASP Top 10)

### Phase D: Deploy & Operate (Weeks 19-20)
- [ ] Docker Compose: API + PostgreSQL + Redis
- [ ] Deploy to Mac mini
- [ ] Monitoring dashboard
- [ ] Load test with k6, find and fix bottlenecks

> After completing each phase, run `/reflect` to capture a quick reflection.

## Learning Triggers

| Trigger | Concepts |
|---------|----------|
| "Why is PostgreSQL different from SQL Server?" | MVCC vs locking, isolation levels |
| "How should I handle concurrent short-code generation?" | Concurrency, race conditions, distributed IDs |
| "What happens under load?" | Connection pooling, caching, async I/O |
| "Is this secure?" | OWASP Top 10, CORS, CSRF, secrets management |
| "How do I know it's working in production?" | Observability, structured logging, tracing |

## Deep Dives to Write
- `deep-dives/database-internals.md`
- `deep-dives/security.md`
- `deep-dives/testing.md`
- `deep-dives/performance.md`
- `deep-dives/architecture.md`

## Reference
- *Designing Data-Intensive Applications* by Kleppmann
- *Unit Testing Principles* by Khorikov
- *Concurrency in C# Cookbook* by Cleary
- Stripe API docs (design reference)
