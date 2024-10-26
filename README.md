# Scan folders


## Following the examples:

```c#
using ScanFolders;

var result = ScanFolder.GetFiles(@"C:\Users\gabri\OneDrive\Área de Trabalho");

Console.WriteLine(result);

[{"DirectoryName":"Área de Trabalho","FileName":"desktop.ini","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\desktop.ini","Length":282},{"DirectoryName":"Área de Trabalho","FileName":"Discord.lnk","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\Discord.lnk","Length":2253},{"DirectoryName":"Área de Trabalho","FileName":"Docker Desktop.lnk","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\Docker Desktop.lnk","Length":2146},{"DirectoryName":"Área de Trabalho","FileName":"DS4Windows - Atalho.lnk","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\DS4Windows - Atalho.lnk","Length":1537},{"DirectoryName":"Área de Trabalho","FileName":"financiamento.zip","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento.zip","Length":1652358},{"DirectoryName":"Área de Trabalho","FileName":"linda S2.png","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\linda S2.png","Length":20246},{"DirectoryName":"Área de Trabalho","FileName":"Navegador Opera.lnk","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\Navegador Opera.lnk","Length":1390},{"DirectoryName":"Área de Trabalho","FileName":"Rockstar Games Launcher.lnk","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\Rockstar Games Launcher.lnk","Length":1934},{"DirectoryName":"Área de Trabalho","FileName":"TS4_x64 - Atalho.lnk","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\TS4_x64 - Atalho.lnk","Length":1966},{"DirectoryName":"Área de Trabalho","FileName":"Visual Studio Code.lnk","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\Visual Studio Code.lnk","Length":1410},{"DirectoryName":"financiamento","FileName":"Carteira de trabalho.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Carteira de trabalho.pdf","Length":95650},{"DirectoryName":"financiamento","FileName":"Certid nasc Gabriel.jpeg","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Certid nasc Gabriel.jpeg","Length":119368},{"DirectoryName":...
```

```c#
using ScanFolders;

var result = ScanFolder.GetFiles(@"C:\Users\gabri\OneDrive\Área de Trabalho", "pdf");

Console.WriteLine(result);

[{"DirectoryName":"financiamento","FileName":"Carteira de trabalho.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Carteira de trabalho.pdf","Length":95650},{"DirectoryName":"financiamento","FileName":"CNH-e.pdf.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\CNH-e.pdf.pdf","Length":289281},{"DirectoryName":"financiamento","FileName":"Declaracao1.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Declaracao1.pdf","Length":340782},{"DirectoryName":"financiamento","FileName":"Declaracao2.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Declaracao2.pdf","Length":340290},{"DirectoryName":"financiamento","FileName":"Extrato1.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Extrato1.pdf","Length":35830},{"DirectoryName":"financiamento","FileName":"Extrato2.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Extrato2.pdf","Length":39124},{"DirectoryName":"financiamento","FileName":"Extrato3.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Extrato3.pdf","Length":35552},{"DirectoryName":"financiamento","FileName":"Extrato4.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Extrato4.pdf","Length":28888},{"DirectoryName":"financiamento","FileName":"Extrato5.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Extrato5.pdf","Length":35773},{"DirectoryName":"financiamento","FileName":"Extrato6.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\Extrato6.pdf","Length":35781},{"DirectoryName":"financiamento","FileName":"FGTS1.pdf","FilePath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento\\FGTS1.pdf","Length":144569},{"DirectoryName"...
```

```c#
using ScanFolders;

var result = ScanFolder.GetDirectories(@"C:\Users\gabri\OneDrive\Área de Trabalho");

Console.WriteLine(result);

[{"DirectoryName":"financiamento","DirectoryPath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento"},{"DirectoryName":"financiamento2","DirectoryPath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento2"},{"DirectoryName":"sims-4-updater-v1.0.0","DirectoryPath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\sims-4-updater-v1.0.0"}]
```

```c#
using ScanFolders;

var result = ScanFolder.GetDirectories(@"C:\Users\gabri\OneDrive\Área de Trabalho", "financiamento");

Console.WriteLine(result);

[{"DirectoryName":"financiamento","DirectoryPath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento"},{"DirectoryName":"financiamento2","DirectoryPath":"C:\\Users\\gabri\\OneDrive\\Área de Trabalho\\financiamento2"}]
```
## Install

```bash
  dotnet add package ScanFolders
```
    
## Author

- [@GabrielBrl](https://github.com/GabrielBrL)


## Licence

[MIT](https://choosealicense.com/licenses/mit/)

