module.exports = {
    plugins: [
        "@semantic-release/commit-analyzer",
        [
            "semantic-release-dotnet",
            {
                paths: ["CrazyMouse/**.csproj"],
            }
        ],
    ],
};
