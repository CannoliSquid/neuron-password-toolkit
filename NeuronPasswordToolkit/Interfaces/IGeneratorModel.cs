using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace NeuronPasswordToolkit.Interfaces
{
    public interface IGeneratorModel
    {
        string AnsweredQuestion1 { get; }

        string AnsweredQuestion2 { get; }

        string SpecialCharacterSet { get; set; }

        string SpecialCharacters { get; }

        string GenerationType { get; set; }

        int SelectedLength { get; }

        SecureString FinalProduct { get; set; }
    }
}
