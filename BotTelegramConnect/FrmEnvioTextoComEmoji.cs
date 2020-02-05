using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioTextoComEmoji : Form
    {
        public FrmEnvioTextoComEmoji()
        {
            InitializeComponent();
        }

        private async void btnEnviar_ClickAsync(object sender, EventArgs e)
        {
            if (txtMensagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a mensagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new TelegramBotClient("TOKEN_DO_SEU_BOT");
                var strMensagem = txtMensagem.Text.Trim();

                strMensagem = EmojiConfig.Config(strMensagem);
                
                await telegramBot.SendTextMessageAsync(chatId: "ID_DO_SEU_CHAT", text: strMensagem, parseMode: ParseMode.Html);
                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Text = string.Empty;
            }
        }
    }
}
