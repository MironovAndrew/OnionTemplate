### Создание проекта на основе template
`dotnet new template-short-name -n ProjectName`

### Посмотреть список templates
`dotnet new list`

### Создание template (удалите лишние файлы): 
`dotnet new --install --force .` <br>
1.) В корне проекта создать папку `.template.config` <br>
2.) Внтури создать файл `template.json` <br>
3.) Пример файла template.json <br>
<pre>{
  "$schema": "http://json.schemastore.org/template",
  "author": "Ваше Имя",
  "classifications": [ "Common", "Console" ],
  "identity": "MyCompany.MyTemplateProject",
  "name": "My Custom Console Template",
  "shortName": "mytemplate",
  "sourceName": "MyTemplateProject",
  "preferNameDirectory": true,
  "guids": [ "d4b3a8e3-1c6b-4b84-9e8c-2a6e4d92a7b8" ],
  "symbols": {
    "projectName": {
      "type": "parameter",
      "datatype": "string",
      "defaultValue": "MyTemplateProject",
      "replaces": "MyTemplateProject",
      "fileRename": "MyTemplateProject"
    }
  }
}</pre>

4.) Создание проекта на основе template  <br>
`dotnet new template -n template-short-name`    

### Публикация в NuGet
1.) Добавить в .csproj:
<pre>< PropertyGroup >
  < PackAsTool > false < /PackAsTool >
  < IsPackable > true < /IsPackable >
  < PackageType > Template < /PackageType >
  < /PropertyGroup > </pre>
2.) Упаковать  <br>
`dotnet pack -o ./nupkg`  <br>
3.) Проверить template локально  <br>
`dotnet new --install ./nupkg/template-sourse-name.1.0.0.nupkg`  <br>
4.) Опубликовать <br>
`dotnet new --install MyCompany.MyTemplateProject`




