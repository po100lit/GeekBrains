using static System.Console;
Clear();

/*
Вывод папок и файлов в консоль
*/

/*
string path = "/Users/po100lit/Documents/GeekBrains/C-sharp";
DirectoryInfo di = new DirectoryInfo(path);
WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    WriteLine(fi[i].Name);
}
*/

string path = "/Users/po100lit/Documents/GeekBrains/C-sharp/Lection";
CatalogInfo(path);

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        WriteLine($"{indent}{files[i].Name}");
    }
}
