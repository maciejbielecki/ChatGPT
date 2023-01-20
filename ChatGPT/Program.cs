// See https://aka.ms/new-console-template for more information

//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

Console.WriteLine("ChatGPT");

var chatGPT = new ChatGPT.ChatGPT("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");



//var obj1 = chatGPT.GetGtpModels().Result;
//var obj2 = chatGPT.Completions(new("text-davinci-003", "What is 2 + 2?", 0, 512)).Result;
//var obj3 = chatGPT.Edits(new("text-davinci-edit-001", "What day of th wek is it?", "Fix the spelling mistakes")).Result;
//var obj4 = chatGPT.ImageGeneration(new("A cute baby sea otter", 2)).Result;

//var bytes = File.ReadAllBytes("C:\\Users\\Maciej Bielecki\\Downloads\\icon.png");
//var obj5 = chatGPT.ImageEdits(new("A cute baby sea otter", bytes, bytes, 1)).Result;



//var obj = chatGPT.Completions(new("text-davinci-003", "Human: Show me 3 most efective programming languages.", 0, 512)).Result;
//Console.WriteLine(obj.Choices.First().Text);

var conversation = new List<string>()
{
};

Console.WriteLine(string.Join('\n', conversation));

while (true)
{
    if (conversation.Any())
    {
        var obj = chatGPT.Completions(new("text-davinci-003", string.Join('\n', conversation), 0, 512)).Result;
        var answer = obj.Choices.First().Text.Replace(string.Join('\n', conversation), string.Empty);
        Console.WriteLine($"{answer}");
        conversation.Add(answer);
    }

    Console.Write("Human: ");
    conversation.Add(Console.ReadLine());
}