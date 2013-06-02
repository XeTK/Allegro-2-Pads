using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PadsConvert
{
    public partial class FRM_Main : Form
    {
        private List<CSV_File> CSV_Files = new List<CSV_File>();
        private List<PadConvert> Pad_Files = new List<PadConvert>();

        public FRM_Main()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            fbd_open_csv.Description = "Select folder containing .csv files";
            if (fbd_open_csv.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("{0} .csv location", fbd_open_csv.SelectedPath);
                string[] CSV_files = new Explore().find_CSV(fbd_open_csv.SelectedPath);
                for (int i = 0; i < CSV_files.Length; i++)
                {
                    lbox_files.Items.Add(CSV_files[i]);
                    CSV_Files.Add(new CSV_File(CSV_files[i]));
                }
            }

            fbd_open_pads.Description = "Select folder containing .pads files";
            if (fbd_open_pads.ShowDialog() == DialogResult.OK)
            {
                string[] Pads_files = new Explore().find_PADS(fbd_open_pads.SelectedPath);

                for (int i = 0; i < Pads_files.Length; i++)
                {
                    bool exists = false;
                    for (int j = 0; j < Pad_Files.Count; j++)
                    {
                        if (Pad_Files[j].Old_dot_pad_file == Pads_files[i])
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        PadConvert pc = new PadConvert();
                        pc.Old_dot_pad_file = Pads_files[i];
                        pc.Old_pad_name = Path.GetFileNameWithoutExtension(Pads_files[i]);
                        Pad_Files.Add(pc);
                    }
                }

            }
            MessageBox.Show("Import Complete", "We are done", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            fbd_export.Description = "Where to save .pads files";
            if (fbd_export.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("{0} .pads export path", fbd_export.SelectedPath);
                for (int i = 0; i < CSV_Files.Count; i++)
                {
                    int pads = 0;
                    List<Pad_Line> pls = CSV_Files[i].Pads;
                    for (int j = 0; j < pls.Count; j++)
                    {
                        for (int k = 0; k < Pad_Files.Count; k++)
                        {
                            if (Pad_Files[k].Old_pad_name == pls[j].Pad_Stack.ToLower())
                            {
                                if (Pad_Files[k].New_pad_name == null)
                                {
                                    Pad_Files[k].New_pad_name = Path.GetFileNameWithoutExtension(CSV_Files[i].Path) + pads;
                                    Pad_Files[k].New_dot_pad_file = fbd_export.SelectedPath + "\\PadStacks\\" + Pad_Files[k].New_pad_name + ".pad";
                                }
                                pls[j].Pad_Stack = Pad_Files[k].New_pad_name;
                                break;
                            }
                        }
                    }
                }

                for (int i = 0; i < Pad_Files.Count; i++)
                {
                    if (!Directory.Exists(fbd_export.SelectedPath + "\\PadStacks\\"))
                        Directory.CreateDirectory(fbd_export.SelectedPath + "\\PadStacks\\");

                    if (!File.Exists(Pad_Files[i].New_dot_pad_file))
                        if (Pad_Files[i].New_dot_pad_file != null)
                            File.Copy(Pad_Files[i].Old_dot_pad_file, Pad_Files[i].New_dot_pad_file);
                }

                if (!Directory.Exists(fbd_export.SelectedPath + "\\Symbols\\"))
                    Directory.CreateDirectory(fbd_export.SelectedPath + "\\Symbols\\");

                for (int i = 0; i < CSV_Files.Count; i++)
                {
                    List<Pad_Line> pls = CSV_Files[i].Pads;

                    StreamWriter fi = new StreamWriter(fbd_export.SelectedPath + "\\Symbols\\" + Path.GetFileName(CSV_Files[i].Path));
                    fi.Write("# If units not specified use current design units\n" +
                            "Units,millimeters\n" +
                            "# Format for pin definition file (comma delineated)\n" +
                            "#    To Mirror pin text use \"m\".\n" +
                            "#PinNumber,Padstack,x,y,rotation,textOffsetX,textOffsetY,textRotate,textMirror\n");
                    for (int j = 0; j < pls.Count; j++)
                    {
                        fi.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},", pls[j].Pin_no, pls[j].Pad_Stack, pls[j].X, pls[j].Y, pls[j].Rotation, pls[j].Text_Offset_X, pls[j].Text_Offset_Y, pls[j].Text_Rotate, pls[j].Text_Mirror);
                    }
                    fi.Close();

                }
            }
            MessageBox.Show("Export Complete","We are done",MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
