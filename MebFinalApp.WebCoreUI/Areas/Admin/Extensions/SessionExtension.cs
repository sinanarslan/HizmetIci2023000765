using Newtonsoft.Json;

namespace MebFinalApp.WebCoreUI.Areas.Admin.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            string json = JsonConvert.SerializeObject(value);

            session.SetString(key, json);

        }
        public static T GetObject<T>(this ISession session, string key)
            where T : class
        {
            string json = session.GetString(key);

            if (string.IsNullOrEmpty(json))
            {
                return null;
            }
         


           return  JsonConvert.DeserializeObject<T>(json);

        }

    }
}
