using System;

using R5T.Norsica;


namespace R5T.Smyni.Norsica
{
    public class DotnetVisualStudioSolutionFileOperator : IVisualStudioSolutionFileOperator
    {
        private IDotnetOperator DotnetOperator { get; }


        public DotnetVisualStudioSolutionFileOperator(IDotnetOperator dotnetOperator)
        {
            this.DotnetOperator = dotnetOperator;
        }

        public void CreateNewSolutionFile(string solutionDirectoryPath, string solutionName)
        {
            this.DotnetOperator.CreateNewSolutionFile(solutionDirectoryPath, solutionName);
        }
    }
}
