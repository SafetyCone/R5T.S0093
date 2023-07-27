using System;

using R5T.T0141;


namespace R5T.S0093
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Get_RivetCloudSharedDataDirectoryPath()
        {
            var directoryPath = Instances.OrganizationDirectoryPathOperator.Get_Rivet_CloudSharedDataDirectoryPath();

            Console.WriteLine(directoryPath);
        }
    }
}
