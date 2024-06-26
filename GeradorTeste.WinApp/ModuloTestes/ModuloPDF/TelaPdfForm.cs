using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Drawing.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GeradorTeste.WinApp.ModuloTestes.ModuloPDF
{
    public partial class TelaPdfForm : Form
    {
        public TelaPdfForm()
        {
            InitializeComponent();
        }

        private Teste teste;

        public Teste Teste
        {
            get
            {
                return teste;
            }
            set
            {
               
                labelTitulo.Text = value.Titulo;
              labelDisciplina.Text = value.Disciplina.Nome;
               labelMateria.Text = value.Materia.NomeMateria + ", " + value.Materia.Serie;
               


                listQuestoes.Items.AddRange(value.Questoes.ToArray());
            }
        }

        private void btnGerarPdf_Click(object sender, EventArgs e)
        {
          Document pdf = new Document(iTextSharp.text.PageSize.A4, 20,20,20,20);
         PdfWriter pdfWriter = PdfWriter.GetInstance(pdf,new FileStream($"{txtNomeArquivo}.pdf", FileMode.Create));

           
            pdf.Open();
            var fonte = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 16, Font.Height, BaseColor.BLACK);
            var fonte1 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 16, Font.Height, BaseColor.BLACK);

            var para1 = new Paragraph(labelTitulo.Text, fonte);
            para1.Alignment = Element.ALIGN_CENTER;
            pdf.Add(para1);
            pdf.Add(new Paragraph(""));
            pdf.Add(new Paragraph(""));

            pdf.Add(new Paragraph(labelDisciplina.Text, fonte1));
            pdf.Add(new Paragraph(""));
            pdf.Add(new Paragraph(labelMateria.Text,fonte1));

            pdf.Add(new Paragraph(""));
            pdf.Add(new Paragraph(""));    
            pdf.Add(new Paragraph(listQuestoes.Text));


            pdf.Close();





        }
    }
}
