namespace BotTelegramConnect
{
    public static class EmojiConfig
    {
        public static string Config(string strMensagem)
        {
            if (strMensagem.Contains(":white_check_mark:"))
                strMensagem = strMensagem.Replace(":white_check_mark:", char.ConvertFromUtf32(0x2705));
            if (strMensagem.Contains(":grin:"))
                strMensagem = strMensagem.Replace(":grin:", char.ConvertFromUtf32(0x1F601));

            return strMensagem;
        }
    }
}