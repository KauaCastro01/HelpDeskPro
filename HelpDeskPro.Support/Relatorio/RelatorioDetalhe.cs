using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskPro.Support.Relatorio
{
    using System;
    using System.IO;
    using iTextSharp.text;
    using iTextSharp.text.pdf;

    namespace HelpDeskPro.Relatorios
    {
        public class RelatorioDetalhe
        {
            public void GerarPDF(
                string titulo,
                string descricao,
                string abertura,
                string resolvido,
                string abertoPor,
                string resolvidoPor,
                string status,
                string prioridade)
            {
                try
                {
                    SaveFileDialog salvar = new SaveFileDialog();
                    salvar.Filter = "Arquivo PDF (*.pdf)|*.pdf";
                    salvar.FileName = $"Chamado_{titulo}_{DateTime.Now:dd-MM-yyyy}.pdf";

                    if (salvar.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                        return;

                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter.GetInstance(doc, new FileStream(salvar.FileName, FileMode.Create));
                    doc.Open();

                    // Título
                    Paragraph cabecalho = new Paragraph("Detalhes do Chamado - HelpDesk Pro - Support\n\n",
                        new Font(Font.FontFamily.HELVETICA, 20, Font.BOLD))
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(cabecalho);

                    Font labelFont = new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD);
                    Font valorFont = new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL);

                    void Campo(string label, string valor)
                    {
                        doc.Add(new Phrase(label + "\n", labelFont));
                        PdfPTable table = new PdfPTable(1);
                        PdfPCell cel = new PdfPCell(new Phrase(valor, valorFont))
                        {
                            Padding = 8,
                            MinimumHeight = 26
                        };
                        table.AddCell(cel);
                        table.SpacingAfter = 10;
                        doc.Add(table);
                    }

                    // Campos do chamado
                    Campo("Título:", titulo);
                    Campo("Descrição:", descricao);
                    Campo("Data de Abertura:", abertura);
                    Campo("Data de Fechamento / Resolução:", resolvido);
                    Campo("Aberto Por:", abertoPor);
                    Campo("Resolvido Por:", resolvidoPor);
                    Campo("Status:", status);
                    Campo("Prioridade:", prioridade);

                    Paragraph rodape = new Paragraph("\n\nRelatório gerado automaticamente.",
                        new Font(Font.FontFamily.HELVETICA, 10, Font.ITALIC))
                    {
                        Alignment = Element.ALIGN_RIGHT
                    };
                    doc.Add(rodape);

                    doc.Close();

                    System.Windows.Forms.MessageBox.Show(
                        "PDF do chamado gerado com sucesso!",
                        "Sucesso",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(
                        $"Erro ao gerar PDF: {ex.Message}",
                        "Erro",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error
                    );
                }
            }
        }
    }

}
