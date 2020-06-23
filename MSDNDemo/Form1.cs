using HtmlAgilityPack;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace MSDNDemo
{
    public partial class frmMSDNDemo : Form
    {
        public frmMSDNDemo()
        {
            InitializeComponent();

            btnAnterior.Enabled = false;
            btnProxima.Enabled = false;
        }

        int pageNumber = 1;

        // se a fonte de dados for um Webservice ou API, sempre optar por esses. Somente se não houver uma fonte padronizada, usar essa técnica
        private void btnAtualizaLista_Click(object sender, EventArgs e)
        {
            Processa(1, txtPesquisa.Text);
        }

        private void dgvMSDNDemo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) // coluna Link
            {
                Process.Start(new ProcessStartInfo(dgvMSDNDemo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageNumber++;
            Processa(pageNumber, txtPesquisa.Text);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            pageNumber--;

            if (pageNumber <= 0)
                pageNumber = 1;

            Processa(pageNumber, txtPesquisa.Text);
        }

        private void Processa(int pageNumber, string strPesquisa)
        {
            var wc = new WebClient();

            wc.Encoding = System.Text.Encoding.UTF8;

            string url = "https://social.msdn.microsoft.com/Forums/pt-BR/home?filter=alltypes&sort=firstpostdesc";

            if (strPesquisa.Trim().Length > 0)
            {
                url = url + "&searchTerm=" + strPesquisa;
            }

            if (pageNumber > 1)
            {
                url = url + "&page=" + pageNumber.ToString();
            }
   
            string pagina = wc.DownloadString(url);

            if (pagina.Contains("Nenhum resultado encontrado"))
            {
                MessageBox.Show("Pesquisa não retornou resultado.");
                return;
            }

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();

            htmlDocument.LoadHtml(pagina);

            dgvMSDNDemo.Rows.Clear();

            string id = string.Empty;
            string titulo = string.Empty;
            string postagem = string.Empty;
            string exibicao = string.Empty;
            string resposta = string.Empty;
            string link = string.Empty;

            try
            {
                foreach (HtmlNode node in htmlDocument.GetElementbyId("threadList").ChildNodes)
                {
                    if (node.Attributes.Count > 0)
                    {
                        id = node.Attributes["data-threadid"].Value;

                        link = "https://social.msdn.microsoft.com/Forums/pt-BR/" + id;

                        titulo = node.Descendants().First(x => x.Id.Equals("threadTitle_" + id)).InnerText;

                        postagem = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("lastpost")).InnerText.Replace("\n", "").Replace("  ", ""));

                        exibicao = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("viewcount")).InnerText);

                        resposta = WebUtility.HtmlDecode(node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("replycount")).InnerText);

                        if (!string.IsNullOrEmpty(titulo))
                        {
                            dgvMSDNDemo.Rows.Add(titulo, postagem, exibicao, resposta, link); // mesma ordem das colunas em tela
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Falha ao realizar a busca no site.");
                return;
            }

            btnAnterior.Enabled = pageNumber > 1;
            btnProxima.Enabled =  pageNumber > 0;

            label1.Text = "Página: " + pageNumber.ToString();
        }
    }
}
