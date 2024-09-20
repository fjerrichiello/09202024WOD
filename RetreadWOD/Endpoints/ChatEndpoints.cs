using RetreadWOD.Dtos;

namespace RetreadWOD.Endpoints;

public static class ChatEndpoints
{
    public static void MapBookEndpoints(this WebApplication app)
    {
        app.MapPost("/v1/chat", MessageBot);
    }

    public static Task MessageBot(HttpContext context, ChatRequestDto chatRequestDto)
    {
        
        throw new NotImplementedException();
    }
}