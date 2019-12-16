using System;

using R5T.Norsica;


namespace R5T.Smyni.Norsica
{
    public class DotnetVisualStudioSolutionFileOperator
    {
        private IDotnetOperator DotnetOperator { get; }


        public DotnetVisualStudioSolutionFileOperator(IDotnetOperator dotnetOperator)
        {
            this.DotnetOperator = dotnetOperator;
        }
    }
}
