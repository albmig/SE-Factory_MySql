using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace SE_Factory
{
    public partial class UC_form_Spedizioni : UserControl
    {
        public UC_form_Spedizioni()
        {
            InitializeComponent();
        }

        private void menu_sw_exit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void UC_form_Spedizioni_Load(object sender, EventArgs e)
        {
            tb_file_SN.Text = @"D:\VS2017 - Projects\SE_Factory\SE_Factory\SN\Numeri di serie.xlsx";

            //tb_Folder_Sped.Text = @"\\192.168.1.10\DiskNEOHM\Sistematica\report_spedito"; // versione LAN
            tb_Folder_Sped.Text = @"D:\VS2017 - Projects\SE_Factory\SE_Factory\Report Spedito"; // versione local

            this.spedNeohmBindingSource.Filter = "Elaborato = false";
            lab_avanzamento.Text = "";
            lab_file_analizzato.Text = "";
            lab_riga.Text = "";
            lab_data_bolla.Text = "";
            lab_doc_sist.Text = "";
            lab_avanzamento.Refresh();

        }

        private void button_go_sped_Click(object sender, EventArgs e)
        {
            // Prima fase: trovo tutti i file excel
            lab_avanzamento.Text = "Ricerca di tutti i file excel ricevuti";
            lab_avanzamento.Refresh();
            Cursor.Current = Cursors.WaitCursor;
            dB_FactoryDataSet.SpedNeohm.Clear();
            foreach (string file in Directory.EnumerateFiles(tb_Folder_Sped.Text, "*.xls*", SearchOption.AllDirectories))
            {
                DataRow workRow = dB_FactoryDataSet.SpedNeohm.NewRow();
                workRow["File_Sped"] = file;
                workRow["Elaborato"] = false;
                dB_FactoryDataSet.SpedNeohm.Rows.Add(workRow);
            }
            Cursor.Current = Cursors.Default;


            // Seconda fase: scarto i files non necessari
            lab_avanzamento.Text = "Selezione dei file excel ricevuti";
            lab_avanzamento.Refresh();
            Cursor.Current = Cursors.WaitCursor;
            foreach (DataRow workRow in dB_FactoryDataSet.SpedNeohm.Rows)
            {
                string nomefile_conpath = workRow["File_Sped"].ToString();
                string nomefile = Path.GetFileName(nomefile_conpath);
                if (nomefile.StartsWith("spedito_sistematica_"))
                {
                    // trova anno
                    string anno = nomefile.Substring(20, 4);
                    if (anno != DateTime.Today.Year.ToString())
                    {
                        workRow["Elaborato"] = true;
                    }
                }
                else
                {
                    workRow["Elaborato"] = true;
                }
            }

            this.spedNeohmBindingSource.Filter = "Elaborato = false";
            dg_spedizioni.Refresh();
            Cursor.Current = Cursors.Default;

            // Terza fase: lettura xls
            lab_avanzamento.Text = "Lettura del file dei numeri di serie";
            lab_avanzamento.Refresh();
            Cursor.Current = Cursors.WaitCursor;
            dB_FactoryDataSet.xls_Serials.Clear();
            DataTable dt = ImportToDataTable(tb_file_SN.Text, "Foglio1");
            // Scrivo dt xls_Serials
            foreach (DataRow workRow in dt.Rows)
            {
                if ((workRow[3].ToString() == @"\") || (workRow[3].ToString() == ""))
                {
                    continue;
                }

                // trova anno
                string firstchar = workRow[2].ToString().Substring(0, 1);
                if (firstchar != DateTime.Today.Year.ToString().Substring(3, 1))
                {
                    continue;
                }

                DataRow dr = dB_FactoryDataSet.xls_Serials.NewRow();
                dr["Serial_Id"] = workRow[2];
                dr["Serial_Cli"] = workRow[3];
                dr["Serial_Des"] = workRow[4];
                dr["Serial_Kit"] = workRow[5];
                dr["Serial_Art"] = workRow[6];
                dr["Serial_Commessa"] = workRow[8];

                //int qta = 0;
                //bool res = int.TryParse(workRow[9].ToString(), out qta);

                //dr["Serial_Qta"] = qta;
                dB_FactoryDataSet.xls_Serials.Rows.Add(dr);
            }
            Cursor.Current = Cursors.Default;

            // Quarta fase: lettura dei file xls
            lab_avanzamento.Text = "Analisi dei files ricevuti";
            lab_avanzamento.Refresh();
            Cursor.Current = Cursors.WaitCursor;
            foreach (DataRow NeohmDocsRow in dB_FactoryDataSet.SpedNeohm.Rows)
            {
                DataTable NeohmRigheDocs = ImportToDataTable(NeohmDocsRow[0].ToString(), "Sheet0");
                lab_file_analizzato.Text = NeohmDocsRow[0].ToString();
                lab_file_analizzato.Refresh();

                foreach (DataRow NeohmRigaEvasa in NeohmRigheDocs.Rows)
                {
                    //ciclo su tutte le righe evase

                    // Primo controllo: data bolla
                    string inputdata = NeohmRigaEvasa[2].ToString();
                    try
                    {
                        DateTime databolla = Convert.ToDateTime(inputdata);
                        if (databolla.Year != DateTime.Today.Year)
                        {
                            continue;
                        }

                    }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                    catch (System.FormatException ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                    {
                        continue;
                    }

                    // Secondo controllo: Numero commessa
                    string valorecella = NeohmRigaEvasa[11].ToString();
                    string annovalorecella = "";
                    if (valorecella.Length > 4)
                    {
                        annovalorecella = valorecella.Substring(0, 4);
                    }

                    int anno = 0;
                    try
                    {
                        anno = Int32.Parse(annovalorecella);
                    }
#pragma warning disable CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                    catch (FormatException ex)
#pragma warning restore CS0168 // La variabile 'ex' è dichiarata, ma non viene mai usata
                    {
                    }

                    int annotoday = Int32.Parse(DateTime.Today.Year.ToString());

                    string NeohmCommessa = "";
                    if ((anno != 0) && (anno == annotoday))
                    {
                        NeohmCommessa = valorecella.Substring(0, 12);
                    }
                    else
                    {
                        continue;
                    }

                    lab_riga.Text = NeohmRigaEvasa[5].ToString();
                    lab_riga.Refresh();
                    lab_data_bolla.Text = NeohmRigaEvasa[2].ToString();
                    lab_data_bolla.Refresh();
                    lab_doc_sist.Text = NeohmRigaEvasa[11].ToString();
                    lab_doc_sist.Refresh();

                    //MessageBox.Show("ne ho trovato uno!");

                    //mò si comincia a ciclare....
                    string filtroxls = "(Serial_Commessa like '" + NeohmCommessa + "%')";
                    xlsSerialsBindingSource.Filter = filtroxls;

                    //int qtadaevadere = Convert.ToUInt16(NeohmRigaEvasa[6]);
                    //int contaqtaevasa = 1;
                    foreach (DataRowView rigaserial in xlsSerialsBindingSource.List)
                    {
                        ////evado le righe
                        //if (contaqtaevasa > qtadaevadere)
                        //{ continue; }

                        if ((NeohmRigaEvasa[5].ToString().Trim() == rigaserial["Serial_Kit"].ToString().Trim()) || (NeohmRigaEvasa[5].ToString().Trim() == rigaserial["Serial_Art"].ToString().Trim()))
                        {
                            rigaserial["Serial_N_numdoc"] = NeohmRigaEvasa[12];
                            rigaserial["Serial_N_datadoc"] = NeohmRigaEvasa[2];
                            //contaqtaevasa++;
                        }
                    }
                }
            }

            xlsSerialsBindingSource.RemoveFilter();
            dg_SN.Refresh();

            Cursor.Current = Cursors.Default;

            lab_avanzamento.Text = "Terminato";
            lab_avanzamento.Refresh();
        }

        public static DataTable ImportToDataTable(string FilePath, string SheetName)
        {

            DataTable dt = new DataTable();
            FileInfo fi = new FileInfo(FilePath);

            // Check if the file exists
            if (!fi.Exists)
                throw new Exception("File " + FilePath + " Does Not Exists");

            using (ExcelPackage xlPackage = new ExcelPackage(fi))
            {
                // get the first worksheet in the workbook
                //ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets[SheetName];
                ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets[1];

                // Fetch the WorkSheet size
                ExcelCellAddress startCell = worksheet.Dimension.Start;
                ExcelCellAddress endCell = worksheet.Dimension.End;

                string nf = Path.GetFileName(FilePath);

                // create all the needed DataColumn
                for (int col = startCell.Column; col <= endCell.Column; col++)
                {
                    //if ((nf.StartsWith("Numeri di serie")) && (col < 3))
                    //    continue;

                    dt.Columns.Add(col.ToString());
                }

                //Aggiunta colonna di servizio
                if ((nf.StartsWith("spedito_sistematica_")) || (nf.StartsWith("Numeri di serie")))
                {
                    dt.Columns.Add("NumCommessa");
                }

                // place all the data into DataTable
                for (int row = startCell.Row; row <= endCell.Row; row++)
                {
                    DataRow dr = dt.NewRow();
                    int x = 0;
                    for (int col = startCell.Column; col <= endCell.Column; col++)
                    {
                        //if ((nf.StartsWith("Numeri di serie")) && (col < 3))
                        //    continue;
                        //else
                        dr[x++] = worksheet.Cells[row, col].Value;
                    }
                    if ((nf.StartsWith("spedito_sistematica_")) || (nf.StartsWith("Numeri di serie")))
                    {
                        string valorecella = "";
                        if (nf.StartsWith("spedito_sistematica_"))
                        {
                            valorecella = dr[12].ToString();
                        }

                        string firstchar = "";
                        if (nf.StartsWith("Numeri di serie"))
                        {
                            // trova anno
                            if (dr[2].ToString() != "")
                            {
                                firstchar = dr[2].ToString().Substring(0, 1);
                                if (firstchar != DateTime.Today.Year.ToString().Substring(3, 1))
                                {
                                    continue;
                                }
                            }
                            // trova cliente valido
                            if (dr[3].ToString() != "")
                            {
                                firstchar = dr[3].ToString().Substring(0, 1);
                            }
                            if ((firstchar == @"\") || (dr[3].ToString() == null) || (dr[3].ToString() == ""))
                            {
                                continue;
                            }
                        }

                        if ((nf.StartsWith("Numeri di serie")) && (dr[8] != null))
                        {
                            valorecella = dr[8].ToString();
                        }

                        string annovalorecella = "";
                        if (valorecella.Length > 4)
                        {
                            annovalorecella = valorecella.Substring(0, 4);
                        }

                        int anno = 0;
                        try
                        {
                            anno = Int32.Parse(annovalorecella);
                        }
#pragma warning disable CS0168 // La variabile 'e' è dichiarata, ma non viene mai usata
                        catch (FormatException e)
#pragma warning restore CS0168 // La variabile 'e' è dichiarata, ma non viene mai usata
                        {
                        }

                        int annotoday = Int32.Parse(DateTime.Today.Year.ToString());

                        if ((anno != 0) && (anno == annotoday))
                        {
                            dr["NumCommessa"] = valorecella.Substring(0, 12);
                        }
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    }
}
