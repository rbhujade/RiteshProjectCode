

using System.Text;
using System.Text.Json;

namespace JWT_Token_Deserialize
{
    class Program
    {
        public static void Main(string[] args) 
        {
            string authorization = "eyJraWQiOiJcL3ppUnNFSWpwOVwvbDdjNjRmS2tlV0FpblAyMFBoTkpZaG9TdXJzSmxOU0E9IiwiYWxnIjoiUlMyNTYifQ.eyJzdWIiOiI2NjgzM2NjNC00ZTkyLTQxNzUtYjFmOS1jM2FiNmRkYjI2MTkiLCJpc3MiOiJodHRwczpcL1wvY29nbml0by1pZHAuYXAtc291dGhlYXN0LTEuYW1hem9uYXdzLmNvbVwvYXAtc291dGhlYXN0LTFfM3lJMFpVMWFVIiwidmVyc2lvbiI6MiwiY2xpZW50X2lkIjoiM3VtdTZla2YwNTN0dm9kYzlyZGpxanVjZGwiLCJvcmlnaW5fanRpIjoiNTBjNDExMjMtNDM0Yi00MjdjLWJhMDEtYjQzZWI5MmYzZTVhIiwiZXZlbnRfaWQiOiJhYjA3NmZmOS05MzgzLTQ4YzgtYWM4MC0yYmNiNDg5OTAyNzMiLCJ0b2tlbl91c2UiOiJhY2Nlc3MiLCJzY29wZSI6ImF3cy5jb2duaXRvLnNpZ25pbi51c2VyLmFkbWluIHBob25lIG9wZW5pZCBwcm9maWxlIGVtYWlsIiwiYXV0aF90aW1lIjoxNzM4MTUwNDkwLCJleHAiOjE3MzgxNTc2OTAsImlhdCI6MTczODE1MDQ5MCwianRpIjoiNzY1ZGRmMjctMDY0Mi00YjY3LWI5ZWQtYjRlNDljNTZmMWU5IiwidXNlcm5hbWUiOiJiYzFiOTY2OS02YWU2LTRlZGItYjQ5My1hNWY0Njk2MDRmMTkifQ.VPPpe_rAPrwzmtN9lB5GA830BtRGRX1bu7qxpGLc50KhlgUmRjFOTqPdmEovGy86HQkjT2BZq5-d8ON3sZB3czQdrKzcG_ieCIA4yJy0sL97bg2MUmhAJFO4rRFdS8_gzMtzFJEGeX94pd97NjLO52sbv5sedIE7GFYDrtrFRPYMo2oohYRmM_t9rQ9KCWg1rcGbD9bUo0ATLIizqSOnJ09CrZywy5CTbjNikksH8nkiLAGZRHyVk0shPuhJJQMGn4v1_0TnlGOh9bFewgjQpDDGe29Rv5VFQ21ak3R8_KxbgFAvGtlQ5ASYVxH4SBPZrcYFnt_t14cxwKqZ9T0P1Q";

            string[] token = authorization.Split(".");

            if (token.Length != 3) 
            {
                Console.WriteLine("Invalid token.");
            }

            string payload = token[1];
            
            //var padded = payload.PadRight(payload.Length + (payload.Length * 3) % 4, '=');

            payload = payload.PadRight(payload.Length + (4- payload.Length % 4) % 4,'=');

            string payloadJson = Encoding.UTF8.GetString(Convert.FromBase64String(payload));

            var payloadDes = JsonSerializer.Deserialize<JsonElement>(payloadJson);

            string? userName = payloadDes.GetProperty("username").GetString();

            Console.WriteLine($"User Name : {userName}");

            Console.ReadLine();

        }
    }
}
