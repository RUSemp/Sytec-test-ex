namespace RKKandAppeals
{
    public partial class Form1 : Form
    {

        public struct Docs // ��������� �������� ������ �� ���� ���������� ��� ������ � dataGridView � ��������� ����
        {
            public string nameResp;
            public int rkk;
            public int appeals;
            public int allDocs;

            public Docs(string _nameResp, int _rkk, int _appeals)
            {
                nameResp = _nameResp;
                rkk = _rkk; 
                appeals = _appeals;
                allDocs = rkk + appeals;
            }
        }

        List<Docs> docs = new List<Docs>();


        string[] content = new string[5];
        string rkkPath = string.Empty;
        string appealsPath = string.Empty;
        string sortMethod = string.Empty;
        int allDocuments = 0;
        int allRKK = 0;
        int allAppeals = 0;

        System.Data.DataTable table = new System.Data.DataTable();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.AllowUserToAddRows = false; 
            dataGridView1.AllowUserToDeleteRows = false;

            table.Columns.Add("�", typeof(int));
            table.Columns.Add("������������� �����������", typeof(string));
            table.Columns.Add("���", typeof(int));
            table.Columns.Add("���������", typeof(int));
            table.Columns.Add("����� ���-���", typeof(int));

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            Docs doc1 = new Docs();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                rkkPath = openFile.FileName;

                var fileStream = openFile.OpenFile();
                string name;

                using(StreamReader sr = new StreamReader(fileStream))
                {
                    while(!sr.EndOfStream)
                    {
                        content = sr.ReadLine().Split(' ', '\t', ';');

                        if (content[0] == "������")
                        {
                            if(docs.Find(x => x.nameResp.Contains(content[3] + " " + content[4])).allDocs > 0)
                            {
                                int i = docs.IndexOf(docs.Find(x => x.nameResp.Contains(content[3] + " " + content[4])));
                                doc1 = docs[i];
                                doc1.rkk++;
                                doc1.allDocs++;
                                docs[i] = doc1;
                            }
                            else
                            {
                                docs.Add(new Docs(content[3] + " " + content[4], 1, 0));
                            }
                        }
                        else
                        {
                            name = content[0] + " " + content[1].Substring(0, 1) + "." + content[2].Substring(0, 1) + ".";

                            if(docs.Find(x => x.nameResp.Contains(name)).allDocs > 0)
                            {
                                int i = docs.IndexOf(docs.Find(x => x.nameResp.Contains(name)));
                                doc1 = docs[i];
                                doc1.rkk++;
                                doc1.allDocs++;
                                docs[i] = doc1;
                                
                            }
                            else
                            {
                                docs.Add(new Docs(name, 1, 0));
                            }
                        }
                    }
                }
            }

            richTextBox1.Text += rkkPath + "\n";
        }

        private void ������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            Docs doc1 = new Docs();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                appealsPath = openFile.FileName;

                var fileStream = openFile.OpenFile();
                string name;

                using (StreamReader sr = new StreamReader(fileStream))
                {
                    while (!sr.EndOfStream)
                    {
                        content = sr.ReadLine().Split(' ', '\t', ';');

                        if (content[0] == "������")
                        {
                            if (docs.Find(x => x.nameResp.Contains(content[3] + " " + content[4])).allDocs > 0)
                            {
                                int i = docs.IndexOf(docs.Find(x => x.nameResp.Contains(content[3] + " " + content[4])));
                                doc1 = docs[i];
                                doc1.appeals++;
                                doc1.allDocs++;
                                docs[i] = doc1;
                            }
                            else
                            {
                                docs.Add(new Docs(content[3] + " " + content[4], 0, 1));
                            }
                        }
                        else
                        {
                            name = content[0] + " " + content[1].Substring(0, 1) + "." + content[2].Substring(0, 1) + ".";

                            if (docs.Find(x => x.nameResp.Contains(name)).allDocs > 0)
                            {
                                int i = docs.IndexOf(docs.Find(x => x.nameResp.Contains(name)));
                                doc1 = docs[i];
                                doc1.appeals++;
                                doc1.allDocs++;
                                docs[i] = doc1;

                            }
                            else
                            {
                                docs.Add(new Docs(name, 0, 1));
                            }
                        }
                    }
                }
            }

            richTextBox1.Text += appealsPath + "\n";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(docs.Count != 0)
            {
                allDocuments = 0;
                allRKK = 0;
                allAppeals = 0;

                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                }

                table.Clear();

                for (int i = 0; i < docs.Count; i++)
                {
                    table.Rows.Add(i + 1, docs[i].nameResp, docs[i].rkk, docs[i].appeals, docs[i].allDocs);
                    allDocuments += docs[i].allDocs;
                    allRKK += docs[i].rkk;
                    allAppeals += docs[i].appeals;
                }

                dataGridView1.DataSource = table;
            }
            else
            {
                richTextBox1.Text = "no data";
            }
        }

        private void �������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docs.Sort(delegate (Docs x, Docs y)
            {
                return x.nameResp.CompareTo(y.nameResp);
            });

            sortMethod = "�� ������� �������������� �����������.";
        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docs.Sort(delegate (Docs x, Docs y)
            {
                return y.rkk.CompareTo(x.rkk);
            });

            sortMethod = "�� ���.";
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docs.Sort(delegate (Docs x, Docs y)
            {
                return y.appeals.CompareTo(x.appeals);
            });

            sortMethod = "�� ����������.";
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            docs.Sort(delegate (Docs x, Docs y)
            {
                return y.allDocs.CompareTo(x.allDocs);
            });

            sortMethod = "�� ���� ����������.";
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FileName = "��� � ���������";
            string filename = "";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                filename = saveFile.FileName;
            }
            if(filename != string.Empty)
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.WriteLine("          ������� � ��� � ���������� �������\n");
                    sw.WriteLine("�� ��������� � ���� {0} ����������� �� ���:\n", allDocuments);
                    sw.WriteLine(" - ���������� ���: {0};\n", allRKK);
                    sw.WriteLine(" - ���������� ���������: {0}.\n", allAppeals);
                    sw.WriteLine("����������: " + sortMethod + "\n");

                    sw.WriteLine(" � | ������������� ����������� | ��� | ��������� | ��� ���-�� |");

                    for (int i = 0; i < docs.Count; i++)
                    {
                        sw.WriteLine("{0,3}|{1,27}|{2,5}|{3,11}|{4,12}|", (i + 1), docs[i].nameResp, docs[i].rkk, docs[i].appeals, docs[i].allDocs);
                    }
                    sw.WriteLine("\n\n");
                    sw.Write("���� ����������� �������: ");

                    DateTime dateTime = DateTime.UtcNow.Date;
                    sw.WriteLine(dateTime.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}