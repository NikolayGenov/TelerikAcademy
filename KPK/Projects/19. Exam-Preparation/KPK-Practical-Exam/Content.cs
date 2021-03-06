﻿using System;
using System.Text;

namespace FreeContentCatalog
{
    public class Content : IComparable, IContent
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public Int64 Size { get; set; }

        private string url;

        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                this.url = value;
                this.TextRepresentation = this.ToString(); // To update the text representation
            }
        }

        public ContentType Type { get; set; }

        public string TextRepresentation { get; set; }

        public Content(ContentType type, string[] commandParams)
        {
            this.Type = type;
            this.Title = commandParams[(int)ContentPosition.Title];
            this.Author = commandParams[(int)ContentPosition.Author];
            this.Size = Int64.Parse(commandParams[(int)ContentPosition.Size]);
            this.Url = commandParams[(int)ContentPosition.Url];
        }

        public int CompareTo(object obj)
        {
            if (null == obj)
            {
                return 1;
            }

            Content otherContent = obj as Content;
            if (otherContent == null)
            {
                throw new ArgumentException("Object is not a Content");
            }
            else
            {
                int comparisonResult = this.TextRepresentation.CompareTo(otherContent.TextRepresentation);

                return comparisonResult;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0}: ", this.Type.ToString());
            output.AppendFormat("{0}; ", this.Title);
            output.AppendFormat("{0}; ", this.Author);
            output.AppendFormat("{0}; ", this.Size);
            output.AppendFormat("{0}", this.Url);

            return output.ToString();
        }
    }
}