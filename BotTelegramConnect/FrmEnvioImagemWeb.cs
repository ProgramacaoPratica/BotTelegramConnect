using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemWeb : Form
    {
        public FrmEnvioImagemWeb()
        {
            InitializeComponent();
        }

        private async void btnEnviar_ClickAsync(object sender, EventArgs e)
        {
            if (txtUrlImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a URL da imagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                var telegramBot = new TelegramBotClient("TOKEN_DO_SEU_BOT");
                var imagemRequest = WebRequest.Create(txtUrlImagem.Text.Trim());

                using (var imagemResponse = imagemRequest.GetResponse())
                {
                    var stream = imagemResponse.GetResponseStream();
                    await telegramBot.SendPhotoAsync(chatId: "ID_DO_SEU_CHAT", photo: stream, caption: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
                }

                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Text = string.Empty;
                txtUrlImagem.Text = string.Empty;
            }
        }
    }
}
