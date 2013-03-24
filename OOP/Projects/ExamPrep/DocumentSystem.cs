using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentSystem
{
    public interface IDocument
    {
        string Name { get; }

        string Content { get; }

        void LoadProperty(string key, string value);

        void SaveAllProperties(IList<KeyValuePair<string, object>> output);

        string ToString();
    }

    public interface IEditable
    {
        void ChangeContent(string newContent);
    }

    public interface IEncryptable
    {
        bool IsEncrypted { get; }

        void Encrypt();

        void Decrypt();
    }

    public class DocumentSystem
    {
        private static IList<IDocument> documents = new List<IDocument>();

        static void Main()
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static void AddTextDocument(string[] attributes)
        {
            AddDocument(new TextDocument(), attributes);
        }

        private static void AddPdfDocument(string[] attributes)
        {
            AddDocument(new PDFDocument(), attributes);
        }

        private static void AddWordDocument(string[] attributes)
        {
            AddDocument(new WordDocument(), attributes);
        }

        private static void AddExcelDocument(string[] attributes)
        {
            AddDocument(new ExcelDocument(), attributes);
        }

        private static void AddAudioDocument(string[] attributes)
        {
            AddDocument(new AudioDocument(), attributes);
        }

        private static void AddVideoDocument(string[] attributes)
        {
            AddDocument(new VideoDocument(), attributes);
        }

        private static void ListDocuments()
        {
            if (documents.Count > 0)
            {
                foreach (var doc in documents)
                {
                    Console.WriteLine(doc);
                }
            }
            else
            {
                Console.WriteLine("No documents found");
            }
        }

        private static void EncryptDocument(string name)
        {
            bool documentFound = false;
            foreach (var doc in documents)
            {
                if (doc.Name == name)
                {
                    if (doc is IEncryptable)
                    {
                        ((IEncryptable)doc).Encrypt();
                        Console.WriteLine("Document encrypted: " + name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support encryption: " + name);
                    }
                    documentFound = true;
                }
            }
            if (!documentFound)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }

        private static void DecryptDocument(string name)
        {
            bool documentFound = false;
            foreach (var doc in documents)
            {
                if (doc.Name == name)
                {
                    if (doc is IEncryptable)
                    {
                        ((IEncryptable)doc).Decrypt();
                        Console.WriteLine("Document decrypted: " + name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support decryption: " + name);
                    }
                    documentFound = true;
                }
            }
            if (!documentFound)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }

        private static void EncryptAllDocuments()
        {
            bool documentFound = false;
            foreach (var doc in documents)
            {
                if (doc is IEncryptable)
                {
                    ((IEncryptable)doc).Encrypt();
                    documentFound = true;
                }
            }
            if (documentFound)
            {
                Console.WriteLine("All documents encrypted");
            }
            else
            {
                Console.WriteLine("No encryptable documents found");
            }
        }

        private static void ChangeContent(string name, string content)
        {
            bool documentFound = false;
            foreach (var doc in documents)
            {
                if (doc.Name == name)
                {
                    if (doc is IEditable)
                    {
                        ((IEditable)doc).ChangeContent(content);
                        Console.WriteLine("Document content changed: " + doc.Name);
                    }
                    else
                    {
                        Console.WriteLine("Document is not editalbe: " + doc.Name);
                    }
                    documentFound = true;
                }
            }
            if (documentFound == false)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }

        private static void AddDocument(IDocument doc, string[] attrs)
        {
            foreach (var attr in attrs)
            {
                string[] keysValues = attr.Split('=');
                string key = keysValues[0];
                string value = keysValues[1];
                doc.LoadProperty(key, value);
            }
            if (doc.Name != null)
            {
                documents.Add(doc);
                Console.WriteLine("Document added: " + doc.Name);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }
    }

    public class AudioDocument : MultimediaDocs
    {
        public int? SampleRate { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "samplerate")
            {
                this.SampleRate = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRate));
        }
    }

    public abstract class Document : IDocument
    {
        public string Content { get; protected set; }

        public string Name { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
            else
            {
                throw new ArgumentException("INVALID KEY");
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            List<KeyValuePair<string, object>> prop = new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(prop);
            prop.Sort((a, b) => a.Key.CompareTo(b.Key));
            info.Append(GetType().Name);
            info.Append("[");
            bool first = true;
            foreach (var pro in prop)
            {
                if (pro.Value != null)
                {
                    if (!first)
                    {
                        info.Append(";");
                    }
                    info.AppendFormat("{0}={1}", pro.Key, pro.Value);
                    first = false;
                }
            }
            info.Append("]");
            return info.ToString();
        }
    }

    public abstract class EncryptableBinaryDoc : BinaryDocument, IEncryptable
    {
        private bool isEncrypted = false;

        public bool IsEncrypted
        {
            get
            {
                return this.isEncrypted;
            }
        }

        public void Encrypt()
        {
            this.isEncrypted = true;
        }

        public void Decrypt()
        {
            this.isEncrypted = false;
        }

        public override string ToString()
        {
            if (this.isEncrypted)
            {
                return String.Format("{0}[encrypted]", this.GetType().Name);
            }
            else
            {
                return base.ToString();
            }
        }
    }

    public class PDFDocument : EncryptableBinaryDoc
    {
        public int? NumberOfPages { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "pages")
            {
                this.NumberOfPages = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
        }
    }

    public class TextDocument : Document, IEditable
    {
        public string Charset { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "charset")
            {
                this.Charset = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("charset", this.Charset));
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }

    public class VideoDocument : MultimediaDocs
    {
        public double? FrameRate { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "framerate")
            {
                this.FrameRate = double.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
        }
    }

    public class ExcelDocument : OfficeDocuments
    {
        public int? NumberOfRows { get; set; }

        public int? NumberOfCols { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "rows")
            {
                this.NumberOfRows = int.Parse(value);
            }
            else if (key == "cols")
            {
                this.NumberOfCols = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));

            output.Add(new KeyValuePair<string, object>("cols", this.NumberOfCols));
        }
    }

    public class WordDocument : OfficeDocuments, IEditable
    {
        public int? NumberOfCharacters { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.NumberOfCharacters = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);

            output.Add(new KeyValuePair<string, object>("chars", this.NumberOfCharacters));
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }

    public abstract class BinaryDocument : Document
    {
        public long? Size { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "size")
            {
                this.Size = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("size", this.Size));
        }
    }

    public abstract class MultimediaDocs : BinaryDocument
    {
        public int? Length { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "length")
            {
                this.Length = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("length", this.Length));
        }
    }

    public abstract class OfficeDocuments : EncryptableBinaryDoc
    {
        public string Version { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "version")
            {
                this.Version = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("version", this.Version));
        }
    }
}