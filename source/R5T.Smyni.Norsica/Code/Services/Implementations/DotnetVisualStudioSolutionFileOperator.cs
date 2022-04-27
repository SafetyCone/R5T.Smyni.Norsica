using System;

using R5T.Norsica;using R5T.T0064;


namespace R5T.Smyni.Norsica
{[ServiceImplementationMarker]
    public class DotnetVisualStudioSolutionFileOperator : IVisualStudioSolutionFileOperator,IServiceImplementation
    {
        private IDotnetOperator DotnetOperator { get; }
        private IVisualStudioSolutionFilePathProvider VisualStudioSolutionFilePathProvider { get; }


        public DotnetVisualStudioSolutionFileOperator(IDotnetOperator dotnetOperator, IVisualStudioSolutionFilePathProvider visualStudioSolutionFilePathProvider)
        {
            this.DotnetOperator = dotnetOperator;
            this.VisualStudioSolutionFilePathProvider = visualStudioSolutionFilePathProvider;
        }

        public string CreateSolutionFile(string solutionDirectoryPath, string solutionName)
        {
            this.DotnetOperator.CreateNewSolutionFile(solutionDirectoryPath, solutionName);

            // Get the path of the created solution file path.
            var solutionFilePath = this.VisualStudioSolutionFilePathProvider.GetVisualStudioSolutionFilePath(solutionDirectoryPath, solutionName);
            return solutionFilePath;
        }

        public void AddProjectFileToSolutionFile(string solutionFilePath, string projectFilePath)
        {
            this.DotnetOperator.AddProjectFileToSolutionFile(solutionFilePath, projectFilePath);
        }
    }
}
