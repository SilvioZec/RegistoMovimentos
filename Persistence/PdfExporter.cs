using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;

namespace RegistoMovimentos.Persistence
{
    internal class PdfExporter
    {
        public void exportarPDF(DataGridView dataGridView, string caminho, string nomeArquivo)
        {
            // Cria um documento PDF
            string caminhoArquivo = Path.Combine(caminho, nomeArquivo);
            PdfWriter writer = new PdfWriter(caminhoArquivo);

            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Adicionar título
            Paragraph title = new Paragraph("Clix").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20);
            document.Add(title);

            // Adicionar subtítulo
            Paragraph subtitle = new Paragraph("Escritório de Contabilidade").SetTextAlignment(TextAlignment.CENTER).SetFontSize(15);
            document.Add(subtitle);

            // Adicionar logo da empresa
            string caminhoLogo = Path.Combine("C:\\Users\\silvi\\source\\repos\\RegistoMovimentos\\Recursos\\", "clix_logo.png");
            iText.Layout.Element.Image logo = new iText.Layout.Element.Image(ImageDataFactory.Create(caminhoLogo));
            document.Add(logo);

            // Cria uma tabela com as colunas do DataGridView
            Table table = new Table(dataGridView.ColumnCount);
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                Cell headerCell = new Cell().Add(new Paragraph(dataGridView.Columns[i].HeaderText));
                table.AddHeaderCell(headerCell);
            }

            // Adiciona as linhas do DataGridView na tabela
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    string value = dataGridView[j, i].Value != null ? dataGridView[j, i].Value.ToString() : ""; // Verifica se o valor é nulo
                    Cell cell = new Cell().Add(new Paragraph(value));
                    table.AddCell(cell);
                }
            }

            // Adiciona a tabela ao documento
            document.Add(table);
            
            document.Close();

            MessageBox.Show("PDF exportado com sucesso!");
        }
        
           
            
        
    }
}

