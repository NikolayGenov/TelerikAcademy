using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
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
            prop.Sort((a, b) => a.Key.CompareTo(b));
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
                }
            }
            info.Append("]");
            return info.ToString();
        }
    }
}