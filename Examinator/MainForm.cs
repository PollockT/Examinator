using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Reflection;

namespace Examinator {
    public partial class MainForm : Form {

        private BindingList<IQuestion> questions;
        private bool edited;
        private const char editedCharacter = '*';
        private string currentFile;
        private Dictionary<string, Type> loadedQuestions;

        public MainForm()
            : this(null) {
        }

        public MainForm(String file) {
            InitializeComponent();
            InitializeForm(file);
        }

        private void InitializeForm(String file) {
            questions = new BindingList<IQuestion>();
            this.Text = "Examinator";
            currentFile = null;
            loadQuestionTypes();
            SetUnedited();
            if (file != null) {
                LoadExam(file);
            }
            QuestionList.DataSource = questions;
            questions.ListChanged += new ListChangedEventHandler(questions_ListChanged);
            QuestionList.MouseDoubleClick += new MouseEventHandler(QuestionList_MouseDoubleClick);
        }

        private void loadQuestionTypes() {
            string path = Path.Combine(Application.StartupPath, "plugins");
            string[] pluginFiles = Directory.GetFiles(path, "*.dll");
            loadedQuestions = new Dictionary<string, Type>();

            for (int i = 0; i < pluginFiles.Length; i++) {
                string file = pluginFiles[i].Substring(pluginFiles[i].LastIndexOf("\\") + 1);
                try {
                    Assembly ass = Assembly.LoadFrom(Path.Combine("plugins", file));
                    if (ass != null) {
                        try {
                            Type q = ass.GetTypes().Where(t =>
                                    typeof(IQuestion).IsAssignableFrom(t)).First();
                            try {
                                QuestionTypeAttribute s = (QuestionTypeAttribute)q.GetCustomAttributes(
                                                                typeof(QuestionTypeAttribute), false).First();
                                loadedQuestions[s.type] = q;
                            }
                            catch (ArgumentNullException) {
                                MessageBox.Show(String.Format("Class {0} does not have a " +
                                    "QuestionTypeAttribute. Cannot load Question Type.",
                                    q.Name));
                            }
                        }
                        catch (ArgumentNullException) {
                            MessageBox.Show(String.Format("Assembly {0} does not have a " +
                                "class that implements IQuestion. Cannot load a question type " +
                                "from that assembly.", file));
                        }
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void LoadExam(String file) {
            try {
                TextReader tr = new StreamReader(file);
                String data = tr.ReadToEnd();
                using (XmlReader reader = XmlReader.Create(new StringReader(data))) {
                    if (reader.ReadToDescendant("Test")) {
                        reader.ReadToDescendant("Question");
                        do {
                            /*IQuestion q = new IQuestion();
                            int answer;
                            if (!int.TryParse(reader.GetAttribute("correct"), out answer)) {
                                q.correctAnswer = -1;
                            }
                            else {
                                q.correctAnswer = answer;
                            }
                            reader.MoveToContent();
                            if (reader.ReadToDescendant("Text")) {
                                q.value = reader.ReadElementContentAsString();
                            }
                            else {
                                q.correctAnswer = -1;
                                break;
                            }
                            while (reader.ReadToNextSibling("Answer")) {
                                q.answers.Add(reader.ReadElementContentAsString());
                            }
                            if (q.isValidQuestion()) {
                                questions.Add(q);
                            }*/
                        } while (reader.ReadToFollowing("Question"));
                    }
                }
                tr.Close();
            }
            catch (Exception e) {
                MessageBox.Show("Error loading file " + file + "\nInfo: " + e.Message);
                InitializeForm(null);
            }
            currentFile = file;
            this.Text = System.IO.Path.GetFileNameWithoutExtension(file);
            SetUnedited();
        }

        private void SetEdited() {
            this.Text = this.Text + editedCharacter;
            edited = true;
            SaveExam.Enabled = true;
        }

        private void SetUnedited() {
            if (this.Text[this.Text.Length - 1] == editedCharacter) {
                this.Text = this.Text.Remove(this.Text.Length - 1);
            }
            edited = false;
            SaveExam.Enabled = false;
        }

        private bool AssureSaved() {
            bool cont = true;

            if (edited) {
                DialogResult save = MessageBox.Show("You have unsaved changes. Do you want to save before continuing?",
                    "Unsaved Data", MessageBoxButtons.YesNoCancel);
                switch (save) {
                    case DialogResult.Yes:
                        SaveData();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        cont = false;
                        break;
                }
            }
            if (cont) {
                SetUnedited();
            }
            return cont;
        }

        private void SaveData() {
            if (currentFile == null) {
                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                save.Filter = "Exam Files (*.tst)|*.tst|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK) {
                    currentFile = save.FileName;
                }
            }
            if (currentFile != null) {

                try {
                    TextWriter tw = new StreamWriter(currentFile);
                    string data = buildAndValidateSaveFile();
                    if (!String.IsNullOrEmpty(data)) {
                        tw.Close();
                    }
                    SetUnedited();
                }
                catch (Exception e) {
                    MessageBox.Show("Error saving file: " + e.Message);
                }
            }
        }

        private string buildAndValidateSaveFile() {
            StringBuilder exam = new StringBuilder();
            exam.AppendLine("<Test>");
            XmlDocument xmltest = new XmlDocument();
            foreach (IQuestion q in questions) {
                string xmlstr = q.toXML();
                try {
                    exam.AppendLine("\t" + xmlstr);
                }
                catch (XmlException e) {
                    MessageBox.Show(String.Format(@"Error validating question ""{0}"": " +
                        "Remove the question and contact the developer.\n{1}", q.question, e.Message));
                    return null;
                }
            }
            exam.AppendLine("</Test>");
            return exam.ToString();
        }

        private void EditSelectedQuestion() {
            if (QuestionList.SelectedIndex != -1) {
                Form q = questions[QuestionList.SelectedIndex].questionForm;
                q.ShowDialog();
            }
        }

        #region EventHandlers

        private void AddQuestion_Click(object sender, EventArgs e) {
            QuestionTypeChooser c = new QuestionTypeChooser(loadedQuestions);
            if (c.ShowDialog() == DialogResult.OK) {
                IQuestion newQuestion = (IQuestion)Activator.CreateInstance(c.choice);
                newQuestion.questionForm.ShowDialog();
                if (newQuestion.isValidQuestion()) {
                    questions.Add(newQuestion);
                }
            }
        }

        private void RemoveQuestion_Click(object sender, EventArgs e) {
            if (QuestionList.SelectedIndex != -1) {
                questions.RemoveAt(QuestionList.SelectedIndex);
            }
        }

        private void EditButton_Click(object sender, EventArgs e) {
            EditSelectedQuestion();
        }

        private void QuestionList_MouseDoubleClick(object sender, MouseEventArgs e) {
            int ix = QuestionList.IndexFromPoint(e.Location);
            if (ix != System.Windows.Forms.ListBox.NoMatches) {
                EditSelectedQuestion();
            }
        }

        private void questions_ListChanged(object sender, ListChangedEventArgs e){
            if (!edited) {
                SetEdited();
            }
        }

        private void generateData_Click(object sender, EventArgs e) {
            TextWriter tw = new StreamWriter("save.txt");
            tw.WriteLine("<Test>");
            foreach (IQuestion q in questions) {
                tw.WriteLine("\t" + q.toXML());
            }
            tw.WriteLine("</Test>");
            tw.Close();
        }

        private void Save_Click(object sender, EventArgs e) {
            SaveData();
        }

        private void Open_Click(object sender, EventArgs e) {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            open.Filter = "Exam Files (*.tst)|*.tst|All Files (*.*)|*.*";
            open.CheckFileExists = true;
            if (open.ShowDialog() == DialogResult.OK) {
                if (AssureSaved()) {
                    LoadExam(open.FileName);
                }
            }
        }

        private void New_Click(object sender, EventArgs e) {
            if (AssureSaved()) {
                InitializeForm(null);
            }
        }

        #endregion

    }
}
