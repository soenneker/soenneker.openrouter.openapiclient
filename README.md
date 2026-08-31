[![](https://img.shields.io/nuget/v/soenneker.openrouter.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openrouter.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openrouter.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.openrouter.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.openrouter.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openrouter.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openrouter.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.openrouter.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.OpenRouter.OpenApiClient

Typed request builders and models for calling OpenRouter's unified AI API from .NET.

## Installation

```bash
dotnet add package Soenneker.OpenRouter.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.OpenRouter.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new OpenRouterOpenApiClient(adapter);
var models = await client.Models.GetAsync(cancellationToken: cancellationToken);
```

The client defaults to `https://openrouter.ai/api/v1`. Its request builders cover models, chat completions, responses, embeddings, generation metadata, providers, credits, keys, and workspaces.

For configuration-based credentials and managed client reuse, use [`Soenneker.OpenRouter.OpenApiClientUtil`](https://github.com/soenneker/soenneker.openrouter.openapiclientutil).
