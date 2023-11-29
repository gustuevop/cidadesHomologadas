using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
using verificadorDeCidadesHomologadas.APIConsumer;
using verificadorDeCidadesHomologadas.Modelo;
using verificadorDeCidadesHomologadas.Uteis;
using System.Collections.Generic;
using System.Drawing;

namespace verificadorDeCidadesHomologadas
{
    public partial class frm_main : Form
    {
        List<Cidade> cidadesHomologadas;
        List<string> nomesDeCidades;
        List<string> codigosIBGE;
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            verificaToken();
            preencheCombos();
            cidadesHomologadas = BuscaCidades();
            nomesDeCidades = BuscaNomes();
            codigosIBGE = BuscaCodigosIBGE();
        }

        private List<string> BuscaCodigosIBGE()
        {
            List<string> resultado = new List<string>();
            foreach (var cidade in cidadesHomologadas)
            {
                resultado.Add(cidade.id.ToString());
            }
            return resultado;
        }

        private List<string> BuscaNomes()
        {
            List<string> resultado = new List<string>();
            foreach (var cidade in cidadesHomologadas)
            {
                resultado.Add(cidade.nome);
            }
            return resultado;
        }

        void verificaToken()
        {
            if (string.IsNullOrEmpty(txt_Token.Text))
            {
                txt_Token.Text = ConfigManager.BuscarToken();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Token.Text))
            {
                ConfigManager.AdicionaOuAlteraToken(txt_Token.Text);
            }
        }
        private void btn_verificarPorNome_Click(object sender, EventArgs e)
        {
            lbl_resultadoText.Text = "";

            var nomeCidade = cb_cidade.SelectedItem.ToString();
            if (nomesDeCidades.Contains(nomeCidade))
            {
                lbl_resultadoText.Text = "Homologada!";
                lbl_resultadoText.ForeColor = Color.Green;
            } else
            {
                lbl_resultadoText.Text = "Não homologada!";
                lbl_resultadoText.ForeColor = Color.Red;
            }
        }
        private void btn_verificarPorIBGE_Click(object sender, EventArgs e)
        {
            txt_homologadas.Clear();
            txt_naoHomologadas.Clear();

            var listaIbges = new List<string>();
            foreach (var linha in txt_codigosIBGE.Lines)
            {
                listaIbges.Add(linha);
            }
            foreach (var codigo in listaIbges)
            {
                if (codigosIBGE.Contains(codigo))
                {
                    txt_homologadas.Text += codigo + "\r\n";
                }
                else
                {
                    txt_naoHomologadas.Text += codigo + "\r\n";
                }
            }
        }
        List<Cidade> BuscaCidades()
        {
            string response = PlugNotasConsumer.BuscaCidadesHomologadas();
            return JsonSerializer.Deserialize<List<Cidade>>(response);
        }
        void preencheCombos()
        {
            List<string> ufs = new List<string>
            {
            "AC","AL","AM","AP","BA","CE","DF","ES","GO","MA","MG","MS","MT","PA","PB","PE","PI","PR","RJ","RN","RO","RR","RS","SC","SE","SP","TO"
            };
            cb_uf.DataSource = ufs;
        }

        private void cb_uf_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencheComboCidades pc = new PreencheComboCidades();
            pc.preencheCombos(cb_uf, cb_cidade);
        }
    }
}
