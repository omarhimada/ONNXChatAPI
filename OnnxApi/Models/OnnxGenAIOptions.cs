namespace OnnxChatApi.Options;

public sealed class OnnxGenAIOptions {
    public const string SectionName = "OnnxGenAI";

    public string ModelPath { get; set; } = "./models/phi";
    public string SystemMessage { get; set; } = "You are a helpful assistant.";
    public int MaxLength { get; set; } = 512;
    public double Temperature { get; set; } = 0.7;
    public double TopP { get; set; } = 0.9;
}