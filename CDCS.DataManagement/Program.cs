#region

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using CDCS.Data;
using CDCS.ModelTransformation;
using Newtonsoft.Json;

#endregion

namespace CDCS.DataManagement {

    internal static class Program {
        private static void Main(string[] args)
        {
            var now         = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            var folder_path = ConfigurationManager.AppSettings["JsonFiles"];

            // DEV
            now         = "20181115_110456";
            folder_path = $"{folder_path}\\{now}\\";

            var folder = Directory.CreateDirectory(folder_path);

            // Load Json file into a text file
            /*
            if (ConfigurationManager.GetSection("CdcsBaseUris") is NameValueCollection json_base_files)
                DownloadJsonFiles(json_base_files, folder_path);
            else
                Console.WriteLine("Cdcs base web api uris are not defined in config file");
                */

            var cdcs_objects = SerializeCdcsJsonToObjects(folder_path).ToList();

            /*
            if (ConfigurationManager.GetSection("CdcsComplexUris") is NameValueCollection json_complex_files)
                GetCategories(GetCdcsObjectByType<CdcsSector>(cdcs_objects), json_complex_files["CdcsSector_byId"]);
            else
                Console.WriteLine("Cdcs base web api uris are not defined in config file");
                */

            var nb_of_changes = SaveToDb(cdcs_objects);
        }

        private static List<CdcsCategory> GetCategories(IEnumerable<CdcsSector> sectors, string uri)
        {
            var categories = new List<CdcsCategory>();

            using (var web_client = new WebClient()) {
                foreach (var sector in sectors) {
                    var uri_by_id = string.Format(uri, sector.Id);
                    Console.WriteLine(uri_by_id);

                    /*foreach (string json_file in json_files) {
                        var uri = json_files[json_file];

                        Console.WriteLine(json_file + " = " + uri);
                        var json      = web_client.DownloadString(uri);
                        var file_path = folder_path + $"{json_file}.json";

                        File.WriteAllText(file_path, json);
                    }*/
                }
            }

            return categories;
        }

        private static IList<T> GetCdcsObjectByType<T>(IEnumerable<ICdcsIdentity> cdcs_objects) where T : ICdcsIdentity
        {
            return cdcs_objects.OfType<T>().ToList();
        }

        private static int SaveToDb(IReadOnlyCollection<ICdcsIdentity> cdcs_objects)
        {
            var types         = cdcs_objects.Select(o => o.GetType()).Distinct();
            var nb_of_changes = 0;

            using (var context = new CdcsContext()) {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                // context.Database.Migrate();

                foreach (var t in types)
                    switch (t.Name) {
                        case "CdcsActionZone":
                            context.CdcsActionZones.AddRange(GetCdcsObjectByType<CdcsActionZone>(cdcs_objects));
                            break;

                        case "CdcsAccreditationType":
                            context.CdcsAccreditationTypes.AddRange(GetCdcsObjectByType<CdcsAccreditationType>(cdcs_objects));
                            break;

                        case "CdcsAccreditor":
                            context.CdcsAccreditors.AddRange(GetCdcsObjectByType<CdcsAccreditor>(cdcs_objects));
                            break;

                        case "CdcsLanguage":
                            context.CdcsLanguages.AddRange(GetCdcsObjectByType<CdcsLanguage>(cdcs_objects));
                            break;

                        case "CdcsLegalStatus":
                            context.CdcsLegalStatuses.AddRange(GetCdcsObjectByType<CdcsLegalStatus>(cdcs_objects));
                            break;

                        case "CdcsSector":
                            context.CdcsSectors.AddRange(GetCdcsObjectByType<CdcsSector>(cdcs_objects));
                            break;

                        case "CdcsServiceType":
                            context.CdcsServiceTypes.AddRange(GetCdcsObjectByType<CdcsServiceType>(cdcs_objects));
                            break;
                    }
                nb_of_changes = context.SaveChanges();
            }

            return nb_of_changes;
        }

        private static IEnumerable<ICdcsIdentity> SerializeCdcsJsonToObjects(string folder_path)
        {
            var files        = Directory.GetFiles(folder_path, "*.json");
            var cdcs_objects = new List<ICdcsIdentity>();

            foreach (var f in files) {
                var json_name = Path.GetFileNameWithoutExtension(f);
                var json      = File.ReadAllText(f);

                switch (json_name) {
                    case "CdcsActionZones":
                        cdcs_objects.AddRange(JsonConvert.DeserializeObject<List<CdcsActionZone>>(json));
                        break;

                    case "CdcsAccreditationTypes":
                        cdcs_objects.AddRange(JsonConvert.DeserializeObject<List<CdcsAccreditationType>>(json));
                        break;

                    case "CdcsAccreditors":
                        cdcs_objects.AddRange(JsonConvert.DeserializeObject<List<CdcsAccreditor>>(json));
                        break;

                    case "CdcsLanguages":
                        cdcs_objects.AddRange(JsonConvert.DeserializeObject<List<CdcsLanguage>>(json));
                        break;

                    case "CdcsLegalStatus":
                        cdcs_objects.AddRange(JsonConvert.DeserializeObject<List<CdcsLegalStatus>>(json));
                        break;

                    case "CdcsSectors":
                        cdcs_objects.AddRange(JsonConvert.DeserializeObject<List<CdcsSector>>(json));
                        break;

                    case "CdcsServiceTypes":
                        cdcs_objects.AddRange(JsonConvert.DeserializeObject<List<CdcsServiceType>>(json));
                        break;
                }
            }

            return cdcs_objects;
        }

        private static void DownloadJsonFiles(NameValueCollection json_files, string folder_path)
        {
            using (var web_client = new WebClient()) {
                foreach (string json_file in json_files) {
                    var uri = json_files[json_file];

                    Console.WriteLine(json_file + " = " + uri);
                    var json      = web_client.DownloadString(uri);
                    var file_path = folder_path + $"{json_file}.json";

                    File.WriteAllText(file_path, json);
                }
            }
        }
    }

}