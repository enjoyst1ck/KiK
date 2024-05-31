using Newtonsoft.Json.Linq;
using System.Drawing.Imaging;
using System.Text;

namespace Llava
{
    public partial class Form1 : Form
    {
        private string conversationHistory = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWoP_Click(object sender, EventArgs e)
        {
            AskOllama();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            conversationHistory = "";
            textBoxAnswer.Text = "";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            AskOllama();
        }

        private void buttonLoadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    pictureBox1.Image = new Bitmap(fileName);
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (FileStream fs = new FileStream(fileName, FileMode.Open,
                       FileAccess.Read))
                        {
                            fs.CopyTo(memoryStream);
                        }
                        byte[] imageBytes = memoryStream.ToArray();
                        pictureBox1.Tag = Convert.ToBase64String(imageBytes);
                    }
                }
            }
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Image image = Clipboard.GetImage();
                pictureBox1.Image = image;
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Png);
                    byte[] imageBytes = ms.ToArray();
                    string base64Image = Convert.ToBase64String(imageBytes);
                    pictureBox1.Tag = base64Image;
                }
            }
        }

        private async void AskOllama()
        {
            textBoxAnswer.Text = "Czekaj na odpowiedü...";

            try
            {
                var client = new HttpClient();
                client.Timeout = TimeSpan.FromMinutes(10);
                using (client)
                {
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
                    {
                        model = "llava",
                        prompt = conversationHistory + "Co jest na obrazku?",
                        images = new JArray(pictureBox1.Tag)
                    });
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("http://localhost:11434/api/generate", content);
                    
                    if (!response.IsSuccessStatusCode) throw new Exception($"Error: {response.StatusCode}");

                    var responseBody = await response.Content.ReadAsStringAsync();
                    string textOfModelAnswer = string.Join(",", responseBody.Split("\n".ToCharArray()));
                    if (textOfModelAnswer.EndsWith(",")) textOfModelAnswer = textOfModelAnswer.Substring(0, textOfModelAnswer.Length - 1);
                    textOfModelAnswer = $"[{textOfModelAnswer}]";

                    JArray jsonResponse = JArray.Parse(textOfModelAnswer);
                    textOfModelAnswer = "";

                    for (int i = 0; i < jsonResponse.Count; ++i)
                        textOfModelAnswer += jsonResponse[i]["response"].ToString();
                    if (!string.IsNullOrEmpty(textOfModelAnswer))
                    {
                        textBoxAnswer.Text = "Co jest na obrazku?" + " \r\n\r\n";
                        textBoxAnswer.Text += textOfModelAnswer.Replace("\n", "\r\n").Trim();
                        conversationHistory += textBoxAnswer.Text + " \r\n\r\n";
                    }
                }
            }
            catch (Exception ex)
            {
                textBoxAnswer.Text = $"{ex.Message}";
            }
        }

    }
}
