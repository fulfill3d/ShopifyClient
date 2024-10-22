
# ShopifyClient

ShopifyClient is a .NET library that integrates with Shopify's API using RestSharp. It provides support for managing Shopify resources such as products, orders, variants, webhooks, fulfillment, inventory, authorization, and more. The client is designed to handle retries and errors, making API communication more reliable.

## Table of Contents

1. [Introduction](#introduction)
2. [Features](#features)
3. [Tech Stack](#tech-stack)
4. [Usage](#usage)
5. [Configuration](#configuration)

## Introduction

ShopifyClient simplifies the communication with Shopify by providing various clients to interact with the Shopify API, covering products, orders, variants, fulfillment, inventory, authorization, and more. The library utilizes RestSharp for HTTP requests and includes retry mechanisms for handling errors such as conflicts or too many requests.

## Features

- **Product Client:** Manage Shopify products and product variants.
- **Order Client:** Handle Shopify orders and fulfillments.
- **Webhook Client:** Manage Shopify webhooks.
- **Fulfillment Client:** Manage Shopify fulfillment orders and requests.
- **Inventory Client:** Handle Shopify inventory items and levels.
- **Authorization Client:** Manage Shopify authorization and token exchange.
- **Retry Policies:** Automatically retries API requests when transient failures occur (e.g., Too Many Requests, Bad Gateway).
- **API Versioning Support:** Supports Shopify API versioning.

## Tech Stack

- **Backend:** .NET 8
- **HTTP Client:** RestSharp
- **Logging:** Microsoft.Extensions.Logging
- **Dependency Injection:** Used for service registrations and configurations

## Usage

1. **Register the ShopifyClient:** Use the provided extension methods such as `AddShopifyProductClient`, `AddShopifyOrderClient`, `AddShopifyWebhooksClient`, `AddShopifyFulfillmentServiceClient`, `AddShopifyInventoryItemClient`, and `AddShopifyAuthorizationClient` to register the necessary clients in the dependency injection container.
2. **Invoke Services:** Use the respective service clients (e.g., `IShopifyProductClientFactory`, `IShopifyOrderClientFactory`, `IShopifyFulfillmentOrderClientFactory`, `IShopifyInventoryItemClientFactory`) to interact with Shopify's API.

## Configuration

### RestSharp Configuration

- **Timeout:** 5-minute timeout for API requests.
- **Retry Count:** Automatically retries failed requests up to 2 times.

### Dependency Injection Example

Registering Shopify clients in the `Startup.cs` or `Program.cs`:

```csharp
services.AddShopifyProductClient();
services.AddShopifyOrderClient();
services.AddShopifyWebhooksClient();
services.AddShopifyFulfillmentServiceClient();
services.AddShopifyInventoryItemClient();
services.AddShopifyAuthorizationClient();
```

Example usage for creating a product in Shopify:

```csharp
var productClient = serviceProvider.GetRequiredService<IShopifyProductClientFactory>();
var product = new Product { Title = "New Product", BodyHtml = "<strong>Great product!</strong>" };
var response = await productClient.Create(product);

if (response.IsSuccessful)
{
    Console.WriteLine("Product created successfully");
}
else
{
    Console.WriteLine("Failed to create product");
}
```
