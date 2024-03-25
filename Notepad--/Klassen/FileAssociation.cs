using System;
using System.IO;
using Microsoft.Win32;

public static class FileAssociationHelper
{
    public static void AssociateFileType(string extension, string progId, string appName, string iconPath)
    {
        try
        {
            // Set the file extension association
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(extension))
            {
                key.SetValue("", progId);
            }

            // Set the ProgId association
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(progId))
            {
                key.SetValue("", appName);

                // Set the DefaultIcon association
                using (RegistryKey iconKey = key.CreateSubKey("DefaultIcon"))
                {
                    iconKey.SetValue("", iconPath);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating file association: {ex.Message}");
        }
    }
}
