
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;


namespace HelpDeskPro.OpenCall.Relatorio
{
    public class RelatorioTotal
    {
        public void GerarPDF(DataGridView dgv)
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum chamado encontrado para gerar o relatório.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Filter = "Arquivo PDF (*.pdf)|*.pdf";
                salvar.FileName = $"Relatorio_OpenCall_{DateTime.Now:dd-MM-yyyy}.pdf";

                if (salvar.ShowDialog() != DialogResult.OK)
                    return;

                Document documento = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
                PdfWriter.GetInstance(documento, new FileStream(salvar.FileName, FileMode.Create));
                documento.Open();

                Paragraph titulo = new Paragraph("Relatório de Chamados - HelpDesk Pro - OpenCall\n\n",
                    new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
                titulo.Alignment = Element.ALIGN_CENTER;
                documento.Add(titulo);

                // Criar tabela apenas com colunas visibles
                PdfPTable tabela = new PdfPTable(CountVisibleColumns(dgv));
                tabela.WidthPercentage = 100;

                // Cabeçalhos filtrados
                foreach (DataGridViewColumn coluna in dgv.Columns)
                {
                    if (!coluna.Visible || IsConfidential(coluna.Name)) continue;

                    PdfPCell cell = new PdfPCell(new Phrase(coluna.HeaderText));
                    cell.BackgroundColor = new BaseColor(200, 200, 200);
                    tabela.AddCell(cell);
                }

                // Dados filtrados
                foreach (DataGridViewRow linha in dgv.Rows)
                {
                    if (linha.IsNewRow) continue;

                    foreach (DataGridViewColumn coluna in dgv.Columns)
                    {
                        if (!coluna.Visible || IsConfidential(coluna.Name)) continue;

                        object valor = linha.Cells[coluna.Index].Value;
                        tabela.AddCell(valor?.ToString() ?? "");
                    }
                }

                documento.Add(tabela);
                documento.Close();

                MessageBox.Show("Relatório OpenCall gerado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsConfidential(string columnName)
        {
            return columnName == "Id" ||
                   columnName == "UsuarioClientId" ||
                   columnName == "UsuarioAdminId";
        }

        private int CountVisibleColumns(DataGridView dgv)
        {
            int count = 0;
            foreach (DataGridViewColumn coluna in dgv.Columns)
                if (coluna.Visible && !IsConfidential(coluna.Name))
                    count++;
            return count;
        }
    }
}
