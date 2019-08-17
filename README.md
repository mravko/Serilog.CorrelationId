# Serilog.CorrelationId

Asp.Net Core middleware that will check the incoming request for header X-Correlation-ID, and if it is present the value will be added to the Serilog log.

If the header value is not present in the incoming request, new GUID value will be created as correlation id, and that value will be added to the Serilog log. Also, the same value will be returned in the response as X-Correlation-ID.

Installation:
`dotnet add package DynamicLinqFilters.Extensions`
