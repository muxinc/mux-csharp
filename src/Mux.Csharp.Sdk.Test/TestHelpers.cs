using System;

using Mux.Csharp.Sdk.Client;

internal static class TestHelpers {
    public static Configuration BuildApiConfiguration() {
        return new Configuration() {
            BasePath = "https://api.mux.com",
            Username = Environment.GetEnvironmentVariable("MUX_TOKEN_ID"),
            Password = Environment.GetEnvironmentVariable("MUX_TOKEN_SECRET")
        };
    }
}