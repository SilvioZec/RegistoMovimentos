using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace RegistoMovimentos.Persistence
{
    internal class ExcelConverter
    {



        public void ExportarParaExcel(DataGridView dgv, string caminho, string nomeDoArquivo)
        {
            // Cria uma aplicação Excel
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;

            // Adiciona uma nova planilha
            Workbook wb = excelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = wb.Worksheets[1] as Worksheet;

            // Copia o conteúdo do DataGridView para a planilha do Excel
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                ws.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
{
    for (int j = 0; j < dgv.Columns.Count; j++)
    {
        if (dgv.Rows[i].Cells[j].Value != null) // Verifica se a célula não é nula
        {
            ws.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
        }
        else
        {
            ws.Cells[i + 2, j + 1] = ""; // Se a célula for nula, insere uma string vazia na planilha
        }
    }
}

            // Ajusta o formato da planilha
            ws.Columns.AutoFit();

            // Salva o arquivo Excel
            try
            {
                wb.SaveAs(caminho + "\\" + nomeDoArquivo + ".xlsx");
                MessageBox.Show("Arquivo Excel salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o arquivo Excel: " + ex.Message);
            }

            // Libera os recursos
            ReleaseObject(ws);
            ReleaseObject(wb);
            ReleaseObject(excelApp);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Erro ao liberar objeto do Excel" + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}

