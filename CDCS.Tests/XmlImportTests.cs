#region

using System.Configuration;
using System.IO;
using CDCS.ModelTransformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace CDCS.Tests {

    [TestClass]
    public class XmlImportTests {
        [TestMethod]
        public void TestMethod1()
        {
            var output_organisations = ConfigurationManager.AppSettings["OutputOrganisations"];
            var organisation_request = XmlToObjects(File.ReadAllText($@"{folder_path}{output_organisations}.xml"), typeof(CdcsOrganisationsInput));

        }
    }

}