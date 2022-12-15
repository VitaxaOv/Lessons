// dotnet add package Telegram.Bot
using Telegram.Bot;
using Telegram.Bot.Types;

TelegramBotClient client = new TelegramBotClient("");

User bot = client.GetMeAsync().Result;
Console.WriteLine(bot.Username);

List<(long, string)> userIds = new List<(long, string)>();
long adminId = 0;

while (true)
{
    Update[] updates = await client.GetUpdatesAsync();
    for (int i = 0; i < updates.Length; i++)
    {
        long userId = updates[i].Message.From.Id;
        if (!userIds.Contains((userId, updates[i].Message.From.FirstName)))
        {
            userIds.Add((userId, updates[i].Message.From.FirstName));
        }

        Console.WriteLine(updates[i].Message.Text);
        if (updates[i].Message.From.Id == adminId)
        {
            if (updates[i].Message.Text.Contains("SEND_ALL", StringComparison.CurrentCultureIgnoreCase))
            {
                string[] partsOfMessage = updates[i].Message.Text.Split(" ");
                if (partsOfMessage.Length > 1)
                {
                    for (int j = 0; j < userIds.Count(); j++)
                    {
                        await client.SendTextMessageAsync(new ChatId(userIds[j].Item1), partsOfMessage[1]);
                    }
                }
            }

            if (updates[i].Message.Text.Contains("GET", StringComparison.CurrentCultureIgnoreCase))
            {
                await client.SendTextMessageAsync(new ChatId(adminId), string.Join(",", userIds));
            }

            if (updates[i].Message.Text.Contains("SEND_PERSONAL", StringComparison.CurrentCultureIgnoreCase))
            {
                string[] partsOfMessage = updates[i].Message.Text.Split(" ");
                if (partsOfMessage.Length > 2)
                {
                    bool isParsed = long.TryParse(partsOfMessage[1], out long id);
                    if (isParsed && Containts(id, userIds))
                    {
                        await client.SendTextMessageAsync(new ChatId(partsOfMessage[1]), partsOfMessage[2]);
                    }
                    else
                    {
                        await client.SendTextMessageAsync(new ChatId(adminId), "Отправляйте сообщение по шаблону SEND_PERSONAL id message");
                    }
                }
            }
        }

        if (adminId == 0 && updates[i].Message.Text == "3")
        {
            adminId = updates[i].Message.From.Id;
        }
        updates = client.GetUpdatesAsync(updates[^1].Id + 1).Result;
    }
}

bool Containts(long id, List<(long, string)> userIds)
{
    for (var i = 0; i < userIds.Count(); i++)
    {
        if (userIds[i].Item1 == id)
        {
            return true;
        }
    }

    return false;
}




