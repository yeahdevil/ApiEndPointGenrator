using GenerateAPIEndpoints;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
string outputFile = @"\Output\"+ DateTime.Now.ToString("ddMMyyyyHHmmss") + ".txt";

try
{
    string apiSkeleten = "api/v1/{0}";
    var Helper = new Helper();
    // Check if file already exists. If yes, delete it.     
    if (File.Exists(outputFile))
    {
        File.Delete(outputFile);
    }
    var dbModels = Assembly.GetExecutingAssembly().GetTypes().Where(x=> x.FullName.StartsWith("GenerateAPIEndpoints.DBModels"));
    foreach(var dbModel in dbModels)
    {
        if(dbModel.Name== "tbl_Email_Notification_Events")
        {
            Table tableAttribute = (Table)dbModel.GetCustomAttribute(typeof(Table));
            var tableName = tableAttribute.Name;
            string keyPropName = String.Empty;
            var getselectionskeleton = string.Empty;

            var keyProperty = dbModel.GetProperties().Where(x => x.GetCustomAttribute(typeof(Key)) != null).FirstOrDefault();
            if(keyProperty != null)
            {
                keyPropName = keyProperty.Name;
            }

            var selectionProperties = dbModel.GetProperties().Where(x => x.GetCustomAttribute(typeof(Searchable)) != null).Select(x=> new { attr = (Searchable)x.GetCustomAttributes(typeof(Searchable)).FirstOrDefault(), name = x.Name }).ToList();
            if(selectionProperties!= null)
            {
                foreach (var selectionProperty in selectionProperties.OrderBy(x=> x.attr.Order))
                {
                    if (getselectionskeleton == string.Empty)
                        getselectionskeleton = getselectionskeleton + String.Format("/{{{0}}}", selectionProperty.name);
                    else
                        getselectionskeleton = getselectionskeleton + String.Format("/{{{0}?}}", selectionProperty.name);
                }
            }

            var getSkeleton = string.Format("[Get]"+Environment.NewLine+apiSkeleten, tableName);

            var putURI = string.Format("[Put]" + Environment.NewLine + apiSkeleten +"/{{{1}}}", tableName, keyPropName);
            var patchURI = string.Format("[Patch]" + Environment.NewLine + apiSkeleten + "/{{{1}}}", tableName, keyPropName);
            var deleteURI = string.Format("[Delete]" + Environment.NewLine + apiSkeleten + "/{{{1}}}", tableName, keyPropName);
            var postURI = string.Format("[Post]" + Environment.NewLine + apiSkeleten, tableName);
            var getURI = getSkeleton+ getselectionskeleton;


            var commonResponseObject = new CommonResponseObject { ErrorCode = null, ErrorMsg = null, IsSuccess = true };
            string commonResponsestring = "Response : " + JsonSerializer.Serialize(commonResponseObject);

            object modelInstance = Activator.CreateInstance(dbModel);

            PropertyInfo[] modelprops = dbModel.GetProperties();

            foreach(PropertyInfo modelprop in modelprops)
            {
                var actualType = Nullable.GetUnderlyingType(modelprop.PropertyType) == null ? modelprop.PropertyType:Nullable.GetUnderlyingType(modelprop.PropertyType);
                dynamic defaultValue = typeof(Helper).GetMethod("GetDefaultGeneric").MakeGenericMethod(actualType).Invoke(Helper,null);
                modelprop.SetValue(modelInstance, defaultValue);
            }

            string modelResposeString = JsonSerializer.Serialize(modelInstance);



            string finalResponseString ="*****************************"+ Environment.NewLine+
                putURI + Environment.NewLine + commonResponsestring + Environment.NewLine 
                +patchURI + Environment.NewLine + commonResponsestring + Environment.NewLine 
                +deleteURI + Environment.NewLine + commonResponsestring + Environment.NewLine 
                +getURI + Environment.NewLine + modelResposeString + Environment.NewLine 
                +postURI + Environment.NewLine + "Request : " + modelResposeString + Environment.NewLine + commonResponsestring + Environment.NewLine;

            using (FileStream fs = File.Create(outputFile))
            {
                Byte[] title = new UTF8Encoding(true).GetBytes(finalResponseString);
                fs.Write(title, 0, title.Length);
            }

            Console.WriteLine(finalResponseString);
        }

    }
}
catch (Exception Ex)
{
    Console.WriteLine(Ex.ToString());
}



