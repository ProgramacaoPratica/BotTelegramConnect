using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemLocal : Form
    {
        public FrmEnvioImagemLocal()
        {
            InitializeComponent();
        }

        private Stream ToStream(Image imagem, ImageFormat formato)
        {
            var stream = new MemoryStream();
            imagem.Save(stream, formato);
            stream.Position = 0;
            return stream;
        } 

        private void btnBscImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\Imagens\";
                ofd.Filter = "Imagens (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                    txtCaminhoImagem.Text = ofd.FileName;
            }
        }

        private async void btnEnviar_ClickAsync(object sender, EventArgs e)
        {
            if (txtCaminhoImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve selecionar a imagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new TelegramBotClient("TOKEN_DO_SEU_BOT");
                
                using (var imgEnvio = Image.FromFile(txtCaminhoImagem.Text.Trim()))
                {
                    var stream = ToStream(imgEnvio, ImageFormat.Jpeg);
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
                txtCaminhoImagem.Text = string.Empty;
            }
        }
    }
}
