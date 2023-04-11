using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.IO;


namespace ObjModelAddUVData
{
    public partial class ObjFixUVForm : Form
    {
        private Computer computer = new Computer();

        private string objFilePath = string.Empty;
        private string csvFilePath = string.Empty;
        private string fileNameWithoudExtension = string.Empty;
        private string saveFilePath = string.Empty;

        //读取点链接索引
        private ArrayList vertexList = new ArrayList();
        private ArrayList faceLinkList = new ArrayList();
        private ArrayList normalList = new ArrayList();
        private ArrayList allUVData = new ArrayList();
        private ArrayList mergeData = new ArrayList();

        //判断csv数据是否为float4类型
        private bool isUVFloat4 = false;
        private bool isAddUVCount1 = false;
        private bool isFlipUV_Y = false;

        private string objFileData = string.Empty;
        private string[] allRowText = null;

        string newFilePath = string.Empty;

        private StringBuilder allDatas = new StringBuilder();

        public ObjFixUVForm()
        {
            InitializeComponent();
        }

        private void Btn_BrowObjFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog objFileDialog = new OpenFileDialog();
            objFileDialog.Title = "请选择Obj模型文件";
            objFileDialog.Filter = "WaveFront OBJ(*.obj)|*.obj";
            objFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            if (objFileDialog.ShowDialog() == DialogResult.OK)
            {
                Tt_ObjPath.Text = objFileDialog.FileName.ToString();
                fileNameWithoudExtension = objFileDialog.SafeFileName.Split('.')[0].ToString();
                string tPath = objFileDialog.FileName;
                string[] cellPath = tPath.Split('\\');
                for (int i = 0; i < cellPath.Length - 1; i++)
                {
                    saveFilePath += cellPath[i] + "\\";
                }
            }
        }

        private void Btn_BrowCsvFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog csvFileDialog = new OpenFileDialog();
            csvFileDialog.Title = "请选择Obj模型文件";
            csvFileDialog.Filter = "CSV(*.csv)|*.csv";
            csvFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            if (csvFileDialog.ShowDialog() == DialogResult.OK)
            {
                Tt_CsvPath.Text = csvFileDialog.FileName.ToString();
            }
        }

        private void Btn_FixedUVData_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Tt_ObjPath.Text))
            {
                MessageBox.Show("请选择OBJ模型文件！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!File.Exists(Tt_CsvPath.Text))
            {
                MessageBox.Show("请选择CSV数据文件！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {


                //获取obj及CSV文件路径
                objFilePath = Tt_ObjPath.Text;
                csvFilePath = Tt_CsvPath.Text;
                //判断csv数据是否为float4类型
                isUVFloat4 = cb_isUVFloat4.Checked;
                isAddUVCount1 = cb_Add1ToUVCount.Checked;
                isFlipUV_Y = cb_flipUV_Y.Checked;

                //读取GPA导出的obj模型数据
                objFileData = File.ReadAllText(objFilePath);
                allRowText = objFileData.Split('\n');


                for (int i = 0; i < allRowText.Length; i++)
                {
                    string[] cell = allRowText[i].Trim().Split(' ');
                    if (cell[0] == "v")
                    {
                        vertexList.Add(allRowText[i]);
                    }
                    if (cell[0] == "vn")
                    {
                        normalList.Add(allRowText[i]);
                    }
                    if (cell[0] == "f")
                    {
                        string[] cellData = allRowText[i].Trim().Split('/', ' ');
                        faceLinkList.Add(cellData[0] + " " + cellData[1] + "/" + cellData[1] + "/" + cellData[3] +
                                                " " + cellData[4] + "/" + cellData[4] + "/" + cellData[6] +
                                                " " + cellData[7] + "/" + cellData[7] + "/" + cellData[9] + "\r");
                    }
                }
                int vertexCount = vertexList.Count;
                //读取UV数据
                allUVData = ReadUVData(vertexCount, csvFilePath, isUVFloat4, isAddUVCount1, isFlipUV_Y);
                //获取文件的总长度
                int fileLineCount = vertexList.Count + normalList.Count + faceLinkList.Count + allUVData.Count;

                for (int i = 0; i < fileLineCount; i++)
                {
                    if (i < vertexList.Count)
                    {
                        mergeData.Add(vertexList[i]);
                    }
                    else if ((i >= vertexList.Count) && i < (vertexList.Count + normalList.Count))
                    {
                        int index = i - normalList.Count;
                        mergeData.Add(normalList[index]);
                    }
                    else if ((i >= (vertexList.Count + normalList.Count) && i < (vertexList.Count + normalList.Count + allUVData.Count)))
                    {
                        int index = i - normalList.Count - allUVData.Count;
                        mergeData.Add(allUVData[index]);
                    }
                    else
                    {
                        int index = i - normalList.Count - allUVData.Count - allUVData.Count;
                        mergeData.Add(faceLinkList[index]);
                    }
                }

                for (int i = 0; i < fileLineCount; i++)
                {
                    allDatas.Append(mergeData[i]);
                }

                newFilePath = saveFilePath + fileNameWithoudExtension + "_AddUV.obj";
                ASCIIEncoding strData = new ASCIIEncoding();
                SaveFile(newFilePath, strData.GetBytes(allDatas.ToString()));
            }
            catch(Exception ex)
            {
                MessageBox.Show("错误：" + ex, "错误！", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            bool isResetButton = true;
            ResetSetting(isResetButton);
        }

        private ArrayList ReadUVData(int vertexCount, string path, bool isUVFloat4, bool isAddUVCount1, bool isFlipUVY)
        {
            string allUVText = File.ReadAllText(path);
            string[] allRowText = allUVText.Split('\n');
            ArrayList uvList = new ArrayList();
            int addUV1 = 0;
            if (isAddUVCount1)
            {
                addUV1 = 1;
            }

            for (int i = 1; i < vertexCount + addUV1; i++)
            {
                string lineTextX = allRowText[(i - 1) * 2 + 1].Trim();
                string lineTextY = allRowText[(i - 1) * 2 + 2].Trim();
                if (isUVFloat4)
                {
                    lineTextX = allRowText[(i - 1) * 4 + 1].Trim();
                    lineTextY = allRowText[(i - 1) * 4 + 2].Trim();
                }
                if (isFlipUVY)
                {
                    lineTextY = (1 - float.Parse(lineTextY)).ToString();
                }

                string lineData = "vt " + lineTextX + " " + lineTextY + " " + lineTextY + "\r";
                uvList.Add(lineData);
            }
            return uvList;
        }

        private void SaveFile(string path, byte[] centens)
        {
            string directoryName = Path.GetDirectoryName(path);
            if (!Directory.Exists(directoryName))
            {
                Directory.CreateDirectory(directoryName);
            }
            File.WriteAllBytes(path, centens);
            MessageBox.Show("添加UV到obj成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetSetting(false);
        }

        private void ResetSetting(bool isResetButton)
        {
            fileNameWithoudExtension = string.Empty;
            saveFilePath = string.Empty;

            vertexList.Clear();
            faceLinkList.Clear();
            normalList.Clear();
            allUVData.Clear();
            mergeData.Clear();
            allDatas.Clear();

            isUVFloat4 = false;
            isAddUVCount1 = true;
            isFlipUV_Y = false;

            objFileData = string.Empty;
            allRowText = null;
            newFilePath = string.Empty;

            if (isResetButton)
            {
                objFilePath = string.Empty;
                csvFilePath = string.Empty;
                Tt_ObjPath.Text = string.Empty;
                Tt_CsvPath.Text = string.Empty;
                cb_isUVFloat4.Checked = isUVFloat4;
                cb_Add1ToUVCount.Checked = isAddUVCount1;
                cb_flipUV_Y.Checked = isFlipUV_Y;
            }
        }

    }
}
