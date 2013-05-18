using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Free_Content
{
    public enum CommandType
    {
        AddBook,
        AddMovie,
        AddSong,
        AddApplication,
        Update,
        Find,
    }

    public enum ContentType
    {
        Book,
        Movie,
        Music,
        Application,
    }

    public enum acpi
    {
        Title = 0,
        Author,
        Size,
        Url,
    }
}