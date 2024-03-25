using Microsoft.Win32;
using System;

public static class RegistryHelper
{
    public static void CreateFileAssociation(string extension, string progId, string appName, string iconPath)
    {
        try
        {
            // Setze die Dateiverknüpfung in der Registry
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(extension))
            {
                key.SetValue("", progId);
            }

            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(progId))
            {
                key.SetValue("", appName);
                key.CreateSubKey("DefaultIcon").SetValue("", iconPath);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating file association: {ex.Message}");
        }
    }
}

// Beispielaufruf
//RegistryHelper.CreateFileAssociation(".cs", "MyCompany.Notepad--", "Notepad--", "C:\\Path\\To\\Your\\Icon.ico");
