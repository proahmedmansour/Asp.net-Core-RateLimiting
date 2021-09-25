# Asp.net-Core-RateLimiting

When building web applications, you might often want to control the frequency of user requests to prevent malicious attacks. 
In other words, you might want to limit the number of requests coming from an IP address during a short timespan to mitigate 
denial-of-service attacks. This process is known as rate limiting.

This is an implementation of Rate-Limiting and throtting in Asp.net Core 5.

Steps to test: 
1. Build and run the application.
2. Use Swagger UI to consume any of existing Apis.
3. After the fourth consumtion u gotta a response with "API calls quota exceeded! maximum admitted 3 per 3m.".
