# API Gateway Demo

This repository demonstrates an **API Gateway** that provides:
- ✅ **Routing** (Forwarding requests to microservices)
- ✅ **Authentication & Authorization** (JWT-based security)
- ✅ **Rate Limiting** (Preventing abuse)

## 🚀 **Projects Overview**
This repository contains **3 projects**:
1. **ApiGateway/** → Manages authentication, authorization, routing, and rate limiting.
2. **TradeService/** → Provides trade-related data.
3. **BookService/** → Provides book-related data.

## 🛠 **Tech Stack**
- **.NET 8**
- **Proxy Controller** (For API Gateway Routing)
- **AspNetCoreRateLimit** (For Rate Limiting)
- **JWT Authentication** (For Secure Access)

## How to run
- Start the 3 projects
- Authenticate your swagger for api gateway project using bearer jwt-token(this you can get from the top api in swagger)
- Try doing multiple requests to books/trades, it will rate limit
- Doing request to book or trade will redirect to appropreate microservice
